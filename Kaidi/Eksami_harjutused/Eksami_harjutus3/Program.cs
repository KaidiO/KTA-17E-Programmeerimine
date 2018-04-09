using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksami_harjutus3
{
    class Program
    {
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
        static void Main(string[] args)
        {
            string input = "";
            string input1 = "";
            string input2 = "";

            Console.Write("Palus sisesta minimaalne aasta arv: ");            
            input = Console.ReadLine();
            int mini = int.Parse(input);
            Console.Write("Palus sisesta maksimaalne aasta arv: ");
            input1 = Console.ReadLine();
            int maks = int.Parse(input);
            Console.Write("Palus sisesta suvaliselt genereeritavate andmete hulka: ");
            input2 = Console.ReadLine();
            int suva = int.Parse(input);

            String timeStamp = GetTimestamp(DateTime.Now);
            Console.WriteLine(timeStamp);

            Console.ReadLine();
        }
       
  
  
    }
}
