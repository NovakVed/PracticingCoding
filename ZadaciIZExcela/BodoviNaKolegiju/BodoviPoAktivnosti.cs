using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodoviNaKolegiju
{
    public class BodoviPoAktivnosti
    {
        public int Bodovi { get; set; }
        public BodoviPoAktivnosti(int bodovi)
        {
            Bodovi = bodovi;
        }

        public override string ToString()
        {
            return this.Bodovi.ToString();
        }
    }
}
