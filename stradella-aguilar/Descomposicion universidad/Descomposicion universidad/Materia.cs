using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descomposicion_universidad
{
    public class Materia
    {
        public string Nombre { get; set; } = "";

        public List<Alumno> Alumnos { get; set; } = new List<Alumno>();

        public Profesor Titular { get; set; } = new Profesor();

        public int TotalAlumnos()
        {
            int total = Alumnos.Count;

            return total;
        }

        public List<Alumno> RetornarAlumnos()
        {
            return Alumnos;
        }
    }
}
