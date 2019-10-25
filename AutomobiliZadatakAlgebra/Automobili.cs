using System;

namespace AutomobiliZadatakAlgebra
{
    internal class Automobili
    {
        public string Naziv { get; set; }
        public int GodinaProizvodnje { get; set; }
        public double OsnovnaCijena { get; set; }

        public int Starost()
        {
            return GodinaProizvodnje - DateTime.Now.Year;
        }

        public double UkupnaCijena()
        {
            if (OsnovnaCijena <= 70000)
            {
                return OsnovnaCijena * 1.3;
            }
            if (70000 < OsnovnaCijena && OsnovnaCijena < 100000)
            {
                return OsnovnaCijena * 1.4;
            }
            else
            {
                return OsnovnaCijena * 1.5;
            }
        }
    }
}