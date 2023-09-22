using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;

namespace NetworkControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Ipadress;
            Console.WriteLine("Kendi ağınız çalışıyor mu diye kontrol ediyorsanız 8.8.8.8'e ping atabilirsiniz.");
            Console.Write("ip adresini girin :");
            Ipadress = Console.ReadLine();
            Ping ping = new Ping();
            PingReply pingDurumu = ping.Send(IPAddress.Parse(Ipadress));

            if (pingDurumu.Status == IPStatus.Success)
            {
                Console.WriteLine("bağlantı var");
            }
            else
            {
                Console.WriteLine("bağlantı yok");
            }
            Console.ReadKey();
        }
    }
}
