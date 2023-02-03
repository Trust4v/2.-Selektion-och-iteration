using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Satsen___Övning_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in ett heltal : ");
            int stop = int.Parse(Console.ReadLine());
            for (int i = stop; i > 0; i--)
            {
                if ((i % 7) == 0 && (i % 3) == 0)
                {
                    Console.WriteLine($"Talet {i} är delbart med både 3 och 7");
                }
                else if (stop < 21)
                {
                    Console.WriteLine($"Inga tal under {stop} kan delas med både 3 och 7");
                    i = 0;

                }
            }
        }
    }
}
