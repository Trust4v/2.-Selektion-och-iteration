using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Satsen___Övning_2
{
    class Program
    {
        static void wanderingtrader()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
            if (num <10)
            {
                Console.WriteLine("You stubled uppon a wandering traveler. He showes you his wears");
                Console.WriteLine("In his stock he has:");
                Console.WriteLine("Nike Airs (5 Coins) (1)");
                Console.WriteLine("THE MOST FIT OUTFIT EVER (10 Coins) (2)");
                Console.WriteLine("Nothing ... (3)");
                Console.Write("Would you like to buy anything (1/2/3): ");
                int buying = int.Parse(Console.ReadLine());
                switch (buying){
                    case 1:
                        Console.WriteLine("You bought some Nikes");
                        break;
                    case 2:
                        Console.WriteLine("You bought some drip");
                        break;
                    default:
                        Console.WriteLine("You didn't buy anything");
                        break;
                }
                
            }
            else
            {

            }
        }
        static void Main(string[] args)
            
        {
            
            int coins = 0;
            int xaxel = 0;
            int yaxel = 0;
            string vaderx;
            string vadery;
            bool sak = true;
            while (sak == true){
            Console.Write("Which way do you want to go? (n/s/e/w) : ");
            string Vaderstack = Console.ReadLine();
                Random rnd = new Random();
                int num1 = rnd.Next(1, 3);

                switch (Vaderstack){
                case "n":
                    Console.WriteLine("You walked North");
                        yaxel++;
                        coins = coins + num1;
                        Console.WriteLine("You now have : " + coins + "coins.");
                        wanderingtrader();
                        break;
                case "s":
                    Console.WriteLine("You walked South");
                        yaxel--;
                        coins = coins + num1;
                        Console.WriteLine("You now have : " + coins + "coins.");
                        wanderingtrader();
                        break;
                case "e":
                    Console.WriteLine("You walked East");
                        xaxel++;
                        coins = coins + num1;
                        Console.WriteLine("You now have : " + coins + "coins.");
                        wanderingtrader();
                        break;
                case "w":
                    Console.WriteLine("You walked West");
                        xaxel--;
                        coins = coins + num1;
                        Console.WriteLine("You now have : " + coins + "coins.");
                        wanderingtrader();
                        break;
                default:
                        if (xaxel > 0){vaderx = "east";}
                        else if (xaxel < 0){ vaderx = "west";}
                        else {vaderx = "ingenstans";}
                        if (yaxel > 0) { vadery = "north"; }
                        else if (yaxel < 0) { vadery = "South"; }
                        else { vadery = "ingenstans"; }
                        Console.WriteLine("You cant travel to "+ Vaderstack + " that would be stupid..");
                        Console.WriteLine("You walked " + xaxel + " km " + vaderx + " and " + yaxel + " km " + vadery);
                        sak = false;

                    break;
            }
}


        }
    }
}
