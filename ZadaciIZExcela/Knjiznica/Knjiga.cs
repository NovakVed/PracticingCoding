using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica
{
    class Knjiga : IPretraga
    {
        public string Naziv { get; set; }
        public int Godina { get; set; }
        public int Izdanje { get; set; }
        public List<Autor> ListaAutora = new List<Autor>();

        public void DodajAutora(Autor autor)
        {
            this.ListaAutora.Add(autor);
        }

        public void UkloniAutora(Autor autor)
        {
            if (ListaAutora.Count != 0 && ListaAutora.Contains(autor))
            {
                ListaAutora.Remove(autor);
            }
        }

        public bool Usporedi(string kljucnaRijec)
        {
            if (Naziv.Contains(kljucnaRijec))
            {
                return true;
            }
            else
            {
                bool pronaden = false;
                foreach (var item in ListaAutora)
                {
                    if (item.Usporedi(kljucnaRijec))
                    {
                        pronaden = true;
                    }
                }
                return pronaden;
            }
        }

        public string Ispisi()
        {
            string ispis = Naziv + "\n";
            foreach (var item in ListaAutora)
            {
                ispis += item.Ispisi() + "\n";
            }
            return ispis;
        }
    }
}
