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

        public Nakladak()
        {
            Jmeno = " ";
            Spotreba = 5;
            naklad = 0;
            stav_paliva = 30;
            stav_Tachometru = 0;
            nosnost = 3000;


        }
        public void Natanokovat()
        {
            stav_paliva += 5;
            if (stav_paliva > 75)
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
            if (naklad > 3000)
            {
                naklad = 3000;
            }
        }
        public void Jet()
        {
            stav_paliva -= 5;
            stav_Tachometru += 50;
            if (stav_paliva < 0)
            {
                stav_Tachometru -=50 ;
                stav_paliva = 0;
                
                
            }
            if (stav_paliva > -1)
                stav_paliva = 0;



         
            if (naklad == 500)
            {
                stav_paliva -= 2;
            }
            else if (naklad == 1000)
            {
                stav_paliva -= 4;
            }
            else if (naklad == 1500)
            {
                stav_paliva -= 6;
            }
            else if (naklad == 2000)
            {
                stav_paliva -= 8;
            }
            else if (naklad == 2500)
            {
                stav_paliva -= 10;
            }
            else if (naklad == 3000)
            {
                stav_paliva -= 12;
            }



        }
        public void Vysipat()
        {
            naklad = 0;
        }
        

    }
}
