using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Rectangulo : Figura
    {
        public double Largo { get; private set; }
        public double Ancho { get; private set; }

        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        override public double CalcularArea()
        {
            return Ancho * Largo;
        }

        override public double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }


        public override string ToString()
        {
            return $"Rectangulo - {CalcularArea():f2} - {CalcularPerimetro():f2}";
        }
    }
}
