using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    public class Carrera
    {
        public Carrera()
        {            
            this.Materias = new List<Materia>();
        }

        public string Nombre { get; set; }

        public List<Materia> Materias { get; set; }

        public int TotalAlumnos
        {            
            get
            {
                return this.Materias.SelectMany(x => x.Alumnos).Distinct().Count();
            }
        }
    }
}
