using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.Write("Karakter Girin: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(c + " karakteri ASCII Kaşılığı >> " + Convert.ToInt32(c));
            Console.ReadKey();
        }
    }
}
