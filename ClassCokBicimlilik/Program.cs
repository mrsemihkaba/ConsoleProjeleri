using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCokBicimlilik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sekil sekil1 = new Dikdortgen();
            sekil1.Ciz(); // Dikdörtgen sınıfının Ciz metodu çağrılır

            Sekil sekil2 = new Daire();
            sekil2.Ciz(); // Daire sınıfının Ciz metodu çağrılır

            Console.ReadLine();
        }
    }
}
