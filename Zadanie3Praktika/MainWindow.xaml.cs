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

namespace Zadanie3Praktika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bSum_Click(object sender, RoutedEventArgs e)
        {
            Class1 p = new Class1();
            p.ch1 = Convert.ToDouble(txtB1.Text);
            p.ch2 = Convert.ToDouble(txtB2.Text);
            lAnsw.Content = Convert.ToString(p.ch1 + p.ch2);
        }

        private void bNaib_Click(object sender, RoutedEventArgs e)
        {
            Class1 p = new Class1();
            p.ch1 = Convert.ToDouble(txtB1.Text);
            p.ch2 = Convert.ToDouble(txtB2.Text);
            if (p.ch1 > p.ch2)
            {
                lNaib.Content = Convert.ToString(p.ch1);
            }
            else
            {
                lNaib.Content = Convert.ToString(p.ch2);
            }
        }

        private void bClear_Click(object sender, RoutedEventArgs e)
        {
            txtB1.Text = "";
            txtB2.Text = "";
            lNaib.Content = "";
            lAnsw.Content = "";
        }
    }
}
