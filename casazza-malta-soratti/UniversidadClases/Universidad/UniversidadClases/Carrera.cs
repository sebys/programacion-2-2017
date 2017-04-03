using clases;
using ConsoleApplication21.UniversidadClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    public class Carrera
    {
        public carreras NombreCarrera { get; set; }
        public List<Materia> Materias { get; set; }
        public int TiempoCursado { get; set; }

        public Carrera()
        {
            this.Materias = new List<Materia>();
        }

        public int TotalAlumnos()
        {
            return this.Materias.SelectMany(x => x.Alumnos).Distinct().Count();
        }
    }
}
