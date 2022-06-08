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

namespace Test_Slavíček
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nakladak Tatra;
        Nakladak MAN;

        public MainWindow()
        {
            InitializeComponent();
            Tatra = new Nakladak();
            Tatra.Jmeno = "Tatra";          
            Zobraz(Tatra, txtbox1);

            MAN = new Nakladak();
            MAN.Jmeno = "MAN";
            Zobraz(MAN, txtbox2);
        }
        public void Zobraz(Nakladak nakladak, TextBox textBox)
        {
            textBox.Text = "Jmeno: " + nakladak.Jmeno.ToString() + "\n";
            textBox.Text += "Spotřeba: " + nakladak.Spotreba.ToString() + "\n";
            textBox.Text += "Stav Tachometru: " + nakladak.Stav_tachometru.ToString() + ("\n");
            textBox.Text += "Naklad: " + nakladak.Naklad.ToString() + "\n";
            textBox.Text += "Stav Paliva: " + nakladak.Stav_Paliva.ToString() + ("\n");
            textBox.Text += "Nosnost: " + nakladak.Nosnost.ToString() + "\n";


        }


     

        private void btn_Jet_1_Click(object sender, RoutedEventArgs e)
        {

            Tatra.Jet();
            Zobraz(Tatra, txtbox1);
        }

        private void btn_Naložit_1_Click(object sender, RoutedEventArgs e)
        {
            Tatra.Nalozit();
            Zobraz(Tatra, txtbox1);
        }

        private void btn_Tankovat_1_Click(object sender, RoutedEventArgs e)
        {
            Tatra.Natanokovat();
            Zobraz(Tatra, txtbox1);
        }

        private void btn_Vysipat_1_Click(object sender, RoutedEventArgs e)
        {
            Tatra.Vysypat();
            Zobraz(Tatra, txtbox1);
        }

        private void btnJet_2_Click(object sender, RoutedEventArgs e)
        {
            MAN.Jet();
            Zobraz(MAN, txtbox2);
        }

        private void btn_Natankovat_2_Click(object sender, RoutedEventArgs e)
        {
            MAN.Natanokovat();
            Zobraz(MAN, txtbox2);
        }

        private void btn_Nalozit_2_Click(object sender, RoutedEventArgs e)
        {
            MAN.Nalozit();
            Zobraz(MAN, txtbox2);
        }

        private void btn_Vysipat_2_Click(object sender, RoutedEventArgs e)
        {
            MAN.Vysypat();
            Zobraz(MAN, txtbox2);
        }
    }

}
