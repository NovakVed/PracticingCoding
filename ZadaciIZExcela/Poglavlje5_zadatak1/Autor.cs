using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poglavlje5_zadatak1
{
    class Autor : IPretraga
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Autor(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        public string Ispisi()
        {
            return Ime + " " + Prezime;
        }
        public bool Usporedi(string kljucnaRijec)
        {
            return Ispisi().Contains(kljucnaRijec);
        }
    }
}
