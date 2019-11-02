using System;

namespace _112Zadatak
{
    internal class Text
    {
        public string InputedWord { get; set; }

        public void InputedText(string text)
        {
            InputedWord = text;
        }

        public string ReverseOrder()
        {
            char[] charArray = InputedWord.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string NumberOfChar()
        {
            char[] charArray = InputedWord.ToCharArray();
            return charArray.Length.ToString();
        }

        public string NumberOfInputedChar(char c)
        {
            char[] charArray = InputedWord.ToCharArray();
            int counter = 0;
            if (c.Equals(""))
            {
                return counter.ToString();
            }
            else
            {
                foreach (var item in charArray)
                {
                    if (item.Equals(c))
                    {
                        counter++;
                    }
                }
                return counter.ToString();
            }
        }
    }
}