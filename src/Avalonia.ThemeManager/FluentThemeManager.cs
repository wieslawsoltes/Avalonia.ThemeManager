using Avalonia.Styling;
using Avalonia.Themes.Fluent;

namespace Avalonia.ThemeManager;

public class FluentThemeManager : IThemeManager
{
    private static readonly FluentTheme Fluent = new()
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
            // Fluent Light
            case 0:
            {
                Application.Current.RequestedThemeVariant = ThemeVariant.Light;
                Application.Current.Styles[0] = Fluent;
                break;
            }
            // Fluent Dark
            case 1:
            {
                Application.Current.RequestedThemeVariant = ThemeVariant.Dark;
                Application.Current.Styles[0] = Fluent;
                break;
            }
        }
    }

    public void Initialize(Application application)
    {
        application.Styles.Insert(0, Fluent);
    }
}
