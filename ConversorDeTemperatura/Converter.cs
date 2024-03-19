using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeTemperatura
{
    class Converter
    {
        public static double F_para_C(double F)
        {
            return (F - 32) * 5 / 9;
        }

        public static double C_para_F(double C)
        {
            return (C * 9 / 5) + 32;
        }

        public static double C_para_K(double C)
        {
            return C + 273.15;
        }

        public static double K_para_C(double K)
        {
            return K - 273.15;
        }

        public static double K_para_F(double K)
        {
            var celsius = K_para_C(K);
            var fahrenheit = C_para_F(celsius);
            return fahrenheit;
        }

        public static double F_para_K(double F)
        {
            var celsius = F_para_C(F);
            var kelvin = C_para_K(celsius);
            return kelvin;
        }
    }
}

