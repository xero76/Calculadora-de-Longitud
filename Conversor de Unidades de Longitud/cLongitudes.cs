using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversor_de_Unidades_de_Longitud
{
    class cLongitudes
    {
        public double mil_mil(double valor)
        {
            return valor;
        }
        public double mil_cen(double valor)
        {
            return valor/10;
        }
        public double mil_dec(double valor)
        {
            return valor/100;
        }
        public double mil_metr(double valor)
        {
            return valor/1000;
        }
        public double mil_km(double valor)
        {
            return valor/1000000;
        }
        public double cen_mil(double valor)
        {
            return valor*10;
        }
        public double cen_cen(double valor)
        {
            return valor;
        }
        public double cen_dec(double valor)
        {
            return valor / 10;
        }
        public double cen_metr(double valor)
        {
            return valor / 100;
        }
        public double cen_km(double valor)
        {
            return valor / 100000;
        }
        public double dec_mil(double valor)
        {
            return valor * 100;
        }
        public double dec_cen(double valor)
        {
            return valor * 10;
        }
        public double dec_dec(double valor)
        {
            return valor;
        }
        public double dec_metr(double valor)
        {
            return valor/10;
        }
        public double dec_km(double valor)
        {
            return valor / 10000;
        }
        public double metr_mil(double valor)
        {
            return valor * 1000;
        }
        public double metr_cen(double valor)
        {
            return valor*100;
        }
        public double metr_dec(double valor)
        {
            return valor * 10;
        }
        public double metr_metr(double valor)
        {
            return valor;
        }
        public double metr_km(double valor)
        {
            return valor / 1000;
        }
        public double km_mil(double valor)
        {
            return valor*1000000;
        }
        public double km_cen(double valor)
        {
            return valor*100000;
        }
        public double km_dec(double valor)
        {
            return valor*10000;
        }
        public double km_metr(double valor)
        {
            return valor*1000;
        }
        public double km_km(double valor)
        {
            return valor;
        }


    }
}
