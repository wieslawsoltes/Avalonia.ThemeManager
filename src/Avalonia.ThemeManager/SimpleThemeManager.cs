using Avalonia.Styling;
using Avalonia.Themes.Simple;

namespace Avalonia.ThemeManager;

public class SimpleThemeManager : IThemeManager
{
    private static readonly SimpleTheme Simple = new()
    {
    };

    public void Switch(int index)
    {
        if (Application.Current is null)
        {
            return;
        }

        switch (index)
        {
            // Simple Light
            case 0:
            {
                Application.Current.RequestedThemeVariant = ThemeVariant.Light;
                Application.Current.Styles[0] = Simple;
                break;
            }
            // Simple Dark
            case 1:
            {
                Application.Current.RequestedThemeVariant = ThemeVariant.Dark;
                Application.Current.Styles[0] = Simple;
                break;
            }
        }
    }

    public void Initialize(Application application)
    {
        application.Styles.Insert(0, Simple);
    }
}
