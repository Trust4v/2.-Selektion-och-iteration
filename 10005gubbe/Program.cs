using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10005gubbe
{
    class Program
    {
        static void Main(string[] args)
        {
            double summa = 0;
            bool isBin = true;
            
            Console.WriteLine("Skriv in ditt binära tal: ");
            if(double.TryParse(Console.ReadLine(), out double bintal))
            {
                string bintalS = bintal.ToString();

                #region Test om input är binärt. 
                for (int i = 0; i < bintalS.Length; i++)
                {
                    if (!(bintalS[i] == '1' || bintalS[i] == '0'))
                    {
                        Console.WriteLine("Du har matat in ett tal som inte är endas ettor och nollor!");
                        isBin = false;
                        break;
                    }
                }
                #endregion
                #region Konverterar från 10 bas till binärt
                if (isBin)
                {
                    for (int j = 0; j < bintalS.Length; j++)
                    {
                        if (bintalS[j] == '1')
                        {
                            summa += Math.Pow(2, bintalS.Length - j - 1);
                        }
                    }
                    Console.WriteLine(summa);
                }
                #endregion
            }
            else
            {
                Console.WriteLine("Du måste skriva med ettor och nollor");
            }
            
        }
    }
}
