using Avalonia;
using Avalonia.Controls;
using FluentAvalonia.UI.Controls;
using LifeRaft_AUI.Services;
using LifeRaft_AUI.ViewModels;
using Splat;

namespace LifeRaft_AUI.Views;

public partial class MainView : UserControl
{
    private Frame? _frameView;

    public MainView()
    {
        InitializeComponent();
        DataContext = Locator.Current.GetService<MainViewViewModel>();
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);

        _frameView = this.FindControl<Frame>("RootFrame");

        NavigationService.Instance.SetFrame(_frameView);
    }
}