using System.Windows;
using WoWCharacterManager.ViewModels;
using WoWCharacterManager.Views;

namespace WoWCharacterManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVm();
        }

        private void CreateCharacter(object sender, RoutedEventArgs e)
        {
            var secondWindow = new Character();
            secondWindow.Show();
        }
    }
}
