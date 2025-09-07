using Ejercicio3.Models;
using System.Security.Policy;

namespace Ejercicio4.Models
{
    abstract public class Figura : IFigura, IComparable
    {
        abstract public double CalcularArea();
        abstract public double CalcularPerimetro();
        abstract public int CompareTo(object obj);
    }
}
