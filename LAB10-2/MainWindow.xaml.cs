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

namespace LAB10_2
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

        private void valuuttabox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
   

        }

        private void USD_Selected(object sender, RoutedEventArgs e)
        {
            double maara = double.Parse(valuutta.Text);
            double kerroin = 0.8997;
            double tulos = maara * kerroin;
            lopputulos.Text = tulos.ToString("0.00");

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            double maara = double.Parse(valuutta.Text);
            double kerroin = 1;
            double tulos = maara * kerroin;
            lopputulos.Text = tulos.ToString("0.00");

        }

        private void lopputulos_TextChanged(object sender, TextChangedEventArgs e)
        {
         
                double value = double.Parse(lopputulos.Text);
                double kerroin = 1.1115;
                double tulos = kerroin * value;
                valuutta.Text = tulos.ToString("0.00");
          
        }
        //private void valuutta_TextChanged(object sender, TextChangedEventArgs e)
        //{
          //  double value = double.Parse(valuutta.Text);
           // double kerroin = 1.1115;
            //double tulos = kerroin * value;
            //lopputulos.Text = tulos.ToString("0.00");
        //}
    }
}
