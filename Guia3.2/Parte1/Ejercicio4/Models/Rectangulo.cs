using Ejercicio3.Models;
using Ejercicio4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Rectangulo : Figura
    {
        public double Largo { get; private set; }
        public double Ancho { get; private set; }

        public Rectangulo (double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        override public double CalcularArea()
        {
            return Ancho*Largo;
        }

        override public double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }

        override public int CompareTo(object obj)
        {
            Figura fig = obj as Figura;
            if (fig != null)
            {
                double areaEsta = this.CalcularArea();
                double areaFig = fig.CalcularArea();
                return areaEsta.CompareTo(areaFig);

                //de forma equivalente
                //return this.CalcularArea().CompareTo(fig.CalcularArea());
            }
            return 1;
        }

        public override string ToString()
        {
            return $"Rectangulo - {CalcularArea():f2} - {CalcularPerimetro():f2}";
        }
    }
}
