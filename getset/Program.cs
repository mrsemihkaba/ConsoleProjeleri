using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci Ogrenci = new ogrenci();

            // Ad özelliğine değer atama
            Ogrenci.Ad = "Ali";
            Console.WriteLine("Öğrenci Adı: " + Ogrenci.Ad);

            // Yaş özelliğine değer atama
            Ogrenci.Yas = 20;
            Console.WriteLine("Öğrenci Yaşı: " + Ogrenci.Yas);

            // Geçersiz yaş değeri denemesi
            Ogrenci.Yas = -5;

            Console.ReadLine();
        }
    }
}
