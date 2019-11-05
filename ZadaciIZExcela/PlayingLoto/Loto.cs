using System;
using System.Collections.Generic;

namespace PlayingLoto
{
    internal class Loto
    {
        public List<int> UneseniBrojevi { get; set; }
        public List<int> DobitniBrojevi { get; set; }

        public Loto()
        {
            UneseniBrojevi = new List<int>();
            DobitniBrojevi = new List<int>();
        }

        public void GenerirajDobitneBrojeve()
        {
            Random random = new Random();
            while (DobitniBrojevi.Count < 7)
            {
                int broj = random.Next(1, 39);
                if (!DobitniBrojevi.Contains(broj))
                {
                    DobitniBrojevi.Add(broj);
                }
            }
        }

        public void UnesenaListaBrojeva(List<int> listaBrojeva)
        {
            UneseniBrojevi = listaBrojeva; //pogreska! Pogledaj na pdf.u
        }

        public int IzracunajDobitneBrojeve(List<int> listaBrojeva)
        {
            int brojPogodenih = 0;
            foreach (var item in listaBrojeva)
            {
                if (DobitniBrojevi.Contains(item))
                {
                    brojPogodenih++;
                }
            }

            return brojPogodenih;
        }

        public void IzbrisiListu()
        {
            DobitniBrojevi.Clear();
        }
    }
}