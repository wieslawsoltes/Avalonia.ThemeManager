namespace AvaloniaApp;

public class Accents
{
    #region AccentColors.xaml

    public static string AccentColors =
"""
<Style xmlns="https://github.com/avaloniaui"
       xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
       xmlns:sys="clr-namespace:System;assembly=netstandard">
  <Style.Resources>
    <!-- Accent Colours -->
    <!-- TODO pull accents from system... algorithm to generate shades -->
    <Color x:Key="SystemAccentColor">#FF0078D7</Color>
    <Color x:Key="SystemAccentColorDark1">#FF005A9E</Color>
    <Color x:Key="SystemAccentColorDark2">#FF004275</Color>
    <Color x:Key="SystemAccentColorDark3">#FF002642</Color>
    <Color x:Key="SystemAccentColorLight1">#FF429CE3</Color>
    <Color x:Key="SystemAccentColorLight2">#FF76B9ED</Color>
    <Color x:Key="SystemAccentColorLight3">#FFA6D8FF</Color>
  </Style.Resources>
</Style>
""";

    #endregion

    #region BaseLight.xaml

    public static string BaseLight =
"""
<Style xmlns="https://github.com/avaloniaui"
       xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
       xmlns:sys="clr-namespace:System;assembly=netstandard">
  <Style.Resources>
    <!-- System Control Colors -->
    <Color x:Key="SystemAltHighColor">#FFFFFFFF</Color>
    <Color x:Key="SystemAltLowColor">#33FFFFFF</Color>
    <Color x:Key="SystemAltMediumColor">#99FFFFFF</Color>
    <Color x:Key="SystemAltMediumHighColor">#CCFFFFFF</Color>
    <Color x:Key="SystemAltMediumLowColor">#66FFFFFF</Color>
    <Color x:Key="SystemBaseHighColor">#FF000000</Color>
    <Color x:Key="SystemBaseLowColor">#33000000</Color>
    <Color x:Key="SystemBaseMediumColor">#99000000</Color>
    <Color x:Key="SystemBaseMediumHighColor">#CC000000</Color>
    <Color x:Key="SystemBaseMediumLowColor">#66000000</Color>
    <Color x:Key="SystemChromeAltLowColor">#FF171717</Color>
    <Color x:Key="SystemChromeBlackHighColor">#FF000000</Color>
    <Color x:Key="SystemChromeBlackLowColor">#33000000</Color>
    <Color x:Key="SystemChromeBlackMediumLowColor">#66000000</Color>
    <Color x:Key="SystemChromeBlackMediumColor">#CC000000</Color>
    <Color x:Key="SystemChromeDisabledHighColor">#FFCCCCCC</Color>
    <Color x:Key="SystemChromeDisabledLowColor">#FF7A7A7A</Color>
    <Color x:Key="SystemChromeHighColor">#FFCCCCCC</Color>
    <Color x:Key="SystemChromeLowColor">#FFF2F2F2</Color>
    <Color x:Key="SystemChromeMediumColor">#FFE6E6E6</Color>
    <Color x:Key="SystemChromeMediumLowColor">#FFF2F2F2</Color>
    <Color x:Key="SystemChromeWhiteColor">#FFFFFFFF</Color>
    <Color x:Key="SystemChromeGrayColor">#FF767676</Color>
    <Color x:Key="SystemListLowColor">#19000000</Color>
    <Color x:Key="SystemListMediumColor">#33000000</Color>
    <Color x:Key="SystemErrorTextColor">#C50500</Color>

    <Color x:Key="SystemRevealListLowColor">#17000000</Color>
    <Color x:Key="SystemRevealListMediumColor">#2E000000</Color>

    <SolidColorBrush x:Key="SystemControlBackgroundAccentBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundAltHighBrush" Color="{StaticResource SystemAltHighColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundAltMediumHighBrush" Color="{StaticResource SystemAltMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundAltMediumBrush" Color="{StaticResource SystemAltMediumColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundAltMediumLowBrush" Color="{StaticResource SystemAltMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundBaseLowBrush" Color="{StaticResource SystemBaseLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundBaseMediumHighBrush" Color="{StaticResource SystemBaseMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundBaseMediumLowBrush" Color="{StaticResource SystemBaseMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeBlackHighBrush" Color="{StaticResource SystemChromeBlackHighColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeBlackMediumBrush" Color="{StaticResource SystemChromeBlackMediumColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeBlackLowBrush" Color="{StaticResource SystemChromeBlackLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeBlackMediumLowBrush" Color="{StaticResource SystemChromeBlackMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeMediumBrush" Color="{StaticResource SystemChromeMediumColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeMediumLowBrush" Color="{StaticResource SystemChromeMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeWhiteBrush" Color="{StaticResource SystemChromeWhiteColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundListLowBrush" Color="{StaticResource SystemListLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundListMediumBrush" Color="{StaticResource SystemListMediumColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledAccentBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledBaseLowBrush" Color="{StaticResource SystemBaseLowColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledBaseMediumLowBrush" Color="{StaticResource SystemBaseMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledChromeDisabledHighBrush" Color="{StaticResource SystemChromeDisabledHighColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledChromeDisabledLowBrush" Color="{StaticResource SystemChromeDisabledLowColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledChromeHighBrush" Color="{StaticResource SystemChromeHighColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledChromeMediumLowBrush" Color="{StaticResource SystemChromeMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledListMediumBrush" Color="{StaticResource SystemListMediumColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledTransparentBrush" Color="Transparent" />
    <SolidColorBrush x:Key="SystemControlFocusVisualPrimaryBrush" Color="{DynamicResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlFocusVisualSecondaryBrush" Color="{DynamicResource SystemAltMediumColor}" />
    <SolidColorBrush x:Key="SystemControlRevealFocusVisualBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundAccentBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundAltHighBrush" Color="{StaticResource SystemAltHighColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundAltMediumHighBrush" Color="{StaticResource SystemAltMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundBaseLowBrush" Color="{StaticResource SystemBaseLowColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundBaseMediumHighBrush" Color="{StaticResource SystemBaseMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundBaseMediumLowBrush" Color="{StaticResource SystemBaseMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeBlackHighBrush" Color="{StaticResource SystemChromeBlackHighColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeHighBrush" Color="{StaticResource SystemChromeHighColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeMediumBrush" Color="{StaticResource SystemChromeMediumColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeDisabledLowBrush" Color="{StaticResource SystemChromeDisabledLowColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeWhiteBrush" Color="{StaticResource SystemChromeWhiteColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeBlackMediumBrush" Color="{StaticResource SystemChromeBlackMediumColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeBlackMediumLowBrush" Color="{StaticResource SystemChromeBlackMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeGrayBrush" Color="{StaticResource SystemChromeGrayColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundListLowBrush" Color="{StaticResource SystemListLowColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundListMediumBrush" Color="{StaticResource SystemListMediumColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundTransparentBrush" Color="Transparent" />
    <SolidColorBrush x:Key="SystemControlHighlightAccentBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltAccentBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltAltHighBrush" Color="{StaticResource SystemAltHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltBaseLowBrush" Color="{StaticResource SystemBaseLowColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltBaseMediumHighBrush" Color="{StaticResource SystemBaseMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltAltMediumHighBrush" Color="{StaticResource SystemAltMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltBaseMediumLowBrush" Color="{StaticResource SystemBaseMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltListAccentHighBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.7" />
    <SolidColorBrush x:Key="SystemControlHighlightAltListAccentLowBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.4" />
    <SolidColorBrush x:Key="SystemControlHighlightAltListAccentMediumBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.6" />
    <SolidColorBrush x:Key="SystemControlHighlightAltChromeWhiteBrush" Color="{StaticResource SystemChromeWhiteColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltTransparentBrush" Color="Transparent" />
    <SolidColorBrush x:Key="SystemControlHighlightBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightBaseLowBrush" Color="{StaticResource SystemBaseLowColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightBaseMediumHighBrush" Color="{StaticResource SystemBaseMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightBaseMediumLowBrush" Color="{StaticResource SystemBaseMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightChromeAltLowBrush" Color="{StaticResource SystemChromeAltLowColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightChromeHighBrush" Color="{StaticResource SystemChromeHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightListAccentHighBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.7" />
    <SolidColorBrush x:Key="SystemControlHighlightListAccentLowBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.4" />
    <SolidColorBrush x:Key="SystemControlHighlightListAccentMediumBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.6" />
    <SolidColorBrush x:Key="SystemControlHighlightListMediumBrush" Color="{StaticResource SystemListMediumColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightListLowBrush" Color="{StaticResource SystemListLowColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightChromeWhiteBrush" Color="{StaticResource SystemChromeWhiteColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightTransparentBrush" Color="Transparent" />
    <SolidColorBrush x:Key="SystemControlHyperlinkTextBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlHyperlinkBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlHyperlinkBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlHyperlinkBaseMediumHighBrush" Color="{StaticResource SystemBaseMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundAltMediumBrush" Color="{StaticResource SystemAltMediumColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundAltHighBrush" Color="{StaticResource SystemAltHighColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundMediumAltMediumBrush" Color="{StaticResource SystemAltMediumColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundBaseLowBrush" Color="{StaticResource SystemBaseLowColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundListLowBrush" Color="{StaticResource SystemListLowColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundChromeLowBrush" Color="{StaticResource SystemChromeLowColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundChromeMediumLowBrush" Color="{StaticResource SystemChromeMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundTransparentBrush" Color="Transparent" />
    <SolidColorBrush x:Key="SystemControlPageTextBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlPageTextBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlPageTextChromeBlackMediumLowBrush" Color="{StaticResource SystemChromeBlackMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlErrorTextForegroundBrush" Color="{StaticResource SystemErrorTextColor}" />
    <SolidColorBrush x:Key="SystemControlTransientBorderBrush" Color="#000000" Opacity="0.14" />
    <SolidColorBrush x:Key="SystemControlHighlightListLowRevealBackgroundBrush" Color="{StaticResource SystemListMediumColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightListMediumRevealBackgroundBrush" Color="{StaticResource SystemListMediumColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAccentRevealBackgroundBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAccent3RevealBackgroundBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.6" />
    <SolidColorBrush x:Key="SystemControlHighlightAccent2RevealBackgroundBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.8" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeWhiteRevealBorderBrush" Color="{StaticResource SystemChromeWhiteColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltTransparentRevealBorderBrush" Color="Transparent" />
    <SolidColorBrush x:Key="SystemControlBackgroundTransparentRevealBorderBrush" Color="Transparent" />
    <!-- TODO implement AcrylicBrush -->
    <!--<AcrylicBrush x:Key="SystemControlTransientBackgroundBrush" BackgroundSource="HostBackdrop" TintColor="{StaticResource SystemChromeAltHighColor}" TintOpacity="0.8" FallbackColor="{StaticResource SystemChromeMediumLowColor}" />-->
    <SolidColorBrush x:Key="SystemControlTransientBackgroundBrush" Color="{StaticResource SystemChromeMediumLowColor}" />
    <StaticResource x:Key="SystemControlDescriptionTextForegroundBrush" ResourceKey="SystemControlPageTextBaseMediumBrush" />
    
    <!--<AcrylicBrush x:Key="SystemControlAcrylicWindowBrush" BackgroundSource="HostBackdrop" TintColor="{ThemeResource SystemChromeAltHighColor}" TintOpacity="0.8" FallbackColor="{ThemeResource SystemChromeMediumColor}" />-->
    <!--<RevealBackgroundBrush x:Key="SystemControlTransparentRevealBackgroundBrush" TargetTheme="Dark" Color="Transparent" FallbackColor="Transparent" />-->
    <SolidColorBrush x:Key="SystemControlTransparentRevealBackgroundBrush" Color="Transparent" />
    <!--<RevealBorderBrush x:Key="SystemControlTransparentRevealBorderBrush" TargetTheme="Dark" Color="Transparent" FallbackColor="Transparent" />-->
    <SolidColorBrush x:Key="SystemControlTransparentRevealBorderBrush" Color="Transparent" />


    <!--<RevealBackgroundBrush x:Key="SystemControlHighlightListLowRevealBackgroundBrush" TargetTheme="Light" Color="{ThemeResource SystemRevealListMediumColor}" FallbackColor="{ StaticResource SystemListMediumColor}" />-->
    <Color x:Key="RegionColor">#FFFFFFFF</Color>
    <SolidColorBrush x:Key="RegionBrush" Color="{StaticResource RegionColor}" />


    <x:Double x:Key="AutoCompleteListMaxHeight">374</x:Double>
    <Thickness x:Key="AutoCompleteListMargin">0,2,0,2</Thickness>
    <Thickness x:Key="AutoCompleteListBorderThemeThickness">1</Thickness>
    <Thickness x:Key="AutoCompleteListPadding">-1,0,-1,0</Thickness>
    <x:Double x:Key="TextControlThemeMinHeight">32</x:Double>
    <x:Double x:Key="TextControlThemeMinWidth">64</x:Double>
    <x:Double x:Key="FlyoutThemeMaxWidth">456</x:Double>
    <Thickness x:Key="DateTimeFlyoutButtonBorderThickness">0</Thickness>
    <Thickness x:Key="DateTimeFlyoutBorderThickness">1</Thickness>
    <Thickness x:Key="DateTimeFlyoutBorderPadding">0</Thickness>

    <Thickness x:Key="FlyoutContentThemePadding">12,11,12,12</Thickness>
    <x:Double x:Key="FlyoutThemeMinWidth">96</x:Double>
    <x:Double x:Key="FlyoutThemeMinHeight">40</x:Double>
    <x:Double x:Key="FlyoutThemeMaxHeight">758</x:Double>

    <!-- Moved from FlyoutPresenter.xaml -->
    <Thickness x:Key="FlyoutBorderThemePadding">0</Thickness>

    <!-- Moved from MenuItem.xaml -->
    <Thickness x:Key="MenuFlyoutScrollerMargin">0,4,0,4</Thickness>

    <!-- Moved from Menu.xaml -->
    <Thickness x:Key="MenuBarItemPadding">12,0,12,0</Thickness>
  </Style.Resources>
</Style>
""";

