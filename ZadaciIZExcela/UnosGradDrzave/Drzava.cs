using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnosGradDrzave
{
    class Drzava
    {
        public string Naziv { get; set; }

        public static List<Drzava> ListaDrzava = new List<Drzava>();
        public List<Grad> ListaGradova = new List<Grad>();

        public Drzava(string naziv)
        {
            Naziv = naziv;
            ListaDrzava.Add(this);
        }

        public void DodajGrad(Grad grad)
        {
            ListaGradova.Add(grad);
        }
    }
}
