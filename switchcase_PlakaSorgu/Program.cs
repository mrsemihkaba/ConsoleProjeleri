using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase_PlakaSorgu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plaka;
            Console.Write("lütfen plaka bilgisini girin: ");
            plaka = Console.ReadLine();
            switch (plaka)
            {
                case "31 TA 31": Console.Write("murat zindan, TC : 311111111111");
                    break;
                case "Yerli Plaka": Console.Write("Ceza, TC : Gizli Bilgi");
                    break;
                case "34 Coder 34": Console.Write("Semih Kaba, TC: Gizli Bilgi");
                    break;
                default:
                    Console.WriteLine("bu plaka tanınmıyor.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
