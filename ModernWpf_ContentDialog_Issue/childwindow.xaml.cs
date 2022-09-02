using ModernWpf.Controls;
using System.Windows;

namespace ModernWpf_ContentDialog_Issue
{
    public partial class childwindow : Window
    {
        public childwindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.Owner = mainWindow;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog contentDialog = new ContentDialog();
            ModernWpf.ThemeManager.SetRequestedTheme(contentDialog, ModernWpf.ElementTheme.Dark);
            contentDialog.Title = "Hello";
            contentDialog.Content = "Welcome";
            contentDialog.CloseButtonText = "Exit";
            contentDialog.ShowAsync();
        }
    }
}
