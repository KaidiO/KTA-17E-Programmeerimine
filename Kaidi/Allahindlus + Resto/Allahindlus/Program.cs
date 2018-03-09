using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allahindlus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("See on allahindluse arvutamise programm, sisesta summa:");
            Console.Write("> ");

            string input = Console.ReadLine();

            Console.WriteLine($"Summa: {input}€");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Tavakliendile");
            Console.WriteLine("------------");

            int amount = int.Parse(input);
            int percent = 0;

            if (amount >= 50 && amount < 250)
                percent = 10;

            if (amount >= 250 && amount < 350)
                percent = 20;

            if (amount >= 350)
                percent = 30;

            Console.WriteLine($"Allahindlus: {percent}% ");

            var finalAmount = amount - ((double)amount / 100 * percent);

            Console.WriteLine($"Tasuda: {finalAmount}€");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Püsikliendile");
            Console.WriteLine("------------");

            int percent2 = 0;
            
            if (amount >= 50 && amount < 250)
                percent2 = 20;

            if (amount >= 250 && amount < 350)
                percent2 = 30;

            if (amount >= 350)
                percent2 = 40;


            Console.WriteLine($"Allahindlus: {percent2}%");

            var finalAmount2 = amount - ((double)amount / 100 * percent2);

            Console.WriteLine($"Tasuda: {finalAmount2}€");

            Console.ReadLine();
        }
    }
}
