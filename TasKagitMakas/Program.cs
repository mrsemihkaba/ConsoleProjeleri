using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taş-Kağıt-Makas Oyunu");

            while (true)
            {
                Console.WriteLine("Seçiminizi yapın: (Taş, Kağıt, Makas, Çıkış)");
                string oyuncuSecimi = Console.ReadLine();

                if (oyuncuSecimi.Equals("Çıkış", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Oyundan çıkılıyor...");
                    break;
                }

                string[] secenekler = { "Taş", "Kağıt", "Makas" };
                Random random = new Random();
                int bilgisayarSecimiIndex = random.Next(secenekler.Length);
                string bilgisayarSecimi = secenekler[bilgisayarSecimiIndex];

                Console.WriteLine("Bilgisayarın Seçimi: " + bilgisayarSecimi);

                if (oyuncuSecimi.Equals(bilgisayarSecimi, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Berabere!");
                }
                else if (
                    (oyuncuSecimi.Equals("Taş", StringComparison.OrdinalIgnoreCase) && bilgisayarSecimi.Equals("Makas", StringComparison.OrdinalIgnoreCase)) ||
                    (oyuncuSecimi.Equals("Kağıt", StringComparison.OrdinalIgnoreCase) && bilgisayarSecimi.Equals("Taş", StringComparison.OrdinalIgnoreCase)) ||
                    (oyuncuSecimi.Equals("Makas", StringComparison.OrdinalIgnoreCase) && bilgisayarSecimi.Equals("Kağıt", StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Kazandınız!");
                }
                else
                {
                    Console.WriteLine("Bilgisayar Kazandı!");
                }
            }
        }    
    }
}
