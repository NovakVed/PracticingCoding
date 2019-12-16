using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poglavlje5_zadatak1
{
    class Knjiga : IPretraga
    {
        public string Naziv { get; set; }
        public int Godina { get; set; }
        public int Izdanje { get; set; }
        public List<IPretraga> Autori = new List<IPretraga>();

        public string Ispisi()
        {
            string ispis = Naziv + "\n";
            foreach (IPretraga autor in Autori)
            {
                ispis += autor.Ispisi() + "\n";
            }
            return ispis;
        }

        public bool Usporedi(string kljucnaRijec)
        {
            if (Naziv.Contains(kljucnaRijec))
            {
                return true;
            }
            else
            {
                foreach (IPretraga autor in Autori)
                {
                    if (autor.Usporedi(kljucnaRijec))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public void DodajAutora(Autor autor)
        {
            Autori.Add(autor);
        }
        
        public void UkloniAutora(Autor autor)
        {
            if (Autori.Count != 0 && Autori.Contains(autor))
            {
                Autori.Remove(autor);
            }
        }
    }
}
