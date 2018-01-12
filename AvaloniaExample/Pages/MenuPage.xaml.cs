using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaExample.Pages
{
    public class MenuPage : UserControl
    {
        public MenuPage()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
