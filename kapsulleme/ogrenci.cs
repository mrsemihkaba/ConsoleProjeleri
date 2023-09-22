using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme
{
    internal class ogrenci
    {
        private string ad;
        private int yas;

        public string Ad
        {
            get { return ad; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    ad = value;
            }
        }

        public int Yas
        {
            get { return yas; }
            set
            {
                if (value >= 0)
                    yas = value;
            }
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine("Öğrenci Adı: " + Ad);
            Console.WriteLine("Öğrenci Yaşı: " + Yas);
        }
    }
}
