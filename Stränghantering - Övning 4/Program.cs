using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Stränghantering___Övning_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv texten du vill bearbeta: ");
            string text = Console.ReadLine();
            Console.WriteLine("Skriv ordet du vill ringa in i citattecken: ");
            string citattext = Console.ReadLine();
            //ersätter text
            text = Regex.Replace(text, citattext, $"\"{citattext}\"");
            Console.WriteLine(text);
            
        }
    }
}
