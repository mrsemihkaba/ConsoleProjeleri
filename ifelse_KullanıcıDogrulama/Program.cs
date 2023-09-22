using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_KullanıcıDogrulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim, pass;
            Console.Write("Isminizi Girin: ");
            isim = Console.ReadLine();
            Console.Write("Parolanızı Girin: ");
            pass = Console.ReadLine();
            if (isim == "semih" && pass == "pass")
            {
                Console.WriteLine("hoşgeldin, " + isim);
            }
            else
            {
                Console.WriteLine("Yalnış oturum bilgileri lütfen tekrar dene !");
            }
            Console.ReadKey();
        }
    }
}
