using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeometrikIslemler_Odev
{
    class DikDortgenHesap : IDortgen
    {
        public double UzunKenar { get; set; }
        
        public double AlanHesapla(double UzunKenar, double KisaKenar)
        {
            return UzunKenar * KisaKenar;
        }

        public double CevreHesapla(double UzunKenar, double KisaKenar)
        {
            return 2 * (UzunKenar + KisaKenar);
        }
    }
}
