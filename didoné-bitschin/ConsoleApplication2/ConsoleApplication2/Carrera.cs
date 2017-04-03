using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public enum Tipo {pregrado, grado, posgrado}

    public class Carrera
    {
        //jefe carrera
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Tipo Tipo { get; set; }
        public List<Materia> Materias { get; set; }
        public Titulo Titulo { get; set; }

        public Carrera()
        {
            this.Materias = new List<Materia>();
        }

        public int CantidadAlumnos ()
        {
            List<Alumno> alumnosCarrera = new List<Alumno>();
            bool noExiste = false;
            foreach (var item in Materias)
            {
                foreach (var item2 in item.Alumnos)
                {
                    noExiste = true;
                    foreach (var item3 in alumnosCarrera)
                    {
                        //noExiste = item2 != item3;
                        if (item2 != item3)
                        {
                            noExiste = true;
                        }
                        else
                        {
                            noExiste = false;
                            break;
                        }                      
                    }
                    if (noExiste)
                    {
                        alumnosCarrera.Add(item2);
                    }
                }              
            }
            return alumnosCarrera.Count();
        }
    }
}
