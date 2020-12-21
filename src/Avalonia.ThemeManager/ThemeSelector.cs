using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Styling;
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

        public virtual void LoadDefaultThemes()
        {
            var light = new StyleInclude(new Uri("resm:Styles?assembly=Avalonia.ThemeManager"))
            {
                Source = new Uri("resm:Avalonia.Themes.Default.Accents.BaseLight.xaml?assembly=Avalonia.Themes.Default")
            };
            var dark = new StyleInclude(new Uri("resm:Styles?assembly=Avalonia.ThemeManager"))
            {
                Source = new Uri("resm:Avalonia.Themes.Default.Accents.BaseDark.xaml?assembly=Avalonia.Themes.Default")
            };
            _themes.Add(new Theme() {Name = "Light", Style = light, Selector = this});
            _themes.Add(new Theme() {Name = "Dark", Style = dark, Selector = this});
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
                    disposable = this.WhenAnyValue(x => x.SelectedTheme).Where(x => x != null).Subscribe(x =>
                    {
                        if (x != null && x.Style != null)
                        {
                            window.Styles[0] = x.Style; 
                        }
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
