using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomkomutu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rasgele = new Random();
            Console.WriteLine("rastgele şehir programı\n");
            string[] sehirler = {" istanbul", "ankara", "izmir", "bursa", "kastamonu", "şanlıurfa", "malatya","mersin "};
            int a = rasgele.Next(0, sehirler.Length);
            Console.Write("rastgele gelen şehir : " + sehirler[a]);
            Console.Read();
        }
    }
}
