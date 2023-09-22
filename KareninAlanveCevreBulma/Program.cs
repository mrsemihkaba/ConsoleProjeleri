using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareninAlanveCevreBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kenar, karealan, karecevre, kisakenar, uzunkenar, dikalan, dikcevre;

            Console.Write("Karenin bir kenarını girin:  ");
            kenar = Convert.ToInt32(Console.ReadLine());
            karealan = kenar * kenar;
            karecevre = kenar * 4;
            Console.WriteLine("kare alan: {0}\nkare çevre: {1}",karealan, karecevre);
            Console.Write("kısa kenarı girin: ");
            kisakenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("uzun kenarı girin: ");
            uzunkenar = Convert.ToInt32(Console.ReadLine());
            dikalan = kisakenar * uzunkenar;
            dikcevre = kisakenar * 2 + uzunkenar * 2;
            Console.WriteLine("Diktörtgen Alan: {0}\nDiktortgen Çevre: {1}",dikalan,dikcevre);
            Console.ReadKey();

        }
    }
}
