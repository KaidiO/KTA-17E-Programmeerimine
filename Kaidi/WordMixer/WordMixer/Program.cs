using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMixer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("See programm jätab lauses iga sõna esimese");
            Console.WriteLine("ja viimase tähe paigale, kuid muudab");
            Console.WriteLine("sõna sees olevaid tähtede järjekorra");
            Console.WriteLine();
            Console.WriteLine("Sisesta oma lause: ");




            //string sõna = Console.ReadLine();
            //string segamini = Meetod(sõna);
            //Console.WriteLine(segamini);
            
            String[] sõna = Console.ReadLine().Split(' ');
            foreach (String part in sõna)
            {
                char a = part[1];
                char b = part[part.Length-2];
                string str = part.Substring(a, part.Length -2);
                Console.Write(" {0}{1}{2} ",a ,Meetod(str),b);
            }

            Console.ReadLine();

            

        }

        static string Meetod(string word)
        {


            string temp = word;
            string result = string.Empty;
            Random rand = new Random();
            for (int a = 0; a < word.Length; a++)
            {
                //multiplied by a number to get a better result, it was less likely for the last index to be picked
                int temp1 = rand.Next(0, (temp.Length - 1) * 3);

                result += temp[temp1 % temp.Length];
                temp = temp.Remove(temp1 % temp.Length, 1);
            }

            return result;
        }



    }
}
