using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegatifPozitif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 5, 7, -15, 12, -32, 3, 0, 95, 43, 100 };
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                if (sayi > 0)
                    Console.WriteLine(sayi + " Pozitif");
                else if (sayi < 0)
                    Console.WriteLine(sayi + " Negatif");
                else
                    Console.WriteLine(sayi + " İşaretsiz");

            }
            Console.ReadKey();
        }
    }
}
