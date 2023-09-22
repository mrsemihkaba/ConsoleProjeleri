using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinif
{
    internal class Program
    {
        static void Main(string[] args)
        {
         araba Araba = new araba();
            Araba.marka = "Supra mk4";
            Araba.fiyat = 9999999;
            Console.WriteLine("Araba Listemiz \n");
            Console.WriteLine("araba markası : " + Araba.marka + "\nAraba Fiyatı : " + Araba.fiyat);
            Console.Read();
        
        }
    }
}
