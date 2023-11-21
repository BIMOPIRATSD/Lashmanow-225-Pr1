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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!double.TryParse(Text1.Text, out double a))
            {

            }
            if(!double.TryParse(Text2.Text, out double b))
            {

            }
            if (!double.TryParse(Text3.Text, out double c))
            {

            }
            double newA, newB, newC;
            newA = c;
            newB = a;
            newC = b;
            Text4.Text = $"A = {newA}\nB = {newB}\nC = {newC}";
        }
    }
}
