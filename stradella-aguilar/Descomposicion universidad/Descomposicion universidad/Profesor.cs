using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descomposicion_universidad
{
    public class Profesor
    {
        public List<Carrera> Carreras { get; set; }

        public List<string> Materias { get; set; }

        public int DNI { get; set; }

        public List<Aula> AulasAsignadas { get; set; }

        public int LoQueSea { get; set; }
    }
}
