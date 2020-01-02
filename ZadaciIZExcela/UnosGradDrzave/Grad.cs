using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnosGradDrzave
{
    class Grad
    {
        public string Naziv { get; set; }
        public int BrojStanovnika { get; set; }
        public Grad(string naziv, int brojStanovnika)
        {
            Naziv = naziv;
            BrojStanovnika = brojStanovnika;
        }
    }
}
