using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetamatikMenusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menü:");
                Console.WriteLine("1-) Aritmetik Dört İşlem");
                Console.WriteLine("2-) Üs Alma");
                Console.WriteLine("3-) Kök Alma");
                Console.WriteLine("4-) Karenin Çevre ve Alan Hesabı");
                Console.WriteLine("5-) Dikdörtgenin Çevre ve Alan Hesabı");
                Console.WriteLine("6-) Eşkenar Üçgenin Çevre");
                Console.WriteLine("0-) Çıkış");

                Console.Write("Seçiminizi yapın (0-6): ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        AritmetikIslemler();
                        break;
                    case 2:
                        UsAlma();
                        break;
                    case 3:
                        KokAlma();
                        break;
                    case 4:
                        KareninHesaplari();
                        break;
                    case 5:
                        DikdortgeninHesaplari();
                        break;
                    case 6:
                        EskenarUcgeninCevresi();
                        break;
                    case 0:
                        Console.WriteLine("Programdan çıkılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                        break;
                }

                Console.WriteLine(); // Bir boş satır ekleyerek menüyü ayırır.
            }
        }

        static void AritmetikIslemler()
        {
            Console.Write("İlk sayıyı girin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Toplam: " + (sayi1 + sayi2));
            Console.WriteLine("Çıkarma: " + (sayi1 - sayi2));
            Console.WriteLine("Çarpma: " + (sayi1 * sayi2));
            Console.WriteLine("Bölme: " + (sayi1 / sayi2));
        }

        static void UsAlma()
        {
            Console.Write("Tabanı girin: ");
            double taban = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üssü girin: ");
            double us = Convert.ToDouble(Console.ReadLine());

            double sonuc = Math.Pow(taban, us);
            Console.WriteLine("Sonuç: " + sonuc);
        }

        static void KokAlma()
        {
            Console.Write("Kökünü almak istediğiniz sayıyı girin: ");
            double sayi = Convert.ToDouble(Console.ReadLine());

            double kok = Math.Sqrt(sayi);
            Console.WriteLine("Kök: " + kok);
        }

        static void KareninHesaplari()
        {
            Console.Write("Karenin kenar uzunluğunu girin: ");
            double kenar = Convert.ToDouble(Console.ReadLine());

            double cevre = 4 * kenar;
            double alan = kenar * kenar;

            Console.WriteLine("Karenin Çevresi: " + cevre);
            Console.WriteLine("Karenin Alanı: " + alan);
        }

        static void DikdortgeninHesaplari()
        {
            Console.Write("Dikdörtgenin uzun kenarını girin: ");
            double uzunKenar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dikdörtgenin kısa kenarını girin: ");
            double kisaKenar = Convert.ToDouble(Console.ReadLine());

            double cevre = 2 * (uzunKenar + kisaKenar);
            double alan = uzunKenar * kisaKenar;

            Console.WriteLine("Dikdörtgenin Çevresi: " + cevre);
            Console.WriteLine("Dikdörtgenin Alanı: " + alan);
        }

        static void EskenarUcgeninCevresi()
        {
            Console.Write("Eşkenar üçgenin kenar uzunluğunu girin: ");
            double kenar = Convert.ToDouble(Console.ReadLine());

            double cevre = 3 * kenar;
            Console.WriteLine("Eşkenar Üçgenin Çevresi: " + cevre);
        }
    }
}

