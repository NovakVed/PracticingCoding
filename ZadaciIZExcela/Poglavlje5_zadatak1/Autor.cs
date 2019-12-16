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
        public string Email { get; set; }
        public Autor(string ime, string prezime, string email)
        {
            Ime = ime;
            Prezime = prezime;
            Email = email;
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
