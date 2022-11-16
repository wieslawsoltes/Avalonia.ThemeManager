using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace AvaloniaApp;

public class ColorResource
{
    public string Key { get; set; }

    public Color Color { get; set; }

    public ColorResource(string key, Color color)
    {
        Key = key;
        Color = color;
    }
}

public partial class ColorsPage : UserControl
{
    // System Control Colors
    // https://github.com/AvaloniaUI/Avalonia/blob/master/src/Avalonia.Themes.Fluent/Accents/BaseDark.xaml
    // https://github.com/AvaloniaUI/Avalonia/blob/master/src/Avalonia.Themes.Fluent/Accents/FluentControlResourcesDark.xaml
    // https://github.com/AvaloniaUI/Avalonia/blob/master/src/Avalonia.Themes.Fluent/Accents/BaseLight.xaml
    // https://github.com/AvaloniaUI/Avalonia/blob/master/src/Avalonia.Themes.Fluent/Accents/FluentControlResourcesLight.xaml
    // Accent Colours
    // https://github.com/AvaloniaUI/Avalonia/blob/master/src/Avalonia.Themes.Fluent/Accents/AccentColors.xaml

    private string[] _colorKeys = 
    {
        "SystemAltHighColor",
        "SystemAltLowColor",
        "SystemAltMediumColor",
        "SystemAltMediumHighColor",
        "SystemAltMediumLowColor",
        "SystemBaseHighColor",
        "SystemBaseLowColor",
        "SystemBaseMediumColor",
        "SystemBaseMediumHighColor",
        "SystemBaseMediumLowColor",
        "SystemChromeAltLowColor",
        "SystemChromeBlackHighColor",
        "SystemChromeBlackLowColor",
        "SystemChromeBlackMediumLowColor",
        "SystemChromeBlackMediumColor",
        "SystemChromeDisabledHighColor",
        "SystemChromeDisabledLowColor",
        "SystemChromeHighColor",
        "SystemChromeLowColor",
        "SystemChromeMediumColor",
        "SystemChromeMediumLowColor",
        "SystemChromeWhiteColor",
        "SystemChromeGrayColor",
        "SystemListLowColor",
        "SystemListMediumColor",
        "SystemErrorTextColor",
        "SystemRevealListLowColor",
        "SystemRevealListMediumColor",
        "SystemAccentColor",
        "SystemAccentColorDark1",
        "SystemAccentColorDark2",
        "SystemAccentColorDark3",
        "SystemAccentColorLight1",
        "SystemAccentColorLight2",
        "SystemAccentColorLight3",
    };

    public ObservableCollection<ColorResource> ColorResources { get; set; }

    public ColorsPage()
    {
        InitializeComponent();

        ColorResources = new ObservableCollection<ColorResource>();
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);

        if (Application.Current?.Resources is { })
        {
            foreach (var colorKey in _colorKeys)
            {
                Application.Current.TryFindResource(colorKey, out var resource);
                if (resource is Color color)
                {
                    ColorResources.Add(new ColorResource(colorKey, color));
                }
            }
        }

        var itemsControl = this.FindControl<ItemsControl>("ItemsControl");
        if (itemsControl is { })
        {
            itemsControl.Items = ColorResources;
        }
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}

