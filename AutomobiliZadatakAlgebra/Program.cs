using System;
using System.Collections.Generic;

namespace AutomobiliZadatakAlgebra
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input;
            List<Automobili> listaAutomobila = new List<Automobili>();

            do
            {
                Console.WriteLine("--- MENI ---");
                Console.WriteLine("1. UNOS AUTOMOBILA");
                Console.WriteLine("2. IMPLEMENTACIJA DOGAĐAJA NaPromijenuGodineProizvodnje");
                Console.WriteLine("3. ISPIS UNEŠENOG AUTOMOBILA");
                Console.WriteLine("0. KRAJ");
                Console.Write("\nODABERI: ");
                input = int.Parse(Console.ReadLine());
                Console.WriteLine("\n--------------------------------\n");
                switch (input)
                {
                    case 1:
                        Automobili auto = new Automobili();
                        Console.Write("Unesite naziv auta: ");
                        auto.Naziv = Console.ReadLine();
                        Console.Write("Unesite godinu proizvodnje auta: ");
                        auto.GodinaProizvodnje = int.Parse(Console.ReadLine());
                        Console.Write("Unesite osnovnu cijenu auta: ");
                        auto.OsnovnaCijena = double.Parse(Console.ReadLine());
                        listaAutomobila.Add(auto);
                        break;

                    case 2:
                        //EVENT HANDLER
                        break;

                    case 3:
                        Console.WriteLine("--- ISPIS AUTOMOBILA ---\n");
                        foreach (Automobili item in listaAutomobila)
                        {
                            Console.WriteLine(item.Naziv);
                            Console.WriteLine(item.GodinaProizvodnje);
                            Console.WriteLine(item.UkupnaCijena());
                        }
                        break;

                    case 0:
                        Console.WriteLine("KRAJ!");
                        break;

                    default:
                        break;
                }
            } while (input != 0);

            Console.ReadLine();
        }
    }
}