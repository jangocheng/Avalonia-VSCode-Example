using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaExample.Pages
{
    public class TextBoxPage : UserControl
    {
        public TextBoxPage()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
