using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Char aranma;
            Console.Write("GTAV Aranma Seviyenizi GİRİNİZ : ");
            aranma = Convert.ToChar(Console.ReadLine());
            if (aranma == '2' || aranma == '1') 
            {
                Console.Write("Acemi Oyuncu");
            }
            else if (aranma == '3')
            {
                Console.Write("Ortlama Oyuncu");
            }
            else if (aranma == '4' || aranma == '5')
            {
                Console.Write("PRof musunnn sennnn ");
            }
            else
            {
                Console.WriteLine("Gerçek Oyuncu DEGİLDİR");
            }
            Console.Read();
        }
    }
}
