using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Profesor:Persona
    {
        public string Titulos { get; set; }
        public int CantidadHoras { get; set; }
        public List<Carrera> Carreras { get; set; }
    }
}
