using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodutöö
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            int loos = 1; 

            Console.WriteLine("Tere tulemast loosimisele. Palun vali number 1 kuni 4-ni");
            a = int.Parse(Console.ReadLine());

            loos = (new Random()).Next(0,4);
            switch (loos)
            {
                case 1:
                    Console.WriteLine("Sinu valituks osutus kategooria: arvutid");
                    break;
                case 2:
                    Console.WriteLine("Sinu valituks osutus kategooria: telefonid");
                    break;
                case 3:
                    Console.WriteLine("Sinu valituks osutus kategooria: lauamängud");
                    break;
                case 4:
                    Console.WriteLine("Sinu valituks osutus kategooria: lauanõud");
                    break;
                default:
                    Console.WriteLine("Seda numbrit pole valikus");
                    break;
            }

            Console.WriteLine();

            if (new Random().Next(0, 4) == 3)
            {
                Console.WriteLine("Palun vali üks number 1 kuni 3-ni, et teada saada millise asja sa täpselt võitsid ");
                b = int.Parse(Console.ReadLine());


                int lauamäng = 1;
                
                lauamäng = (new Random()).Next(0, 3);


                switch (lauamäng)
                {
                    case 1:
                        Console.WriteLine("Sinu valituks mänguks osutus: Alias. Palju õnne!");
                        break;
                    case 2:
                        Console.WriteLine("Sinu valituks mänguks osutus: Monopoly. Palju õnne!");
                        break;
                    case 3:
                        Console.WriteLine("Sinu valituks mänguks osutus: Pokker. Palju õnne!");
                        break;
                    default:
                        Console.WriteLine("Seda numbrit pole valikus");
                        break;
                }
            }
            Console.ReadKey();

            if (new Random().Next(0, 4) == 2)
            {

                Console.WriteLine("Palun vali üks number 1 kuni 3-ni, et teada saada millise asja sa täpselt võitsid ");
                c = int.Parse(Console.ReadLine());


                int telefon = 1;

                telefon = (new Random()).Next(0, 3);

                switch (telefon)
                {
                    case 1:
                        Console.WriteLine("Sinu valituks telefoniks osutus: Apple iPhone 6. Palju õnne!");
                        break;
                    case 2:
                        Console.WriteLine("Sinu valituks telefoniks osutus: Samsung Galaxy S6. Palju õnne!");
                        break;
                    case 3:
                        Console.WriteLine("Sinu valituks telefoniks osutus: Huawei P8 Lite. Palju õnne!");
                        break;
                    default:
                        Console.WriteLine("Seda numbrit pole valikus");
                        break;
                }
            }
            
            Console.ReadKey();

            if (new Random().Next(0, 4) == 1)
            {

                Console.WriteLine("Palun vali üks number 1 kuni 3-ni, et teada saada millise asja sa täpselt võitsid ");
                d = int.Parse(Console.ReadLine());


                int arvuti = 1;

                arvuti = (new Random()).Next(0, 3);
                switch (arvuti)
                {
                    case 1:
                        Console.WriteLine("Sinu valituks arvutiks osutus: IdeaTab 2 A10-30L 10.1 2GB 16GB 4G Blue tahvelarvuti. Palju õnne!  ");
                        break;
                    case 2:
                        Console.WriteLine("Sinu valituks arvutiks osutus: DELL Optiplex E4400 2GB 160GB DVD-RW Win7 Pro lauaarvuti. Palju õnne!");
                        break;
                    case 3:
                        Console.WriteLine("Sinu valituks arvutiks osutus: PRESTIGIO SmartBook 11.6 Z3735F 2GB 32GB RU W10 White 116A03 sülearvuti. Palju õnne!");
                        break;
                    default:
                        Console.WriteLine("Seda numbrit pole valikus");
                        break;
                }
            }
            Console.ReadKey();

            if (new Random().Next(0, 4) == 4)
            {
                Console.WriteLine("Palun vali üks number 1 kuni 3-ni, et teada saada millise asja sa täpselt võitsid ");
                e = int.Parse(Console.ReadLine());


                int lauanõud = 1;

                lauanõud = (new Random()).Next(0, 3);


                switch (lauanõud)
                {
                    case 1:
                        Console.WriteLine("Sinu valituks lauanõuks osutus: Taldriku komplekt. Palju õnne!");
                        break;
                    case 2:
                        Console.WriteLine("Sinu valituks mänguks osutus: Tassi komplekt. Palju õnne!");
                        break;
                    case 3:
                        Console.WriteLine("Sinu valituks mänguks osutus: Söögiriistade komplekt. Palju õnne!");
                        break;
                    default:
                        Console.WriteLine("Seda numbrit pole valikus");
                        break;
                }
            }


            Console.ReadKey();


            
        }
    }
}
