using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stänghantering___Övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string lösenord = "DAVE";
            int antalgissningar = 1;
            string gissning = "";
            
            Console.WriteLine("Gissa lösenordet");
            while (true)
            {
                var gurka = Console.ReadKey(true);
                if (gurka.Key == ConsoleKey.Enter)
                {
                    if (gissning == lösenord)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Du skrev rätt lösneord på {antalgissningar} gissningar!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("du skrev in fel lösenord " + gissning);
                        gissning = "";
                    }
                }
                else if (gurka.Key == ConsoleKey.Backspace)
                {
                    Console.WriteLine();
                    Console.WriteLine("det går inte att ta bort saker");
                }
                else if (gurka.Key != ConsoleKey.Enter || gurka.Key != ConsoleKey.Backspace)
                {
                    gissning += gurka.Key;
                    Console.Write("*");
                }
                

            }
        }
    }
}
