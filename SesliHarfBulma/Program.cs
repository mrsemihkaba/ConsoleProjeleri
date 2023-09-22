using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesliHarfBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sesli Harf Bulma Oyunu");
            Console.WriteLine("Bir kelime seçildi, içindeki sesli harfleri bulmaya çalışın.");

            string[] kelimeler = { "merhaba", "kitap", "bilgisayar", "programlama", "ocean", "turuncu" };

            Random random = new Random();
            int index = random.Next(kelimeler.Length);
            string hedefKelime = kelimeler[index];

            char[] sesliHarfler = { 'a', 'e', 'i', 'o', 'u' };
            int dogruTahminSayisi = 0;

            foreach (char harf in hedefKelime)
            {
                if (Array.Exists(sesliHarfler, h => h == harf))
                {
                    Console.Write("_");
                }
                else
                {
                    Console.Write(harf + " ");
                    dogruTahminSayisi++;
                }

                
                if (Console.ReadKey().Key == ConsoleKey.Q)
                {
                    Console.WriteLine("Oyundan çıkılıyor...");
                    return;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Toplam " + dogruTahminSayisi + " sesli harf bulunuyor.");
        }
    }
}
