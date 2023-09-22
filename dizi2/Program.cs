using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pozitif = 0;
            int negatif = 0;
            int notr = 0;
            Random rnd = new Random();

            int[] sayilar = new int[20];

            for (int i = 0; i < 20; i++)
            {
                sayilar[i] = rnd.Next(-100, 100);
            }

            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
                if (sayi > 0)
                {
                    pozitif++;
                }
                else if (sayi < 0)
                {
                    negatif++;
                }
                else
                {
                    notr++;
                }
            }
            Console.WriteLine("Pozitif Sayı Adeti>>> " + pozitif);
            Console.WriteLine("Negatif Sayı Adeti>>> " + negatif);
            Console.WriteLine("İşaretsiz Sayı Adeti>>> " + notr);
            Console.ReadKey();
        }
    }
}
