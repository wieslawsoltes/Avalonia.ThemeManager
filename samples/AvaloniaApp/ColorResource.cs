using System;
using Avalonia.Media;

namespace AvaloniaApp;

public class ColorResource
{
    public string Key { get; set; }

    public Color Color { get; set; }

    public Action Update { get; set; }
    
    public ColorResource(string key, Color color, Action update)
    {
        Key = key;
        Color = color;
        Update = update;
    }
}
