using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("faktoriyeli alınacak sayıyı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            while(sayi > 1) { faktoriyel = faktoriyel * sayi; sayi--; }
            Console.WriteLine(faktoriyel);
            Console.Read();
        }
    }
}
