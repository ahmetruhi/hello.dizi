using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello.dizi
{
    class Program
    {
        static void Main(string[] args)
        {//Array(dizi)

            //int[] sayilar = {3,6,8,4};



            //int[] sayilar = new int[3];

            //sayilar[0] = 5;
            //sayilar[1] = 3;
            //sayilar[2] = 15;

            ////Console.WriteLine(sayilar[0]);
            ////Console.WriteLine(sayilar[1]);
            ////Console.WriteLine(sayilar[2]); (((Kod Fazlalığı Böyle)))

            //Array.Sort(sayilar); //Arrayleri yani sayıları sıralayıp gösteriyor bize

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}



            Console.WriteLine("Kaç adet isim gireceksiniz?:");
            byte isim = byte.Parse(Console.ReadLine());
            string[] name = new string[isim];

            for (int i = 0; i < isim; i++)
            {
                Console.WriteLine("İsimleri giriniz:");
                string name2 = Console.ReadLine();
                name[i] = name2;
            }

            Array.Sort(name);
            for (int i = 0; i < isim; i++)
            {
                Console.WriteLine(" {0}", name[i]);
            }



            Console.ReadKey();
        }
    }
}
