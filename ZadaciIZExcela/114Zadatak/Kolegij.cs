using System.Collections.Generic;

namespace _114Zadatak
{
    internal class Kolegij
    {
        public string NazivKolegija { get; set; }
        public int OcijenaKolegija { get; set; }

        public List<Kolegij> listaKolegija = new List<Kolegij>();

        public Kolegij(string naziv, string ocijena)
        {
            NazivKolegija = naziv;
            OcijenaKolegija = int.Parse(ocijena);
        }
    }
}