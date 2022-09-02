using ModernWpf.Controls;
using System.Windows;

namespace ModernWpf_ContentDialog_Issue
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            childwindow childwindow = new childwindow(this);
            childwindow.Show();
        }
    }
}
