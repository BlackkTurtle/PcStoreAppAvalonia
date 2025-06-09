using System;

using Avalonia;
using Avalonia.ReactiveUI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PcStore.DAL.Persistence;
using PcStore.DAL.Repositories.Contracts;
using PCStore.DAL.Repositories;
using PcStoreApp.App.ViewModels;
using PcStoreApp.App.Views;

namespace PcStoreApp.App.Desktop;

class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();

        // Optionally resolve services here:
        // var someService = host.Services.GetRequiredService<IMyService>();

        BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace()
            .UseReactiveUI();

    public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<PcstoreContext>(options =>
                       options.UseSqlite("Data Source = C:\\Users\\user\\Desktop\\ІФТКН\\4 курс\\ДИПЛОМНА\\back-end-dotnet\\PCStore.API\\PCStore.db"));

                    services.AddTransient<IUnitOfWork, UnitOfWork>();

                    services.AddSingleton<MainViewModel>();
                    services.AddSingleton<MainWindow>();
                });
}
