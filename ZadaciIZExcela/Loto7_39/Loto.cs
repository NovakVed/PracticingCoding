using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loto7_39
{
    class Loto
    {
        public List<int> ListaUplacenihBrojeva { get; set; }
        public List<int> ListaDobivenihBrojeva { get; set; }
        public Loto()
        {
            ListaUplacenihBrojeva = new List<int>();
            ListaDobivenihBrojeva = new List<int>();
        }

        public bool UnesiUplaceneBrojeve(List<string> ListaKorisnickihVrijednosti)
        {
            bool ispravno = false;
            foreach (var item in ListaKorisnickihVrijednosti)
            {
                int broj = 0;
                if (int.TryParse(item, out broj) == true)
                {
                    if (broj > 0 && broj < 40)
                    {
                        ListaUplacenihBrojeva.Add(broj);
                    }
                }
            }

            if (ListaUplacenihBrojeva.Count == 7)
            {
                ispravno = true;
            }

            return ispravno;
        }

        public void GenerirajDobiveneBrojeve()
        {
            ListaDobivenihBrojeva.Clear();

            Random random = new Random();
            while (ListaDobivenihBrojeva.Count < 7)
            {
                int broj = random.Next(1, 39);
                if (ListaDobivenihBrojeva.Contains(broj) == false)
                {
                    ListaDobivenihBrojeva.Add(broj);
                }
            }
        }

        public int ProvjeraDobivenihBrojeva()
        {
            int brojPogodaka = 0;
            foreach (var item in ListaUplacenihBrojeva)
            {
                if (ListaDobivenihBrojeva.Contains(item))
                {
                    brojPogodaka += 1;
                }
            }
            return brojPogodaka;
        }
    }
}
