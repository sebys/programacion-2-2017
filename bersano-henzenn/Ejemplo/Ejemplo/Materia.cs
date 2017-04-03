using System.Collections.Generic;

namespace Ejemplo
{
    public class Materia
    {
        public Materia()
        {
            this.Alumnos = new List<Alumno>();
        }

        public string Nombre { get; set; }

        public List<Alumno> Alumnos { get; set; }
    }
}