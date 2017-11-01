using System;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pangakontole sisselogimine

            Console.WriteLine("Tere tulemast: ");
            Console.WriteLine();

            int pin = 0000;                                  
            bool correct = false;
            
            while (!correct)
            {
                Console.WriteLine("Palun sisesta Pin kood: ");
                string pin1 = Console.ReadLine();
                int number = int.Parse(pin1);
                
                Console.WriteLine();

                if (pin != number)
                {
                    Console.WriteLine("Sinu sisestatud PIN kood on vale. Proovi uuesti! ");
                    Console.WriteLine();
                }
            
                else
                {
                    Console.WriteLine("Tere tulemast oma pangakontole! ");
                    Console.WriteLine();
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
