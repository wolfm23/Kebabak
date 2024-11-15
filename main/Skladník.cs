using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab_house
{
    class Skladník
    {
        private Sklad sklad;  // Odkaz na objekt Sklad

        public Skladník(Sklad sklad)
        {
            this.sklad = sklad;
        }

        public int DoskladniMaso()
        {
            if (sklad.KolikJeMasa() > 1)
            {
                return 0;
            }
            else
            {
                return sklad.DoskladniSe();
            }


        }
    }
}

