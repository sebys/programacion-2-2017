using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    class Carrera
    {
        public List<Materia> Materia { get; set; }
        public string TituloCarrera { get; set; }
        public List<string> TituloMedio { get; set; }
        
        public int CantidadAlumnos()
        {
            int totalAlum = 0;
            foreach (var c in Materia)
            {
                totalAlum = c.Alumnos.Count();
            }
            return totalAlum;
        }
    }

}