    #endregion

    #region FluentControlResourcesLight.xaml

    public static string FluentControlResourcesLight =
"""
<Style xmlns="https://github.com/avaloniaui"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  xmlns:sys="clr-namespace:System;assembly=netstandard">
  <Style.Resources>
    <!-- Resources for Button.xaml -->
    <StaticResource x:Key="AccentButtonBackground" ResourceKey="SystemControlBackgroundAccentBrush" />
    <StaticResource x:Key="AccentButtonBackgroundPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="AccentButtonBackgroundPressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="AccentButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="AccentButtonForeground" ResourceKey="SystemControlBackgroundChromeWhiteBrush" />
    <StaticResource x:Key="AccentButtonForegroundPointerOver" ResourceKey="SystemControlBackgroundChromeWhiteBrush" />
    <StaticResource x:Key="AccentButtonForegroundPressed" ResourceKey="SystemControlBackgroundChromeWhiteBrush" />
    <StaticResource x:Key="AccentButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="AccentButtonBorderBrush" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="AccentButtonBorderBrushPointerOver" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="AccentButtonBorderBrushPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="AccentButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
    <Thickness x:Key="ButtonBorderThemeThickness">1</Thickness>
    <StaticResource x:Key="ButtonBackground" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <SolidColorBrush x:Key="ButtonBackgroundPointerOver" Color="{StaticResource SystemBaseHighColor}" Opacity="0.1" />
    <StaticResource x:Key="ButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="ButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ButtonForegroundPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ButtonForegroundPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ButtonBorderBrush" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ButtonBorderBrushPointerOver" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ButtonBorderBrushPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="ButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
    
    <!-- Resources for RepeatButton.xaml -->
    <StaticResource x:Key="RepeatButtonBackground" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <SolidColorBrush x:Key="RepeatButtonBackgroundPointerOver" Color="{StaticResource SystemBaseHighColor}" Opacity="0.1" />
    <StaticResource x:Key="RepeatButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="RepeatButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="RepeatButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="RepeatButtonForegroundPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="RepeatButtonForegroundPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="RepeatButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="RepeatButtonBorderBrush" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="RepeatButtonBorderBrushPointerOver" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="RepeatButtonBorderBrushPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="RepeatButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
        
    <!-- Resources for ToggleButton.xaml -->
    <Thickness x:Key="ToggleButtonBorderThemeThickness">1</Thickness>
    <StaticResource x:Key="ToggleButtonBackground" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <SolidColorBrush x:Key="ToggleButtonBackgroundPointerOver" Color="{StaticResource SystemBaseHighColor}" Opacity="0.1" />
    <StaticResource x:Key="ToggleButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundChecked" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundCheckedPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="ToggleButtonBackgroundCheckedPressed" ResourceKey="SystemControlHighlightBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundCheckedDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundIndeterminate" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundIndeterminatePointerOver" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundIndeterminatePressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundIndeterminateDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ToggleButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ToggleButtonForegroundPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleButtonForegroundPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonForegroundChecked" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="ToggleButtonForegroundCheckedPointerOver" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="ToggleButtonForegroundCheckedPressed" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="ToggleButtonForegroundCheckedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonForegroundIndeterminate" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ToggleButtonForegroundIndeterminatePointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleButtonForegroundIndeterminatePressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleButtonForegroundIndeterminateDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrush" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushPointerOver" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushChecked" ResourceKey="SystemControlHighlightAltTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushCheckedPointerOver" ResourceKey="SystemControlHighlightAltTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushCheckedPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushCheckedDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushIndeterminate" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushIndeterminatePointerOver" ResourceKey="SystemControlHighlightBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushIndeterminatePressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushIndeterminateDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />

    <!-- Resources for ComboBox.xaml -->
    <x:Double x:Key="ComboBoxThemeMinWidth">64</x:Double>
    <Thickness x:Key="ComboBoxBorderThemeThickness">1</Thickness>
    <Thickness x:Key="ComboBoxDropdownBorderThickness">1</Thickness>
    <Thickness x:Key="ComboBoxItemThemePadding">11,5,11,7</Thickness>
    <FontWeight x:Key="ComboBoxHeaderThemeFontWeight">Normal</FontWeight>
    <StaticResource x:Key="ComboBoxItemForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundSelected" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundSelectedPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundSelectedPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundSelectedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ComboBoxItemBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundPressed" ResourceKey="SystemControlHighlightListMediumBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundPointerOver" ResourceKey="SystemControlHighlightListLowBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundSelected" ResourceKey="SystemControlHighlightListAccentLowBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundSelectedPressed" ResourceKey="SystemControlHighlightListAccentHighBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundSelectedPointerOver" ResourceKey="SystemControlHighlightListAccentMediumBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundSelectedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushSelected" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushSelectedPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushSelectedPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushSelectedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxBackground" ResourceKey="SystemControlBackgroundAltMediumLowBrush" />
    <StaticResource x:Key="ComboBoxBackgroundPointerOver" ResourceKey="SystemControlPageBackgroundAltMediumBrush" />
    <StaticResource x:Key="ComboBoxBackgroundPressed" ResourceKey="SystemControlBackgroundListMediumBrush" />
    <StaticResource x:Key="ComboBoxBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ComboBoxBackgroundUnfocused" ResourceKey="SystemControlHighlightListAccentLowBrush" />
    <StaticResource x:Key="ComboBoxBackgroundBorderBrushFocused" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="ComboBoxBackgroundBorderBrushUnfocused" ResourceKey="SystemControlHighlightBaseMediumLowBrush" />
    <StaticResource x:Key="ComboBoxForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ComboBoxForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ComboBoxForegroundFocused" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxForegroundFocusedPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxPlaceHolderForeground" ResourceKey="SystemControlPageTextBaseHighBrush" />
    <StaticResource x:Key="ComboBoxPlaceHolderForegroundFocusedPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxBorderBrush" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="ComboBoxBorderBrushPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="ComboBoxBorderBrushPressed" ResourceKey="SystemControlHighlightBaseMediumBrush" />
    <StaticResource x:Key="ComboBoxBorderBrushDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="ComboBoxDropDownGlyphForeground" ResourceKey="SystemControlForegroundBaseMediumHighBrush" />
    <StaticResource x:Key="ComboBoxDropDownGlyphForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ComboBoxDropDownGlyphForegroundFocused" ResourceKey="SystemControlHighlightAltBaseMediumHighBrush" />
    <StaticResource x:Key="ComboBoxDropDownGlyphForegroundFocusedPressed" ResourceKey="SystemControlHighlightAltBaseMediumHighBrush" />
    <StaticResource x:Key="ComboBoxDropDownBackground" ResourceKey="SystemControlTransientBackgroundBrush" />
    <StaticResource x:Key="ComboBoxDropDownBorderBrush" ResourceKey="SystemControlTransientBorderBrush" />
    <Thickness x:Key="ComboBoxDropdownBorderPadding">0</Thickness>
    <Thickness x:Key="ComboBoxDropdownContentMargin">0,4,0,4</Thickness>
    
    <!-- Resources for ListBox.xaml -->
    <Thickness x:Key="ListBoxBorderThemeThickness">0</Thickness>
    
    <!-- Resources for ProgressBar.xaml -->    
    <x:Double x:Key="ProgressBarThemeMinHeight">4</x:Double>
    <Thickness x:Key="ProgressBarBorderThemeThickness">0</Thickness>
    
    <!-- Resources for MenuFlyout.xaml (Menu, ContextMenu, etc) -->
    <x:Double x:Key="MenuFlyoutSeparatorThemeHeight">1</x:Double>
    <x:Double x:Key="MenuFlyoutThemeMinHeight">32</x:Double>
    <Thickness x:Key="MenuFlyoutPresenterThemePadding">0,0</Thickness>
    <Thickness x:Key="MenuFlyoutItemChevronMargin">12,0,0,0</Thickness>
    <Thickness x:Key="MenuFlyoutSeparatorThemePadding">12,4,12,4</Thickness>
    <StaticResource x:Key="MenuFlyoutItemBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="MenuFlyoutItemBackgroundPointerOver" ResourceKey="SystemControlHighlightListLowBrush" />
    <StaticResource x:Key="MenuFlyoutItemBackgroundPressed" ResourceKey="SystemControlHighlightListMediumBrush" />
    <StaticResource x:Key="MenuFlyoutItemBackgroundDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="MenuFlyoutItemForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="MenuFlyoutItemForegroundPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="MenuFlyoutItemForegroundPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="MenuFlyoutItemForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="MenuFlyoutSubItemChevron" ResourceKey="SystemControlForegroundBaseMediumHighBrush" />
    <StaticResource x:Key="MenuFlyoutSubItemChevronPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="MenuFlyoutSubItemChevronPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="MenuFlyoutSubItemChevronSubMenuOpened" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="MenuFlyoutSubItemChevronDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="MenuFlyoutItemKeyboardAcceleratorTextForeground" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="MenuFlyoutItemKeyboardAcceleratorTextForegroundPointerOver" ResourceKey="SystemControlHighlightAltBaseMediumBrush" />
    <StaticResource x:Key="MenuFlyoutItemKeyboardAcceleratorTextForegroundPressed" ResourceKey="SystemControlHighlightAltBaseMediumBrush" />
    <StaticResource x:Key="MenuFlyoutItemKeyboardAcceleratorTextForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <Thickness x:Key="MenuFlyoutItemThemePadding">11,9,11,10</Thickness>
    <Thickness x:Key="MenuFlyoutItemThemePaddingNarrow">11,4,11,7</Thickness>
    <StaticResource x:Key="MenuFlyoutPresenterBackground" ResourceKey="SystemControlTransientBackgroundBrush" />
    <StaticResource x:Key="MenuFlyoutPresenterBorderBrush" ResourceKey="SystemControlTransientBorderBrush" />
    <Thickness x:Key="MenuFlyoutPresenterBorderThemeThickness">1</Thickness>
        
    <!-- Resources for TextBox.xaml -->
    <StaticResource x:Key="TextControlForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="TextControlForegroundPointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="TextControlForegroundDisabled" ResourceKey="SystemControlDisabledChromeDisabledLowBrush" />
    <StaticResource x:Key="TextControlBackground" ResourceKey="SystemControlBackgroundAltMediumLowBrush" />
    <StaticResource x:Key="TextControlBackgroundPointerOver" ResourceKey="SystemControlBackgroundAltMediumBrush" />
    <StaticResource x:Key="TextControlBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="TextControlBorderBrushFocused" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="TextControlBorderBrushDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="TextControlPlaceholderForeground" ResourceKey="SystemControlPageTextBaseMediumBrush" />
    <StaticResource x:Key="TextControlPlaceholderForegroundPointerOver" ResourceKey="SystemControlPageTextBaseMediumBrush" />
    <StaticResource x:Key="TextControlPlaceholderForegroundDisabled" ResourceKey="SystemControlDisabledChromeDisabledLowBrush" />    
    <StaticResource x:Key="TextControlSelectionHighlightColor" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="TextControlButtonBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TextControlButtonBackgroundPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TextControlButtonBackgroundPressed" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="TextControlButtonBorderBrush" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TextControlButtonBorderBrushPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TextControlButtonBorderBrushPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TextControlButtonForegroundPointerOver" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="TextControlButtonForegroundPressed" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />    
    <StaticResource x:Key="TextControlBackgroundFocused" ResourceKey="SystemControlBackgroundAltHighBrush" />
    <StaticResource x:Key="TextControlBorderBrush" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="TextControlBorderBrushPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="TextControlButtonForeground" ResourceKey="SystemControlForegroundBaseMediumHighBrush" />
    <StaticResource x:Key="TextControlForegroundFocused" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="TextControlPlaceholderForegroundFocused" ResourceKey="SystemControlForegroundBaseMediumLowBrush" />
    
    <!-- Resources for AutoCompleteBox.xaml -->
    <StaticResource x:Key="AutoCompleteBoxSuggestionsListBackground" ResourceKey="SystemControlTransientBackgroundBrush" />
    <StaticResource x:Key="AutoCompleteBoxSuggestionsListBorderBrush" ResourceKey="SystemControlTransientBorderBrush" />
   
    <!-- Resources for CheckBox.xaml -->
    <Thickness x:Key="CheckBoxBorderThemeThickness">1</Thickness>
    <StaticResource x:Key="CheckBoxForegroundUnchecked" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundUncheckedPointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundUncheckedPressed" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundUncheckedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CheckBoxForegroundChecked" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundCheckedPointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundCheckedPressed" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundCheckedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CheckBoxForegroundIndeterminate" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundIndeterminatePointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundIndeterminatePressed" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundIndeterminateDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CheckBoxBackgroundUnchecked" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundUncheckedPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundUncheckedPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundUncheckedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundChecked" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundCheckedPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundCheckedPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundCheckedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundIndeterminate" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundIndeterminatePointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundIndeterminatePressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundIndeterminateDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushUnchecked" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushUncheckedPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushUncheckedPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushUncheckedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushChecked" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushCheckedPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushCheckedPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushCheckedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushIndeterminate" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushIndeterminatePointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushIndeterminatePressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushIndeterminateDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeUnchecked" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeUncheckedPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeUncheckedPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeUncheckedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />    
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeCheckedPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeCheckedPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeCheckedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeIndeterminate" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeIndeterminatePointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeIndeterminatePressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeIndeterminateDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillUnchecked" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillUncheckedPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillUncheckedPressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillUncheckedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillChecked" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillCheckedPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillCheckedPressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillCheckedDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillIndeterminate" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillIndeterminatePointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillIndeterminatePressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillIndeterminateDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundUnchecked" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundUncheckedPointerOver" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundUncheckedPressed" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundUncheckedDisabled" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundChecked" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundCheckedPointerOver" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundCheckedPressed" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundCheckedDisabled" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundIndeterminate" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundIndeterminatePointerOver" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundIndeterminatePressed" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundIndeterminateDisabled" ResourceKey="SystemControlForegroundChromeWhiteBrush" />

    <!-- Resources for Calendar.xaml, CalendarButton.xaml, CalendarDayButton.xaml, CalendarItem.xaml -->
    <StaticResource x:Key="CalendarViewSelectedHoverBorderBrush" ResourceKey="SystemControlHighlightListAccentMediumBrush" />
    <StaticResource x:Key="CalendarViewSelectedPressedBorderBrush" ResourceKey="SystemControlHighlightListAccentHighBrush" />
    <StaticResource x:Key="CalendarViewSelectedBorderBrush" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="CalendarViewHoverBorderBrush" ResourceKey="SystemControlHighlightBaseMediumLowBrush" />
    <StaticResource x:Key="CalendarViewPressedBorderBrush" ResourceKey="SystemControlHighlightBaseMediumBrush" />
    <StaticResource x:Key="CalendarViewTodayForeground" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CalendarViewBlackoutForeground" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CalendarViewOutOfScopeForeground" ResourceKey="SystemControlHyperlinkBaseHighBrush" />
    <StaticResource x:Key="CalendarViewCalendarItemForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CalendarViewOutOfScopeBackground" ResourceKey="SystemControlDisabledChromeMediumLowBrush" />
    <StaticResource x:Key="CalendarViewForeground" ResourceKey="SystemControlHyperlinkBaseMediumHighBrush" />
    <StaticResource x:Key="CalendarViewBackground" ResourceKey="SystemControlBackgroundAltHighBrush" />
    <StaticResource x:Key="CalendarViewBorderBrush" ResourceKey="SystemControlForegroundChromeMediumBrush" />
    <StaticResource x:Key="CalendarViewWeekDayForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CalendarViewNavigationButtonBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CalendarViewNavigationButtonForegroundPointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CalendarViewNavigationButtonForegroundPressed" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="CalendarViewCalendarItemRevealBackground" ResourceKey="SystemControlTransparentRevealBackgroundBrush" />
    <StaticResource x:Key="CalendarViewCalendarItemRevealBorderBrush" ResourceKey="SystemControlTransparentRevealBorderBrush" />
    <StaticResource x:Key="CalendarViewNavigationButtonBorderBrushPointerOver" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="CalendarViewNavigationButtonBorderBrush" ResourceKey="SystemControlTransparentBrush" />

    <!-- Resources for Expander.xaml -->
    <!-- Expander:Header -->
    <StaticResource x:Key="ExpanderHeaderBackground" ResourceKey="SystemAltMediumHighColor" />
    <StaticResource x:Key="ExpanderHeaderBackgroundPointerOver" ResourceKey="SystemAltMediumHighColor" />
    <StaticResource x:Key="ExpanderHeaderBackgroundPressed" ResourceKey="SystemAltMediumHighColor" />
    <StaticResource x:Key="ExpanderHeaderBackgroundDisabled" ResourceKey="SystemAltMediumHighColor" />
    <StaticResource x:Key="ExpanderHeaderForeground" ResourceKey="SystemBaseHighColor" />
    <StaticResource x:Key="ExpanderHeaderForegroundPointerOver" ResourceKey="SystemBaseHighColor" />
    <StaticResource x:Key="ExpanderHeaderForegroundPressed" ResourceKey="SystemBaseHighColor" />
    <StaticResource x:Key="ExpanderHeaderForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ExpanderHeaderBorderBrush" ResourceKey="SystemBaseLowColor" />
    <StaticResource x:Key="ExpanderHeaderBorderBrushPointerOver" ResourceKey="SystemBaseLowColor" />
    <StaticResource x:Key="ExpanderHeaderBorderBrushPressed" ResourceKey="SystemBaseLowColor" />
    <StaticResource x:Key="ExpanderHeaderBorderBrushDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />

    <SolidColorBrush x:Key="ExpanderChevronBackground" Color="Transparent" />
    <SolidColorBrush x:Key="ExpanderChevronBackgroundPointerOver" Color="{StaticResource SystemBaseHighColor}" Opacity="0.1" />
    <SolidColorBrush x:Key="ExpanderChevronBackgroundPressed" Color="Transparent" />
    <SolidColorBrush x:Key="ExpanderChevronBackgroundDisabled" Color="Transparent" />
    <StaticResource x:Key="ExpanderChevronForeground" ResourceKey="SystemBaseHighColor" />
    <StaticResource x:Key="ExpanderChevronForegroundPointerOver" ResourceKey="SystemBaseHighColor" />
    <StaticResource x:Key="ExpanderChevronForegroundPressed" ResourceKey="SystemBaseHighColor" />
    <StaticResource x:Key="ExpanderChevronForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <SolidColorBrush x:Key="ExpanderChevronBorderBrush" Color="Transparent" />
    <SolidColorBrush x:Key="ExpanderChevronBorderBrushPointerOver" Color="Transparent" />
    <SolidColorBrush x:Key="ExpanderChevronBorderBrushPressed" Color="Transparent" />
    <SolidColorBrush x:Key="ExpanderChevronBorderBrushDisabled" Color="Transparent" />

    <!-- Expander:Content -->
    <StaticResource x:Key="ExpanderContentBackground" ResourceKey="SystemChromeMediumLowColor" />
    <StaticResource x:Key="ExpanderContentBorderBrush" ResourceKey="SystemBaseLowColor" />

    <!--Resources for NotificationCard.xaml -->
    <SolidColorBrush x:Key="NotificationCardBackgroundBrush" Color="White" />
    <StaticResource x:Key="NotificationCardForegroundBrush" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <SolidColorBrush x:Key="NotificationCardProgressBackgroundBrush" Color="#9A9A9A" />
    <SolidColorBrush x:Key="NotificationCardInformationBackgroundBrush" Color="#0078D4" />
    <SolidColorBrush x:Key="NotificationCardSuccessBackgroundBrush" Color="#128B44" />
    <SolidColorBrush x:Key="NotificationCardWarningBackgroundBrush" Color="#FFC316" />
    <SolidColorBrush x:Key="NotificationCardErrorBackgroundBrush" Color="#F03916" />
    
    <!-- Resources for RadioButton.xaml -->
    <x:Double x:Key="RadioButtonBorderThemeThickness">1</x:Double>
    <StaticResource x:Key="RadioButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="RadioButtonForegroundPointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="RadioButtonForegroundPressed" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="RadioButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="RadioButtonBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBackgroundPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBackgroundPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBackgroundDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBorderBrush" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBorderBrushPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBorderBrushPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBorderBrushDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseStroke" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseStrokePointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseStrokePressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseStrokeDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseFill" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseFillPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseFillPressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseFillDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedStroke" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedStrokePointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedStrokePressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedStrokeDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedFill" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedFillPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedFillPressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedFillDisabled" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphFill" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphFillPointerOver" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphFillPressed" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphFillDisabled" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphStroke" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphStrokePointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphStrokePressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphStrokeDisabled" ResourceKey="SystemControlTransparentBrush" />
    
    <!-- Resources for Slider.xaml -->
    <x:Double x:Key="SliderOutsideTickBarThemeHeight">4</x:Double>
    <x:Double x:Key="SliderTrackThemeHeight">2</x:Double>
    <Thickness x:Key="SliderBorderThemeThickness">0</Thickness>
    <StaticResource x:Key="SliderContainerBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="SliderContainerBackgroundPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="SliderContainerBackgroundPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="SliderContainerBackgroundDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="SliderThumbBackground" ResourceKey="SystemControlForegroundAccentBrush" />
    <StaticResource x:Key="SliderThumbBackgroundPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="SliderThumbBackgroundPressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="SliderThumbBackgroundDisabled" ResourceKey="SystemControlDisabledChromeDisabledHighBrush" />
    <StaticResource x:Key="SliderTrackFill" ResourceKey="SystemControlForegroundBaseMediumLowBrush" />
    <StaticResource x:Key="SliderTrackFillPointerOver" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="SliderTrackFillPressed" ResourceKey="SystemControlForegroundBaseMediumLowBrush" />
    <StaticResource x:Key="SliderTrackFillDisabled" ResourceKey="SystemControlDisabledChromeDisabledHighBrush" />
    <StaticResource x:Key="SliderTrackValueFill" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="SliderTrackValueFillPointerOver" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="SliderTrackValueFillPressed" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="SliderTrackValueFillDisabled" ResourceKey="SystemControlDisabledChromeDisabledHighBrush" />
    <StaticResource x:Key="SliderTickBarFill" ResourceKey="SystemControlForegroundBaseMediumLowBrush" />
    <StaticResource x:Key="SliderTickBarFillDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="SliderInlineTickBarFill" ResourceKey="SystemControlBackgroundAltHighBrush" />
   
    <!--Recources ToggleSwitch-->
    <Thickness x:Key="ToggleSwitchOnStrokeThickness">0</Thickness>
    <Thickness x:Key="ToggleSwitchOuterBorderStrokeThickness">1</Thickness>
    <StaticResource x:Key="ToggleSwitchContentForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ToggleSwitchHeaderForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleSwitchContainerBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ToggleSwitchContainerBackgroundPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ToggleSwitchContainerBackgroundPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ToggleSwitchFillOff" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ToggleSwitchFillOffPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ToggleSwitchFillOffPressed" ResourceKey="SystemControlHighlightBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOff" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOffPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOffPressed" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOffDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleSwitchFillOn" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="ToggleSwitchFillOnPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="ToggleSwitchFillOnPressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="ToggleSwitchFillOnDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOn" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOnPointerOver" ResourceKey="SystemControlHighlightListAccentHighBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOnPressed" ResourceKey="SystemControlHighlightBaseMediumBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOnDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOff" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOffPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOffPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOffDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOn" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOnPointerOver" ResourceKey="SystemControlHighlightChromeWhiteBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOnPressed" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOnDisabled" ResourceKey="SystemControlPageBackgroundBaseLowBrush" />
    
    <!-- Resources for ToolTip.xaml -->
    <x:Double x:Key="ToolTipContentThemeFontSize">12</x:Double>
    <Thickness x:Key="ToolTipBorderThemeThickness">1</Thickness>
    <StaticResource x:Key="ToolTipForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ToolTipBackground" ResourceKey="SystemControlBackgroundChromeMediumLowBrush" />
    <StaticResource x:Key="ToolTipBorderBrush" ResourceKey="SystemControlTransientBorderBrush" />
    <Thickness x:Key="ToolTipBorderThemePadding">8,5,8,7</Thickness>
    
    <!-- Resources for DatePicker.xaml-->
    <StaticResource x:Key="DatePickerSpacerFill" ResourceKey="SystemControlForegroundBaseLowBrush" />
    <StaticResource x:Key="DatePickerSpacerFillDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="DatePickerButtonBorderBrush" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="DatePickerButtonBorderBrushPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="DatePickerButtonBorderBrushPressed" ResourceKey="SystemControlHighlightBaseMediumBrush" />
    <StaticResource x:Key="DatePickerButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="DatePickerButtonBackground" ResourceKey="SystemControlBackgroundAltMediumLowBrush" />
    <StaticResource x:Key="DatePickerButtonBackgroundPointerOver" ResourceKey="SystemControlPageBackgroundAltMediumBrush" />
    <StaticResource x:Key="DatePickerButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="DatePickerButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="DatePickerButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="DatePickerButtonForegroundPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="DatePickerButtonForegroundPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="DatePickerButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="DatePickerFlyoutPresenterBackground" ResourceKey="SystemControlTransientBackgroundBrush" />
    <StaticResource x:Key="DatePickerFlyoutPresenterBorderBrush" ResourceKey="SystemControlTransientBorderBrush" />
    <StaticResource x:Key="DatePickerFlyoutPresenterSpacerFill" ResourceKey="SystemControlForegroundBaseLowBrush" />
    <StaticResource x:Key="DatePickerFlyoutPresenterHighlightFill" ResourceKey="SystemControlHighlightListAccentLowBrush" />

    <StaticResource x:Key="DateTimePickerFlyoutButtonBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonBackgroundPointerOver" ResourceKey="SystemControlHighlightListLowBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonBackgroundPressed" ResourceKey="SystemControlHighlightListMediumBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonBorderBrush" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonBorderBrushPointerOver" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonBorderBrushPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonForegroundPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonForegroundPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
  
    <!-- Resources for TimePicker.xaml -->
    <StaticResource x:Key="TimePickerSpacerFill" ResourceKey="SystemControlForegroundBaseLowBrush" />
    <StaticResource x:Key="TimePickerSpacerFillDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="TimePickerButtonBorderBrush" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="TimePickerButtonBorderBrushPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="TimePickerButtonBorderBrushPressed" ResourceKey="SystemControlHighlightBaseMediumBrush" />
    <StaticResource x:Key="TimePickerButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="TimePickerButtonBackground" ResourceKey="SystemControlBackgroundAltMediumLowBrush" />
    <StaticResource x:Key="TimePickerButtonBackgroundPointerOver" ResourceKey="SystemControlPageBackgroundAltMediumBrush" />
    <StaticResource x:Key="TimePickerButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="TimePickerButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="TimePickerButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="TimePickerButtonForegroundPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="TimePickerButtonForegroundPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="TimePickerButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="TimePickerFlyoutPresenterBackground" ResourceKey="SystemControlTransientBackgroundBrush" />
    <StaticResource x:Key="TimePickerFlyoutPresenterBorderBrush" ResourceKey="SystemControlTransientBorderBrush" />
    <StaticResource x:Key="TimePickerFlyoutPresenterSpacerFill" ResourceKey="SystemControlForegroundBaseLowBrush" />
    <StaticResource x:Key="TimePickerFlyoutPresenterHighlightFill" ResourceKey="SystemControlHighlightListAccentLowBrush" />
        
    <!-- Resources for TabItem.xaml -->
    <x:Double x:Key="TabItemHeaderFontSize">24</x:Double>
    <Thickness x:Key="TabItemHeaderMargin">12,0,12,0</Thickness>
    <Thickness x:Key="TabItemMargin">12,0,12,0</Thickness>
    <FontWeight x:Key="TabItemHeaderThemeFontWeight">SemiLight</FontWeight>
    <StaticResource x:Key="TabControlBackground" ResourceKey="SystemControlTransparentBrush" />
     
    <!-- Resources for TabItem -->
    <StaticResource x:Key="TabItemHeaderBackgroundUnselected" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderBackgroundUnselectedPointerOver" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderBackgroundUnselectedPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderBackgroundSelected" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderBackgroundSelectedPointerOver" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderBackgroundSelectedPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderBackgroundDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundUnselected" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundUnselectedPointerOver" ResourceKey="SystemControlHighlightAltBaseMediumHighBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundUnselectedPressed" ResourceKey="SystemControlHighlightAltBaseMediumHighBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundSelected" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundSelectedPointerOver" ResourceKey="SystemControlHighlightAltBaseMediumHighBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundSelectedPressed" ResourceKey="SystemControlHighlightAltBaseMediumHighBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="TabItemHeaderSelectedPipeFill" ResourceKey="SystemControlHighlightAltAccentBrush" />
 
    <!-- Resources for ScrollBar.xaml -->
    <x:Double x:Key="ScrollBarTrackBorderThemeThickness">0</x:Double>
    <StaticResource x:Key="ScrollBarBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarBackgroundPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarForeground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarBorderBrush" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarButtonBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarButtonBackgroundPointerOver" ResourceKey="SystemControlBackgroundListLowBrush" />
    <StaticResource x:Key="ScrollBarButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseMediumBrush" />
    <StaticResource x:Key="ScrollBarButtonBorderBrush" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarButtonBorderBrushPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarButtonBorderBrushPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarButtonBorderBrushDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarButtonArrowForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ScrollBarButtonArrowForegroundPointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ScrollBarButtonArrowForegroundPressed" ResourceKey="SystemControlForegroundAltHighBrush" />
    <StaticResource x:Key="ScrollBarButtonArrowForegroundDisabled" ResourceKey="SystemControlForegroundBaseLowBrush" />
    <StaticResource x:Key="ScrollBarThumbFillPointerOver" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="ScrollBarThumbFillPressed" ResourceKey="SystemControlBackgroundBaseMediumBrush" />
    <StaticResource x:Key="ScrollBarThumbFillDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
    <SolidColorBrush x:Key="ScrollBarTrackFill" Color="{StaticResource SystemChromeMediumColor}" Opacity="0.9" />
    <SolidColorBrush x:Key="ScrollBarTrackFillPointerOver" Color="{StaticResource SystemChromeMediumColor}" Opacity="0.9" />
    <StaticResource x:Key="ScrollBarTrackStroke" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ScrollBarTrackStrokePointerOver" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ScrollBarThumbBackgroundColor" ResourceKey="SystemBaseLowColor" />
    <StaticResource x:Key="ScrollBarPanningThumbBackgroundColor" ResourceKey="SystemChromeDisabledLowColor" />
    <SolidColorBrush x:Key="ScrollBarPanningThumbBackground" Color="{StaticResource ScrollBarPanningThumbBackgroundColor}" />
    <x:Double x:Key="ScrollBarSize">16</x:Double>
    <x:Double x:Key="ScrollBarButtonArrowIconFontSize">8</x:Double>
     
    <!-- Resources for TreeViewItem.xaml -->
    <StaticResource x:Key="TreeViewItemBackground" ResourceKey="SystemControlTransparentRevealBackgroundBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundPointerOver" ResourceKey="SystemControlHighlightListLowRevealBackgroundBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundPressed" ResourceKey="SystemControlHighlightListMediumRevealBackgroundBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundSelected" ResourceKey="SystemControlHighlightAccent3RevealBackgroundBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundSelectedPointerOver" ResourceKey="SystemControlHighlightAccent2RevealBackgroundBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundSelectedPressed" ResourceKey="SystemControlHighlightListMediumRevealBackgroundBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundSelectedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="TreeViewItemForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="TreeViewItemForegroundPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="TreeViewItemForegroundPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="TreeViewItemForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="TreeViewItemForegroundSelected" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="TreeViewItemForegroundSelectedPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="TreeViewItemForegroundSelectedPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="TreeViewItemForegroundSelectedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrush" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushPointerOver" ResourceKey="SystemControlHighlightAltTransparentRevealBorderBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushPressed" ResourceKey="SystemControlHighlightAltTransparentRevealBorderBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushSelected" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushSelectedPointerOver" ResourceKey="SystemControlBackgroundTransparentRevealBorderBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushSelectedPressed" ResourceKey="SystemControlBackgroundTransparentRevealBorderBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushSelectedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <Thickness x:Key="TreeViewItemBorderThemeThickness">1</Thickness>
    <x:Double x:Key="TreeViewItemMinHeight">32</x:Double>

    <!-- Resources for SplitButton.xaml (shared with ToggleSplitButton) -->
    <StaticResource x:Key="SplitButtonBackground" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <SolidColorBrush x:Key="SplitButtonBackgroundPointerOver" Color="{StaticResource SystemBaseHighColor}" Opacity="0.1" />
    <StaticResource x:Key="SplitButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="SplitButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="SplitButtonBackgroundChecked" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="SplitButtonBackgroundCheckedPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="SplitButtonBackgroundCheckedPressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="SplitButtonBackgroundCheckedDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="SplitButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="SplitButtonForegroundPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="SplitButtonForegroundPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="SplitButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="SplitButtonForegroundChecked" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="SplitButtonForegroundCheckedPointerOver" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="SplitButtonForegroundCheckedPressed" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="SplitButtonForegroundCheckedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="SplitButtonBorderBrush" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushPointerOver" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushChecked" ResourceKey="SystemControlHighlightAltTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushCheckedPointerOver" ResourceKey="SystemControlHighlightAltTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushCheckedPressed" ResourceKey="SystemControlHighlightAltTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushCheckedDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
    <Thickness x:Key="SplitButtonBorderThemeThickness">1</Thickness>

    <!-- Resources for SplitView.xaml -->
    <StaticResource x:Key="SplitViewLightDismissOverlayBackground" ResourceKey="SystemControlPageBackgroundMediumAltMediumBrush" />
  
    <!-- Resources for CalendarDatePicker.xaml -->
    <StaticResource x:Key="CalendarDatePickerForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CalendarDatePickerForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CalendarDatePickerCalendarGlyphForeground" ResourceKey="SystemControlForegroundBaseMediumHighBrush" />
    <StaticResource x:Key="CalendarDatePickerCalendarGlyphForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CalendarDatePickerTextForeground" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="CalendarDatePickerTextForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CalendarDatePickerTextForegroundSelected" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CalendarDatePickerBackground" ResourceKey="SystemControlBackgroundAltMediumLowBrush" />
    <StaticResource x:Key="CalendarDatePickerBackgroundPointerOver" ResourceKey="SystemControlPageBackgroundAltMediumBrush" />
    <StaticResource x:Key="CalendarDatePickerBackgroundPressed" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="CalendarDatePickerBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="CalendarDatePickerBackgroundFocused" ResourceKey="SystemControlHighlightListAccentLowBrush" />
    <StaticResource x:Key="CalendarDatePickerBorderBrush" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="CalendarDatePickerBorderBrushPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="CalendarDatePickerBorderBrushPressed" ResourceKey="SystemControlHighlightBaseMediumBrush" />
    <StaticResource x:Key="CalendarDatePickerBorderBrushDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="CalendarDatePickerLightDismissOverlayBackground" ResourceKey="SystemControlPageBackgroundMediumAltMediumBrush" />
    <Thickness x:Key="CalendarDatePickerBorderThemeThickness">1</Thickness>

    <!-- Resources for FlyoutPresenter.xaml -->
    <StaticResource x:Key="FlyoutPresenterBackground" ResourceKey="SystemControlBackgroundChromeMediumLowBrush" />
    <StaticResource x:Key="FlyoutBorderThemeBrush" ResourceKey="SystemControlTransientBorderBrush" />
    
    <!-- Resources for ScrollViewer.xaml -->
    <SolidColorBrush x:Key="ScrollViewerScrollBarsSeparatorBackground" Color="{StaticResource SystemChromeMediumColor}" Opacity="0.9" />
  </Style.Resources>
</Style>
""";

