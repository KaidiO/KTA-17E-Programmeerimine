using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valikud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta siia nii palju kohanimesid kui tead! Vajuta X, kui oled lõpetanud");
            List<string> names = new List<string>();

            while (true)
            {
                Console.Write("Sisesta kohanimi: ");
                string input = Console.ReadLine();
                if (input == "x")
                {
                    break;
                }

                names.Add(input);

                               
            }
            Console.WriteLine(String.Join(", ", names));

            Random rnd = new Random();
            int n = rnd.Next(0,names.Count());

            
            Console.WriteLine($"Tänaseks kohanimeks osutus:{names[n]} ");
                       

            Console.ReadLine();
}   }   }



