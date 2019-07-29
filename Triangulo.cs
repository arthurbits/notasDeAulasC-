using System;
using System.Collections.Generic;
using System.Text;

namespace Orientado_a_Objetos
{
    class Triangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;
        private double area;

        public double getArea()
        {
            return this.area;
        }


        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;          
            this.area = this.areaTriangulo(ladoA, ladoB, ladoC);
        }
       

        public double areaTriangulo(double ladoA, double ladoB, double ladoC)
        {
            double p = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
            return area;
        }


    }
}
