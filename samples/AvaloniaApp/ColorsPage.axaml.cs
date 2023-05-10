using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace AvaloniaApp;

public partial class ColorsPage : UserControl
{
    // System Control Colors
    // https://github.com/AvaloniaUI/Avalonia/blob/master/src/Avalonia.Themes.Fluent/Accents/BaseLight.xaml
    // https://github.com/AvaloniaUI/Avalonia/blob/master/src/Avalonia.Themes.Fluent/Accents/FluentControlResourcesLight.xaml
    // https://github.com/AvaloniaUI/Avalonia/blob/master/src/Avalonia.Themes.Fluent/Accents/BaseDark.xaml
    // https://github.com/AvaloniaUI/Avalonia/blob/master/src/Avalonia.Themes.Fluent/Accents/FluentControlResourcesDark.xaml
    // Accent Colours
    // https://github.com/AvaloniaUI/Avalonia/blob/master/src/Avalonia.Themes.Fluent/Accents/AccentColors.xaml

    private readonly string[] _colorKeys = 
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

    private readonly ObservableCollection<ColorResource> _colorResources;

    public Control? Preview { get; set; }

    private bool _canUpdate = false;
    
    public ColorsPage()
    {
        InitializeComponent();

        _colorResources = new ObservableCollection<ColorResource>();
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);

        UpdateColorResources();
    }


    public void UpdatePreview()
    {
        if (!_canUpdate)
        {
            return;
        }

        if (Preview is { })
        {
            foreach (var colorResource in _colorResources)
            {
                // TODO:
                // Preview.Resources[colorResource.Key] = colorResource.Color;
                // Application.Current.Resources[colorResource.Key] = colorResource.Color;
            }
        }
    }
    
    public void UpdateColorResources()
    {
        _canUpdate = false;

        _colorResources.Clear();

        if (Application.Current is { } application)
        {
            foreach (var colorKey in _colorKeys)
            {
                application.TryFindResource(colorKey, out var resource);
                if (resource is Color color)
                {
                    _colorResources.Add(new ColorResource(colorKey, color, UpdatePreview));
                }
            }
        }

        var itemsControl = this.FindControl<ItemsControl>("ItemsControl");
        if (itemsControl is { })
        {
            itemsControl.ItemsSource = _colorResources;
        }

        _canUpdate = true;
    }
}

