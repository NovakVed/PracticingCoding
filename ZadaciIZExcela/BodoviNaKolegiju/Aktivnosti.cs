using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodoviNaKolegiju
{
    class Aktivnosti
    {
        public string NazivAktivnosti { get; set; }
        public int Bodovi { get; set; }
        public BodoviPoAktivnosti OstvareniBodovi { get; set; }
        public Aktivnosti(string nazivAktivnosti, int bodovi)
        {
            NazivAktivnosti = nazivAktivnosti;
            Bodovi = bodovi;
            OstvareniBodovi = new BodoviPoAktivnosti(0);
        }

        public override string ToString()
        {
            return this.NazivAktivnosti;
        }
    }
}
