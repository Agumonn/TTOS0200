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

namespace LAB11_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeGames();
        }
        private void InitializeGames()
        {
            pelibox.Items.Add(new Lotto());
            pelibox.Items.Add(new Vikinglotto());
            pelibox.Items.Add(new Eurojackpot());
        }
        private void draw_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                if (pelibox.SelectedIndex >= 0)
                {
                    Lottopeli game = (Lottopeli)pelibox.SelectedItem;
                    rivitblock.Text = "";
                    int number = int.Parse(kierrosbox.Text);
                    for (int x = 0; x < number; x++)
                    {
                        game.Generate();
                        rivitblock.Text += String.Format("Rivi {0}: ", x + 1) + game.LineToString() + "\n";
                        game.Numbers.Clear();
                    }
                }
            }
            catch (Exception)
            {
                rivitblock.Text += "Try again";
            }

        }

        private void clear_Click_1(object sender, RoutedEventArgs e)
        {
            rivitblock.Text = String.Empty;
            kierrosbox.Text = String.Empty;
            pelibox.SelectedIndex = -1;

        }
    }
}
