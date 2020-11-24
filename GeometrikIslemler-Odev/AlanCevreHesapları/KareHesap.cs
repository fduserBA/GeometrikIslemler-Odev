using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikIslemler_Odev.AlanCevreHesapları
{
    class KareHesap : IDortgen
    {
        public double UzunKenar { get; set; }

        public double AlanHesapla(double UzunKenar, double KisaKenar = 0)
        {
            return UzunKenar * UzunKenar;
        }

        public double CevreHesapla(double UzunKenar, double KisaKenar = 0)
        {
            return 4 * UzunKenar;
        }
    }
}
