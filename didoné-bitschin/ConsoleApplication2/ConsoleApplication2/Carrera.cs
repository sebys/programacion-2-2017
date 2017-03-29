using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    enum Tipo {pregrado, grado, posgrado}

    class Carrera
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Tipo Tipo { get; set; }
        public List<Materia> Materias { get; set; }
        public Titulo Titulo { get; set; }
    }
}
