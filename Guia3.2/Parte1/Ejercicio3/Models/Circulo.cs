using Ejercicio3.Models;

namespace Ejercicio1.Models
{
    class Circulo : IFigura, IComparable
    {
        public double Radio {  get; private set; }

        public Circulo(double radio) 
        { 
            Radio = radio;
        }

        public double CalcularArea() 
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override string ToString()
        {
            return $"Circulo - {CalcularArea():f2} - {CalcularPerimetro():f2}";
        }

        public int CompareTo(object obj)
        {
            IFigura fig = obj as IFigura;
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
