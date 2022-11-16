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
        var themeButton = this.FindControl<Button>("ThemeButton");
        var colorsPage = this.FindControl<ColorsPage>("ColorsPage");
        var previewPage = this.FindControl<PreviewPage>("PreviewPage");
        if (themeButton is { } && colorsPage is { } && previewPage is { })
        {
            colorsPage.Preview = previewPage;

            themeButton.Click += (_, _) =>
            {
                dark = !dark;
                App.ThemeManager?.Switch(dark ? 1 : 0);
                colorsPage.UpdateColorResources();
            };
        }

#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
