using System.Windows;

namespace SnippetManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CopySnippet(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(SnippetManagerViewmodel.SelectedSnippet.Content);
        }

        private void SaveSnippet(object sender, RoutedEventArgs e)
        {
            SnippetManagerViewmodel.SelectedSnippet.Content = SnippetTextBox.Text;
        }
    }
}