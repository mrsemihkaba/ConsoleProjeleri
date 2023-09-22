using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    internal class Program
    {
        static void arttir(out int s)
        {
            s = 12;
            s++;
        }
        static void Main(string[] args)
        {
            int a;
            arttir(out a);
            Console.Write(a);
            Console.Read();
        }
    }
}
