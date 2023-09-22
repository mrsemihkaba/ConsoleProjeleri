using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Ahmet";
            ogrenci.Soyad = "Yılmaz";
            ogrenci.Yas = 25;
            ogrenci.Okul = "XYZ Üniversitesi";

            ogrenci.BilgileriGoster(); // Üst sınıftan miras alınan metot
            ogrenci.OkulunuGoster();   // Alt sınıfa özgü metot

            Console.ReadLine();
        }
    }
}
