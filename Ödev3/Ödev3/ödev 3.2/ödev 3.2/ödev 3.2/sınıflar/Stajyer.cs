using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_3._2.sınıflar
{
    class Stajyer : Calisan
    {
        public Stajyer()
        {
            Ad = "Pelin";
            Soyad = "Demir";
            Departman = "Staj";
        }
        public override double Maas()
        {
            return 10000.0;
        }
    }
}