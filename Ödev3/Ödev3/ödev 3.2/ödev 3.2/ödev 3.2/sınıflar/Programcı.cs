using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_3._2.sınıflar
{
    class Programci : Calisan
    {
        public Programci()
        {
            Ad = "Bilal";
            Soyad = "Çelik";
            Departman = "Yazılım";
        }
        public override double Maas()
        {
            return 25000.0;
        }
    }
}
