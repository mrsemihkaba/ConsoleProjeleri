using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forilesekilyapma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 5; // S harfinin yüksekliği (satır sayısı)

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (i == 0 || i == height - 1 || i == height / 2)
                    {
                        Console.Write("*");
                    }
                    else if (j == 0 && i < height / 2)
                    {
                        Console.Write("*");
                    }
                    else if (j == height - 1 && i > height / 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
