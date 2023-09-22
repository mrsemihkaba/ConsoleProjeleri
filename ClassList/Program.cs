using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<kisiler> kisiListesi = new List<kisiler>();
            kisiler yenikisi1 = new kisiler();
            kisiler yenikisi2 = new kisiler();
            kisiler yenikisi3 = new kisiler();

            yenikisi1.Ad = "Ahmet";
            yenikisi1.Soyad = "Can";
            yenikisi1.Telefon = "050555554";

            yenikisi2.Ad = "Ali";
            yenikisi2.Soyad = "Aydın";
            yenikisi2.Telefon = "13213546541";


            yenikisi3.Ad = "Serdar";
            yenikisi3.Soyad = "Kaymaz";
            yenikisi3.Telefon = "875154";

            kisiListesi.Add(yenikisi1);
            kisiListesi.Add(yenikisi2);
            kisiListesi.Add(yenikisi3);

            //Diğer Ekleme Yöntemi
            kisiListesi.Add(new kisiler()
            {
                Ad = "Halil",
                Soyad = "Çan",
                Telefon = "5454545"
            });
            //Listeden Silme
            kisiListesi.Remove(yenikisi3);

            for (int i = 0; i < kisiListesi.Count; i++)
            {
                Console.WriteLine(kisiListesi[i].Ad + "\t" + kisiListesi[i].Soyad + "\t" + kisiListesi[i].Telefon);
            }
            Console.ReadKey();
        }
    }
}
