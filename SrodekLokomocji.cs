using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;
        public SrodekLokomocji() { }
        public virtual void ObliczCene()
        {
            cenaBiletu = DateTime.Today.Day;
        }
        public double zwracamCeneBiletu()
        {
            return cenaBiletu;
        }
    }
}
