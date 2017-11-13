using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("See on allahindluse arvutamise programm, sisesta summa: ");
            Console.WriteLine();

            Console.Write("Summa: ");
            int summa = int.Parse(Console.ReadLine());
            

            if (summa > 50 && summa < 250)
                Console.WriteLine("Tavakliendile on allahindlus -10%");
                Console.WriteLine("Püsikliendile on allahindlus -20%");

            if (summa > 250 && summa < 350)
                Console.WriteLine("Tavakliendile on allahindlus -20%");
                Console.WriteLine("Püsikliendile on allahindlus -30%");

            if (summa > 350)
                Console.WriteLine("Tavakliendile on allahindlus -30%");
                Console.WriteLine("Püsikliendile on allahindlus -40%");

            Console.ReadLine();
            
        }
    }
}
