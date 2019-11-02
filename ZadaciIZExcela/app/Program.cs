using System;
using System.Collections.Generic;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = "";
            List<string> listaRijeci = new List<string>();

            Console.WriteLine("Unesite recenicu: ");
            input = Console.ReadLine();

            var word = input.Split(' ');
            foreach (var item in word)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}