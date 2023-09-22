using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalsayiyiDecimalYapma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hexadecimal sayıyı girin: ");
            string hexString = Console.ReadLine();

            try
            {
                int decimalNumber = Convert.ToInt32(hexString, 16);
                Console.WriteLine("Ondalık sayı: " + decimalNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş!");
            }
            Console.ReadKey();
        }
    }
}
