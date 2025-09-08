namespace Ejercicio1.Models
{
    class Persona : IComparable
    {
        public int DNI {  get; set; }
        public string Nombre {  get; set; }
        
        public Persona (int dni, string nombre)
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }
        
        public string ToString()
        {
            return $"{DNI} : {Nombre}";
        }

        public int CompareTo(object other)
        {
            Persona per = other as Persona;
            if (per != null)
            {
                int personaEsta = this.DNI;
                int personaOtra = per.DNI;
                return personaEsta.CompareTo(personaOtra);
            }
            return 1;

            // De otra forma:
            /*Persona p = obj as Persona;
            if (p != null)
                return DNI.CompareTo(p.DNI);
            return 1;*/
        }
    }
}
