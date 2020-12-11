// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
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
    public sealed class ThemeSelector : ReactiveObject, IThemeSelector
    {
        private ITheme? _selectedTheme;
        private IList<ITheme>? _themes;
        private IList<Window>? _windows;

        public ITheme? SelectedTheme
        {
            get => _selectedTheme;
            set => this.RaiseAndSetIfChanged(ref _selectedTheme, value);
        }

        public IList<ITheme>? Themes
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

        public static IThemeSelector Create(string path)
        {
            return new ThemeSelector()
            {
                Themes = new ObservableCollection<ITheme>(),
                Windows = new ObservableCollection<Window>()
            }.LoadThemes(path);
        }

        private IThemeSelector LoadThemes(string path)
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
            }

            if (_themes?.Count == 0)
            {
                var light = new StyleInclude(new Uri("resm:Styles?assembly=Avalonia.ThemeManager"))
                {
                    Source = new Uri("resm:Avalonia.Themes.Default.Accents.BaseLight.xaml?assembly=Avalonia.Themes.Default")
                };
                var dark = new StyleInclude(new Uri("resm:Styles?assembly=Avalonia.ThemeManager"))
                {
                    Source = new Uri("resm:Avalonia.Themes.Default.Accents.BaseDark.xaml?assembly=Avalonia.Themes.Default")
                };
                _themes.Add(new Theme() { Name = "Light", Style = light, Selector = this });
                _themes.Add(new Theme() { Name = "Dark", Style = dark, Selector = this });
            }

            _selectedTheme = _themes?.FirstOrDefault();

            return this;
        }

        public ITheme LoadTheme(string file)
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

        public void ApplyTheme(ITheme theme)
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
            }
        }
    }
}
