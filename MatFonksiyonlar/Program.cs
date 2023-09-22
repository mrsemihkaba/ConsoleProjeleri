using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatFonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mutlak Değer (Absolute Value)
            double absoluteValue = Math.Abs(-5.5);
            Console.WriteLine("Mutlak Değer: " + absoluteValue);

            // Yuvarlama (Round)
            double roundedValue = Math.Round(3.7);
            Console.WriteLine("Yuvarlanmış Değer: " + roundedValue);

            // Karekök (Square Root)
            double squareRoot = Math.Sqrt(25);
            Console.WriteLine("Karekök: " + squareRoot);

            // Üs Alma (Power)
            double powerValue = Math.Pow(2, 3);
            Console.WriteLine("Üs Alma: " + powerValue);

            // Trigonometrik Fonksiyonlar (Trigonometric Functions)
            double sinValue = Math.Sin(Math.PI / 6); // 30 derece
            double cosValue = Math.Cos(Math.PI / 3); // 60 derece
            double tanValue = Math.Tan(Math.PI / 4); // 45 derece

            Console.WriteLine("Sinüs: " + sinValue);
            Console.WriteLine("Kosinüs: " + cosValue);
            Console.WriteLine("Tanjant: " + tanValue);

            Console.ReadLine();
        }
    }
}
