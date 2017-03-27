using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Materia
    {
        public string Nombre { get; set; }
        public List<Materia> CorrelativasDebiles { get; set; }
        public List<Materia> CorrelativasFuertes { get; set; }
        public int CantidadHoras { get; set; }
        public List<Profesor> profesores{ get; set; }
        public List<Alumno> alumnos { get; set; }
        public Horario horario { get; set; }
    }
}
