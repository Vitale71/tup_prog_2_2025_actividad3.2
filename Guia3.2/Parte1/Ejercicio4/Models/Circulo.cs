using Ejercicio3.Models;
using Ejercicio4.Models;

namespace Ejercicio1.Models
{
    class Circulo : Figura
    {
        public double Radio {  get; private set; }

        public Circulo(double radio) 
        { 
            Radio = radio;
        }

        override public double CalcularArea() 
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        override public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override string ToString()
        {
            return $"Circulo - {CalcularArea():f2} - {CalcularPerimetro():f2}";
        }

        override public int CompareTo(object obj)
        {
            Figura fig = obj as Figura;
            if (fig != null)
            {
                double areaEsta = this.CalcularArea();
                double areaFig = fig.CalcularArea();
                return areaEsta.CompareTo(areaFig);
            }
            return 1;
        }
    }
}
