using System;
using System.ComponentModel;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
                i++;
            }

            Console.WriteLine("----------------------------------------------------------");

            int a = 1;

            while (a < 20)
            {
                Console.WriteLine(a);
                a++;
            }

            Console.WriteLine("------------------------------------------------------------");

            int b = 2;

            while (b < 20)
            {
                Console.WriteLine(b);
                b += 2;
            }

            Console.WriteLine("----------------------------------------------------------------");

            int c = 51;
            int terimSayisi = 0;
            while (c < 150)
            {
                terimSayisi++;
                c++;
            }

            int result = (terimSayisi * (51 + 149)) / 2;
            Console.WriteLine("Terim Sayısı:" + terimSayisi);
            Console.WriteLine("Toplam:" + result);

            Console.WriteLine("--------------------------------------------------------------------");

            int d = 1;

            List<int> tekSayilar = new List<int>();
            List<int> ciftSayilar = new List<int>();

            while (d < 120)
            {
                if (d % 2 == 0)
                {
                    ciftSayilar.Add(d);
                }
                else
                {
                    tekSayilar.Add(d);
                }

                d++;
            }

            int e1 = 0;
            int toplam1 = 0;
            while (e1 < ciftSayilar.Count)
            {
                toplam1 += ciftSayilar[e1];
                e1++;
            }

            Console.WriteLine("Çift sayıların toplamı: " + toplam1 );

            int e2 = 0;
            int toplam2 = 0;
            while (e2 < tekSayilar.Count)
            {
                toplam2 += tekSayilar[e2];
                e2++;
            }

            Console.WriteLine("Tek sayıların toplamı: " + toplam2);
        }
    }
}