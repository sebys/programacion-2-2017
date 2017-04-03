using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    
    public class Carrera
    {
        public List<Materia> Materia { get; set; }
        public string TituloCarrera { get; set; }
        public List<string> TituloMedio { get; set; }
        public Carrera()
        {
            Materia = new List<Materia>();
        }
        public int CantidadAlumnos()
        {
            int totalAlum = 0;
            foreach (var c in Materia)
            {
                totalAlum = totalAlum + c.Alumnos.Count();
            }
            return totalAlum;
        }

        /*public int CantidadAlumnosNoRepetidos()
        {
            int totalAlum = 0;

        }*/
    }

}
