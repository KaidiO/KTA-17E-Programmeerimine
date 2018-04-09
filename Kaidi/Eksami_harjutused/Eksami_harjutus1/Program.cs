using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksami_harjutus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun lisa siia nii palju nimesid kui soovid, alustamiseks vajuta enter :");

            string a = "";
            ArrayList al = new ArrayList();

            while (a != "-1")
            {

                Console.WriteLine("Lisa nimi:");
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
