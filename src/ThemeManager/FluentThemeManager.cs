using Avalonia.Styling;
using Avalonia.Themes.Fluent;

namespace Avalonia.ThemeManager;

public class FluentThemeManager : IThemeManager
{
    private static readonly FluentTheme s_fluent = new();

    public void Switch(int index)
    {
        if (Application.Current is null)
        {
            return;
        }

        Application.Current.RequestedThemeVariant = index switch
        {
            0 => ThemeVariant.Light,
            1 => ThemeVariant.Dark,
            _ => Application.Current.RequestedThemeVariant
        };
    }

    public void Initialize(Application application)
    {
        application.Styles.Insert(0, s_fluent);
    }
}
