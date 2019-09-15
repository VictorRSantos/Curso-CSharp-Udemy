﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_41
{
    class Triangulo
    {
        public double A;

        public double B;

        public double C;

        //Método para calcular o triângulo
        public double Area()
        {
            double p = (A + B + C) / 2.0;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            
        }





    }
}
