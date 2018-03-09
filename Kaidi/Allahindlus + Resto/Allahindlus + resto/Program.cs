using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allahindlus___resto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
                        
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
                               

            
            Console.WriteLine($"Summa: {kokku}€");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Tavakliendile");
            Console.WriteLine("------------");

            
            int percent = 0;

            if (kokku >= 10 && kokku < 15)
                percent = 10;

            if (kokku >= 15 && kokku < 20)
                percent = 20;

            if (kokku >= 20)
                percent = 30;

            Console.WriteLine($"Allahindlus: {percent}% ");

            var finalAmount = kokku - ((double)kokku / 100 * percent);

            Console.WriteLine($"Tasuda: {finalAmount}€");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Püsikliendile");
            Console.WriteLine("------------");

            int percent2 = 0;

            if (kokku >= 10 && kokku < 15)
                percent2 = 20;

            if (kokku >= 15 && kokku < 20)
                percent2 = 30;

            if (kokku >= 20)
                percent2 = 40;


            Console.WriteLine($"Allahindlus: {percent2}%");

            var finalAmount2 = kokku - ((double)kokku / 100 * percent2);

            Console.WriteLine($"Tasuda: {finalAmount2}€");

            Console.ReadLine();

        }
    }
}
