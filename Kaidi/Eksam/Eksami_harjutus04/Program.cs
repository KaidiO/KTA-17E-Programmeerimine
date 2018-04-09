using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksami_harjutus04
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            //Programmis on defineeritud masiiv mis sisaldab umbes 30 erinevat timestamp’i mis illustreerivad inimeste sünniaega, näiteks vahemikus alates 1940 – 2010.
            //Programmi ülesanne on leida nende timestamp’ide põhjal:
            //maksimaalne vanus
            //keskmine vanus aastates
            //minimaalne vanus
            //millisel kuul on kõige rohkem sünnipäevi
            //kõik timestamp’id sorteerituna kasvavalt
            
            ArrayList al = new ArrayList();

            //Console.WriteLine("Timestamp's list:");

            al.Add(new DateTime(1940, 01, 01, 02, 25, 56));
            al.Add(new DateTime(1945, 05, 08, 17, 50, 02));
            al.Add(new DateTime(1949, 12, 04, 20, 24, 22));
            al.Add(new DateTime(1953, 07, 08, 17, 50, 12));
            al.Add(new DateTime(1955, 05, 12, 17, 59, 02));
            al.Add(new DateTime(1963, 02, 16, 02, 13, 31));
            al.Add(new DateTime(1966, 10, 10, 22, 41, 52));
            al.Add(new DateTime(1970, 06, 11, 23, 50, 54));
            al.Add(new DateTime(1972, 05, 12, 12, 21, 56));
            al.Add(new DateTime(1976, 05, 15, 19, 55, 32));
            al.Add(new DateTime(1976, 02, 16, 18, 12, 51));
            al.Add(new DateTime(1979, 05, 08, 17, 50, 02));
            al.Add(new DateTime(1980, 06, 07, 15, 45, 09));
            al.Add(new DateTime(1985, 07, 11, 19, 29, 17));
            al.Add(new DateTime(1988, 11, 05, 01, 30, 32));
            al.Add(new DateTime(1996, 12, 03, 08, 47, 55));
            al.Add(new DateTime(1997, 08, 08, 21, 21, 22));
            al.Add(new DateTime(1999, 04, 03, 05, 07, 08));
            al.Add(new DateTime(2000, 10, 22, 16, 00, 02));
            al.Add(new DateTime(2006, 09, 16, 02, 34, 24));
            al.Add(new DateTime(2008, 01, 28, 12, 12, 12));
            al.Add(new DateTime(2008, 09, 30, 11, 10, 52));
            al.Add(new DateTime(2009, 11, 18, 23, 59, 22));
            al.Add(new DateTime(2010, 05, 08, 17, 50, 02));



           


            int[] numbers = new int[24] { 1940, 1945, 1949, 1953, 1955, 1963, 1966, 1970, 1972, 1976, 1976, 1979, 1980, 1985, 1988, 1996, 1997, 1999, 2000, 2006, 2008, 2008, 2009, 2010};



            int sum = 1940 + 1945 + 1949 + 1953 + 1955 + 1963 + 1966 + 1970 + 1972 + 1976 + 1976 + 1979 + 1980 + 1985 + 1988 + 1996 + 1997 + 1999 + 2000 + 2006 + 2008 + 2008 + 2009 + 2010;
            int arv = 24;
            int keskmine = sum / arv;

            int min_vanus = 2018 - numbers.Min();
            int max_vanus = 2018 - numbers.Max();
            int kesk_vanus = 2018 - keskmine;

            Console.WriteLine("Minimaalne vanus: {0}", max_vanus);
            Console.WriteLine("Maksimaalne vanus: {0}", min_vanus);
            Console.WriteLine("Keskmine vanus aastates: {0}", kesk_vanus);

            //int min_vanus = numbers[0];

            //for (int index = 0; index < numbers.Length; index++)
            //{
            //    if (numbers[index] < min_vanus) min_vanus = numbers[index];
            //} 
            //Console.WriteLine(min_vanus);


            //int max_vanus = numbers[0];
            //for (int index = 0; index > numbers.Length; index++)
            //{
            //    if (numbers[index] > max_vanus) max_vanus = numbers[index];
            //}
            //Console.WriteLine(max_vanus);

            




            //for (int i = 0; i < array.Length; i++)
            //{
            //    int count = 0;
            //    for (int j = 0; j < array.Length; j++)
            //    {

            //        if (array[i] == array[j])
            //            count = count + 1;
            //    }
            //    Console.WriteLine("\t\n " + array[i] + " kuul " + count + " korda");
            //}


            int[] array = new int[24] { 01, 05, 12, 07, 05, 02, 10, 06, 05, 05, 02, 05, 06, 07, 11, 12, 08, 04, 10, 09, 01, 09, 11, 05 };
            int count = 1, tempCount;
            int sagedus = array[0];
            int Number = 0;
            for (int i = 0; i < (array.Length - 1); i++)
            {
                Number = array[i];
                tempCount = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (Number == array[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    sagedus = Number;
                    count = tempCount;
                }
            }
            Console.WriteLine("Kõige sagedasem kuu on: {0}, sel kuul on {1}'el inimesel sünnipäev.", sagedus, count);

            //foreach (int value in array)
            //{
            //    Console.WriteLine("Before: {0}", value);
            //}

            //// Get distinct elements and convert into a list again.
            //List<int> distinct = array.Distinct().ToList();

            //foreach (int value in distinct)
            //{
            //    Console.WriteLine("After: {0}", value);
            //}

            //var uus = DateTime.Now;
            //uus.Year();



            //var now = DateTime.Now;

            //Console.WriteLine($"Aastad:{now.Year}");





            //for (var i = 0; i < 0; i++)
            //{
            //    //var pro = rnd.Next(a, b);


            //    //Console.Write(pro);

            //    Console.WriteLine(i);
            //}


            Console.WriteLine();
            Console.WriteLine("Kõik timestamp’id sorteerituna kasvavalt:");
            Console.WriteLine();

            foreach (DateTime i in al)
            {

                Console.WriteLine((i) + " ");
            }





















            //string mini;
            //string maks;
            //string sgah;

            //int a, b, c;


            //Console.Write("Palun sisesta minimaalne aasta arv: ");
            //mini = Console.ReadLine();
            //a = int.Parse(mini);
            //Console.Write("Palun sisesta maksimaalne aasta arv: ");
            //maks = Console.ReadLine();
            //b = int.Parse(maks);
            //Console.Write("Palun sisesta suvaliselt genereeritavate andmete hulka: ");
            //sgah = Console.ReadLine();
            //c = int.Parse(sgah);

            //Random rnd = new Random();
            //int vahemik = rnd.Next(a, b);



            //for (var i = 0; i < c; i++)
            //{
            //    var pro = rnd.Next(a, b);


            //    //Console.Write(pro);

            //    Console.WriteLine(new DateTime(pro, 01, 01));
            //}





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
