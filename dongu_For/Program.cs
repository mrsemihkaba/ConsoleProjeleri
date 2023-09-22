using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dongu_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, toplam = 0;
            for (i = 1; i <= 10; i += 2)
            {
                toplam = toplam + i;
            }
            Console.WriteLine("toplam: " + toplam);
            Console.Read();
        }
    }
}
