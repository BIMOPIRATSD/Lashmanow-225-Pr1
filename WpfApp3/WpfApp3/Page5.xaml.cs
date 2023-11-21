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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(Text1.Text, out double A1))
            {

            }
            if(!double.TryParse(Text2.Text, out double B1))
            {

            }
            if(!double.TryParse(Text3.Text, out double C1))
            {

            }
            if(!double.TryParse(Text4.Text, out double A2))
            {

            }
            if(!double.TryParse(Text5.Text, out double B2))
            {

            }
            if(!double.TryParse(Text6.Text, out double C2))
            {

            }
            double D = A1 * B2 - A2 * B1;
            double x = (C1 * B2 - C2 * B1) / D;
            double y = (A1 * C2 - A2 * C1) / D;
            Text7.Text += $"x = {x}\ny = {y}";
        }
    }
}
