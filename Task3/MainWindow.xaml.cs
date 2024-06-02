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

namespace Task3
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
            Storyboard buttonStoryBoard = new();

            DoubleAnimation fontSizeAnimation = new()
            {
                From = button.FontSize,
                To = 32,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true,
                RepeatBehavior = new(2)
            };
            Storyboard.SetTargetProperty(fontSizeAnimation, new(Button.FontSizeProperty));

            DoubleAnimation buttonHeightAnimation = new() 
            {
                From = button. Height,
                To = button.Height * 2,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true,
                RepeatBehavior = new(2)
            };
            Storyboard.SetTargetProperty(buttonHeightAnimation, new(Button.HeightProperty));

            DoubleAnimation buttonWidthAnimation = new()
            {
                From = button.Width,
                To = button.Width * 2,
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true,
                RepeatBehavior = new(2)
            };
            Storyboard.SetTargetProperty(buttonWidthAnimation, new(Button.WidthProperty));

            buttonStoryBoard.Children.Add(fontSizeAnimation);
            buttonStoryBoard.Children.Add(buttonHeightAnimation);
            buttonStoryBoard.Children.Add(buttonWidthAnimation);

            buttonStoryBoard.Begin(button);
        }
    }
}