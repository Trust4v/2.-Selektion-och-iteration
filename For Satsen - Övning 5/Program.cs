using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Satsen___Övning_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            Console.Write("Mata in ett heltal : ");
            if (int.TryParse(Console.ReadLine(), out int stop)){
                for (int i = 0; i < stop; i++)
                {
                    summa += (i+1);
                    
                }
                Console.WriteLine(summa);
            }
            else
            {
                Console.WriteLine("Du matade inte in ett heltal");
            }
            

        }
    }
}
