using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Styling;
using Avalonia.Threading;
using ReactiveUI;

namespace Avalonia.ThemeManager
{
    public class ThemeSelector : ReactiveObject
    {
        private Theme? _selectedTheme;
        private IList<Theme>? _themes;
        private IList<Window>? _windows;

        public Theme? SelectedTheme
        {
            get => _selectedTheme;
            set => this.RaiseAndSetIfChanged(ref _selectedTheme, value);
        }

        public IList<Theme>? Themes
        {
            get => _themes;
            set => this.RaiseAndSetIfChanged(ref _themes, value);
        }

        public IList<Window>? Windows
        {
            get => _windows;
            set => this.RaiseAndSetIfChanged(ref _windows, value);
        }

        private ThemeSelector()
        {
        }

        public static ThemeSelector Create(string path)
        {
            return new ThemeSelector()
            {
                Themes = new ObservableCollection<Theme>(),
                Windows = new ObservableCollection<Window>()
            }.LoadThemes(path);
        }

        private ThemeSelector LoadThemes(string path)
        {
            try
            {
                foreach (string file in System.IO.Directory.EnumerateFiles(path, "*.xaml"))
                {
                    var theme = LoadTheme(file);
                    if (theme != null)
                    {
                        _themes?.Add(theme);
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }

            if (_themes?.Count == 0)
            {
                LoadDefaultThemes();
            }

            _selectedTheme = _themes?.FirstOrDefault();

            return this;
        }

        public static Styles DefaultLight = new Styles
        {
            new StyleInclude(new Uri("avares://Avalonia.ThemeManager/Styles"))
            {
                Source = new Uri("avares://Avalonia.Themes.Fluent/Accents/Base.xaml")
            },
            new StyleInclude(new Uri("avares://Avalonia.ThemeManager/Styles"))
            {
                Source = new Uri("avares://Avalonia.Themes.Fluent/Accents/BaseLight.xaml")
            },
            new StyleInclude(new Uri("avares://Avalonia.ThemeManager/Styles"))
            {
                Source = new Uri("avares://Avalonia.Themes.Default/Accents/BaseLight.xaml")
            },
            new StyleInclude(new Uri("avares://Avalonia.ThemeManager/Styles"))
            {
                Source = new Uri("avares://Avalonia.Themes.Default/DefaultTheme.xaml")
            }
        };

        public static Styles DefaultDark = new Styles
        {
            new StyleInclude(new Uri("avares://Avalonia.ThemeManager/Styles"))
            {
                Source = new Uri("avares://Avalonia.Themes.Fluent/Accents/Base.xaml")
            },
            new StyleInclude(new Uri("avares://Avalonia.ThemeManager/Styles"))
            {
                Source = new Uri("avares://Avalonia.Themes.Fluent/Accents/BaseDark.xaml")
            },
            new StyleInclude(new Uri("avares://Avalonia.ThemeManager/Styles"))
            {
                Source = new Uri("avares://Avalonia.Themes.Default/Accents/BaseDark.xaml")
            },
            new StyleInclude(new Uri("avares://Avalonia.ThemeManager/Styles"))
            {
                Source = new Uri("avares://Avalonia.Themes.Default/DefaultTheme.xaml")
            }
        };
  
        public static Styles FluentLight = new Styles
        {
            new StyleInclude(new Uri("avares://Avalonia.ThemeManager/Styles"))
            {
                Source = new Uri("avares://Avalonia.Themes.Fluent/FluentLight.xaml")
            }
        };

        public static Styles FluentDark = new Styles
        {
            new StyleInclude(new Uri("avares://Avalonia.ThemeManager/Styles"))
            {
                Source = new Uri("avares://Avalonia.Themes.Fluent/FluentDark.xaml")
            }
        };

        public virtual void LoadDefaultThemes()
        {
            _themes?.Add(new Theme() {Name = "Default Light", Style = DefaultLight, Selector = this});
            _themes?.Add(new Theme() {Name = "Default Dark", Style = DefaultDark, Selector = this});
            _themes?.Add(new Theme() {Name = "Fluent Light", Style = FluentLight, Selector = this});
            _themes?.Add(new Theme() {Name = "Fluent Dark", Style = FluentDark, Selector = this});
        }

        public Theme LoadTheme(string file)
        {
            var name = System.IO.Path.GetFileNameWithoutExtension(file);
            var xaml = System.IO.File.ReadAllText(file);
            var style = AvaloniaRuntimeXamlLoader.Parse<IStyle>(xaml);
            return new Theme() { Name = name, Style = style, Selector = this };
        }

        public void EnableThemes(Window window)
        {
            IDisposable? disposable = null;

            if (_selectedTheme != null && _selectedTheme.Style != null)
            {
                window.Styles.Add(_selectedTheme.Style); 
            }

            window.Opened += (sender, e) =>
            {
                if (_windows != null)
                {
                    _windows.Add(window);
                    disposable = this.WhenAnyValue(x => x.SelectedTheme)
                        .Where(x => x != null)
                        .ObserveOn(RxApp.MainThreadScheduler)
                        .Subscribe(x =>
                        {
                            SelectedThemeChanged(window, x);
                        }); 
                }
            };

            window.Closing += (sender, e) =>
            {
                disposable?.Dispose();
                if (_windows != null)
                {
                    _windows.Remove(window); 
                }
            };
        }

        private static void SelectedThemeChanged(Window window, Theme? theme)
        {
            if (theme?.Style == null)
            {
                return;
            }

            try
            {
                window.Styles[0] = theme.Style;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{ex.Message}");
            }
        }

        public void ApplyTheme(Theme theme)
        {
            if (theme != null)
            {
                SelectedTheme = theme;
            }
        }

        public void LoadSelectedTheme(string file)
        {
            try
            {
                if (System.IO.File.Exists(file) == true)
                {
                    var name = System.IO.File.ReadAllText(file);
                    if (name != null)
                    {
                        var theme = _themes?.FirstOrDefault(x => x.Name == name);
                        if (theme != null)
                        {
                            SelectedTheme = theme;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public void SaveSelectedTheme(string file)
        {
            try
            {
                System.IO.File.WriteAllText(file, _selectedTheme?.Name);
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
