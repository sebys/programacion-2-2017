using clases;
using ConsoleApplication21.UniversidadClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Carrera
    {
        public carreras NombreCarrera { get; set; }
        public List<Materia> Materias { get; set; }
        public int TiempoCursado { get; set; }

        public int TotalAlumnos()
        {
            int TotalA = 0;
            foreach (var item in Materias)
            {
                TotalA = TotalA + item.Alumnos.Count();
            }

            return TotalA;

        }
    }
}
