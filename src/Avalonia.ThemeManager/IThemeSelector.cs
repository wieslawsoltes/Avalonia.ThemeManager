// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using Avalonia.Controls;

namespace Avalonia.ThemeManager
{
    public interface IThemeSelector
    {
        ITheme SelectedTheme { get; set; }
        IList<ITheme> Themes { get; set; }
        IList<Window> Windows { get; set; }
        ITheme LoadTheme(string file);
        void EnableThemes(Window window);
        void ApplyTheme(ITheme theme);
        void LoadSelectedTheme(string file);
        void SaveSelectedTheme(string file);
    }
}
