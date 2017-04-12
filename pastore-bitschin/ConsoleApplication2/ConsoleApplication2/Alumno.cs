using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Alumno:Persona
    {
        public bool EstadoContable { get; set; }
        public int CantidadDeMateriasAprobadas { get; set; }
        public int CantidadDeMateriasRegulares { get; set; }
        public int HistorialDeMaterias { get; set; }
    }
}
