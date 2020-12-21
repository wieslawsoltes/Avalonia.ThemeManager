using Avalonia.Styling;
using ReactiveUI;

namespace Avalonia.ThemeManager
{
    public class Theme : ReactiveObject
    {
        private string _name = string.Empty;
        private IStyle? _style;
        private ThemeSelector? _selector;

        public string Name
        {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }

        public IStyle? Style
        {
            get => _style;
            set => this.RaiseAndSetIfChanged(ref _style, value);
        }

        public ThemeSelector? Selector
        {
            get => _selector;
            set => this.RaiseAndSetIfChanged(ref _selector, value);
        }

        public void ApplyTheme()
        {
            Selector?.ApplyTheme(this);
        }
    }
}
