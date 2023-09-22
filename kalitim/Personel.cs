using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim
{
    internal class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string Okul { get; internal set; }

        public void BilgileriGoster()
        {
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Soyad: " + Soyad);
            Console.WriteLine("Yaş: " + Yas);
        }
    }

    // Alt sınıf (Derived Class)
    class Ogrenci : Personel
    {
        public string Okul { get; set; }


        public void OkulunuGoster()
        {
            Console.WriteLine("Okul: " + Okul);
        }
    }

}
