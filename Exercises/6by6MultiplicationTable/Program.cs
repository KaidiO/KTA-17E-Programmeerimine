using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6by6MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.Write("\n");
            }

            

            Console.WriteLine("---------------------------------------------");

            Console.ReadLine();
        }
    }
} 