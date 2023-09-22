using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kontrol = 0;
            int sayac = 0;
            for (int i = 2; i <= 1000000; i++)
            {
                kontrol = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        kontrol++;
                        break;
                    }
                }
                if (kontrol == 0)
                {
                    sayac++;
                    Console.Write(i + "-");
                }

            }
            Console.WriteLine();
            Console.WriteLine("{0} adet asal sayı bulundu.", sayac);
            Console.ReadKey();
        }
    }
}
