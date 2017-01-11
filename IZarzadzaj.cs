using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    interface IZarzadzaj
    {
        void DodajAutobus(int iloscMiejsc);
        void DodajPociag(int iloscMiejsc, int dlugoscTrasy);
        void UsunOstatni();
        void Wyczysc();
    }
}
