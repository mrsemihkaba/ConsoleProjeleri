using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci Ogrenci = new ogrenci();

            Ogrenci.Ad = "Ali";
            Ogrenci.Yas = 20;

            Ogrenci.BilgileriYazdir();

            Console.ReadLine();
        }
    }
}
