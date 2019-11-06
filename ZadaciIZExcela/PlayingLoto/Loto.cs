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

        public bool UnesenaListaBrojeva(List<string> listaBrojeva)
        {
            bool ispravni = false;
            int broj = 0;
            foreach (var item in listaBrojeva)
            {
                if (int.TryParse(item, out broj) == true)
                {
                    if (broj > 0 && broj < 40)
                    {
                        if (UneseniBrojevi.Contains(broj) == false)
                        {
                            UneseniBrojevi.Add(broj);
                        }
                    }
                }
            }
            if (UneseniBrojevi.Count == 7)
            {
                ispravni = true;
            }
            return ispravni;
        }

        public int IzracunajDobitneBrojeve()
        {
            int brojPogodenih = 0;
            foreach (var item in UneseniBrojevi)
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