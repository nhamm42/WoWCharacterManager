using System.Windows;
using WoWCharacterManager.Views;

namespace WoWCharacterManager
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

        private void CreateCharacter(object sender, RoutedEventArgs e)
        {
            var secondWindow = new Character();
            secondWindow.Show();
        }
    }
}
