using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCokBicimlilik
{
    internal class Sekil
    {
        public virtual void Ciz()
        {
            Console.WriteLine("Bir şekil çizildi.");
        }
    }
    // Türetilmiş sınıf (Derived Class)
    class Dikdortgen : Sekil
    {
        public override void Ciz()
        {
            Console.WriteLine("Dikdörtgen çizildi.");
        }
    }

    // Türetilmiş sınıf (Derived Class)
    class Daire : Sekil
    {
        public override void Ciz()
        {
            Console.WriteLine("Daire çizildi.");
        }
    }
}
