using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tersyazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String metin;
            Console.Write("Tersten Yazılacak Metni Giriniz = ");
            metin = Console.ReadLine();
            for (int i = 0; i <= metin.Length - 1; i++)
            {
                Console.Write(metin[metin.Length - i - 1]);
            }
            Console.ReadLine();
        }
    }
}
