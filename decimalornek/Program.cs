using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimalornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal urun1, urun2, toplam, s1, s2;
            urun1 = 15.45m;
            urun2 = 47.31m;
            Console.Write("birinci ürünün satış miktarı : ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("birinci ürünün satış miktarı : ");
            s2 = Convert.ToInt16(Console.ReadLine());
            toplam = s1 * urun1+ s2 * urun2;
            Console.WriteLine("Gün sonunda kasa olması gerekn tutar : " + toplam + " TL dir.");
            Console.ReadKey();

        }
    }
}
