using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica
{
    class Autor : IPretraga
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        private string Email;

        public Autor(string ime, string prezime, string email)
        {
            Ime = ime;
            Prezime = prezime;
            Email = email;
        }

        public string Ispisi()
        {
            return "Autor: " + Ime + " " + Prezime + ", Email:  " + Email; 
        }

        public bool Usporedi(string kljucnaRijec)
        {

        }
    }
}
