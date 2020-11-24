using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikIslemler_Odev.Interfaces
{
    interface IUcgen
    {
        //TabanKenar
        //AlanHesapla()
        //CevreHesapla()
        double TabanKenar { get; set; }
        double AlanHesapla(double TabanKenar, double DikKenar = 0);
        double CevreHesapla(double TabanKenar, double DikKenar = 0);
    }
}
