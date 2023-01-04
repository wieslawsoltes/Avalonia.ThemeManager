using Avalonia.Themes.Simple;

namespace Avalonia.ThemeManager;

public class SimpleThemeManager : IThemeManager
{
    private static readonly SimpleTheme Simple = new()
    {
        Mode = SimpleThemeMode.Light
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
                if (Simple.Mode != SimpleThemeMode.Light)
                {
                    Simple.Mode = SimpleThemeMode.Light;
                }
                Application.Current.Styles[0] = Simple;
                break;
            }
            // Simple Dark
            case 1:
            {
                if (Simple.Mode != SimpleThemeMode.Dark)
                {
                    Simple.Mode = SimpleThemeMode.Dark;
                }
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
