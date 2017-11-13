using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecercises_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Split


            //prindi: Vabanduste genereerimise programm
            //prindi: Sisesta komadega eraldatud vabandused:
            //prindi: > ja saa kasutaja sisend

            //oletame, et kasutaja sisestab koer sõi ära, ema ei lubanud, ei viitsinud

            //masiiv = input.Split(',')

            //int random = new Random().Next... (0, masiiv.Lenght)?

            //prindi: Tänane vabandus on: {masiiv[random]}



            // Vabanduste genereerimise programm

            //Sisesta komadega eraldatud vabandused:
            //>koer sõi ära, ema ei lubanud arvutis olla, ei viitsinud

            //Tänane vabandus on: ei viitsinud

            Console.WriteLine("Vabanduste genereerimise programm!");
            Console.WriteLine("Sisesta komadega eraldatud vabandused: ");

            Console.Write(">");
             
            var input = Console.ReadLine();

            string [] masiiv = input.Split(',');
            int random = new Random().Next(masiiv.Length);
            Console.WriteLine($"Tänane vabandus on: {masiiv[random]}");
                       
            Console.ReadLine();
            
        }
    }
}
