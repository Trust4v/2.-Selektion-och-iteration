using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Satsen___Övning_8
{
    class Program
    {
        static void Main(string[] args)
        { 

            DateTime nowDate = DateTime.Now;
            DateTime dag = new DateTime(nowDate.Year, 1, 1);
            while (true)
            {
                if (dag.DayOfWeek==DayOfWeek.Monday)
                {
                    Console.WriteLine(dag);
                }
                else if(dag.DayOfYear == nowDate.DayOfYear)
                {
                    break;
                }
                dag += TimeSpan.FromDays(1);
            }
        }
    }
}
