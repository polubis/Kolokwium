using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Podroz:IData,IZarzadzaj
    {
        private DateTime DataPodrozy;
        private List<SrodekLokomocji> planPodrozy;
        private double Koszt = 0;
        public Podroz() 
        {
            planPodrozy = new List<SrodekLokomocji>();
        }
        public void DodajAutobus(int iloscMiejsc)
        {
            Autobus NowyAutobus=new Autobus();
            planPodrozy.Add(new Autobus(iloscMiejsc));
            Koszt = Koszt+NowyAutobus.zwracamCeneBiletu();
        }
        public void DodajPociag(int iloscMiejsc, int dlugoscTrasy)
        {
            Pociag NowyPociag = new Pociag();
            planPodrozy.Add(new Pociag(iloscMiejsc, dlugoscTrasy));
            Koszt =Koszt+ NowyPociag.zwracamCeneBiletu();
        }
        public void UsunOstatni()
        {
            int rozmiar = planPodrozy.Count;
            if(planPodrozy.Count>0)
            {
                planPodrozy.RemoveAt(rozmiar - 1);
            }
            
        }
        public void Wyczysc()
        {
            planPodrozy.Clear();
        }
        public void UstawDate(DateTime Data)
        {
            DataPodrozy = Data;
        }
        public bool SprawdzDate()
        {
            if (DataPodrozy > DateTime.Today)
            {
                return true;
            }
            else
                return false;
        }
        public override string ToString()
        {
            string Text = "";
            if (planPodrozy.Count >= 0)
            {
                foreach (var element in planPodrozy)
                {
                    Text += element.ToString();
                }
                return "Podroz:\n"+Text+"Koszt: :"+Koszt.ToString();
            }
            else
            {
                return "";
            }
        }

    }
}
