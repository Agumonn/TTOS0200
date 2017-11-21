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

namespace LAB11_1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            shoplisttxt.Text = "";

            if ((bool)milkbox.IsChecked)
            {
                shoplisttxt.Text = shoplisttxt.Text + " milk";
            }
            if ((bool)butterbox.IsChecked)
            {
                shoplisttxt.Text = shoplisttxt.Text + " butter";
            }
            if ((bool)beerbox.IsChecked)
            {
                shoplisttxt.Text = shoplisttxt.Text + " beer";
            }
            if ((bool)chickenbox.IsChecked)
            {
                shoplisttxt.Text = shoplisttxt.Text + " chicken";
            }
            if ((bool)lemonadebox.IsChecked)
            {
                shoplisttxt.Text = shoplisttxt.Text + " lemonade";
            }

        }
    
    }
}
