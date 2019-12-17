using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodoviNaKolegijima
{
    class Predmeti
    {
        public static List<Predmeti> ListaPredmeta = new List<Predmeti>();

        public string Naziv { get; set; }
        public List<Aktivnosti> ListaAktivnosti = new List<Aktivnosti>();

        public int UkupniBodovi()
        {
            return ListaAktivnosti.Sum(a => a.Bodovi);
        }

        public int OstvareniBodovi()
        {
            return ListaAktivnosti.Sum(a => a.ostvareniBodovi.Bodovi);
        }

        public string Postotak()
        {
            return (OstvareniBodovi() / UkupniBodovi()).ToString();
        }

        public Predmeti(string naziv)
        {
            Naziv = naziv;
            ListaPredmeta.Add(this);
        }

        public override string ToString()
        {
            return Naziv;
        }

        public void DodajAktivnost(Aktivnosti aktivnost)
        {
            ListaAktivnosti.Add(aktivnost);
        }
    }
}
