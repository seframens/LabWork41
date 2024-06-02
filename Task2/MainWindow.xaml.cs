using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task2
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            DoubleAnimation fontSizeAnimation = new()
            {
                From = button.FontSize,
                To = 32,
                Duration = TimeSpan.FromSeconds(1),
                RepeatBehavior = new(2),
                AutoReverse = true,
            };

            button.BeginAnimation(FontSizeProperty, fontSizeAnimation);
        }
    }
}