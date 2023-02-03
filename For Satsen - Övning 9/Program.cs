using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Satsen___Övning_9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double inmat = double.Parse(Console.ReadLine());
            double nara = inmat;
            double narai = 0;
            double skillnadi;
            for (double i = inmat; i > 0; i -= 0.1)
            {
                skillnadi = (i * i * i) - inmat;
                if (Math.Abs(skillnadi) < nara)
                {
                    nara = skillnadi;
                    narai = i;
                }                  
            }
            Console.WriteLine(Math.Round(narai, 1));
            
        }
    }
}
