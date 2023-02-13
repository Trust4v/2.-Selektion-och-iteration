using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stänghandtering___Övning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("Skriv in två heltal: ");
                if (int.TryParse(Console.ReadLine(), out int tal1) && int.TryParse(Console.ReadLine(), out int tal2))
                {
                    double kvot = (double)tal1 / tal2;
                    Console.Write("Kvoten av talen är: ");
                    Console.WriteLine("{0:0.##}", kvot);
                    break;
                }
                else
                {
                    Console.WriteLine("Du måste skriva in två heltal, försök igen");
                }

            }
            
        }
    }
}
