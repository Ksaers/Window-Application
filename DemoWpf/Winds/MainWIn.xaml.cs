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
using System.Windows.Shapes;

namespace WpfApp1.Winds
{
    /// <summary>
    /// Логика взаимодействия для MainWIn.xaml
    /// </summary>
    public partial class MainWIn : Window
    {
        public MainWIn()
        {
            InitializeComponent();
        }
        private void Win1Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
        }

        private void Win2Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.ShowDialog();
        }

        private void Win3Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.ShowDialog();
        }

        private void Win4Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.ShowDialog();
        }

        private void Win5Click(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.ShowDialog();
        }
    }
}
