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
        private List<Materia> Materias;
        //private List<Materia> Materias { get { return materias; } }
        //public List<Materia> materias { get; set; } HACER CON VAR. DE INSTANCIA
        public Titulo Titulo { get; set; }

        public Carrera()
        {
            this.Materias = new List<Materia>();
            //this.materias = new List<Materia>();
        }

        public int CantidadAlumnos()
        {
            List<Alumno> alumnosCarrera = new List<Alumno>();
            bool noExiste; //= false;
            foreach (var materia in Materias)
            {
                foreach (var alumno in materia.Alumnos)
                {
                   noExiste = true; //porque va la bandera aca: por si la lista no tiene ningun elemento, no entra por el foreach entonces hace de cuenta que no existe y lo agrega
                    foreach (var alumnoSinRepetir in alumnosCarrera)
                    {
                        //noExiste = item2 != item3;
                        if (alumno == alumnoSinRepetir) //si esta repetido; pongo la bandera y rompo el ciclo para que pase al siguiente de la lista de alumnos ; la logica podria ser inversa preguntando por si son distintos en vez de iguales
                        {
                            noExiste = false;
                            break;
                        }
                        else
                        {
                            noExiste = true;                            
                        }                      
                    }
                    if (noExiste)
                    {
                        alumnosCarrera.Add(alumno);
                    }
                }              
            }
            return alumnosCarrera.Count();
        }

        public void AgregarMaterias(string nombre)
        {
            Materia materia = new Materia();
            materia.Nombre = nombre;
            AgregarMaterias(materia);
        }

        public void AgregarMaterias(Materia materia)
        {
            bool Existe = false;

            foreach (var item in Materias)
            {
                if (item == materia)
                {
                    Existe = true;
                    break;
                }
                else
                {
                    Existe = false;
                }
            }

            if (Existe == false)
            {
                Materias.Add(materia);
            }
            else
            {
                throw new NotSupportedException("No se pueden agregar materias repetidas");
            }
        }

        public int CantidadMaterias()
        {
            int cantidadMaterias = Materias.Count;
            return cantidadMaterias;
        }
    }
}
