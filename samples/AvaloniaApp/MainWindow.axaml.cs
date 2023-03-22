using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();

        var dark = false;

        if (ThemeButton is { } && ColorsPage is { } && PreviewPage is { })
        {
            ColorsPage.Preview = PreviewPage;

            ThemeButton.Click += (_, _) =>
            {
                dark = !dark;
                App.ThemeManager?.Switch(dark ? 1 : 0);
                ColorsPage.UpdateColorResources();
            };
        }

#if DEBUG
        this.AttachDevTools();
#endif
    }
}
