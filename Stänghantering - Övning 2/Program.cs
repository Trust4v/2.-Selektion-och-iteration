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
            Console.Write("Skriv in vad lösenordet ska vara: ");
            string lösenord = Console.ReadLine();
            int antalgissningar = 0;
            Console.WriteLine("Gissa lösenordet");
            while (true)
            {

                string gissning = Console.ReadLine();
                antalgissningar++;
                if (gissning == lösenord)
                {
                    Console.WriteLine($"Du skrev rätt lösneord på {antalgissningar} gissningar!");
                    break;
                }
                else if (gissning.ToUpper() == lösenord.ToUpper()) Console.WriteLine("Rätt lösenord, men se över gemener och versaler.Försök igen.");
                
                else Console.WriteLine($"Fel försök igen! Gissning nummer {(int)antalgissningar+1}: ");
            }
        }
    }
}
