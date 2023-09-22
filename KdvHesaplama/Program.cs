using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdvHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fiyat, kdv, toplam;
            Console.Write("Ürünün Fiyatını Giriniz -> ");
            fiyat = Convert.ToDouble(Console.ReadLine());
            kdv = fiyat * 18 / 100;
            toplam = fiyat + kdv;
            Console.WriteLine("KDV'li satış tutarı : " + toplam.ToString());
            Console.ReadKey();
        }
    }
}
