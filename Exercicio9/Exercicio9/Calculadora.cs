﻿

namespace Exercicio9
{
    internal class Calculadora
    {
        public static double pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2 * pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * pi * Math.Pow(r, 3);
        }

    }
}
