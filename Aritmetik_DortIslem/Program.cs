using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetik_DortIslem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam, fark, carpim, bolum;
            Console.WriteLine("aritmetik 4 işlem\n");
            Console.Write("1.sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            Console.WriteLine("\nSonuçlar : ");
            Console.WriteLine("Toplam = {0}\nFark = {1}\nÇarpım = {2}\nBölüm = {3}\n", toplam, fark, carpim, bolum);
            Console.Read();
        }
    }
}
