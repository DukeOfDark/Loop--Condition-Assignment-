using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_3._2.sınıflar
{
    class Mudur : Calisan
    {
        public Mudur()
        {
            Ad = "Eren";
            Soyad = "Ay";
            Departman = "İnsan Kaynakları";
        }
        public override double Maas()
        {
            return 35000.0;
        }
    }
}
