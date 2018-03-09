using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tere tulemast Muu restorani. Palun toidule vastav hind");
            Console.WriteLine();

            Console.Write("Kartul: ");
            string kartuliHind = Console.ReadLine();

            Console.Write("Riis: ");
            string riisiHind = Console.ReadLine();

            Console.Write("Tatar: ");
            string tatraHind = Console.ReadLine();

            Console.Write("Kaste: ");
            string kastmeHind = Console.ReadLine();

            Console.Write("Salat: ");
            string salatiHind = Console.ReadLine();

            Console.Write("Mahl: ");
            string mahlaHind = Console.ReadLine();

            int kartul = int.Parse(kartuliHind);
            int riis = int.Parse(riisiHind);
            int tatar = int.Parse(tatraHind);
            int kaste = int.Parse(kastmeHind);
            int salat = int.Parse(salatiHind);
            int mahl = int.Parse(mahlaHind);

            int kokku = kartul + riis + tatar + kaste + salat + mahl;

            Console.WriteLine($"Kokku: {kokku}");
            Console.ReadLine();
        }
    }
}
