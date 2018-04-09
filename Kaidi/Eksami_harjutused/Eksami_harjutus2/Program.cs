using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksami_harjutus2
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList al = new ArrayList();

            Console.WriteLine("Nimede list:");
            
            //al.Add("Kaur");
            //al.Add("Mattias");
            //al.Add("Kristel");
            //al.Add("Heleri");
            //al.Add("Trevor");
            //al.Add("Kristjan");
            //al.Add("Kelli");
            //al.Add("Kevin");
            //al.Add("Maarika");
            //al.Add("Laura");


            string phrase = Console.ReadLine();
           

            char[] phraseAsChars = phrase.ToCharArray();

            int animalIndex = phrase.IndexOf("kaur");
            if (animalIndex != -1)
            {
                phraseAsChars[animalIndex++] = 'K';
                phraseAsChars[animalIndex++] = 'a';
                phraseAsChars[animalIndex++] = 'u';
                phraseAsChars[animalIndex] = 'r';
            }

            int animalIndex1 = phrase.IndexOf("mattias");
            if (animalIndex1 != -1)
            {
                phraseAsChars[animalIndex1++] = 'M';
                phraseAsChars[animalIndex1++] = 'a';
                phraseAsChars[animalIndex1++] = 't';
                phraseAsChars[animalIndex1++] = 't';
                phraseAsChars[animalIndex1++] = 'i';
                phraseAsChars[animalIndex1++] = 'a';
                phraseAsChars[animalIndex1] = 's';
            }

            int animalIndex2 = phrase.IndexOf("kristel");
            if (animalIndex2 != -1)
            {
                phraseAsChars[animalIndex2++] = 'K';
                phraseAsChars[animalIndex2++] = 'r';
                phraseAsChars[animalIndex2++] = 'i';
                phraseAsChars[animalIndex2++] = 's';
                phraseAsChars[animalIndex2++] = 't';
                phraseAsChars[animalIndex2++] = 'e';
                phraseAsChars[animalIndex2] = 'l';
            }

            int animalIndex3 = phrase.IndexOf("heleri");
            if (animalIndex3 != -1)
            {
                phraseAsChars[animalIndex3++] = 'H';
                phraseAsChars[animalIndex3++] = 'e';
                phraseAsChars[animalIndex3++] = 'l';
                phraseAsChars[animalIndex3++] = 'e';
                phraseAsChars[animalIndex3++] = 'r';
                phraseAsChars[animalIndex3] = 'i';
            }

            int animalIndex4 = phrase.IndexOf("trevor");
            if (animalIndex4 != -1)
            {
                phraseAsChars[animalIndex4++] = 'T';
                phraseAsChars[animalIndex4++] = 'r';
                phraseAsChars[animalIndex4++] = 'e';
                phraseAsChars[animalIndex4++] = 'v';
                phraseAsChars[animalIndex4++] = 'o';
                phraseAsChars[animalIndex4] = 'r';                
            }

            int animalIndex5 = phrase.IndexOf("kristjan");
            if (animalIndex5 != -1)
            {
                phraseAsChars[animalIndex5++] = 'K';
                phraseAsChars[animalIndex5++] = 'r';
                phraseAsChars[animalIndex5++] = 'i';
                phraseAsChars[animalIndex5++] = 's';
                phraseAsChars[animalIndex5++] = 't';
                phraseAsChars[animalIndex5++] = 'j';
                phraseAsChars[animalIndex5++] = 'a';
                phraseAsChars[animalIndex5] = 'n';
            }

            int animalIndex6 = phrase.IndexOf("kelli");
            if (animalIndex6 != -1)
            {
                phraseAsChars[animalIndex6++] = 'K';
                phraseAsChars[animalIndex6++] = 'e';
                phraseAsChars[animalIndex6++] = 'l';
                phraseAsChars[animalIndex6++] = 'l';                
                phraseAsChars[animalIndex6] = 'i';
            }

            int animalIndex7 = phrase.IndexOf("kevin");
            if (animalIndex7 != -1)
            {
                phraseAsChars[animalIndex7++] = 'K';
                phraseAsChars[animalIndex7++] = 'e';
                phraseAsChars[animalIndex7++] = 'v';
                phraseAsChars[animalIndex7++] = 'i';                
                phraseAsChars[animalIndex7] = 'n';
            }

            int animalIndex8 = phrase.IndexOf("maarika");
            if (animalIndex8 != -1)
            {
                phraseAsChars[animalIndex8++] = 'M';
                phraseAsChars[animalIndex8++] = 'a';
                phraseAsChars[animalIndex8++] = 'a';
                phraseAsChars[animalIndex8++] = 'r';
                phraseAsChars[animalIndex8++] = 'i';
                phraseAsChars[animalIndex8++] = 'k';
                phraseAsChars[animalIndex8] = 'a';
            }

            int animalIndex9 = phrase.IndexOf("laura");
            if (animalIndex9 != -1)
            {
                phraseAsChars[animalIndex9++] = 'L';
                phraseAsChars[animalIndex9++] = 'a';
                phraseAsChars[animalIndex9++] = 'u';
                phraseAsChars[animalIndex9++] = 'r';               
                phraseAsChars[animalIndex9] = 'a';
            }

            string updatedPhrase = new string(phraseAsChars);
            Console.WriteLine(updatedPhrase);


         
            Console.ReadKey();

        }
    }
}
