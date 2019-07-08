using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaposlenik_Rok2019_07_08
{
    class Zaposlenik
    {
        public string ImePrezime { get; set; }
        public List<double> MjesecnePlace { get; set; }
        public Zaposlenik(string imeprezime)
        {
            ImePrezime = imeprezime;
            MjesecnePlace = new List<double>();
        }
        public Zaposlenik(string imeprezime, double prvaPlaca)
        {
            ImePrezime = imeprezime;
            MjesecnePlace = new List<double>();
            DodajPlacu(prvaPlaca);
        }
        public void DodajPlacu(double placa)
        {
            MjesecnePlace.Add(placa);
        }
        public double IzracunajProsjecnuPlacu()
        {
            double prosjek = 0;
            foreach(double placa in MjesecnePlace)
            {
                prosjek += placa;
            }
            prosjek = prosjek / MjesecnePlace.Count();
            return prosjek;
        }
    }
}
