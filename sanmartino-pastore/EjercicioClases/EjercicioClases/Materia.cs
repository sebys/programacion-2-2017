using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    public class Materia
    {
        public Materia()
        {
            Alumnos = new List<Alumno>();
        }
        public string NombreMateria { get; set; }
        public List<Materia> CorrelativasDebiles { get; set; }
        public List<Materia> CorrelativasFuertes { get; set; }
        public int CantidadHoras { get; set; }
        public Profesor Profesores { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Horario HorarioMateria { get; set; }       
    }
}
