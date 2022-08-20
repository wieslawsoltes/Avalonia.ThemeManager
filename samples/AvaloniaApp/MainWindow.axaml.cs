using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
        this.InitializeThemes();
        this.AttachDevTools();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void InitializeThemes()
    {
        var dark = false;
        var theme = this.Find<Button>("Theme");
        if (theme is { })
        {
            theme.Click += (_, _) =>
            {
                dark = !dark;
                App.ThemeManager?.Switch(dark ? 1 : 0);
            };
        }
    }
}
