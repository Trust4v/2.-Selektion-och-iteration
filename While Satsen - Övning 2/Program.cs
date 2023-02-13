using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Satsen___Övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int gissningar;
            int highscore = int.MaxValue;
            int tak = 0; 
            while (true)
            {
                //Highscore
                
                gissningar = 0;

                Console.WriteLine("---MENY---");
                Console.WriteLine("- Spela Spel (1) -");
                Console.WriteLine("- Se Highscore (2) -");
                Console.WriteLine("- Sluta spela (3) - ");
                Console.Write("Välj ett alternativ i menyn: ");
                //Testar vad man matar in
                if (int.TryParse(Console.ReadLine(), out int val))
                {
                    // Spelet
                    if (val == 1)
                    {
                        Console.WriteLine("- Gissnings Spelet -");

                        int maxRnd;
                        while (true)
                        {
                            Console.Write("Mata in högsta värde för slupgeneratorn (Högre än 1): ");
                            if (int.TryParse(Console.ReadLine(), out maxRnd))
                            {
                                if (maxRnd > 1) break;
                                else Console.WriteLine("Talet måste vara större än 1");
                            }
                            else Console.WriteLine("Du måste mata in ett tal");
                        }
                        Console.WriteLine("Gissa på ett tal mellan 1 och " + maxRnd);
                        int slumpattal = rnd.Next(1, maxRnd + 1);
                        while (true)
                        {
                            if (int.TryParse(Console.ReadLine(), out int tal))
                            {
                                gissningar++;
                                if (tal == slumpattal)
                                {
                                    Console.WriteLine("Du skrev in rätt tal!");
                                    
                                    break;
                                }
                                else if (tal < slumpattal)
                                {
                                    Console.WriteLine("Högre");
                                }
                                else
                                {
                                    Console.WriteLine("lägre");
                                }
                                

                            }
                            else
                            {
                                Console.WriteLine("Du matade inte in ett heltal med siffor");
                            }

                        }
                        Console.WriteLine(gissningar);
                        if (gissningar < highscore)
                        {
                            Console.WriteLine("Det var rekord!");

                        }
                        if (highscore > gissningar && gissningar != 0)
                        {
                            tak = maxRnd;
                            highscore = gissningar;

                        }
                        
                    }
                    //Highscore
                    else if (val == 2)
                    {
                        if (highscore == int.MaxValue) Console.WriteLine("Du har inte spelat spelet än!");
                        else
                        {
                            Console.WriteLine("Ditt highscore är : " + highscore);
                            Console.WriteLine("intretvall : 1 - " + tak);
                        }
                    }
                    //Avsluta spelet
                    else if (val == 3)
                    {
                        break;
                    }
                    //Felsafe för om man skriver högre än 3
                    else if (val >= 4)
                    {
                        Console.WriteLine("Du måste mata in ett heltal mellan 1 och 3");
                    }
                }               
                else
                {
                    Console.WriteLine("Du måste skriva ett tal med siffror");
                }
                Console.WriteLine("");
            }
        }
    }
}
