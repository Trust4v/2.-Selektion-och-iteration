using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_satsen___Övning_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in ett tal : ");
            double heltal = double.Parse(Console.ReadLine());

            if (heltal % 7 == 0)
            {
                Console.WriteLine("Talet är jämt delbart med 7");
            }
            else
            {
                Console.WriteLine("Talet är ej delbart med 7. Resten blir : " + (heltal % 7));
            }



        }
    }
}
