using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    internal class ogrenci
    {
        private string ad;
        private int yas;

        // Ad özelliği
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        // Yaş özelliği
        public int Yas
        {
            get { return yas; }
            set
            {
                if (value >= 0)
                    yas = value;
                else
                    Console.WriteLine("Geçersiz yaş değeri!");
            }
        }
    }
}
