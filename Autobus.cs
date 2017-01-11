using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Autobus:SrodekLokomocji
    {
        public Autobus() { }
        public Autobus(int IloscMiejsc) 
        {
            ObliczCene();
        }
        public override string ToString()
        {
            return "Autobus: ilosc miejsc: " + iloscMiejsc.ToString() + "CenaBiletu: " + cenaBiletu.ToString()+".\n";
        }
    }
}
