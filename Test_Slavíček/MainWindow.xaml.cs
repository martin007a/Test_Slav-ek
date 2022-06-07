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

        public MainWindow()
        {
            InitializeComponent();
            Tatra = new Nakladak();
            Tatra.Jmeno = "tatra_Pavel";
            Zobraz(Tatra, txtbox1);
            
            InitializeComponent();
            Tatra = new Nakladak();
            Tatra.Jmeno = "tara_ René";
            Zobraz(Tatra, txtbox2);

            
        }
        public void Zobraz(Nakladak nakladak, TextBox textBox)
        {
            textBox.Text = "Jmeno: " + nakladak.Jmeno.ToString() + "\n";
            textBox.Text += "Spotřeba: " + nakladak.Spotreba.ToString() + "\n";
            textBox.Text += "Stav Tachometru: " + nakladak.Stav_Tachometru.ToString() + ("\n");
            textBox.Text += "Naklad: " + nakladak.Naklad.ToString() + "\n";
            textBox.Text += "Stav Paliva: " + nakladak.Stav_Paliva.ToString() + ("\n");
            textBox.Text += "Nosnost: " + nakladak.Nosnost.ToString() + "\n";


        }

        private void btn_Tankovat_Click(object sender, RoutedEventArgs e)
        {
            Tatra.Natanokovat();
            Zobraz (Tatra, txtbox1);
        }

        private void btn_Naložit_Click(object sender, RoutedEventArgs e)
        {
            Tatra.Nalozit();
            Zobraz (Tatra, txtbox1);
        }

        private void btn_Jet_Click(object sender, RoutedEventArgs e)
        {
            Tatra.Jet();
            Zobraz(Tatra, txtbox1);
        }

        private void btn_Vysipat_Click(object sender, RoutedEventArgs e)
        {
            Tatra.Vysypat();
            Zobraz(Tatra,txtbox1);
        }
    }

}
