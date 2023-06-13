using Avalonia.Controls;
using LifeRaft_AUI.ViewModels;
using Splat;

namespace LifeRaft_AUI.Pages;
public partial class HomePage : UserControl
{
    public HomePage()
    {
        InitializeComponent();
        DataContext = Locator.Current.GetService<HomePageViewModel>();
    }
}
