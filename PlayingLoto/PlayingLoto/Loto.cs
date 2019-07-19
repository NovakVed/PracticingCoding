﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingLoto
{
    class Loto
    {
        public List<int> UplaceniBrojevi { get; set; }
        public List<int> DobitniBrojevi { get; set; }

        public Loto()
        {
            UplaceniBrojevi = new List<int>();
            DobitniBrojevi = new List<int>();
        }

        public bool UnesiUplaceneBrojeve(List<string> korisnickeVrijednosti)
        {
            bool ispravni = false;
            UplaceniBrojevi.Clear();
            foreach (string item in korisnickeVrijednosti)
            {
                int broj = 0;
                if (int.TryParse(item, out broj))
                {
                    if (broj >= 1 && broj <= 39)
                    {
                        if (UplaceniBrojevi.Contains(broj) == false)
                        {
                            UplaceniBrojevi.Add(broj);
                        }
                    }
                }
            }
            if (UplaceniBrojevi.Count == 7)
            {
                ispravni = true;   
            }

            return ispravni;
        }

        public void GenerirajDobitneBrojeve()
        {
            DobitniBrojevi.Clear();
            Random random = new Random();
            while (DobitniBrojevi.Count < 7)
            {
                int broj = random.Next(1, 39);
                if (DobitniBrojevi.Contains(broj) == false)
                {
                    DobitniBrojevi.Add(broj);
                }
            }
        }

        public int UsporediBrojeve()
        {
            int brojPogodataka = 0;
            foreach (var item in UplaceniBrojevi)
            {
                if (DobitniBrojevi.Contains(item) == true)
                {
                    brojPogodataka++;
                }
            }
            return brojPogodataka;
        }
    }
}
