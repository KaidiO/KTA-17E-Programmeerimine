using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SõnaarvamisMäng
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

            Console.WriteLine("Arvuti valib suvalise sõna. Proovi see ära arvata.");

            List<string> sõnad = new List<string>();

            sõnad.Add("kaksik");
            sõnad.Add("moos");
            sõnad.Add("pulgakomm");
            sõnad.Add("raamat");
            sõnad.Add("arvuti");
            sõnad.Add("tammepuu");
            sõnad.Add("maja");
            sõnad.Add("jalanõu");
            sõnad.Add("kampsun");
            sõnad.Add("aken");

            Random rnd = new Random();                       
            int n = rnd.Next(0, sõnad.Count);

            
            

            string valitudSõna = PeidetudTähtedeArv(sõnad[n], '_');
            Console.WriteLine();



            Console.WriteLine($"Sõnaks osutus:{sõnad[n]} ");



            Console.ReadLine();
        }

       

        static string PeidetudTähtedeArv(string word, char mask)
        {
            char[] hidden = word.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                hidden[i] = mask;
            }
            return new string(hidden);
        }
    }
}
