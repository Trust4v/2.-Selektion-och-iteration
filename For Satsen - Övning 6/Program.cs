using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Satsen___Övning_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            int inmat = int.Parse(Console.ReadLine());
            for (int i = 0; i <= (inmat-2); i++)
            {
                if (i <= 1)
                {
                    Console.WriteLine(i);
                }

                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            /*
            //int slut = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= inmat; i++)
            {
                
                else
                {
                    Console.WriteLine(((i - 1) + (i - 2)));
                }
            
            }*/
        }
    }
}
