using System.Windows;
using ArthaInventoryManagementSystem.Services;
using ArthaInventoryManagementSystem.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace ArthaInventoryManagementSystem;

public partial class App : Application
{
    public static IServiceProvider serviceProvider;
   
    protected override void OnStartup(StartupEventArgs e)
    {
        var services = new ServiceCollection();
        
        

        ConfigureServices(services);

        serviceProvider = services.BuildServiceProvider();

        var mainWindow = serviceProvider.GetRequiredService<LoginWindow>();

        mainWindow.Show();

        base.OnStartup(e);
    }

    private void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<MainWindow>();
        services.AddLogging(builder =>
        {
            builder.AddConsole();
        });

     
        services.AddSingleton<MainWindow>();
        services.AddSingleton<LoginWindow>();
        // Explicitly use your custom service type
        services.AddSingleton<ArthaInventoryManagementSystem.Services.NavigationService>();
        services.AddTransient<NavigationViewModel>();
    
    }
}