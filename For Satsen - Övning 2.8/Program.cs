using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Satsen___Övning_2._8
{
    class Program
    {
        //static bool primtaltest(double tal)
        //{
        //    bool primtal = true;
        //    for (double i = 2; i < tal; i++)
        //    {
        //        if (tal % i == 0 && i != tal && i != 1)
        //        {
        //            primtal = false;
        //            break;
        //        }
        //        else if (tal == 1 || tal == 0)
        //        {
        //            primtal = false;
        //        }
        //    }
        //    return primtal;
        //}
            static void Main(string[] args)
        {
            Console.Write("Mata in ett heltal : ");
            int faktortal = 1;
            bool primtal = true;
            bool loop = double.TryParse(Console.ReadLine(), out double inmat);
            if (inmat < 0)
            {
                Console.WriteLine("Inga negativa tal är primtal");
            }
            else if (loop)
            {
                for (double i = 2; i < inmat; i++)
                {
                    if (inmat % i == 0)
                    {
                        primtal = false;
                        break;
                    }
                    else if (inmat == 1 || inmat == 0)primtal = false;
                }
                if (!primtal)
                {
                    Console.WriteLine("-----");
                    for (double i = 2; inmat > 1; i++)
                    {
                        if (inmat % i == 0)
                        {
                            inmat /= i;
                            Console.WriteLine($"Faktor {faktortal} : {i}");
                            i = 1;
                            faktortal++;
                        }
                    }
                    Console.WriteLine("-----");
                }
                else if (primtal)Console.WriteLine("Talet är ett primtal så varför skulle du villja bryta upp det i primtal?");
            }
            else Console.WriteLine("Du måste skriva in ett heltal med siffror");
        }
    }
}
