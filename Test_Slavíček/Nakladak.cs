using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Slavíček
{
    
    public class Nakladak
    {
        
        private int naklad;
        private int stav_paliva;
        private int stav_Tachometru;
        private int nosnost;
        
        public string Jmeno { get; set; }
        public int Spotreba { get; set; }
        public int Naklad { get => naklad; }
        public int Stav_Paliva { get => stav_paliva; }
        public int Stav_Tachometru { get => stav_Tachometru; }
        public int Nosnost { get => nosnost; }
        public int Objem_Nadrze { get; set; }   
        
        public Nakladak()
        {
            Jmeno = " ";
            Spotreba = 5; //100Km
            naklad = 0;
            stav_paliva = 30;
            stav_Tachometru = 0;
            nosnost = 3000;
            Objem_Nadrze = 75;
           
        }
       
        public void Natanokovat()
        {
            stav_paliva += 15;
            if (stav_paliva > Objem_Nadrze )
            {
                stav_paliva = 75;
            }
            if (stav_paliva < 0)
            {
                stav_paliva = 0;
            }

        }
        public void Nalozit()
        {
            naklad += 500;
            if (naklad > nosnost)
            {
                naklad = 3000;
            }
        }
        public void Jet()
        {
            stav_paliva -= Spotreba + (naklad / 500);
            stav_Tachometru += 100;
            if (stav_paliva < 0)
            {
                stav_paliva = 0;
                stav_Tachometru -= 100;
            }
          
          
          


        }

        public void Vysypat()
        {
            naklad = 0;
        }
        

    }
    
    

    
}