    #endregion

    #region BaseDark.xaml

    public static string BaseDark = 
"""
<Style xmlns="https://github.com/avaloniaui"
       xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
       xmlns:sys="clr-namespace:System;assembly=netstandard">
  <Style.Resources>
    <!-- System Control Colors -->
    <Color x:Key="SystemAltHighColor">#FF000000</Color>
    <Color x:Key="SystemAltLowColor">#33000000</Color>
    <Color x:Key="SystemAltMediumColor">#99000000</Color>
    <Color x:Key="SystemAltMediumHighColor">#CC000000</Color>
    <Color x:Key="SystemAltMediumLowColor">#66000000</Color>
    <Color x:Key="SystemBaseHighColor">#FFFFFFFF</Color>
    <Color x:Key="SystemBaseLowColor">#33FFFFFF</Color>
    <Color x:Key="SystemBaseMediumColor">#99FFFFFF</Color>
    <Color x:Key="SystemBaseMediumHighColor">#CCFFFFFF</Color>
    <Color x:Key="SystemBaseMediumLowColor">#66FFFFFF</Color>
    <Color x:Key="SystemChromeAltLowColor">#FFF2F2F2</Color>
    <Color x:Key="SystemChromeBlackHighColor">#FF000000</Color>
    <Color x:Key="SystemChromeBlackLowColor">#33000000</Color>
    <Color x:Key="SystemChromeBlackMediumLowColor">#66000000</Color>
    <Color x:Key="SystemChromeBlackMediumColor">#CC000000</Color>
    <Color x:Key="SystemChromeDisabledHighColor">#FF333333</Color>
    <Color x:Key="SystemChromeDisabledLowColor">#FF858585</Color>
    <Color x:Key="SystemChromeHighColor">#FF767676</Color>
    <Color x:Key="SystemChromeLowColor">#FF171717</Color>
    <Color x:Key="SystemChromeMediumColor">#FF1F1F1F</Color>
    <Color x:Key="SystemChromeMediumLowColor">#FF2B2B2B</Color>
    <Color x:Key="SystemChromeWhiteColor">#FFFFFFFF</Color>
    <Color x:Key="SystemChromeGrayColor">#FF767676</Color>
    <Color x:Key="SystemListLowColor">#19FFFFFF</Color>
    <Color x:Key="SystemListMediumColor">#33FFFFFF</Color>
    <Color x:Key="SystemErrorTextColor">#FFF000</Color>

    <Color x:Key="SystemRevealListLowColor">#18FFFFFF</Color>
    <Color x:Key="SystemRevealListMediumColor">#30FFFFFF</Color>

    <SolidColorBrush x:Key="SystemControlBackgroundAccentBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundAltHighBrush" Color="{StaticResource SystemAltHighColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundAltMediumHighBrush" Color="{StaticResource SystemAltMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundAltMediumBrush" Color="{StaticResource SystemAltMediumColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundAltMediumLowBrush" Color="{StaticResource SystemAltMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundBaseLowBrush" Color="{StaticResource SystemBaseLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundBaseMediumHighBrush" Color="{StaticResource SystemBaseMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundBaseMediumLowBrush" Color="{StaticResource SystemBaseMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeBlackHighBrush" Color="{StaticResource SystemChromeBlackHighColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeBlackMediumBrush" Color="{StaticResource SystemChromeBlackMediumColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeBlackLowBrush" Color="{StaticResource SystemChromeBlackLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeBlackMediumLowBrush" Color="{StaticResource SystemChromeBlackMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeMediumBrush" Color="{StaticResource SystemChromeMediumColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeMediumLowBrush" Color="{StaticResource SystemChromeMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeWhiteBrush" Color="{StaticResource SystemChromeWhiteColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundListLowBrush" Color="{StaticResource SystemListLowColor}" />
    <SolidColorBrush x:Key="SystemControlBackgroundListMediumBrush" Color="{StaticResource SystemListMediumColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledAccentBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledBaseLowBrush" Color="{StaticResource SystemBaseLowColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledBaseMediumLowBrush" Color="{StaticResource SystemBaseMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledChromeDisabledHighBrush" Color="{StaticResource SystemChromeDisabledHighColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledChromeDisabledLowBrush" Color="{StaticResource SystemChromeDisabledLowColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledChromeHighBrush" Color="{StaticResource SystemChromeHighColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledChromeMediumLowBrush" Color="{StaticResource SystemChromeMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledListMediumBrush" Color="{StaticResource SystemListMediumColor}" />
    <SolidColorBrush x:Key="SystemControlDisabledTransparentBrush" Color="Transparent" />
    <SolidColorBrush x:Key="SystemControlFocusVisualPrimaryBrush" Color="{DynamicResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlFocusVisualSecondaryBrush" Color="{DynamicResource SystemAltMediumColor}" />
    <SolidColorBrush x:Key="SystemControlRevealFocusVisualBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundAccentBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundAltHighBrush" Color="{StaticResource SystemAltHighColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundAltMediumHighBrush" Color="{StaticResource SystemAltMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundBaseLowBrush" Color="{StaticResource SystemBaseLowColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundBaseMediumHighBrush" Color="{StaticResource SystemBaseMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundBaseMediumLowBrush" Color="{StaticResource SystemBaseMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeBlackHighBrush" Color="{StaticResource SystemChromeBlackHighColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeHighBrush" Color="{StaticResource SystemChromeHighColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeMediumBrush" Color="{StaticResource SystemChromeMediumColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeWhiteBrush" Color="{StaticResource SystemChromeWhiteColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeDisabledLowBrush" Color="{StaticResource SystemChromeDisabledLowColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeGrayBrush" Color="{StaticResource SystemChromeGrayColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundListLowBrush" Color="{StaticResource SystemListLowColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundListMediumBrush" Color="{StaticResource SystemListMediumColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundTransparentBrush" Color="Transparent" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeBlackMediumBrush" Color="{StaticResource SystemChromeBlackMediumColor}" />
    <SolidColorBrush x:Key="SystemControlForegroundChromeBlackMediumLowBrush" Color="{StaticResource SystemChromeBlackMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAccentBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltAccentBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltAltHighBrush" Color="{StaticResource SystemAltHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltBaseLowBrush" Color="{StaticResource SystemBaseLowColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltBaseMediumHighBrush" Color="{StaticResource SystemBaseMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltAltMediumHighBrush" Color="{StaticResource SystemAltMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltBaseMediumLowBrush" Color="{StaticResource SystemBaseMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltListAccentHighBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.9" />
    <SolidColorBrush x:Key="SystemControlHighlightAltListAccentLowBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.6" />
    <SolidColorBrush x:Key="SystemControlHighlightAltListAccentMediumBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.8" />
    <SolidColorBrush x:Key="SystemControlHighlightAltChromeWhiteBrush" Color="{StaticResource SystemChromeWhiteColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltTransparentBrush" Color="Transparent" />
    <SolidColorBrush x:Key="SystemControlHighlightBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightBaseLowBrush" Color="{StaticResource SystemBaseLowColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightBaseMediumHighBrush" Color="{StaticResource SystemBaseMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightBaseMediumLowBrush" Color="{StaticResource SystemBaseMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightChromeAltLowBrush" Color="{StaticResource SystemChromeAltLowColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightChromeHighBrush" Color="{StaticResource SystemChromeHighColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightListAccentHighBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.9" />
    <SolidColorBrush x:Key="SystemControlHighlightListAccentLowBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.6" />
    <SolidColorBrush x:Key="SystemControlHighlightListAccentMediumBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.8" />
    <SolidColorBrush x:Key="SystemControlHighlightListMediumBrush" Color="{StaticResource SystemListMediumColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightListLowBrush" Color="{StaticResource SystemListLowColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightChromeWhiteBrush" Color="{StaticResource SystemChromeWhiteColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightTransparentBrush" Color="Transparent" />
    <SolidColorBrush x:Key="SystemControlHyperlinkTextBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlHyperlinkBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlHyperlinkBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlHyperlinkBaseMediumHighBrush" Color="{StaticResource SystemBaseMediumHighColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundAltMediumBrush" Color="{StaticResource SystemAltMediumColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundAltHighBrush" Color="{StaticResource SystemAltHighColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundMediumAltMediumBrush" Color="{StaticResource SystemAltMediumColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundBaseLowBrush" Color="{StaticResource SystemBaseLowColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundListLowBrush" Color="{StaticResource SystemListLowColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundChromeLowBrush" Color="{StaticResource SystemChromeLowColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundChromeMediumLowBrush" Color="{StaticResource SystemChromeMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlPageBackgroundTransparentBrush" Color="Transparent" />
    <SolidColorBrush x:Key="SystemControlPageTextBaseHighBrush" Color="{StaticResource SystemBaseHighColor}" />
    <SolidColorBrush x:Key="SystemControlPageTextBaseMediumBrush" Color="{StaticResource SystemBaseMediumColor}" />
    <SolidColorBrush x:Key="SystemControlPageTextChromeBlackMediumLowBrush" Color="{StaticResource SystemChromeBlackMediumLowColor}" />
    <SolidColorBrush x:Key="SystemControlErrorTextForegroundBrush" Color="{StaticResource SystemErrorTextColor}" />
    <SolidColorBrush x:Key="SystemControlTransientBorderBrush" Color="#000000" Opacity="0.36" />
    <SolidColorBrush x:Key="SystemControlHighlightListLowRevealBackgroundBrush" Color="{StaticResource SystemListMediumColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightListMediumRevealBackgroundBrush" Color="{StaticResource SystemListMediumColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAccentRevealBackgroundBrush" Color="{DynamicResource SystemAccentColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAccent3RevealBackgroundBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.6" />
    <SolidColorBrush x:Key="SystemControlHighlightAccent2RevealBackgroundBrush" Color="{DynamicResource SystemAccentColor}" Opacity="0.8" />
    <SolidColorBrush x:Key="SystemControlBackgroundChromeWhiteRevealBorderBrush" Color="{StaticResource SystemChromeWhiteColor}" />
    <SolidColorBrush x:Key="SystemControlHighlightAltTransparentRevealBorderBrush" Color="Transparent" />
    <SolidColorBrush x:Key="SystemControlBackgroundTransparentRevealBorderBrush" Color="Transparent" />
    <!-- TODO implement AcrylicBrush -->
    <!--<AcrylicBrush x:Key="SystemControlTransientBackgroundBrush" BackgroundSource="HostBackdrop" TintColor="{StaticResource SystemChromeAltHighColor}" TintOpacity="0.8" FallbackColor="{StaticResource SystemChromeMediumLowColor}" />-->
    <SolidColorBrush x:Key="SystemControlTransientBackgroundBrush" Color="{StaticResource SystemChromeMediumLowColor}" />
    <StaticResource x:Key="SystemControlDescriptionTextForegroundBrush" ResourceKey="SystemControlPageTextBaseMediumBrush" />
    
    <!--<AcrylicBrush x:Key="SystemControlAcrylicWindowBrush" BackgroundSource="HostBackdrop" TintColor="{ThemeResource SystemChromeAltHighColor}" TintOpacity="0.8" FallbackColor="{ThemeResource SystemChromeMediumColor}" />-->
    <!--<RevealBackgroundBrush x:Key="SystemControlTransparentRevealBackgroundBrush" TargetTheme="Dark" Color="Transparent" FallbackColor="Transparent" />-->
    <SolidColorBrush x:Key="SystemControlTransparentRevealBackgroundBrush" Color="Transparent" />
    <!--<RevealBorderBrush x:Key="SystemControlTransparentRevealBorderBrush" TargetTheme="Dark" Color="Transparent" FallbackColor="Transparent" />-->
    <SolidColorBrush x:Key="SystemControlTransparentRevealBorderBrush" Color="Transparent" />

    <Color x:Key="RegionColor">#FF000000</Color>
    <SolidColorBrush x:Key="RegionBrush" Color="{StaticResource RegionColor}" />

    <x:Double x:Key="AutoCompleteListMaxHeight">374</x:Double>
    <Thickness x:Key="AutoCompleteListMargin">0,2,0,2</Thickness>
    <Thickness x:Key="AutoCompleteListBorderThemeThickness">1</Thickness>
    <Thickness x:Key="AutoCompleteListPadding">-1,0,-1,0</Thickness>
    <x:Double x:Key="TextControlThemeMinHeight">32</x:Double>
    <x:Double x:Key="TextControlThemeMinWidth">64</x:Double>
    <x:Double x:Key="FlyoutThemeMaxWidth">456</x:Double>
    <Thickness x:Key="DateTimeFlyoutButtonBorderThickness">0</Thickness>
    <Thickness x:Key="DateTimeFlyoutBorderThickness">1</Thickness>
    <Thickness x:Key="DateTimeFlyoutBorderPadding">0</Thickness>

    <Thickness x:Key="FlyoutContentThemePadding">12,11,12,12</Thickness>
    <x:Double x:Key="FlyoutThemeMinWidth">96</x:Double>
    <x:Double x:Key="FlyoutThemeMinHeight">40</x:Double>
    <x:Double x:Key="FlyoutThemeMaxHeight">758</x:Double>
    
    <!-- Moved from FlyoutPresenter.xaml -->
    <Thickness x:Key="FlyoutBorderThemePadding">0</Thickness>

    <!-- Moved from MenuItem.xaml -->
    <Thickness x:Key="MenuFlyoutScrollerMargin">0,4,0,4</Thickness>

    <!-- Moved from Menu.xaml -->
    <Thickness x:Key="MenuBarItemPadding">12,0,12,0</Thickness> 
  </Style.Resources>
</Style>
""";
    
