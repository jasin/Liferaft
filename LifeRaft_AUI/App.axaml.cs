using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using LifeRaft_AUI.ViewModels;
using LifeRaft_AUI.Views;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Splat.Microsoft.Extensions.DependencyInjection;
using Splat;
using DatabaseAccess.Context;
using DatabaseAccess.Connection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace LifeRaft_AUI;
public partial class App : Application
{
    private string? _connectionString;

    public IHost? AppHost { get; private set; }
    public IServiceProvider? ServiceProvider { get; private set; }

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
       AppHost = Host
            .CreateDefaultBuilder()
            .ConfigureAppConfiguration(configuration =>
            {
                configuration.Sources.Clear();
                configuration.AddJsonFile("appsettings.json", false, true);

                try
                {
                    _connectionString = MssqlConnection.BuildConnectionString(configuration.Build());
                }
                catch (Exception ex)
                {
                    Log.Fatal(ex, "Configuration file not found");
                }
                
            })
            .ConfigureServices(services =>
            {
                services.UseMicrosoftDependencyResolver();
                var resolver = Locator.CurrentMutable;
                resolver.InitializeSplat();

                ConfigureServices(services);
            })
            .UseSerilog()
            .Build();

        ServiceProvider = AppHost.Services;
        ServiceProvider.UseMicrosoftDependencyResolver();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Line below is needed to remove Avalonia data validation.
            // Without this line you will get duplicate validations from both Avalonia and CT
            //ExpressionObserver.DataValidators.RemoveAll(x => x is DataAnnotationsValidationPlugin);
            desktop.MainWindow = Locator.Current.GetService<MainWindow>(); 
        }

        base.OnFrameworkInitializationCompleted(); 
    }

    private void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<MainWindow>();
        
        services.AddTransient<MainViewViewModel>();
        services.AddTransient<HomePageViewModel>();
        services.AddTransient<EmployeePageViewModel>();
      
        services.AddDbContext<SageDbContext>(options => options.UseSqlServer(_connectionString));
    }
}