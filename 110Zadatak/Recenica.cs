using System;
using System.Linq;
using System.Windows.Forms;

namespace _110Zadatak
{
    internal class Recenica
    {
        public string Rijec { get; set; }

        public Recenica(string rijec)
        {
            Rijec = rijec;
        }

        public string MakniRazmak()
        {
            string r = Rijec.Replace(" ", "");
            return r;
        }

        public int BrojSlova()
        {
            return MakniRazmak().Length;
        }

        public char NajcesceSlovo()
        {
            try
            {
                char slovo = MakniRazmak().GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
                return slovo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upozorenje!");
                return ' ';
            }
        }

        public char NajrijedeSlovo()
        {
            try
            {
                char slovo = MakniRazmak().GroupBy(x => x).OrderByDescending(x => x.Count()).Last().Key;
                return slovo;
            }
            catch (Exception)
            {
                return ' ';
            }
        }
    }
}