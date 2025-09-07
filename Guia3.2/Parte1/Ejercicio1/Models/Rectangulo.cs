using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Rectangulo : IFigura
    {
        public double Largo { get; private set; }
        public double Ancho { get; private set; }

        public Rectangulo (double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public double CalcularArea()
        {
            return Ancho*Largo;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }


        public override string ToString()
        {
            return $"Rectangulo - {CalcularArea():f2} - {CalcularPerimetro():f2}";
        }
    }
}
