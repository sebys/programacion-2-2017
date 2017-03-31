using clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Alumno : Persona
    {
        public Carrera carrera { get; set; }
        public int asistencias { get; set; }
    }
}
