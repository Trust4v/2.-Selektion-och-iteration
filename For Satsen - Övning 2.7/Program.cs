using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Satsen___Övning_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in ett positivt heltal : ");
            double inmat = double.Parse(Console.ReadLine());
            bool primtal = true;
            for (int i = 2; i < inmat; i++)
            {
                if (inmat%i == 0)
                {                    
                    primtal = false;
                }                 
                
            }
            if (inmat == 0 || inmat == 1)
            {
                primtal = false;
            }
            if (primtal)
            {
                Console.WriteLine("Talet är ett primtal");
            }
            else
            {
                Console.WriteLine("Talet är inte ett primtal");
            }
            
        }
    }
}
