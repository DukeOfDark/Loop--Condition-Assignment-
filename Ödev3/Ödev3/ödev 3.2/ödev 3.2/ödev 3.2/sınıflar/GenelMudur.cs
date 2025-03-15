using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_3._2.sınıflar
{
    class GenelMudur : Calisan
    {
        public GenelMudur()
        {
            Ad = "Yusuf";
            Soyad = "Aydın";
            Departman = "Yönetim";
        }
        public override double Maas()
        {
            return 45000.0;
        }
    }
}
