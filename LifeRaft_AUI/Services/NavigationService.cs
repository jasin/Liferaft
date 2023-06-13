using System;
using FluentAvalonia.UI.Controls;

namespace LifeRaft_AUI.Services;
public class NavigationService : INavigationService
{
    public static NavigationService Instance { get; } = new();

    public void SetFrame(Frame? frame)
    {
        _frame = frame;
    }

    public void Navigate(Type type)
    {
        _frame?.Navigate(type);
    }

    private Frame? _frame;
}
