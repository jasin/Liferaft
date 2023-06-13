using CommunityToolkit.Mvvm.ComponentModel;
using DatabaseAccess.Context;
using FluentAvalonia.UI.Controls;
using LifeRaft_AUI.Pages;
using LifeRaft_AUI.Services;

namespace LifeRaft_AUI.ViewModels;
[ObservableObject]
public partial class MainViewViewModel : ViewModelBase
{
    private readonly SageDbContext _ctx;

    [ObservableProperty]
    private NavigationViewItem? _selectedNavItem;

    public MainViewViewModel(SageDbContext ctx)
    {
        _ctx = ctx;
    }

    partial void OnSelectedNavItemChanged(NavigationViewItem? value)
    {
        var frame = NavigationService.Instance;

        switch(value!.Tag)
        {
            case "HomePage":
                frame.Navigate(typeof(HomePage));
                break;
            case "EmployeePage":
                frame.Navigate(typeof(EmployeePage));
                break;
        }
    }
}
