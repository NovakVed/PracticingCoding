using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodoviNaKolegiju
{
    class Predmet
    {
        public static List<Predmet> ListaPredmeta = new List<Predmet>();
        public List<Aktivnosti> ListaAktivnosti = new List<Aktivnosti>();
        public string Naziv { get; set; }
        public int UkupniBrojBodova { get; set; }
        public string Postotak { get; set; }
        public int OstvareniBrojBodova { get; set; }
        public Predmet(string naziv)
        {
            Naziv = naziv;
        }

        public int UkupniBrojBodovaAktivnosti()
        {
            int ukupniBrojBodova = 0;
            foreach (var item in ListaAktivnosti)
            {
                ukupniBrojBodova += item.Bodovi;
            }
            UkupniBrojBodova = ukupniBrojBodova;
            return ukupniBrojBodova;
        }

        public int OstvareniBrojBodovaAktivnosti()
        {
            int brojBodova = 0;
            foreach (var item in ListaAktivnosti)
            {
                brojBodova += item.OstvareniBodovi.Bodovi;
            }
            OstvareniBrojBodova = brojBodova;
            return brojBodova;
        }

        public double PostotakUspijeha()
        {
            double postotak = 0;
            OstvareniBrojBodova = this.OstvareniBrojBodovaAktivnosti();
            UkupniBrojBodova = this.UkupniBrojBodovaAktivnosti();
            foreach (var item in ListaAktivnosti)
            {
                postotak = OstvareniBrojBodova/UkupniBrojBodova;
            }
            return postotak;
        }

        public override string ToString()
        {
            return this.Naziv;
        }

        public void DodajAktivnost(Aktivnosti aktivnosti)
        {
            ListaAktivnosti.Add(aktivnosti);
        }

        public void AzurirajTablicu()
        {
            OstvareniBrojBodova = this.OstvareniBrojBodovaAktivnosti();
            UkupniBrojBodova = this.UkupniBrojBodovaAktivnosti();
            Postotak = (this.PostotakUspijeha()*100).ToString(".00%");
        }
    }
}
