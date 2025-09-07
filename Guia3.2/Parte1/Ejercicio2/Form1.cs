using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Figura \t Área \t Perímetro");
            IFigura[] misFiguras = new IFigura[]
            {
                 new Cuadrado(2),
                 new Cuadrado(5),
                 new Rectangulo(5,1),
                 new Circulo(2)
            };
            foreach (var mis in misFiguras)
            {
                listBox1.Items.Add(mis);
            }
        }
    }
}
