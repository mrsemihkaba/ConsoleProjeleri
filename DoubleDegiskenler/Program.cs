using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sinav1, sinav2, proje, ort;
            Console.WriteLine("öğrenci sınav not hesaplama");
            Console.Write("1.sınav bilgisini gir : ");
            sinav1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.sınav bilgisini gir : ");
            sinav2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Proje Not bilgisini gir : ");
            proje = Convert.ToDouble(Console.ReadLine());
            ort = (sinav1 + sinav2 + proje) / 3;
            Console.WriteLine("ortalamanız : " + ort);
            Console.ReadKey();
        }
    }
}
