using System.Collections.Generic;

namespace _111Zadatak
{
    internal class Recenica
    {
        public string UnesenaRecenica { get; set; }
        public List<string> listaRecenice = new List<string>();

        public void UnesenaRecenia(string recenica)
        {
            UnesenaRecenica = recenica;
        }

        public bool Provjera(string recenica)
        {
            if (recenica.Equals(UnesenaRecenica))
            {
                return true;
            }
            return false;
        }
    }
}