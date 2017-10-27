using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercis_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1-100]. Proovi see ära arvata");
            Console.WriteLine();

            Console.Write("Sinu number: ");
            string input = Console.ReadLine();

            int number = int.Parse(input);

            int magicNumber = 45;

            Console.WriteLine();

            if (magicNumber > number)
            {
                Console.WriteLine("Sinu number on väiksem");
            }
            if (magicNumber < number)
            {
                Console.WriteLine("Sinu number on suurem");
            }
            if (magicNumber == number)
            {
                Console.WriteLine("Arvasid numbri ära");
            }
            
            Console.ReadLine();
        }
    }
}
