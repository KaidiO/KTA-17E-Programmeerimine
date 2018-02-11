using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Arvuti valib suvalise sõna. Proovi see ära arvata.");

            string[] sõnad = { "kaksik", "moos", "pulgakomm", "raamat", "arvuti", "tammepuu", "maja", "jalanõu", "kampsun", "aken" };

            Random random = new Random((int)DateTime.Now.Ticks);

            string äraArvatavSõna = sõnad[random.Next(0, sõnad.Length)];
            string arvatavSõna = äraArvatavSõna.ToUpper();

            StringBuilder kuvatavSõna = new StringBuilder(äraArvatavSõna.Length);
            for (int i = 0; i < äraArvatavSõna.Length; i++)
                kuvatavSõna.Append('_');

            List<char> õigeTäht = new List<char>();
            List<char> valeTäht = new List<char>();

            int arvamisKordi = 5;
            bool võit = false;
            int väljaPaistvadTähed = 0;

            string input;
            char arvatudTäht;

            while (!võit && arvamisKordi > 0)
            {
                Console.Write("Arva ära üks täht: ");

                input = Console.ReadLine().ToUpper();
                arvatudTäht = input[0];

                if (õigeTäht.Contains(arvatudTäht))
                {
                    Console.WriteLine("Sa juba proovisid '{0}', ja see oli õige!", arvatudTäht);
                    continue;
                }
                else if (valeTäht.Contains(arvatudTäht))
                {
                    Console.WriteLine("Sa juba proovisid '{0}', ja see oli vale!", arvatudTäht);
                    continue;
                }

                if (arvatavSõna.Contains(arvatudTäht))
                {
                    õigeTäht.Add(arvatudTäht);

                    for (int i = 0; i < äraArvatavSõna.Length; i++)
                    {
                        if (arvatavSõna[i] == arvatudTäht)
                        {
                            kuvatavSõna[i] = äraArvatavSõna[i];
                            väljaPaistvadTähed++;
                        }
                    }

                    if (väljaPaistvadTähed == äraArvatavSõna.Length)
                        võit = true;
                }
                else
                {
                    valeTäht.Add(arvatudTäht);

                    Console.WriteLine("Sõnas ei ole '{0}'!", arvatudTäht);
                    arvamisKordi--;
                }

                Console.WriteLine(kuvatavSõna.ToString());
            }

            if (võit)
                Console.WriteLine("Sa arvasidki sõna ära!");
            else
                Console.WriteLine("Sa kahjuks ei arvanud sõna ära! Sõnaks oli '{0}'", äraArvatavSõna);

            Console.Write("Press any key to exit...");
            Console.ReadLine();


        }
    }
}
