using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_satsen___Övning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in tal 1 : ");
            decimal tal1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Skriv in tal 2 : ");
            decimal tal2 = decimal.Parse(Console.ReadLine());
            if (tal1 > tal2)
            {
                Console.WriteLine("Tal 1 är större än tal 2");
            }
            else if (tal1 < tal2)
            {
                Console.WriteLine("Tal 2 är större än tal 2");
            }
            else
            {
                Console.WriteLine("Talen är lika stora!");
            }
        }
    }
}
