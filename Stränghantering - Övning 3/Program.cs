using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stränghantering___Övning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt fullständiga namn");
            string namn = Console.ReadLine();
            string printnamn = "Dina initsialer är blir: " + namn.ToUpper()[0] + ".";
            for (int i = 0; i < namn.Length; i++)
            {
                if (char.IsWhiteSpace(namn[i]))
                {
                    printnamn = printnamn + namn.ToUpper()[i+1] + ".";
                }
            }
            Console.WriteLine(printnamn);
            
        }
    }
}
