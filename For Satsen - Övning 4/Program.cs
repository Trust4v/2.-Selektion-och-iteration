using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Satsen___Övning_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in Start : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Mata in stop : ");
            int stop = int.Parse(Console.ReadLine());
            Console.Write("Mata in steg : ");
            int step = int.Parse(Console.ReadLine());
            for (int i = start; i <= stop; i += step)
            {
                Console.WriteLine(i);
            }
        }
    }
}
