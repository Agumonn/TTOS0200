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

namespace autotalli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Auto> autot;//käytettävissä kaikissa luokan metodeissa ja tapahtumakäsittelijöissä
        private const string polku = @"D:\K8522\kuva\";
        public MainWindow()
        {
            //tänne koodi joka suoritetaan ikkunan avauksen luonnissa
            InitializeComponent();
            //pyydetään BL kerrokselta autot ja näytetään ne käyttäjälle
            autot = Autotalli.HaeAutot();
            NaytaKuva("autotalli.png");
            //ajetaan comboboxiin kaikki automerkit
            //VE 1 käsintehty
            List<string> merkit = new List<string>();
            merkit.Add("Audi");
            merkit.Add("Saab");
            merkit.Add("Volvo");
            cmbAutot.ItemsSource = merkit;
            //VE2 kysytään LINQ:lla datasta eri merkit
            var result = autot.Select(m => m.Merkki.ToString());
            cmbAutot.ItemsSource = result;
        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            dgAutot.ItemsSource = autot;
        }

        private void btnHaeAudit_Click(object sender, RoutedEventArgs e)
        {
            var result = autot.Where(m => m.Merkki.Contains("Audi"));
            dgAutot.ItemsSource = result;
        }
        private void NaytaKuva(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                url = "puuttuu.png";
            }
            url = polku + url;
            BitmapImage pic = new BitmapImage();
            pic.BeginInit();
            pic.UriSource = new Uri(url);
            pic.EndInit();
            imgAuto.Source = pic;
        }

        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //huom olemme itse populoineet satagridin auto-oliolla joten kukin datagridin jäsen/alkio on itseasiassa auto-olio
            object obj = dgAutot.SelectedItem;
            if (obj != null)
            {
                Auto valittu = (Auto)obj;
                NaytaKuva(valittu.URL);
            }
        }

        private void cmbAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //suodatetaan datagridiin näkyviin vain valittu automerkki
            string merkki = cmbAutot.SelectedValue.ToString();
            var result = autot.Where(m => m.Merkki.Contains(merkki));
            dgAutot.ItemsSource = result;
        }
    }
}
