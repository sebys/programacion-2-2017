using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public delegate void MaximoALumnoDelegate(object sender, MaximoAlumnosEventArgs e); //tiene que ser int?

    public class MaximoAlumnosEventArgs : EventArgs
    {

        public String NombreMateria { get; set; }
        public int CantidadAlumnos { get; set; } 
        
        public MaximoAlumnosEventArgs(String nombreMateria, int cantidadAlumnos)
        {
            this.NombreMateria = nombreMateria;
            this.CantidadAlumnos = cantidadAlumnos;
        }
    }
}
