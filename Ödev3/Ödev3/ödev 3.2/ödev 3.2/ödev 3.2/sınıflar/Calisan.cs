using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_3._2.sınıflar
{
    abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        public abstract double Maas();  

        public void BilgileriYaz()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Departman: {Departman}, Maaş: {Maas():C}");
        }
    }

}