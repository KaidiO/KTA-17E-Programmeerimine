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

            int Factorial(int i)
            {
                if (i <= 1)
                    return 1;
                return i * Factorial(i - 1);

                Console.ReadLine();
            }
        }
    }
}
