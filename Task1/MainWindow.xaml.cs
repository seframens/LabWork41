using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isMenuOpen = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            isMenuOpen = !isMenuOpen;

            DoubleAnimation menuAnimation = new()
            {
                From = menuStackPanel.ActualWidth,
                To = isMenuOpen ? 100 : 30,
                Duration = TimeSpan.FromSeconds(1)
            };

            menuStackPanel.BeginAnimation(StackPanel.WidthProperty, menuAnimation);
        }
    }
}