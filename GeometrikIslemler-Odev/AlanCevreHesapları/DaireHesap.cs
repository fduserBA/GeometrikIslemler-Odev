using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikIslemler_Odev.AlanCevreHesapları
{
    class DaireHesapla
    {
        public double AlanHesapla(double YariCap)
        {
            return Math.PI * YariCap * YariCap;
        }
        public double CevreHesapla(double YariCap)
        {
            return 2 * Math.PI * YariCap;
        }
    }
}
