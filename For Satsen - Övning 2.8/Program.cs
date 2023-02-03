using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Satsen___Övning_2._8
{
    class Program
    {
        static bool primtaltest(double tal)
        {
            bool primtal = true;
            for (double i = 2; i < tal; i++)
            {
                if (tal % i == 0 && i != tal && i != 1)
                {
                    primtal = false;
                    break;
                }
                else if (tal == 1 || tal == 0)
                {
                    primtal = false;
                }
            }
            return primtal;
        }
            static void Main(string[] args)
        {
            Console.Write("Mata in ett heltal : ");
            double inmat = double.Parse(Console.ReadLine());
            double inmat1 = inmat;
            bool primtal = true;
            for (double i = inmat-1; i < inmat; i--)
            {
                if (inmat % i == 0 && i != inmat && i != 1)
                {
                    Console.WriteLine("Talet är ett inte primtal och kan primtals-faktoriseras");
                    primtal = false;
                    break;
                }
            }
            if (!primtal)
            {
                for (double i = 2; inmat > 1; i++)
                {
                    if (inmat % i == 0 && primtaltest(i))
                    {
                        inmat /= i;
                        Console.WriteLine("Faktor : " + i);
                    }
                    else if (i == inmat)
                    {
                        i = 1;
                    }
                }
            }
            else if (primtal)
            {
                Console.WriteLine("Talet är ett primtal så dess faktor är : " + inmat);
            }

        }
    }
}
