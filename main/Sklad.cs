using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Kebab_house
{
    class Sklad
    {
        private int Maso = 100;
        private int Zelenina = 100;
        private int Tortila = 100;
        private int BBQ = 100;
        private int Cesnekova_omacka = 100;


        

        public int KolikJeMasa()
        {
            return Maso;
        }
        public int KolikJeZeleniny()
        {
            return Zelenina;
        }
        public int KolikJeTortil()
        {
            return Tortila;
        }
        public int KolikJeBBQ()
        {
            return BBQ;
        }
        public int KolikJeomacky()
        {
            return Cesnekova_omacka;
        }


        public int VyberZeSkladuSurovin1() 
        {
            if (Maso > 0) {
                Maso -= 1;
                return Maso;
            }
            else {
                Console.WriteLine("Maso došlo");
                return 0;
            }
        }

        public int DoskladniSe()
        {
            return Maso = 100;
        }
    }
}
