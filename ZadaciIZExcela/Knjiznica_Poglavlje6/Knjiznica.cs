using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica_Poglavlje6
{
    class Knjiznica
    {
        public ClanoviRepozitorija ClanoviRepozitorija { get; set; } = new ClanoviRepozitorija();
        public Clan DodajClana(string ime, string prezime)
        {
            
            if (!ClanoviRepozitorija.Sadrzi(ime, prezime))
            {
                Clan clan = new Clan(ime, prezime);
                ClanoviRepozitorija.Spremi(clan);
                return clan;
            }
            else
            {
                return null;
            }
        }
    }
}
