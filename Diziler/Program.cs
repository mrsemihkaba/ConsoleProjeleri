using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mevcut = 0;
            Console.Write("Sınıf mevcudunu Girin : ");
            mevcut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string[] ogrenci = new string[mevcut];

            for (int i = 0; i < mevcut; i++)
            {
                Console.Write("Öğrenci Adını Girin : ");
                ogrenci[i] = Console.ReadLine();
            }
            Console.WriteLine("====================================");
            Console.WriteLine("Öğrenci Mevcudiyet sayısı: " + mevcut);

            Console.ReadKey();
        }
    }
}
