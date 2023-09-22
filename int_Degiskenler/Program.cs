using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sinav1 = 80, sinav2 = 40, proje = 42, ortalama;
            ortalama = (sinav1 + sinav2 + proje) / 3;
            string kullaniciadi, Pass;
            Console.WriteLine("_______________Öğrenci Bilgisi_______________");
            Console.Write("Kullanıcı Adınızı Girin : ");
            kullaniciadi= Console.ReadLine();
            Console.Write("Öğrenci Parolanızı Girin : ");
            Pass= Console.ReadLine();
            Console.WriteLine("Tebrikler Giriş Yaptınız.\n");
            Console.WriteLine("_______________Sınav Sonuçlarınız_______________");
            Console.WriteLine("1.Sınav : {0}\n2.Sınav : {1}\nProje : {2}\nOrtalama : {3}", sinav1, sinav2, proje, ortalama);
            Console.Read();

        }
    }
}
