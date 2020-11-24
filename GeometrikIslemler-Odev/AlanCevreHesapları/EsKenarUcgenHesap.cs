using GeometrikIslemler_Odev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikIslemler_Odev.AlanCevreHesapları
{
    class EsKenarUcgenHesap : IUcgen
    {
        public double TabanKenar { get; set; }

        public double AlanHesapla(double TabanKenar, double DikKenar = 0)
        {
            DikKenar = TabanKenar / 2 * Math.Sqrt(3);
            return TabanKenar * DikKenar / 2;
        }

        public double CevreHesapla(double TabanKenar, double DikKenar = 0)
        {
            return 3 * TabanKenar;
        }
    }
}
