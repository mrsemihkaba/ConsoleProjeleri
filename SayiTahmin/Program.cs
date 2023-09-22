using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Tahmin Oyunu");
            Console.WriteLine("1 ile 100 arasında bir sayı seçildi.");

            Random random = new Random();
            int bilgisayarSayisi = random.Next(1, 101);
            int tahmin = 0;
            int tahminSayisi = 0;

            while (tahmin != bilgisayarSayisi)
            {
                Console.Write("Tahmininizi girin: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                tahminSayisi++;

                if (tahmin < bilgisayarSayisi)
                {
                    Console.WriteLine("Daha büyük bir sayı girin.");
                }
                else if (tahmin > bilgisayarSayisi)
                {
                    Console.WriteLine("Daha küçük bir sayı girin.");
                }
                else
                {
                    Console.WriteLine("Tebrikler! Sayıyı " + tahminSayisi + " tahminde buldunuz.");
                }
            }
        }
    }
}
