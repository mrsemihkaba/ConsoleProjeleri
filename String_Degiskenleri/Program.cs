using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Degiskenleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, yas, meslek, sehir;
            Console.Write("adınızı Girin : ");
            ad = Console.ReadLine();
            Console.Write("soyadınızı Girin : ");
            soyad = Console.ReadLine();
            Console.Write("yaşınızı Girin : ");
            yas = Console.ReadLine();
            Console.Write("mesleğinizi Girin : ");
            meslek = Console.ReadLine();
            Console.Write("Yaşadığınız Şehri Girin : ");
            sehir = Console.ReadLine();

            Console.WriteLine("Tebrikler Kayıt Oluşturuldu");
            Console.WriteLine(" Hoşgeldiniz, " + ad + " " + soyad + " Duyduğum kadarıyla, " + meslek + " Olmak Çok Güzel bir meslek " + yas + " yaşında olmanız ve " + sehir + " gibi bir şehirde çok şanslısınız.");
            Console.WriteLine("Tanıştığımıza çok memnun oldum {0} {1}",ad,soyad );
            Console.Read();
        }
    }
}
