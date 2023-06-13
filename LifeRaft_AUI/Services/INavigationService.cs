using System;
using FluentAvalonia.UI.Controls;

namespace LifeRaft_AUI.Services;
public interface INavigationService
{
    void Navigate(Type type);
    void SetFrame(Frame? frame);
}