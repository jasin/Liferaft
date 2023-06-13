using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using LifeRaft_AUI.ViewModels;

namespace LifeRaft_AUI;
public class ViewLocator : IDataTemplate
{
    public Control Build(object? data)
    {
        var name = data?.GetType().FullName!.Replace("ViewModel", "View");
        var type = Type.GetType(name ?? throw new InvalidOperationException());

        if (type != null)
        {
            return (Control)Activator.CreateInstance(type)!;
        }

        return new TextBlock { Text = "Not Found: " + name };
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}