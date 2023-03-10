using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1004gubbe
{
    class Program
    {
        static void Main(string[] args)
        {
            int faktor;
            int summa;
            while (true)
            {
                summa = 0;
                faktor = 1;
                Console.Write("Testa om ditt tal är ett perfekt tal: ");
                if (int.TryParse(Console.ReadLine(), out int tal1) && tal1>0)
                {
                    for (int i = 1; i < tal1; i++)
                    {
                        if (tal1 % i == 0)
                        {
                            Console.WriteLine("Faktor " + faktor + ": "+ i);
                            summa += i;
                            faktor++;
                        }
                    }
                    Console.WriteLine("Summan blir: " + summa);
                    if (summa == tal1)
                    {
                        Console.WriteLine("Talet är ett perfekt tal!");
                    }
                    else
                    {
                        Console.WriteLine("Talet är inte ett perfekt tal!");
                    }
                }
                else
                {
                    Console.WriteLine("Du måste skriva in ett positivt heltal med siffor");
                }
            }
            
        }
    }
}
