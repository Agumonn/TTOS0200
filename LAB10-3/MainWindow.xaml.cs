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

namespace LAB10_3
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

        private void laske_Click(object sender, RoutedEventArgs e)
        {
            int korkeus = int.Parse(korkeusbox.Text);
            int leveys = int.Parse(leveysbox.Text);
            int karmi = int.Parse(karmibox.Text);
          
            int ikkunapa = korkeus * leveys;
            int karmipiiri = 2 * korkeus + 2 * leveys;
            int lasinpa = (korkeus - (2 * karmi)) * (leveys - (2 * karmi));
            ikkunapa = ikkunapa / 10;
            lasinpa = lasinpa / 10;

            
            ikkunapabox.Text = ikkunapa.ToString() + " cm^2";
            lasinpabox.Text = lasinpa.ToString() + " cm^2" ;
            karmipiiribox.Text = karmipiiri.ToString();
        }
    }
}
