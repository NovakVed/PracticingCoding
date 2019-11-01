using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _112Zadatak
{
    class Text
    {
        public string InputedWord { get; set; }
        public List<string> words = new List<string>();

        public Text(string text)
        {
            InputedWord = text;
        }
    }
}
