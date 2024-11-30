using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace guitest
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

        void Calc(object sender, RoutedEventArgs e)
        {
            if (add.IsChecked == true)
            {
                output.Content = Convert.ToInt32(input1.Text) + Convert.ToInt32(input2.Text);
            }
            else if (sub.IsChecked == true)
            {
                output.Content = Convert.ToInt32(input1.Text) - Convert.ToInt32(input2.Text);
            }
            else if (mul.IsChecked == true)
            {
                output.Content = Convert.ToInt32(input1.Text) * Convert.ToInt32(input2.Text);
            }
            else if (div.IsChecked == true)
            {
                output.Content = Convert.ToInt32(input1.Text) / Convert.ToInt32(input2.Text);
            }
        }
    }
}