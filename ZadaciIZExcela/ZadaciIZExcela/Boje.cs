using System.Collections.Generic;

namespace ZadaciIZExcela
{
    internal class Boje
    {
        public string Boja { get; set; }
        static public List<string> ListaBoja = new List<string>();

        public Boje(string boja)
        {
            Boja = boja;
            ListaBoja.Add(Boja);
        }
    }
}