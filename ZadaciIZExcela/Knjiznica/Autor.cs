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
            return ToString(); 
        }

        public bool Usporedi(string kljucnaRijec)
        {
            return Ispisi().Contains(kljucnaRijec);
        }

        public override string ToString()
        {
            return String.Format("Ime: {0}  Prezime: {1} Email: {2}", this.Ime, this.Prezime, this.Email);
        }
    }
}
