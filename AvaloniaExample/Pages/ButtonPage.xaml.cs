using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaExample.Pages
{
    public class ButtonPage : UserControl
    {
        public ButtonPage()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
