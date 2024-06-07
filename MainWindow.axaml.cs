using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaCannotBinding
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        
        private void OnIsEmptyChanged(object? sender, RoutedEventArgs e)
        {
            var useCode = UseCode.IsChecked ?? false;
            if (!useCode)
            {
                return;
            }
            
            ESV.IsEmpty = (sender as CheckBox)?.IsChecked ?? false;
        }
        
        private void OnNotEmptyChanged(object? sender, RoutedEventArgs e)
        {
            
            var useCode = UseCode.IsChecked ?? false;
            if (!useCode)
            {
                return;
            }
            ESV.NotEmpty = (sender as CheckBox)?.IsChecked ?? false;
        }
    }
}