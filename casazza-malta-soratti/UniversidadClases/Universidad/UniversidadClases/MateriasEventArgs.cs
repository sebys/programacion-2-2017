using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21.UniversidadClases
{
    public class MateriasEventArgs
    {
        public string NombreMateria { get; set; }
        public int CantAlumnos { get; set; }

        public MateriasEventArgs(string Nombre, int Alumnos)
        {
            this.CantAlumnos = Alumnos;
            this.NombreMateria = Nombre;
        }
    }
}
