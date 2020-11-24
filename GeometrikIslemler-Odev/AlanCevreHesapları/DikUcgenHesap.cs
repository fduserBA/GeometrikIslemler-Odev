using GeometrikIslemler_Odev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikIslemler_Odev.AlanCevreHesapları
{
    class DikUcgenHesap : IUcgen
    {
        public double TabanKenar { get; set; }

        public double AlanHesapla(double TabanKenar, double DikKenar)
        {
            return TabanKenar * DikKenar / 2;
        }

        public double CevreHesapla(double TabanKenar, double DikKenar)
        {
            return TabanKenar + DikKenar + (2 * TabanKenar);
        }
    }
}
