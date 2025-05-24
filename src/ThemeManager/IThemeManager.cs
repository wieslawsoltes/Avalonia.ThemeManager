using Avalonia;

namespace Avalonia.ThemeManager;

public interface IThemeManager
{
    void Initialize(Application application);

    void Switch(int index);
}
