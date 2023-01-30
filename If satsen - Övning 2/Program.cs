using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_satsen___Övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in din ålder : ");
            int alder = int.Parse(Console.ReadLine());
            if (alder >= 0 && alder <= 12)
            {
                Console.WriteLine("Färg : Vit");
            }
            else if (alder >= 13 && alder <= 18){
                Console.WriteLine("Färg : Grön");
            }
            else if (alder >= 19 && alder <= 25)
            {
                Console.WriteLine("Färg : Röd");
            }
            else if (alder >= 26 && alder <= 99)
            {
                Console.WriteLine("Färg : Blå");
            }
            else
            {
                Console.WriteLine("Ogiltig ålder");
            }
        }
    }
}
