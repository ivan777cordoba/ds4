using System;

namespace Laboratorio123
{
    public class Triangulo
    {
        public double CalcularSemiperimetro(double lado1, double lado2, double lado3)
        {
            return (lado1 + lado2 + lado3) / 2.0;
        }

        public double CalcularArea(double lado1, double lado2, double lado3)
        {
            double s = CalcularSemiperimetro(lado1, lado2, lado3);
            return Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
        }

        public bool EsTrianguloValido(double lado1, double lado2, double lado3)
        {
            return (lado1 + lado2 > lado3) &&
                   (lado1 + lado3 > lado2) &&
                   (lado2 + lado3 > lado1) &&
                   (lado1 > 0 && lado2 > 0 && lado3 > 0);
        }
    }
}