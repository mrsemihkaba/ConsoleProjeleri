using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            bool isFalse = false;

            if (isTrue)
            {
                Console.WriteLine("isTrue doğru (true) değerini taşıyor.");
            }
            else
            {
                Console.WriteLine("isTrue yanlış (false) değerini taşıyor.");
            }

            if (isFalse)
            {
                Console.WriteLine("isFalse doğru (true) değerini taşıyor.");
            }
            else
            {
                Console.WriteLine("isFalse yanlış (false) değerini taşıyor.");
            }

            bool a = true;
            bool b = false;

            bool result1 = a && b;
            bool result2 = a || b;
            bool result3 = !a;

            Console.WriteLine("AND İşlemi Sonucu: " + result1);
            Console.WriteLine("OR İşlemi Sonucu: " + result2);
            Console.WriteLine("NOT İşlemi Sonucu: " + result3);

            Console.ReadLine();
        }
    }
}
