using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using Avalonia.Markup.Xaml;
using Avalonia.ThemeManager;

namespace AvaloniaApp
{
    public class App : Application
    {
        [STAThread]
        static void Main(string[] args)
        {
            BuildAvaloniaApp().Start(AppMain, args);
        }

        static void AppMain(Application app, string[] args)
        {
            ThemeSelector.Instance = new ThemeSelector("Themes");
            ThemeSelector.Instance.LoadSelectedTheme("AvaloniaApp.theme");

            app.Run(new MainWindow());

            ThemeSelector.Instance.SaveSelectedTheme("AvaloniaApp.theme");
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                         .UsePlatformDetect()
                         .UseReactiveUI()
                         .LogToDebug();

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
