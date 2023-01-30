using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_satsen___Övning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in mönsterdjup : ");
            double djup = double.Parse(Console.ReadLine());
            if (djup < 1.6)
            {
                Console.WriteLine("Dina däck med djupet " + djup + " är inte lagliga, aja baja!");
            }
            else
            {
                Console.WriteLine("Dina där med djupet " + djup + " är helt lagliga!");
            }
        }
    }
}
