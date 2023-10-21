﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double AreaTriangulo()
        {
            double p = (A + B + C) / 2.00;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}
