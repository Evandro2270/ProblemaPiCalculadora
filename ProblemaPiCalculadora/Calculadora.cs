﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaPiCalculadora
{
    internal class Calculadora
    {

        public double Pi = 3.14;
        public double circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0); // return 4.0 / 3.0 * Pi *r * r * r;
        }
    }
}
