namespace Laboratorio122
{
    public class Promedio
    {
        public double CalcularPromedio(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3.0;
        }

        public string ObtenerEstado(double promedio)
        {
            if (promedio >= 6.0)
                return "APROBADO";
            else
                return "REPROBADO";
        }
    }
}