using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();

            Dice uus = new Dice();
                        

            var total = 0;


            for (int i = 0; i < 3; i++)
            {

                var roll = uus.Roll(6);
                total += roll;

                Console.WriteLine("1d6: {0}", roll);

            }

            
            for (int j = 0; j < 2; j++)
            {
                var roll = uus.Roll(8);
                total += roll;

                Console.WriteLine("1d8: {0}", roll);

            }

            Console.WriteLine();
            Console.WriteLine("Roll total: {0}", total);
            Console.WriteLine();
            Console.WriteLine("> ");

            Console.ReadLine();

           
        }
    }
}
