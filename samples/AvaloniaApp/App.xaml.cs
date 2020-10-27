using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Avalonia.ThemeManager;

namespace AvaloniaApp
{
    public class App : Application
    {
        public static IThemeSelector? Selector { get; set; }

        [STAThread]
        static void Main(string[] args)
        {
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                         .UsePlatformDetect()
                         .UseReactiveUI()
                         .LogToTrace();

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktopLifetime)
            {
                Selector = ThemeSelector.Create("Themes");
                Selector.LoadSelectedTheme("AvaloniaApp.theme");
                desktopLifetime.MainWindow = new MainWindow()
                {
                    DataContext = Selector
                };
                desktopLifetime.Exit += (sennder, e) => Selector.SaveSelectedTheme("AvaloniaApp.theme");
            }
            else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewLifetime)
            {
                //singleViewLifetime.MainView = new MainView();
            }
            base.OnFrameworkInitializationCompleted();
        }
    }
}
