using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatabaseAccess.Context;
using DatabaseAccess.Entities;
using DatabaseAccess.Entities.Interfaces;
using DatabaseAccess.Enumerations;
using DatabaseAccess.Extensions;
using Microsoft.EntityFrameworkCore;

namespace LifeRaft_AUI.ViewModels;

[ObservableObject]
public partial class HomePageViewModel : ViewModelBase
{
    private readonly SageDbContext _ctx;

    [ObservableProperty] private string? _companyName;
    [ObservableProperty] private string? _companyAddress;
    [ObservableProperty] private Dictionary<string, decimal>? _accounts;
    [ObservableProperty] private Dictionary<string, decimal>? _accountsPayableAging;
    [ObservableProperty] private Dictionary<string, decimal>? _accountsReceivableAging;

    public HomePageViewModel(SageDbContext ctx)
    {
        _ctx = ctx;
        InitializeAsync().SafeFireAndForget();
    }

    private async Task InitializeAsync()
    {
        // Load account balances from database
        Accounts = await LoadAccountBalancesAsync();
        
        // Load Overdue A/P and A/R invoice totals
        AccountsPayableAging = await LoadAgingAccountsPayableAsync();
        AccountsReceivableAging = await LoadAgingAccountsReceivableAsync();
    }
    
    [RelayCommand]
    private async Task<Dictionary<string, decimal>> LoadAccountBalancesAsync()
    {
        var accountNumbers = Enum.GetValues<AccountType>().ToList().Select(accountType => (long)accountType);
        
        return await _ctx.LedgerAccounts
            .Where(acct => accountNumbers.Contains(acct.Recnum))
            .Select(acct => new {name = acct.Lngnme, balance = acct.Endbal})
            .ToDictionaryAsync(d => d.name, d => d.balance);
    }

    private async Task<Dictionary<string, decimal>> LoadAgingAccountsPayableAsync()
    {
        return await LoadPeriodRevenueAsync(_ctx.AccountsPayables);
    }

    private async Task<Dictionary<string, decimal>> LoadAgingAccountsReceivableAsync()
    {
        return await LoadPeriodRevenueAsync(_ctx.AccountsReceivables);
    }

    private static async Task<Dictionary<string, decimal>> LoadPeriodRevenueAsync(IQueryable<IInvoices> invoices)
    {
        var today = DateTime.Today;

        return await invoices
            .FilterByStatus(InvoiceStatus.Open)
            .GroupBy(inv =>
                inv.Duedte < today.AddDays(-30) ? "Overdue 30+ Days" :
                inv.Duedte < today ? "Overdue 1-30 Days" :
                inv.Duedte < today.AddDays(7) ? "Due 7 Days" :
                inv.Duedte < today.AddDays(30) ? "Due 30 Days" : "empty")
            .Select(group => new { Key = group.Key, Sum = group.Sum(inv => inv.Invnet) })
            .ToDictionaryAsync(group => group.Key, group => group.Sum);
    }
}
