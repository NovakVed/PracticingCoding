using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poglavlje5_zadatak1
{
    public interface IPretraga
    {
        bool Usporedi(string kljucnaRijec);

        string Ispis();
    }
}
