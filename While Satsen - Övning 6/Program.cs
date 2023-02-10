using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Satsen___Övning_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in saldo : ");
            double saldo = double.Parse(Console.ReadLine());
            Console.Write("Mata in Ränta per år (%) : ");
            double ränta = double.Parse(Console.ReadLine());
            ränta = (ränta/100) + 1;
            Console.Write("Mata in sparmålet : ");
            double mål = double.Parse(Console.ReadLine());
            int år = 0;
            while (true)
            {
                saldo *= ränta;
                år++;
                if (saldo > mål)
                {
                    Console.WriteLine($"Det tog {år} år att komma upp i ditt sparmål");
                    break;
                }
            }
        }
    }
}
