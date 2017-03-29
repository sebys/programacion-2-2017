using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descomposicion_universidad
{
    public class Carrera
    {
        public int Años { get; set; }

        public int CargaHoraria { get; set; }

        public string Turno { get; set; }

        public string Coordinador { get; set; }

        public List<Profesor> Profesores { get; set; }
    }
}
