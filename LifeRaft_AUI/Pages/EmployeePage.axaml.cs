using Avalonia.Controls;
using LifeRaft_AUI.ViewModels;
using Splat;

namespace LifeRaft_AUI.Pages;
public partial class EmployeePage : UserControl
{
    public EmployeePage()
    {
        InitializeComponent();
        DataContext = Locator.Current.GetService<EmployeePageViewModel>();
    }
}
