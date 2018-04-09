using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Proramm küsib kasutaja käest kolme sisendit: 
            //a) minimaalne aasta arv, 
            //b) maksimaalne aasta arv, 
            //c) suvaliselt genereeritavate andmete hulka.               
            //Vastavalt sisestatud andmetele genereeritakse suvaliselt etteantud vahemikus ja hulgal timestamp’e.


            //Console.WriteLine(DateTime.Now);

            string mini;
            string maks;
            string sgah;

            int a, b, c;


            Console.Write("Palun sisesta minimaalne aasta arv: ");
            mini = Console.ReadLine();
            a = int.Parse(mini);
            Console.Write("Palun sisesta maksimaalne aasta arv: ");
            maks = Console.ReadLine();
            b = int.Parse(maks);
            Console.Write("Palun sisesta suvaliselt genereeritavate andmete hulka: ");
            sgah = Console.ReadLine();
            c = int.Parse(sgah);

            Random rnd = new Random();
            int vahemik = rnd.Next(a, b);

            //var andmete_hulk = vahemik;

            //Console.WriteLine(rnd.Next(c));


            //Console.WriteLine(DateTime.Now.ToString());
            //rnd.Next(a, b);

            //Random r = new Random();  


            for (var i = 0; i < c; i++)
            {
                 var pro = rnd.Next(a, b);
                
                
                //Console.Write(pro);
                
                Console.WriteLine(new DateTime(pro, 01, 01));
            }

            //.DateTime.Now.ToString();

            //var now = DateTime.Now;

            //Console.WriteLine($"Hour:{now.Hour}");
            //Console.WriteLine($"Minute:{ now.Minute}");



            //var date = DateTime.Parse("09. 04. 2018 09:28:10");
            //Console.WriteLine(DateTime.Now.ToString());


            //var born = new DateTime(1989, 4, 10, 21, 45, 00);
            //Console.WriteLine(born);
            Console.ReadLine();
        }
    }
}
