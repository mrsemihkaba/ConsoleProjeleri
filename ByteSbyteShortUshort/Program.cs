using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteSbyteShortUshort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte byteVariable = 100;
            Console.WriteLine("Byte Değişken Değeri: " + byteVariable);

            sbyte sbyteVariable = -50;
            Console.WriteLine("Sbyte Değişken Değeri: " + sbyteVariable);

            short shortVariable = 15000;
            Console.WriteLine("Short Değişken Değeri: " + shortVariable);

            ushort ushortVariable = 60000;
            Console.WriteLine("Ushort Değişken Değeri: " + ushortVariable);

            byte byteValue = 200;
            ushort ushortValue = byteValue;
            Console.WriteLine("Dönüştürülen Ushort Değeri: " + ushortValue);

            int intValue = 500;
            byte byteValue2 = (byte)intValue;
            Console.WriteLine("Değer Kaybı Olan Byte Değeri: " + byteValue2);

            Console.ReadLine();
        }
    }
}
