using Ejercicio1.Models;
using Ejercicio3.Models;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Lista sin ordenar");
            IFigura [] misFiguras = new IFigura[]
            {
                 new Cuadrado(2),
                 new Cuadrado(5),
                 new Rectangulo(5,1),
                 new Circulo(2)
            };
            listBox1.Items.Add("Figura \t Área \t Perímetro");
            foreach (var mis in misFiguras)
            {
                listBox1.Items.Add(mis);
            }

            listBox1.Items.Add("");

            listBox1.Items.Add("Lista ordenada por área");
            listBox1.Items.Add("Figura \t Área \t Perímetro");
            Array.Sort(misFiguras);
            foreach (var fig in misFiguras)
            {
                listBox1.Items.Add(fig);
            }
        }
    }
}
