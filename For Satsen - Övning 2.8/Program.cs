using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Satsen___Övning_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in ett heltal : ");
            double inmat = double.Parse(Console.ReadLine());
            
            for (int i = 2; inmat == 1; i++)
            {
                if (inmat % i == 0)
                {
                    inmat = inmat / i;
                    Console.WriteLine(inmat + " och "+ i);
                }
                if (i == inmat)
                {
                    i = 0;
                }

            }
            
        }
    }
}
