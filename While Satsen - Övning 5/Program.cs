using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Satsen___Övning_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1 = 0;
            int tal2 = 1;
            int tal3;
            while (tal1 < 1000000)
            {
                Console.WriteLine(tal1);
                tal3 = tal1 + tal2;
                tal1 = tal2;
                tal2 = tal3;
            }
        }
    }
}
