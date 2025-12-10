using System;

namespace Laboratorio121
{
    public class Distancia
    {
        // Método para calcular distancia = velocidad * tiempo
        public double CalcularDistancia(double velocidad, double tiempo)
        {
            return velocidad * tiempo;
        }

        // Método para validar que los valores sean positivos
        public bool ValidarDatos(double velocidad, double tiempo)
        {
            return velocidad > 0 && tiempo > 0;
        }
    }
}