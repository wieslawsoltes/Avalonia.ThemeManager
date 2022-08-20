using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.ThemeManager;

namespace AvaloniaApp;

public class App : Application
{
    public static IThemeManager? ThemeManager;

    [STAThread]
    static void Main(string[] args)
    {
        BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
    }

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace();

    public override void Initialize()
    {
#if true
        ThemeManager = new FluentThemeManager();
#else
        ThemeManager = new SimpleThemeManager();
#endif
        ThemeManager.Initialize(this);

        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktopLifetime)
        {
            desktopLifetime.MainWindow = new MainWindow();
        }
  
        base.OnFrameworkInitializationCompleted();
    }
}
