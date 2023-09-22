using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeTahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kelime Tahmin Oyunu");
            Console.WriteLine("Bir kelime seçildi, tahmin etmeye çalışın.");

            string[] kelimeler = { "merhaba", "kitap", "bilgisayar", "programlama", "ocean", "turuncu" };

            Random random = new Random();
            int index = random.Next(kelimeler.Length);
            string hedefKelime = kelimeler[index];
            int tahminSayisi = 0;
            bool kelimeBulundu = false;

            char[] tahminEdilenHarf = new char[hedefKelime.Length];
            for (int i = 0; i < hedefKelime.Length; i++)
            {
                tahminEdilenHarf[i] = '_';
            }

            while (!kelimeBulundu)
            {
                Console.WriteLine("Kelimeyi tahmin et: " + new string(tahminEdilenHarf));
                string tahmin = Console.ReadLine().ToLower();
                tahminSayisi++;

                if (tahmin.Length != 1)
                {
                    Console.WriteLine("Lütfen sadece bir harf girin.");
                    continue;
                }

                char harf = tahmin[0];

                bool harfBulundu = false;
                for (int i = 0; i < hedefKelime.Length; i++)
                {
                    if (hedefKelime[i] == harf)
                    {
                        tahminEdilenHarf[i] = harf;
                        harfBulundu = true;
                    }
                }

                if (!harfBulundu)
                {
                    Console.WriteLine("Yanlış harf, tekrar deneyin.");
                }

                kelimeBulundu = Array.IndexOf(tahminEdilenHarf, '_') == -1;
            }

            Console.WriteLine("Tebrikler! Kelimeyi " + tahminSayisi + " tahminde buldunuz: " + hedefKelime);
        }
    }
}
