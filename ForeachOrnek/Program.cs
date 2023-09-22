using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var isimler = new List<string>() { "Hayri", "Ufuk", "Recep" };
            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }

            Console.ReadKey();
        }
    }
}
