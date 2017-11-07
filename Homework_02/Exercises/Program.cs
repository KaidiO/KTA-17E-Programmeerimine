using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //Antud programm on kalkulaator.
            //Aluseks võtsin: https://www.youtube.com/watch?v=cuJ9r31c6sM.

            int a, b, c, d;

            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Sisesta esimene number ");
            a = int.Parse(Console.ReadLine());

            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Sisesta teine number ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Esimene number on " + a + " ja teine number on " + b);
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("1. Liitmine");
            Console.WriteLine("2. Lahutamine");
            Console.WriteLine("3. Korrutamine");
            Console.WriteLine("4. Jagamine");
           
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            mmm:
            Console.WriteLine();
            Console.WriteLine("Vali üleval toodud valikutest üks välja ");
            c = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            switch (c)
            {
                case 1:
                    d = a + b;
                    Console.WriteLine("Esimese ja teise numbri summa on " + d);
                    break;
                case 2:
                    d = a - b;
                    Console.WriteLine("Esimese ja teise numbri vahe on " + d);
                    break;
                case 3:
                    d = a * b;
                    Console.WriteLine("Esimese ja teise numbri korrutis on " + d);
                    break;
                case 4:
                    d = a / b;
                    Console.WriteLine("Esimese ja teise numbri jagatis on " + d);
                    break;                
                default:
                    Console.WriteLine("Palun vali number, mis on valikus antud ");
                    goto mmm;
            }
            
            Console.ResetColor();
            Console.ReadKey();
          
        }
    }
}
