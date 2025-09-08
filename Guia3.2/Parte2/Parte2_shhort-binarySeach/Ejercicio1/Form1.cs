using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List <Persona> personas = new List<Persona>()
            {
                new Persona(4343324, "Julia"),
                new Persona(4654879, "Eduardo"),
                new Persona(2015635, "Manu"),
                new Persona(3521056, "Lucas")
            };
            lbMostrar.Items.Add("Lista desordenada");
            foreach (Persona per in personas)
            {
                lbMostrar.Items.Add(per.ToString());
            }
            lbMostrar.Items.Add("");
            lbMostrar.Items.Add("Lista ordenada");
            personas.Sort();
            foreach (Persona per in personas)
            {
                lbMostrar.Items.Add($"{per.ToString()}");
            }
            int buscado = 3521056;
            lbMostrar.Items.Add("");
            lbMostrar.Items.Add($"Buscando: {buscado}");
            Persona buscar = new Persona (buscado, "");
            int idx = personas.BinarySearch(buscar);
            if (idx > -1)
            {
                Persona p1 = personas[idx] as Persona;
                lbMostrar.Items.Add(p1.ToString());
            }
            else
            {
                lbMostrar.Items.Add("Lista ordenada");
            }

            int noEncontrado = 3525134;
            lbMostrar.Items.Add("");
            lbMostrar.Items.Add($"Buscando: {noEncontrado}");
            int idx2 = personas.BinarySearch(new Persona(noEncontrado, ""));
            if (idx2 > -1)
            {
                Persona p2 = personas[idx2] as Persona;
                lbMostrar.Items.Add(p2.ToString());
            }
            else
            {
                lbMostrar.Items.Add("No encontrado");
            }

            //Otra forma de busqueda mas facil es crear otro constructor de persona pero solamente con DNI
            // y contener una sentencia asi
            /*
            int dni = 3521056;
            lbMostrar.Text.Add($"Buscando: {dni}");
            int idx1 = lista.BinarySearch(new Persona(dni));
            if (idx1 >= 0)
            {
                Persona p = personas[idx] as Persona;
                lbMostrar.Items.Add(personas[idx].ToString());
            }
            else
            {
                lbMostrar.Items.Add("No encontrado");
            }*/
        }
    }
}
