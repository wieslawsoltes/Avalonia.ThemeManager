using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Media.Immutable;

namespace AvaloniaApp;

public partial class ColorPage : UserControl
{
    public static readonly StyledProperty<Color> ColorProperty =
        AvaloniaProperty.Register<ColorPage, Color>(nameof(Color));

    public static readonly StyledProperty<string> KeyProperty =
        AvaloniaProperty.Register<ColorPage, string>(nameof(Key));

    public Color Color
    {
        get => GetValue(ColorProperty);
        set => SetValue(ColorProperty, value);
    }

    public string Key
    {
        get => GetValue(KeyProperty);
        set => SetValue(KeyProperty, value);
    }

    public ColorPage()
    {
        InitializeComponent();

        var panel = this.FindControl<Panel>("Panel");
        var popup = this.FindControl<Popup>("Popup");
        if (panel != null && popup != null)
        {
            panel.DoubleTapped += (_, _) => popup.IsOpen = true;
            panel.PointerPressed += (_, _) => popup.IsOpen = true;
        }
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);

        if (change.Property == ColorProperty)
        {
            var border = this.FindControl<Border>("Border");
            if (border != null)
            {
                var color = change.GetNewValue<Color>();
                border.Background = new ImmutableSolidColorBrush(color);

                Application.Current.Resources[Key] = color;
            }
        }
    }
}

