using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanFonksiyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Geçerli tarih ve saat
            DateTime now = DateTime.Now;
            Console.WriteLine("Geçerli Tarih ve Saat: " + now);

            // Belirli bir tarih ve saat oluşturma
            DateTime customDateTime = new DateTime(2023, 9, 22, 14, 30, 0);
            Console.WriteLine("Belirli Tarih ve Saat: " + customDateTime);

            // Tarih ve saat arasındaki farkı hesaplama
            DateTime futureDate = customDateTime.AddDays(7);
            TimeSpan timeDifference = futureDate - now;
            Console.WriteLine("Belirli Tarih ile Gelecek Tarih Arasındaki Fark: " + timeDifference.Days + " gün " + timeDifference.Hours + " saat");

            // Belirli bir süre eklemek veya çıkarmak
            DateTime newDate = customDateTime.AddHours(2);
            Console.WriteLine("Belirli Saat Eklemiş Tarih: " + newDate);

            // Zaman damgası oluşturma
            DateTime timeStamp = DateTime.Now;
            Console.WriteLine("Zaman Damgası: " + timeStamp.ToString("yyyy-MM-dd HH:mm:ss"));

            Console.ReadLine(); 
        }
    }
}
