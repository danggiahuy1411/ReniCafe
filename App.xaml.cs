using Microsoft.Extensions.DependencyInjection;
using Reni_Cafe.Services;
using Reni_Cafe.ViewModels;
using Reni_Cafe.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Reni_Cafe;

public partial class App : Application
{
    private ServiceProvider _services = null!;

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var services = new ServiceCollection();

        services.AddSingleton<INavigationService,
                              NavigationService>();

        services.AddSingleton<MainViewModel>();

        services.AddTransient<LoginViewModel>();
        services.AddTransient<DashboardViewModel>();

        _services = services.BuildServiceProvider();

        var window = new MainWindow
        {
            DataContext =
                _services.GetRequiredService<MainViewModel>()
        };

        window.Show();
    }

    protected override void OnExit(ExitEventArgs e)
    {
        _services?.Dispose();
        base.OnExit(e);
    }
}