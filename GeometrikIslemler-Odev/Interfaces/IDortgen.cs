using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometrikIslemler_Odev
{
    interface IDortgen
    {
        double UzunKenar { get; set; }
        double AlanHesapla(double UzunKenar, double KisaKenar);
        double CevreHesapla(double UzunKenar, double KisaKenar);
    }
}
