using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Satsen___Övning_2
{
    class Program
    {
        static void Main(string[] args)
            
        {
            bool sak = true;
            while (sak == true){
            Console.Write("Which way do you want to go? (n/s/e/w) : ");
            string Vaderstack = Console.ReadLine();

            switch (Vaderstack){
                case "n":
                    Console.WriteLine("You walked North");
                    break;
                case "s":
                    Console.WriteLine("You walked South");
                    break;
                case "e":
                    Console.WriteLine("You walked East");
                    break;
                case "w":
                    Console.WriteLine("You walked West");
                    break;
                default:
                    Console.WriteLine("You cant travel to "+ Vaderstack + " that would be stupid..");
                        sak = false;
                    break;
            }
}


        }
    }
}