    #endregion

    #region FluentControlResourcesDark.xaml

    public string FluentControlResourcesDark =
"""
<Style xmlns="https://github.com/avaloniaui"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  xmlns:sys="clr-namespace:System;assembly=netstandard">
  <Style.Resources>
    <!-- Resources for Button.xaml -->
    <StaticResource x:Key="AccentButtonBackground" ResourceKey="SystemControlBackgroundAccentBrush" />
    <StaticResource x:Key="AccentButtonBackgroundPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="AccentButtonBackgroundPressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="AccentButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="AccentButtonForeground" ResourceKey="SystemControlBackgroundChromeWhiteBrush" />
    <StaticResource x:Key="AccentButtonForegroundPointerOver" ResourceKey="SystemControlBackgroundChromeWhiteBrush" />
    <StaticResource x:Key="AccentButtonForegroundPressed" ResourceKey="SystemControlBackgroundChromeWhiteBrush" />
    <StaticResource x:Key="AccentButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="AccentButtonBorderBrush" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="AccentButtonBorderBrushPointerOver" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="AccentButtonBorderBrushPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="AccentButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
    <Thickness x:Key="ButtonBorderThemeThickness">1</Thickness>
    <StaticResource x:Key="ButtonBackground" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <SolidColorBrush x:Key="ButtonBackgroundPointerOver" Color="{StaticResource SystemBaseHighColor}" Opacity="0.1" />
    <StaticResource x:Key="ButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="ButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ButtonForegroundPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ButtonForegroundPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ButtonBorderBrush" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ButtonBorderBrushPointerOver" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ButtonBorderBrushPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="ButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />

    <!-- Resources for RepeatButton.xaml -->    
    <StaticResource x:Key="RepeatButtonBackground" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <SolidColorBrush x:Key="RepeatButtonBackgroundPointerOver" Color="{StaticResource SystemBaseHighColor}" Opacity="0.1" />
    <StaticResource x:Key="RepeatButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="RepeatButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="RepeatButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="RepeatButtonForegroundPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="RepeatButtonForegroundPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="RepeatButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="RepeatButtonBorderBrush" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="RepeatButtonBorderBrushPointerOver" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="RepeatButtonBorderBrushPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="RepeatButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />

    <!-- Resources for ToggleButton.xaml -->
    <Thickness x:Key="ToggleButtonBorderThemeThickness">1</Thickness>
    <StaticResource x:Key="ToggleButtonBackground" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <SolidColorBrush x:Key="ToggleButtonBackgroundPointerOver" Color="{StaticResource SystemBaseHighColor}" Opacity="0.1" />
    <StaticResource x:Key="ToggleButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundChecked" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundCheckedPointerOver" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="ToggleButtonBackgroundCheckedPressed" ResourceKey="SystemControlHighlightBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundCheckedDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundIndeterminate" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundIndeterminatePointerOver" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundIndeterminatePressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonBackgroundIndeterminateDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ToggleButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ToggleButtonForegroundPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleButtonForegroundPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonForegroundChecked" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="ToggleButtonForegroundCheckedPointerOver" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="ToggleButtonForegroundCheckedPressed" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="ToggleButtonForegroundCheckedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonForegroundIndeterminate" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ToggleButtonForegroundIndeterminatePointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleButtonForegroundIndeterminatePressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleButtonForegroundIndeterminateDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrush" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushPointerOver" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushChecked" ResourceKey="SystemControlHighlightAltTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushCheckedPointerOver" ResourceKey="SystemControlHighlightAltTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushCheckedPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushCheckedDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushIndeterminate" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushIndeterminatePointerOver" ResourceKey="SystemControlHighlightBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushIndeterminatePressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="ToggleButtonBorderBrushIndeterminateDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />

    <!-- Resources for ComboBox.xaml -->
    <x:Double x:Key="ComboBoxThemeMinWidth">64</x:Double>
    <Thickness x:Key="ComboBoxBorderThemeThickness">1</Thickness>
    <Thickness x:Key="ComboBoxDropdownBorderThickness">1</Thickness>
    <Thickness x:Key="ComboBoxItemThemePadding">11,5,11,7</Thickness>
    <FontWeight x:Key="ComboBoxHeaderThemeFontWeight">Normal</FontWeight>
    <StaticResource x:Key="ComboBoxItemForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundSelected" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundSelectedPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundSelectedPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxItemForegroundSelectedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ComboBoxItemBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundPressed" ResourceKey="SystemControlHighlightListMediumBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundPointerOver" ResourceKey="SystemControlHighlightListLowBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundSelected" ResourceKey="SystemControlHighlightListAccentLowBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundSelectedPressed" ResourceKey="SystemControlHighlightListAccentHighBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundSelectedPointerOver" ResourceKey="SystemControlHighlightListAccentMediumBrush" />
    <StaticResource x:Key="ComboBoxItemBackgroundSelectedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushSelected" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushSelectedPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushSelectedPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ComboBoxItemBorderBrushSelectedDisabled" ResourceKey="SystemControlTransparentBrush" />

    <StaticResource x:Key="ComboBoxBackground" ResourceKey="SystemControlBackgroundAltMediumLowBrush" />
    <StaticResource x:Key="ComboBoxBackgroundPointerOver" ResourceKey="SystemControlPageBackgroundAltMediumBrush" />
    <StaticResource x:Key="ComboBoxBackgroundPressed" ResourceKey="SystemControlBackgroundListMediumBrush" />
    <StaticResource x:Key="ComboBoxBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="ComboBoxBackgroundUnfocused" ResourceKey="SystemControlHighlightListAccentLowBrush" />
    <StaticResource x:Key="ComboBoxBackgroundBorderBrushFocused" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="ComboBoxBackgroundBorderBrushUnfocused" ResourceKey="SystemControlHighlightBaseMediumLowBrush" />
    <StaticResource x:Key="ComboBoxForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ComboBoxForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ComboBoxForegroundFocused" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxForegroundFocusedPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxPlaceHolderForeground" ResourceKey="SystemControlPageTextBaseHighBrush" />
    <StaticResource x:Key="ComboBoxPlaceHolderForegroundFocusedPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="ComboBoxBorderBrush" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="ComboBoxBorderBrushPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="ComboBoxBorderBrushPressed" ResourceKey="SystemControlHighlightBaseMediumBrush" />
    <StaticResource x:Key="ComboBoxBorderBrushDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="ComboBoxDropDownGlyphForeground" ResourceKey="SystemControlForegroundBaseMediumHighBrush" />
    <StaticResource x:Key="ComboBoxDropDownGlyphForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ComboBoxDropDownGlyphForegroundFocused" ResourceKey="SystemControlHighlightAltBaseMediumHighBrush" />
    <StaticResource x:Key="ComboBoxDropDownGlyphForegroundFocusedPressed" ResourceKey="SystemControlHighlightAltBaseMediumHighBrush" />    
    <StaticResource x:Key="ComboBoxDropDownBackground" ResourceKey="SystemControlTransientBackgroundBrush" />
    <StaticResource x:Key="ComboBoxDropDownBorderBrush" ResourceKey="SystemControlTransientBorderBrush" />
    <Thickness x:Key="ComboBoxDropdownBorderPadding">0</Thickness>
    <Thickness x:Key="ComboBoxDropdownContentMargin">0,4,0,4</Thickness>

    <!-- Resources for ListBox.xaml -->
    <Thickness x:Key="ListBoxBorderThemeThickness">0</Thickness>

    <!-- Resources for ProgressBar.xaml -->
    <x:Double x:Key="ProgressBarThemeMinHeight">4</x:Double>
    <Thickness x:Key="ProgressBarBorderThemeThickness">0</Thickness>

    <!-- Resources for MenuFlyout.xaml (Menu, ContextMenu, etc) -->
    <x:Double x:Key="MenuFlyoutSeparatorThemeHeight">1</x:Double>
    <x:Double x:Key="MenuFlyoutThemeMinHeight">32</x:Double>
    <Thickness x:Key="MenuFlyoutPresenterThemePadding">0,0</Thickness>
    <Thickness x:Key="MenuFlyoutItemChevronMargin">12,0,0,0</Thickness>
    <Thickness x:Key="MenuFlyoutSeparatorThemePadding">12,4,12,4</Thickness>
    <StaticResource x:Key="MenuFlyoutItemBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="MenuFlyoutItemBackgroundPointerOver" ResourceKey="SystemControlHighlightListLowBrush" />
    <StaticResource x:Key="MenuFlyoutItemBackgroundPressed" ResourceKey="SystemControlHighlightListMediumBrush" />
    <StaticResource x:Key="MenuFlyoutItemBackgroundDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="MenuFlyoutItemForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="MenuFlyoutItemForegroundPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="MenuFlyoutItemForegroundPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="MenuFlyoutItemForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="MenuFlyoutSubItemChevron" ResourceKey="SystemControlForegroundBaseMediumHighBrush" />
    <StaticResource x:Key="MenuFlyoutSubItemChevronPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="MenuFlyoutSubItemChevronPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="MenuFlyoutSubItemChevronSubMenuOpened" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="MenuFlyoutSubItemChevronDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />    
    <StaticResource x:Key="MenuFlyoutItemKeyboardAcceleratorTextForeground" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="MenuFlyoutItemKeyboardAcceleratorTextForegroundPointerOver" ResourceKey="SystemControlHighlightAltBaseMediumBrush" />
    <StaticResource x:Key="MenuFlyoutItemKeyboardAcceleratorTextForegroundPressed" ResourceKey="SystemControlHighlightAltBaseMediumBrush" />
    <StaticResource x:Key="MenuFlyoutItemKeyboardAcceleratorTextForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <Thickness x:Key="MenuFlyoutItemThemePadding">11,9,11,10</Thickness>
    <Thickness x:Key="MenuFlyoutItemThemePaddingNarrow">11,4,11,7</Thickness>
    <StaticResource x:Key="MenuFlyoutPresenterBackground" ResourceKey="SystemControlTransientBackgroundBrush" />
    <StaticResource x:Key="MenuFlyoutPresenterBorderBrush" ResourceKey="SystemControlTransientBorderBrush" />
    <Thickness x:Key="MenuFlyoutPresenterBorderThemeThickness">1</Thickness>
   
    <!-- Resources for TextBox.xaml -->
    <!-- Copied from FluentBaseDark.xaml -->
    <StaticResource x:Key="TextControlForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="TextControlForegroundPointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="TextControlForegroundDisabled" ResourceKey="SystemControlDisabledChromeDisabledLowBrush" />
    <StaticResource x:Key="TextControlBackground" ResourceKey="SystemControlBackgroundAltMediumLowBrush" />
    <StaticResource x:Key="TextControlBackgroundPointerOver" ResourceKey="SystemControlBackgroundAltMediumBrush" />
    <StaticResource x:Key="TextControlBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="TextControlBorderBrushFocused" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="TextControlBorderBrushDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="TextControlPlaceholderForeground" ResourceKey="SystemControlPageTextBaseMediumBrush" />
    <StaticResource x:Key="TextControlPlaceholderForegroundPointerOver" ResourceKey="SystemControlPageTextBaseMediumBrush" />
    <StaticResource x:Key="TextControlPlaceholderForegroundDisabled" ResourceKey="SystemControlDisabledChromeDisabledLowBrush" />
    <StaticResource x:Key="TextControlSelectionHighlightColor" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="TextControlButtonBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TextControlButtonBackgroundPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TextControlButtonBackgroundPressed" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="TextControlButtonBorderBrush" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TextControlButtonBorderBrushPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TextControlButtonBorderBrushPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TextControlButtonForegroundPointerOver" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="TextControlButtonForegroundPressed" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />    
    <StaticResource x:Key="TextControlBackgroundFocused" ResourceKey="SystemControlBackgroundAltHighBrush" />
    <StaticResource x:Key="TextControlBorderBrush" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="TextControlBorderBrushPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="TextControlButtonForeground" ResourceKey="SystemControlForegroundBaseMediumHighBrush" />
    <StaticResource x:Key="TextControlForegroundFocused" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="TextControlPlaceholderForegroundFocused" ResourceKey="SystemControlForegroundBaseMediumLowBrush" />
        

    <!-- Resources for AutoCompleteBox.xaml -->
    <StaticResource x:Key="AutoCompleteBoxSuggestionsListBackground" ResourceKey="SystemControlTransientBackgroundBrush" />
    <StaticResource x:Key="AutoCompleteBoxSuggestionsListBorderBrush" ResourceKey="SystemControlTransientBorderBrush" />
    
    <!-- Resources for Checkbox.xaml -->
    <Thickness x:Key="CheckBoxBorderThemeThickness">1</Thickness>
    <StaticResource x:Key="CheckBoxForegroundUnchecked" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundUncheckedPointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundUncheckedPressed" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundUncheckedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CheckBoxForegroundChecked" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundCheckedPointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundCheckedPressed" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundCheckedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CheckBoxForegroundIndeterminate" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundIndeterminatePointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundIndeterminatePressed" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CheckBoxForegroundIndeterminateDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CheckBoxBackgroundUnchecked" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundUncheckedPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundUncheckedPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundUncheckedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundChecked" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundCheckedPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundCheckedPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundCheckedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundIndeterminate" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundIndeterminatePointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundIndeterminatePressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBackgroundIndeterminateDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushUnchecked" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushUncheckedPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushUncheckedPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushUncheckedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushChecked" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushCheckedPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushCheckedPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushCheckedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushIndeterminate" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushIndeterminatePointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushIndeterminatePressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxBorderBrushIndeterminateDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeUnchecked" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeUncheckedPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeUncheckedPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeUncheckedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />    
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeCheckedPointerOver" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeCheckedPressed" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeCheckedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeIndeterminate" ResourceKey="SystemControlForegroundAccentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeIndeterminatePointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeIndeterminatePressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundStrokeIndeterminateDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillUnchecked" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillUncheckedPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillUncheckedPressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillUncheckedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillChecked" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillCheckedPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillCheckedPressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillCheckedDisabled" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillIndeterminate" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillIndeterminatePointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillIndeterminatePressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="CheckBoxCheckBackgroundFillIndeterminateDisabled" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundUnchecked" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundUncheckedPointerOver" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundUncheckedPressed" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundUncheckedDisabled" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundChecked" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundCheckedPointerOver" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundCheckedPressed" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundCheckedDisabled" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundIndeterminate" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundIndeterminatePointerOver" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundIndeterminatePressed" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CheckBoxCheckGlyphForegroundIndeterminateDisabled" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />

    <!-- Resources for Calendar.xaml, CalendarButton.xaml, CalendarDayButton.xaml, CalendarItem.xaml -->
    <StaticResource x:Key="CalendarViewSelectedHoverBorderBrush" ResourceKey="SystemControlHighlightListAccentMediumBrush" />
    <StaticResource x:Key="CalendarViewSelectedPressedBorderBrush" ResourceKey="SystemControlHighlightListAccentHighBrush" />
    <StaticResource x:Key="CalendarViewSelectedBorderBrush" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="CalendarViewHoverBorderBrush" ResourceKey="SystemControlHighlightBaseMediumLowBrush" />
    <StaticResource x:Key="CalendarViewPressedBorderBrush" ResourceKey="SystemControlHighlightBaseMediumBrush" />
    <StaticResource x:Key="CalendarViewTodayForeground" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="CalendarViewBlackoutForeground" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CalendarViewOutOfScopeForeground" ResourceKey="SystemControlHyperlinkBaseHighBrush" />
    <StaticResource x:Key="CalendarViewCalendarItemForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CalendarViewOutOfScopeBackground" ResourceKey="SystemControlDisabledChromeMediumLowBrush" />
    <StaticResource x:Key="CalendarViewForeground" ResourceKey="SystemControlHyperlinkBaseMediumHighBrush" />
    <StaticResource x:Key="CalendarViewBackground" ResourceKey="SystemControlBackgroundAltHighBrush" />
    <StaticResource x:Key="CalendarViewBorderBrush" ResourceKey="SystemControlForegroundChromeMediumBrush" />
    <StaticResource x:Key="CalendarViewWeekDayForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CalendarViewNavigationButtonBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="CalendarViewNavigationButtonForegroundPointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CalendarViewNavigationButtonForegroundPressed" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="CalendarViewCalendarItemRevealBackground" ResourceKey="SystemControlTransparentRevealBackgroundBrush" />
    <StaticResource x:Key="CalendarViewCalendarItemRevealBorderBrush" ResourceKey="SystemControlTransparentRevealBorderBrush" />
    <StaticResource x:Key="CalendarViewNavigationButtonBorderBrushPointerOver" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="CalendarViewNavigationButtonBorderBrush" ResourceKey="SystemControlTransparentBrush" />

    <!-- Resources for Expander.xaml -->
    <!-- Expander:Header -->
    <StaticResource x:Key="ExpanderHeaderBackground" ResourceKey="SystemAltMediumHighColor" />
    <StaticResource x:Key="ExpanderHeaderBackgroundPointerOver" ResourceKey="SystemAltMediumHighColor" />
    <StaticResource x:Key="ExpanderHeaderBackgroundPressed" ResourceKey="SystemAltMediumHighColor" />
    <StaticResource x:Key="ExpanderHeaderBackgroundDisabled" ResourceKey="SystemAltMediumHighColor" />
    <StaticResource x:Key="ExpanderHeaderForeground" ResourceKey="SystemBaseHighColor" />
    <StaticResource x:Key="ExpanderHeaderForegroundPointerOver" ResourceKey="SystemBaseHighColor" />
    <StaticResource x:Key="ExpanderHeaderForegroundPressed" ResourceKey="SystemBaseHighColor" />
    <StaticResource x:Key="ExpanderHeaderForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ExpanderHeaderBorderBrush" ResourceKey="SystemBaseLowColor" />
    <StaticResource x:Key="ExpanderHeaderBorderBrushPointerOver" ResourceKey="SystemBaseLowColor" />
    <StaticResource x:Key="ExpanderHeaderBorderBrushPressed" ResourceKey="SystemBaseLowColor" />
    <StaticResource x:Key="ExpanderHeaderBorderBrushDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />

    <SolidColorBrush x:Key="ExpanderChevronBackground" Color="Transparent" />
    <SolidColorBrush x:Key="ExpanderChevronBackgroundPointerOver" Color="{StaticResource SystemBaseHighColor}" Opacity="0.1" />
    <SolidColorBrush x:Key="ExpanderChevronBackgroundPressed" Color="Transparent" />
    <SolidColorBrush x:Key="ExpanderChevronBackgroundDisabled" Color="Transparent" />
    <StaticResource x:Key="ExpanderChevronForeground" ResourceKey="SystemBaseHighColor" />
    <StaticResource x:Key="ExpanderChevronForegroundPointerOver" ResourceKey="SystemBaseHighColor" />
    <StaticResource x:Key="ExpanderChevronForegroundPressed" ResourceKey="SystemBaseHighColor" />
    <StaticResource x:Key="ExpanderChevronForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <SolidColorBrush x:Key="ExpanderChevronBorderBrush" Color="Transparent" />
    <SolidColorBrush x:Key="ExpanderChevronBorderBrushPointerOver" Color="Transparent" />
    <SolidColorBrush x:Key="ExpanderChevronBorderBrushPressed" Color="Transparent" />
    <SolidColorBrush x:Key="ExpanderChevronBorderBrushDisabled" Color="Transparent" />

    <!-- Expander:Content -->
    <StaticResource x:Key="ExpanderContentBackground" ResourceKey="SystemChromeMediumLowColor" />
    <StaticResource x:Key="ExpanderContentBorderBrush" ResourceKey="SystemBaseLowColor" />

    <!--Resources for NotificationCard.xaml -->
    <SolidColorBrush x:Key="NotificationCardBackgroundBrush" Color="#444444" />
    <StaticResource x:Key="NotificationCardForegroundBrush" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <SolidColorBrush x:Key="NotificationCardProgressBackgroundBrush" Color="#9A9A9A" />
    <SolidColorBrush x:Key="NotificationCardInformationBackgroundBrush" Color="#007ACC" Opacity="0.75"/>
    <SolidColorBrush x:Key="NotificationCardSuccessBackgroundBrush" Color="#1F9E45" Opacity="0.75"/>
    <SolidColorBrush x:Key="NotificationCardWarningBackgroundBrush" Color="#FDB328" Opacity="0.75"/>
    <SolidColorBrush x:Key="NotificationCardErrorBackgroundBrush" Color="#BD202C" Opacity="0.75"/>
    
    <!-- Resources for RadioButton.xaml -->
    <x:Double x:Key="RadioButtonBorderThemeThickness">1</x:Double>
    <StaticResource x:Key="RadioButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="RadioButtonForegroundPointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="RadioButtonForegroundPressed" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="RadioButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="RadioButtonBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBackgroundPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBackgroundPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBackgroundDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBorderBrush" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBorderBrushPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBorderBrushPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonBorderBrushDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseStroke" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseStrokePointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseStrokePressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseStrokeDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseFill" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseFillPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseFillPressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseFillDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedStroke" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedStrokePointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedStrokePressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedStrokeDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedFill" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedFillPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedFillPressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="RadioButtonOuterEllipseCheckedFillDisabled" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphFill" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphFillPointerOver" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphFillPressed" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphFillDisabled" ResourceKey="SystemControlForegroundChromeWhiteBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphStroke" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphStrokePointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphStrokePressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="RadioButtonCheckGlyphStrokeDisabled" ResourceKey="SystemControlTransparentBrush" />
    
    <!-- Resources for Slider.xaml -->
    <x:Double x:Key="SliderOutsideTickBarThemeHeight">4</x:Double>
    <x:Double x:Key="SliderTrackThemeHeight">2</x:Double>
    <Thickness x:Key="SliderBorderThemeThickness">0</Thickness>
    <StaticResource x:Key="SliderContainerBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="SliderContainerBackgroundPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="SliderContainerBackgroundPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="SliderContainerBackgroundDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="SliderThumbBackground" ResourceKey="SystemControlForegroundAccentBrush" />
    <StaticResource x:Key="SliderThumbBackgroundPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="SliderThumbBackgroundPressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="SliderThumbBackgroundDisabled" ResourceKey="SystemControlDisabledChromeDisabledHighBrush" />
    <StaticResource x:Key="SliderTrackFill" ResourceKey="SystemControlForegroundBaseMediumLowBrush" />
    <StaticResource x:Key="SliderTrackFillPointerOver" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="SliderTrackFillPressed" ResourceKey="SystemControlForegroundBaseMediumLowBrush" />
    <StaticResource x:Key="SliderTrackFillDisabled" ResourceKey="SystemControlDisabledChromeDisabledHighBrush" />
    <StaticResource x:Key="SliderTrackValueFill" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="SliderTrackValueFillPointerOver" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="SliderTrackValueFillPressed" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="SliderTrackValueFillDisabled" ResourceKey="SystemControlDisabledChromeDisabledHighBrush" />
    <StaticResource x:Key="SliderTickBarFill" ResourceKey="SystemControlForegroundBaseMediumLowBrush" />
    <StaticResource x:Key="SliderTickBarFillDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="SliderInlineTickBarFill" ResourceKey="SystemControlBackgroundAltHighBrush" />
    
    <!--ToggleSwitch-->
    <Thickness x:Key="ToggleSwitchOnStrokeThickness">0</Thickness>
    <Thickness x:Key="ToggleSwitchOuterBorderStrokeThickness">1</Thickness>
    <StaticResource x:Key="ToggleSwitchContentForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ToggleSwitchHeaderForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleSwitchContainerBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ToggleSwitchContainerBackgroundPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ToggleSwitchContainerBackgroundPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ToggleSwitchFillOff" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ToggleSwitchFillOffPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ToggleSwitchFillOffPressed" ResourceKey="SystemControlHighlightBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOff" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOffPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOffPressed" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOffDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleSwitchFillOn" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="ToggleSwitchFillOnPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="ToggleSwitchFillOnPressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="ToggleSwitchFillOnDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOn" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleSwitchStrokeOnPointerOver" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="ToggleSwitchStrokeOnPressed" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="ToggleSwitchStrokeOnDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOff" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOffPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOffPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOffDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOn" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOnPointerOver" ResourceKey="SystemControlHighlightChromeWhiteBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOnPressed" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="ToggleSwitchKnobFillOnDisabled" ResourceKey="SystemControlPageBackgroundBaseLowBrush" />

    <!-- Resources for ToolTip.xaml -->
    <x:Double x:Key="ToolTipContentThemeFontSize">12</x:Double>
    <Thickness x:Key="ToolTipBorderThemeThickness">1</Thickness>
    <StaticResource x:Key="ToolTipForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ToolTipBackground" ResourceKey="SystemControlBackgroundChromeMediumLowBrush" />
    <StaticResource x:Key="ToolTipBorderBrush" ResourceKey="SystemControlTransientBorderBrush" />
    <Thickness x:Key="ToolTipBorderThemePadding">8,5,8,7</Thickness>    

    <!-- Resources for DatePicker.xaml-->
    <StaticResource x:Key="DatePickerSpacerFill" ResourceKey="SystemControlForegroundBaseLowBrush" />
    <StaticResource x:Key="DatePickerSpacerFillDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="DatePickerButtonBorderBrush" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="DatePickerButtonBorderBrushPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="DatePickerButtonBorderBrushPressed" ResourceKey="SystemControlHighlightBaseMediumBrush" />
    <StaticResource x:Key="DatePickerButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="DatePickerButtonBackground" ResourceKey="SystemControlBackgroundAltMediumLowBrush" />
    <StaticResource x:Key="DatePickerButtonBackgroundPointerOver" ResourceKey="SystemControlPageBackgroundAltMediumBrush" />
    <StaticResource x:Key="DatePickerButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="DatePickerButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="DatePickerButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="DatePickerButtonForegroundPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="DatePickerButtonForegroundPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="DatePickerButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="DatePickerFlyoutPresenterBackground" ResourceKey="SystemControlTransientBackgroundBrush" />
    <StaticResource x:Key="DatePickerFlyoutPresenterBorderBrush" ResourceKey="SystemControlTransientBorderBrush" />
    <StaticResource x:Key="DatePickerFlyoutPresenterSpacerFill" ResourceKey="SystemControlForegroundBaseLowBrush" />
    <StaticResource x:Key="DatePickerFlyoutPresenterHighlightFill" ResourceKey="SystemControlHighlightListAccentLowBrush" />

    <StaticResource x:Key="DateTimePickerFlyoutButtonBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonBackgroundPointerOver" ResourceKey="SystemControlHighlightListLowBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonBackgroundPressed" ResourceKey="SystemControlHighlightListMediumBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonBorderBrush" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonBorderBrushPointerOver" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonBorderBrushPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonForegroundPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="DateTimePickerFlyoutButtonForegroundPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    

    <!-- Resources for TimePicker.xaml -->
    <StaticResource x:Key="TimePickerSpacerFill" ResourceKey="SystemControlForegroundBaseLowBrush" />
    <StaticResource x:Key="TimePickerSpacerFillDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="TimePickerButtonBorderBrush" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="TimePickerButtonBorderBrushPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="TimePickerButtonBorderBrushPressed" ResourceKey="SystemControlHighlightBaseMediumBrush" />
    <StaticResource x:Key="TimePickerButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="TimePickerButtonBackground" ResourceKey="SystemControlBackgroundAltMediumLowBrush" />
    <StaticResource x:Key="TimePickerButtonBackgroundPointerOver" ResourceKey="SystemControlPageBackgroundAltMediumBrush" />
    <StaticResource x:Key="TimePickerButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="TimePickerButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="TimePickerButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="TimePickerButtonForegroundPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="TimePickerButtonForegroundPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="TimePickerButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="TimePickerFlyoutPresenterBackground" ResourceKey="SystemControlTransientBackgroundBrush" />
    <StaticResource x:Key="TimePickerFlyoutPresenterBorderBrush" ResourceKey="SystemControlTransientBorderBrush" />
    <StaticResource x:Key="TimePickerFlyoutPresenterSpacerFill" ResourceKey="SystemControlForegroundBaseLowBrush" />
    <StaticResource x:Key="TimePickerFlyoutPresenterHighlightFill" ResourceKey="SystemControlHighlightListAccentLowBrush" />

    <!-- Resources for TabItem.xaml -->
    <x:Double x:Key="TabItemHeaderFontSize">24</x:Double>
    <Thickness x:Key="TabItemHeaderMargin">12,0,12,0</Thickness>
    <Thickness x:Key="TabItemMargin">12,0,12,0</Thickness>
    <FontWeight x:Key="TabItemHeaderThemeFontWeight">SemiLight</FontWeight>
    <StaticResource x:Key="TabControlBackground" ResourceKey="SystemControlTransparentBrush" />
          
    <!-- Resources for TabItem -->
    <StaticResource x:Key="TabItemHeaderBackgroundUnselected" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderBackgroundUnselectedPointerOver" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderBackgroundUnselectedPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderBackgroundSelected" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderBackgroundSelectedPointerOver" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderBackgroundSelectedPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderBackgroundDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundUnselected" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundUnselectedPointerOver" ResourceKey="SystemControlHighlightAltBaseMediumHighBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundUnselectedPressed" ResourceKey="SystemControlHighlightAltBaseMediumHighBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundSelected" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundSelectedPointerOver" ResourceKey="SystemControlHighlightAltBaseMediumHighBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundSelectedPressed" ResourceKey="SystemControlHighlightAltBaseMediumHighBrush" />
    <StaticResource x:Key="TabItemHeaderForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />    
    <StaticResource x:Key="TabItemHeaderSelectedPipeFill" ResourceKey="SystemControlHighlightAltAccentBrush" />
    

    <!-- Resources for ScrollBar.xaml -->
    <x:Double x:Key="ScrollBarTrackBorderThemeThickness">0</x:Double>
    <StaticResource x:Key="ScrollBarBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarBackgroundPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarForeground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarBorderBrush" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarButtonBackground" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarButtonBackgroundPointerOver" ResourceKey="SystemControlBackgroundListLowBrush" />
    <StaticResource x:Key="ScrollBarButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseMediumBrush" />
    <StaticResource x:Key="ScrollBarButtonBorderBrush" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarButtonBorderBrushPointerOver" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarButtonBorderBrushPressed" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarButtonBorderBrushDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="ScrollBarButtonArrowForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ScrollBarButtonArrowForegroundPointerOver" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="ScrollBarButtonArrowForegroundPressed" ResourceKey="SystemControlForegroundAltHighBrush" />
    <StaticResource x:Key="ScrollBarButtonArrowForegroundDisabled" ResourceKey="SystemControlForegroundBaseLowBrush" />
    <StaticResource x:Key="ScrollBarThumbFillPointerOver" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="ScrollBarThumbFillPressed" ResourceKey="SystemControlBackgroundBaseMediumBrush" />
    <StaticResource x:Key="ScrollBarThumbFillDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
    <SolidColorBrush x:Key="ScrollBarTrackFill" Color="{StaticResource SystemChromeMediumColor}" Opacity="0.9" />
    <SolidColorBrush x:Key="ScrollBarTrackFillPointerOver" Color="{StaticResource SystemChromeMediumColor}" Opacity="0.9" />
    <StaticResource x:Key="ScrollBarTrackStroke" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ScrollBarTrackStrokePointerOver" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="ScrollBarThumbBackgroundColor" ResourceKey="SystemBaseLowColor" />
    <StaticResource x:Key="ScrollBarPanningThumbBackgroundColor" ResourceKey="SystemChromeDisabledLowColor" />
    <SolidColorBrush x:Key="ScrollBarPanningThumbBackground" Color="{StaticResource ScrollBarPanningThumbBackgroundColor}" />
    <x:Double x:Key="ScrollBarSize">16</x:Double>
    <x:Double x:Key="ScrollBarButtonArrowIconFontSize">8</x:Double>
      
    <!-- Resources for TreeViewItem.xaml -->
    <StaticResource x:Key="TreeViewItemBackground" ResourceKey="SystemControlTransparentRevealBackgroundBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundPointerOver" ResourceKey="SystemControlHighlightListLowRevealBackgroundBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundPressed" ResourceKey="SystemControlHighlightListMediumRevealBackgroundBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundSelected" ResourceKey="SystemControlHighlightAccent3RevealBackgroundBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundSelectedPointerOver" ResourceKey="SystemControlHighlightAccent2RevealBackgroundBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundSelectedPressed" ResourceKey="SystemControlHighlightListMediumRevealBackgroundBrush" />
    <StaticResource x:Key="TreeViewItemBackgroundSelectedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="TreeViewItemForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="TreeViewItemForegroundPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="TreeViewItemForegroundPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="TreeViewItemForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="TreeViewItemForegroundSelected" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="TreeViewItemForegroundSelectedPointerOver" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="TreeViewItemForegroundSelectedPressed" ResourceKey="SystemControlHighlightAltBaseHighBrush" />
    <StaticResource x:Key="TreeViewItemForegroundSelectedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrush" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushPointerOver" ResourceKey="SystemControlHighlightAltTransparentRevealBorderBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushPressed" ResourceKey="SystemControlHighlightAltTransparentRevealBorderBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushDisabled" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushSelected" ResourceKey="SystemControlTransparentBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushSelectedPointerOver" ResourceKey="SystemControlBackgroundTransparentRevealBorderBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushSelectedPressed" ResourceKey="SystemControlBackgroundTransparentRevealBorderBrush" />
    <StaticResource x:Key="TreeViewItemBorderBrushSelectedDisabled" ResourceKey="SystemControlTransparentBrush" />
    <Thickness x:Key="TreeViewItemBorderThemeThickness">1</Thickness>
    <x:Double x:Key="TreeViewItemMinHeight">32</x:Double>

    <!-- Resources for SplitButton.xaml (shared with ToggleSplitButton) -->
    <StaticResource x:Key="SplitButtonBackground" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <SolidColorBrush x:Key="SplitButtonBackgroundPointerOver" Color="{StaticResource SystemBaseHighColor}" Opacity="0.1" />
    <StaticResource x:Key="SplitButtonBackgroundPressed" ResourceKey="SystemControlBackgroundBaseMediumLowBrush" />
    <StaticResource x:Key="SplitButtonBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="SplitButtonBackgroundChecked" ResourceKey="SystemControlHighlightAccentBrush" />
    <StaticResource x:Key="SplitButtonBackgroundCheckedPointerOver" ResourceKey="SystemAccentColorDark1" />
    <StaticResource x:Key="SplitButtonBackgroundCheckedPressed" ResourceKey="SystemAccentColorLight1" />
    <StaticResource x:Key="SplitButtonBackgroundCheckedDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="SplitButtonForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="SplitButtonForegroundPointerOver" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="SplitButtonForegroundPressed" ResourceKey="SystemControlHighlightBaseHighBrush" />
    <StaticResource x:Key="SplitButtonForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="SplitButtonForegroundChecked" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="SplitButtonForegroundCheckedPointerOver" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="SplitButtonForegroundCheckedPressed" ResourceKey="SystemControlHighlightAltChromeWhiteBrush" />
    <StaticResource x:Key="SplitButtonForegroundCheckedDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="SplitButtonBorderBrush" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushPointerOver" ResourceKey="SystemControlForegroundTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushPressed" ResourceKey="SystemControlHighlightTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushChecked" ResourceKey="SystemControlHighlightAltTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushCheckedPointerOver" ResourceKey="SystemControlHighlightAltTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushCheckedPressed" ResourceKey="SystemControlHighlightAltTransparentBrush" />
    <StaticResource x:Key="SplitButtonBorderBrushCheckedDisabled" ResourceKey="SystemControlDisabledTransparentBrush" />
    <Thickness x:Key="SplitButtonBorderThemeThickness">1</Thickness>

    <!-- Resources for SplitView.xaml -->
    <StaticResource x:Key="SplitViewLightDismissOverlayBackground" ResourceKey="SystemControlPageBackgroundMediumAltMediumBrush" />
  
    <!-- Resources for CalendarDatePicker.xaml -->
    <StaticResource x:Key="CalendarDatePickerForeground" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CalendarDatePickerForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CalendarDatePickerCalendarGlyphForeground" ResourceKey="SystemControlForegroundBaseMediumHighBrush" />
    <StaticResource x:Key="CalendarDatePickerCalendarGlyphForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CalendarDatePickerTextForeground" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="CalendarDatePickerTextForegroundDisabled" ResourceKey="SystemControlDisabledBaseMediumLowBrush" />
    <StaticResource x:Key="CalendarDatePickerTextForegroundSelected" ResourceKey="SystemControlForegroundBaseHighBrush" />
    <StaticResource x:Key="CalendarDatePickerBackground" ResourceKey="SystemControlBackgroundAltMediumLowBrush" />
    <StaticResource x:Key="CalendarDatePickerBackgroundPointerOver" ResourceKey="SystemControlPageBackgroundAltMediumBrush" />
    <StaticResource x:Key="CalendarDatePickerBackgroundPressed" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="CalendarDatePickerBackgroundDisabled" ResourceKey="SystemControlBackgroundBaseLowBrush" />
    <StaticResource x:Key="CalendarDatePickerBackgroundFocused" ResourceKey="SystemControlHighlightListAccentLowBrush" />
    <StaticResource x:Key="CalendarDatePickerBorderBrush" ResourceKey="SystemControlForegroundBaseMediumBrush" />
    <StaticResource x:Key="CalendarDatePickerBorderBrushPointerOver" ResourceKey="SystemControlHighlightBaseMediumHighBrush" />
    <StaticResource x:Key="CalendarDatePickerBorderBrushPressed" ResourceKey="SystemControlHighlightBaseMediumBrush" />
    <StaticResource x:Key="CalendarDatePickerBorderBrushDisabled" ResourceKey="SystemControlDisabledBaseLowBrush" />
    <StaticResource x:Key="CalendarDatePickerLightDismissOverlayBackground" ResourceKey="SystemControlPageBackgroundMediumAltMediumBrush" />
    <Thickness x:Key="CalendarDatePickerBorderThemeThickness">1</Thickness>

    <!-- Resources for FlyoutPresenter.xaml -->
    <StaticResource x:Key="FlyoutPresenterBackground" ResourceKey="SystemControlBackgroundChromeMediumLowBrush" />
    <StaticResource x:Key="FlyoutBorderThemeBrush" ResourceKey="SystemControlTransientBorderBrush" />

    <!-- BaseResources for ScrollViewer.xaml -->
    <SolidColorBrush x:Key="ScrollViewerScrollBarsSeparatorBackground" Color="{StaticResource SystemChromeMediumColor}" Opacity="0.9" />    
  </Style.Resources>
</Style>
""";

    #endregion
}
