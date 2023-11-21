using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Math;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!double.TryParse(Text1.Text, out double a))
            {

            }
            if(!double.TryParse(Text2.Text, out double x))
            {

            }
            if(!double.TryParse(Text3.Text, out double w))
            {

            }
            if(!double.TryParse(Text4.Text, out double t))
            {

            }
            if(!double.TryParse(Text5.Text, out double c))
            {

            }
            double g = c + 24.8;
            double y = (Pow(x, 5) * Pow(Sqrt(a * x + Sqrt(Abs(a + x))), 1.0 / 3) / 4 * Pow(Cos(a * x), 2) + Pow(g, x) + w * t);
            Text6.Text += y;
        }
    }
}
