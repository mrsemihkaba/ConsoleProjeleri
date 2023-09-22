using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 6;
            short b = 10;
            sbyte c = 12;
            int d = a + b + c;
            string e = "deneme";
            char f = 'I';
            object g = e + f + d;
            long h = d;
            float i = h;
            double j = i;
            double k = 3.5f;
            Console.WriteLine(j + k);
            Console.ReadKey();
        }
    }
}
