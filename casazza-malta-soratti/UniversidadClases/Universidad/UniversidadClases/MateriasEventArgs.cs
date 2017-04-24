using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21.UniversidadClases
{
    public class MateriasEventArgs
    {
        public Alumno alumno { get; set; }
        public MateriasEventArgs(Alumno agregaralumno)
        {
            this.alumno = agregaralumno;
        }
    }
}
