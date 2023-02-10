using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Satsen___Övning_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int år = DateTime.Now.Year;
            while (true)
            {
                if (år > 2050)
                {
                    break;
                }
                if (DateTime.IsLeapYear(år))
                {
                    Console.WriteLine("År " + år + " är det presidentval i USA");
                }
                år++;
                
            }
        }
    }
}
