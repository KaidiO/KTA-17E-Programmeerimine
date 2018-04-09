using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksami_harjutus02
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList al = new ArrayList();

            Console.WriteLine("Nimede list:");

            al.Add("Kaur");
            al.Add("Mattias");
            al.Add("Kristel");
            al.Add("Heleri");
            al.Add("Trevor");
            al.Add("Kristjan");
            al.Add("Kelli");
            al.Add("Kevin");
            al.Add("Maarika");
            al.Add("Laura");


            string phrase = Console.ReadLine();


            char[] phraseAsChars = phrase.ToCharArray();

            int nimi = phrase.IndexOf("kaur");
            if (nimi != -1)
            {
                phraseAsChars[nimi++] = 'K';
                phraseAsChars[nimi++] = 'a';
                phraseAsChars[nimi++] = 'u';
                phraseAsChars[nimi] = 'r';
            }

            int nimi1 = phrase.IndexOf("mattias");
            if (nimi1 != -1)
            {
                phraseAsChars[nimi1++] = 'M';
                phraseAsChars[nimi1++] = 'a';
                phraseAsChars[nimi1++] = 't';
                phraseAsChars[nimi1++] = 't';
                phraseAsChars[nimi1++] = 'i';
                phraseAsChars[nimi1++] = 'a';
                phraseAsChars[nimi1] = 's';
            }

            int nimi2 = phrase.IndexOf("kristel");
            if (nimi2 != -1)
            {
                phraseAsChars[nimi2++] = 'K';
                phraseAsChars[nimi2++] = 'r';
                phraseAsChars[nimi2++] = 'i';
                phraseAsChars[nimi2++] = 's';
                phraseAsChars[nimi2++] = 't';
                phraseAsChars[nimi2++] = 'e';
                phraseAsChars[nimi2] = 'l';
            }

            int nimi3 = phrase.IndexOf("heleri");
            if (nimi3 != -1)
            {
                phraseAsChars[nimi3++] = 'H';
                phraseAsChars[nimi3++] = 'e';
                phraseAsChars[nimi3++] = 'l';
                phraseAsChars[nimi3++] = 'e';
                phraseAsChars[nimi3++] = 'r';
                phraseAsChars[nimi3] = 'i';
            }

            int nimi4 = phrase.IndexOf("trevor");
            if (nimi4 != -1)
            {
                phraseAsChars[nimi4++] = 'T';
                phraseAsChars[nimi4++] = 'r';
                phraseAsChars[nimi4++] = 'e';
                phraseAsChars[nimi4++] = 'v';
                phraseAsChars[nimi4++] = 'o';
                phraseAsChars[nimi4] = 'r';
            }

            int nimi5 = phrase.IndexOf("kristjan");
            if (nimi5 != -1)
            {
                phraseAsChars[nimi5++] = 'K';
                phraseAsChars[nimi5++] = 'r';
                phraseAsChars[nimi5++] = 'i';
                phraseAsChars[nimi5++] = 's';
                phraseAsChars[nimi5++] = 't';
                phraseAsChars[nimi5++] = 'j';
                phraseAsChars[nimi5++] = 'a';
                phraseAsChars[nimi5] = 'n';
            }

            int nimi6 = phrase.IndexOf("kelli");
            if (nimi6 != -1)
            {
                phraseAsChars[nimi6++] = 'K';
                phraseAsChars[nimi6++] = 'e';
                phraseAsChars[nimi6++] = 'l';
                phraseAsChars[nimi6++] = 'l';
                phraseAsChars[nimi6] = 'i';
            }

            int nimi7 = phrase.IndexOf("kevin");
            if (nimi7 != -1)
            {
                phraseAsChars[nimi7++] = 'K';
                phraseAsChars[nimi7++] = 'e';
                phraseAsChars[nimi7++] = 'v';
                phraseAsChars[nimi7++] = 'i';
                phraseAsChars[nimi7] = 'n';
            }

            int nimi8 = phrase.IndexOf("maarika");
            if (nimi8 != -1)
            {
                phraseAsChars[nimi8++] = 'M';
                phraseAsChars[nimi8++] = 'a';
                phraseAsChars[nimi8++] = 'a';
                phraseAsChars[nimi8++] = 'r';
                phraseAsChars[nimi8++] = 'i';
                phraseAsChars[nimi8++] = 'k';
                phraseAsChars[nimi8] = 'a';
            }

            int nimi9 = phrase.IndexOf("laura");
            if (nimi9 != -1)
            {
                phraseAsChars[nimi9++] = 'L';
                phraseAsChars[nimi9++] = 'a';
                phraseAsChars[nimi9++] = 'u';
                phraseAsChars[nimi9++] = 'r';
                phraseAsChars[nimi9] = 'a';
            }

            string updatedPhrase = new string(phraseAsChars);
            Console.WriteLine(updatedPhrase);



            Console.ReadKey();


        }
    }
}
