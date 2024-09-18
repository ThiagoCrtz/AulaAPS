using System;

namespace AulaAPS
{
    public class Circunferencia : FormaGeometrica
    {
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public override double CalcularArea()
        {
            return (Math.PI * Math.Pow(raio, 2));
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }
        public override string ToString()
        {
            return $"Circuferência ({raio})";
        }
    }
}
