using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksami_harjutus01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Palun lisa siia nii palju nimesid kui soovid, kui oled lõpetanud kirjuta -1:");

            string a = "";
            ArrayList al = new ArrayList();

            while (true)
            {

                Console.Write("Lisa nimi: ");
                a = Console.ReadLine();
                al.Add(a);


                if (a == "-1")
                {

                    break;
                }

            }


            Console.Write("Sinu kirjutatud nimed: ");
            foreach (string i in al)
            {

                Console.Write(System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(i) + " ");
            }

            Console.ReadKey();

        }
    }
}
