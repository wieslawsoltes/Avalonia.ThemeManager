# Avalonia Theme Manager

[![NuGet](https://img.shields.io/nuget/v/Avalonia.ThemeManager.svg)](https://www.nuget.org/packages/Avalonia.ThemeManager)

## About

Theme manager for [Avalonia](https://github.com/AvaloniaUI/Avalonia) applications.

## Usage

Theme manager searches user provided themes directory for `*.xaml` theme files otherwise built-in `Light` and `Dark` theme are used.

The `ThemeSelector` static `Instance` property neeeds to be initalized before using `ThemeSelector` class.

The `ThemeSelector` uses `Styles[0]` property of `Windows` to insert selected theme `Style`.

`App.xaml`
```XAML
<Application x:Class="AvaloniaApp.App"
             xmlns="https://github.com/avaloniaui"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <Application.Styles>
        <StyleInclude Source="avares://Avalonia.Themes.Default/DefaultTheme.xaml"/>
        <StyleInclude Source="avares://Avalonia.Themes.Default/Accents/BaseLight.xaml"/>
    </Application.Styles>
</Application>
```

`App.xaml.cs`
```C#
using System;
using Avalonia;
using Avalonia.Logging.Serilog;
using Avalonia.Markup.Xaml;
using Avalonia.ThemeManager;

namespace AvaloniaApp
{
    public class App : Application
    {
        [STAThread]
        static void Main(string[] args)
        {
            BuildAvaloniaApp().Start(AppMain, args);
        }

        static void AppMain(Application app, string[] args)
        {
            ThemeSelector.Instance = new ThemeSelector("Themes");
            ThemeSelector.Instance.LoadSelectedTheme("AvaloniaApp.theme");

            app.Run(new MainWindow());

            ThemeSelector.Instance.SaveSelectedTheme("AvaloniaApp.theme");
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                         .UsePlatformDetect()
                         .UseReactiveUI()
                         .LogToDebug();

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
```

`MainWindow.xaml`
```XAML
<Window x:Class="AvaloniaApp.MainWindow"
        xmlns="https://github.com/avaloniaui"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:Themes="clr-namespace:Avalonia.ThemeManager;assembly=Avalonia.ThemeManager"
        Title="AvaloniaApp" Width="800" Height="600">
    <Window.Resources>
        <Themes:ObjectEqualityMultiConverter x:Key="ObjectEqualityMultiConverter"/>
    </Window.Resources>
    <Grid RowDefinitions="Auto,*">
        <Menu Grid.Row="0">
            <MenuItem Header="_View">
                <MenuItem Header="_Theme" DataContext="{x:Static Themes:ThemeSelector.Instance}" Items="{Binding Themes}">
                    <MenuItem.Styles>
                        <Style Selector="MenuItem">
                            <Setter Property="Header" Value="{Binding Name}"/>
                            <Setter Property="Command" Value="{Binding Selector.ApplyTheme}"/>
                            <Setter Property="CommandParameter" Value="{Binding}"/>
                            <Setter Property="Icon">
                                <Template>
                                    <CheckBox>
                                        <CheckBox.IsChecked>
                                            <MultiBinding Mode="OneWay" Converter="{StaticResource ObjectEqualityMultiConverter}">
                                                <Binding Path="DataContext" RelativeSource="{RelativeSource Self}"/>
                                                <Binding Path="Selector.SelectedTheme"/>
                                            </MultiBinding>
                                        </CheckBox.IsChecked>
                                    </CheckBox>
                                </Template>
                            </Setter>
                        </Style>
                    </MenuItem.Styles>
                </MenuItem>
            </MenuItem>
        </Menu>
    </Grid>
</Window>
```

`MainWindow.xaml.xs`
```C#
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ThemeManager;

namespace AvaloniaApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.AttachDevTools();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
```

The `ThemeSelector.Instance.EnableThemes(this);` can be used in multiple windows.

## License

Avalonia.ThemeManager is licensed under the [MIT license](LICENSE.TXT).
