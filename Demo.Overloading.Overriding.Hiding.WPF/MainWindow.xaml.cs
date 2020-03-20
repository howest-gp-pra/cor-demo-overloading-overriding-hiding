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
using Demo.Overloading.Overriding.Hiding.LIB;

namespace Demo.Overloading.Overriding.Hiding.WPF
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

        private void btnGEW_Click(object sender, RoutedEventArgs e)
        {
            // alle oproepen van de methode Test geven hetzelfde resultaat
            // GewOvB erft over van GewOvA en wijzigt niets aan de originele methode Test
            // GewOvC erft over van GewOvB en wijzigt eveneens niets

            tbkInfo.Text = "";
            GewOvA a = new GewOvA();
            tbkInfo.Text += a.Test();

            GewOvB b = new GewOvB();
            tbkInfo.Text += b.Test();

            GewOvC c = new GewOvC();
            tbkInfo.Text += c.Test();
        }

        private void btnHiding_Click(object sender, RoutedEventArgs e)
        {
            tbkInfo.Text = "";

            HIDA a = new HIDA();
            tbkInfo.Text += a.Test();
            HIDB b = new HIDB();
            tbkInfo.Text += b.Test();
            HIDC c = new HIDC();
            tbkInfo.Text += c.Test();

            // hieronder gebeurt het onverwachte ...
            a = new HIDB();
            tbkInfo.Text += a.Test();

            b = new HIDC();
            tbkInfo.Text += b.Test();

        }

        private void btnOverridingV1_Click(object sender, RoutedEventArgs e)
        {
            tbkInfo.Text = "";

            OverrA a = new OverrA();
            tbkInfo.Text += a.Test();

            OverrB b = new OverrB();
            tbkInfo.Text += b.Test();

            OverrC c = new OverrC();
            tbkInfo.Text += c.Test();

            // onderstaande zal je waarschijnlijk wel verwachten ...
            a = new OverrB();
            tbkInfo.Text += a.Test();

            b = new OverrC();
            tbkInfo.Text += b.Test();
        }

        private void btnOverridingV2_Click(object sender, RoutedEventArgs e)
        {
            tbkInfo.Text = "";

            MixA a = new MixA();
            tbkInfo.Text += a.Test();

            MixB b = new MixB();
            tbkInfo.Text += b.Test();

            MixC c = new MixC();
            tbkInfo.Text += c.Test();

            // opnieuw misschien verassen dit 
            a = new MixB();
            tbkInfo.Text += a.Test();

            // dit gedraagt zich waarschijnlijk zoals je het zou verwachten
            b = new MixC();
            tbkInfo.Text += b.Test();

        }
    }
}
