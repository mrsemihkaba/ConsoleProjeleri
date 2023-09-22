using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHeapBoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object o = 11;
            int i = Convert.ToInt32(o);
            Console.Write(o);
            Console.ReadKey();
        }
    }
}
