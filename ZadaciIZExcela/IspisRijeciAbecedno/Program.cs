using System;
using System.Collections.Generic;

namespace IspisRijeciAbecedno
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = "";
            List<string> listaRijeci = new List<string>();

            Console.WriteLine("Unesite riječ po riječ sve dok ne unesete riječ 'kraj'");
            do
            {
                input = Console.ReadLine();
                listaRijeci.Add(input.ToLower()); //ovdje ti se unosi svaki unos u listu
            } while (!input.Equals("kraj")); //ako je input jedank 'kraj' program se završava

            Console.WriteLine("Riječi koje započinju sa 'A':");
            foreach (var item in listaRijeci)
            {
                if (item.StartsWith("a"))
                {
                    Console.WriteLine("\t\t\t\t" + item);
                }
            }

            Console.WriteLine("Riječi koje započinju sa 'B':");
            foreach (var item in listaRijeci)
            {
                if (item.StartsWith("b"))
                {
                    Console.WriteLine("\t\t\t\t" + item);
                }
            }

            Console.WriteLine("Riječi koje započinju sa 'C':");
            foreach (var item in listaRijeci)
            {
                if (item.StartsWith("c"))
                {
                    Console.WriteLine("\t\t\t\t" + item);
                }
            }

            Console.WriteLine("Ostale riječi: ");
            foreach (var item in listaRijeci)
            {
                if (!item.StartsWith("a") && !item.StartsWith("b") && !item.StartsWith("c") && !item.Equals("kraj"))
                {
                    Console.WriteLine("\t\t\t\t" + item);
                }
            }

            Console.ReadLine();
        }
    }
}