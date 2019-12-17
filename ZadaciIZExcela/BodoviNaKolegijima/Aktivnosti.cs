using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodoviNaKolegijima
{
    class Aktivnosti
    {
        public string Naziv { get; set; }
        public int Bodovi { get; set; }
        public BodoviNaKolegiju ostvareniBodovi { get; set; }

        public Aktivnosti(string naziv, int bodovi)
        {
            Naziv = naziv;
            Bodovi = bodovi;
            ostvareniBodovi = new BodoviNaKolegiju(0); 
        }
        public override string ToString()
        {
            return Naziv; 
        }
    }
}
