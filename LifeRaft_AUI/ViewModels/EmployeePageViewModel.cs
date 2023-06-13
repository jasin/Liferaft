using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DatabaseAccess.Context;
using DatabaseAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace LifeRaft_AUI.ViewModels;

[ObservableObject]
public partial class EmployeePageViewModel : ViewModelBase
{
    private readonly SageDbContext _ctx;
    
    [ObservableProperty] private ObservableCollection<Employee> _employees = new();

    [ObservableProperty] private string _pageName = "Employee Page";

    public EmployeePageViewModel(SageDbContext ctx)
    {
        _ctx = ctx;
        LoadEmployeesAsync().SafeFireAndForget();
    }
    
    [RelayCommand]
    private async Task LoadEmployeesAsync()
    {
        var employees = await _ctx.Employees
            .Where(e => e.Status == (byte)EmployeeStatus.Current)
            .ToListAsync();

        foreach (var e in employees.Where(e => !Employees.Contains(e)))
        {
            Employees?.Add(e);
        }
    }
}
