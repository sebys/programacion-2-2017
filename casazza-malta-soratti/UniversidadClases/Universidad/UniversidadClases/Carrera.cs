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

        public void AgregarMateria(Materia materia)
        {
            int enc = 0;
            foreach (Materia item in Materias)
            {
                if (item.Nombre == materia.Nombre)
                {
                    enc = 1;
                    
                }
            }
            if (enc == 0)
            {
                Materias.Add(materia);
            }
            else
            {
                throw new NotSupportedException("No se puede agregar un objeto duplicado.");
            }
    
        
        }

    public int TotalAlumnos()
        {
            return this.Materias.SelectMany(x => x.Alumnos).Distinct().Count();
        }
    }
}
