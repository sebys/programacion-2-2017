using clases;
using ConsoleApplication21.UniversidadClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Profesor : Persona
    {
        public int Horas { get; set; }
        public Materia Materias{ get; set; }
        public int Antiguedad { get; set; }
        public double Sueldo { get; set; }
    }
}
