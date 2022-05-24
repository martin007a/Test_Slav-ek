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
        public int Stav_Tachometru { get => stav_Tachometru;}
        public int Nosnost { get => nosnost; }
       
        public Nakladak()
        {
            Jmeno = " ";
            Spotreba = 5 ;
            naklad = 0;
            stav_paliva = 30;
            stav_Tachometru = 0;
            nosnost = 3000;
            

        }
        public void Natanokovat()
        {
            stav_paliva += 5;
            if (stav_paliva > 50)
            {
                stav_paliva = 50;
            }

        }
        public void Nalozit()
        {
            naklad += 100;
            if (naklad > 3000)
            {
                naklad = 3000;
            }
        }
        public void Jet()
        {
            stav_paliva -= 5;
            stav_Tachometru = 0;
            if (stav_paliva < 0)
            {
                stav_paliva = 0;
            }
            else
            {
                stav_Tachometru = 50;

            }
           
            
        }
    }
}
