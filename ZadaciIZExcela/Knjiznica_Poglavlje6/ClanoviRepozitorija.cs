using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica_Poglavlje6
{
    class ClanoviRepozitorija
    {

        public List<Clan> ListaClanova = new List<Clan>();

        public bool Sadrzi(string ime, string prezime)
        {
            return ListaClanova.Exists(c => c.Ime == ime && c.Prezime == prezime);
        }

        public void Spremi(Clan clan)
        {
            clan.KorisnickoIme = GenerirajKorisnickoIme(clan);
            clan.KorisnickaLozinka = GenerirajLozinku();
            ListaClanova.Add(clan);
        }

        public string GenerirajKorisnickoIme(Clan clan)
        {
            string korisnickoIme = clan.Ime + clan.Prezime;
            return korisnickoIme;
        }

        public string GenerirajLozinku()
        {
            Random random = new Random();
            string korisnickaLozinka = random.Next(1000, 9999).ToString();
            return korisnickaLozinka;
        }
    }
}
