using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Satsen___Övning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inmata ett tal 1-4 : ");
            int tal = int.Parse(Console.ReadLine());
            switch (tal)
            {
                case 1:
                    Console.WriteLine("Ett");
                    break;
                case 2:
                    Console.WriteLine("Två");
                    break;
                case 3:
                    Console.WriteLine("Tre");
                    break;
                case 4:
                    Console.WriteLine("Fyra");
                    break;
                default:
                    Console.WriteLine("Du matade in mer än 4, Skämmigt");
                    break;
            }
        }
    }
}
