using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İfelse_TumOperatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            int sayi;
            Console.WriteLine("if else tüm operatörlerine hoşgeldiniz");
            Console.Write("bir sayı girin : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 10) { Console.WriteLine("tebrikler birinci koşul sağlandı"); }
            else if (sayi > 10) { Console.WriteLine("tebrikler ikinci koşul sağlandı"); }
            else if (sayi >= 10) { Console.WriteLine("tebrikler üçüncü koşul sağlandı"); }
            else if (sayi < 10) { Console.WriteLine("tebrikler dördüncü koşul sağlandı"); }
            else if (sayi <= 10) { Console.WriteLine("tebrikler beşinci koşul sağlandı");}
            else if (sayi % 2 == 0) {Console.WriteLine("tebrikler altıncı koşul sağlandı"); }
            else if (sayi > 2 || 3 < sayi) { Console.WriteLine("tebrikler yedinci koşul sağlandı"); }
            else if (sayi < 0 && sayi > 1) { Console.WriteLine("tebrikler sekizinci koşul sağlandı"); }
            else { Console.WriteLine("hiçbir koşul sağlanmadı"); }

            Console.WriteLine("not : burada koşulların birbirine öncü olarak geçtiğini görebilirsiniz // işareti ile koşulları eleyebilirsiniz");
            Console.ReadLine();
        }
    }
}
