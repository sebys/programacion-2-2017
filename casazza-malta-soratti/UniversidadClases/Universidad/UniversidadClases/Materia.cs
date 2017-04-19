using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21.UniversidadClases
{
    public delegate void DelegadosMaterias(object sender, MateriasEventArgs e);
    public class Materia
    {
        

        public event DelegadosMaterias OnAlumnos;

        public string Nombre { get; set; }
        public int CantidadHoras { get; set; }
        public List<Alumno> Alumnos { get; set; }

        public Materia()
        {
            Alumnos = new List<Alumno>();
        }

        public Materia(List<Materia> materias) :this() 
        {            
            foreach (var item in materias)
            {
                materias.Add(item);
            }
        }


        public void ContarAlumnos(List<Alumno> alumnos)
        {
            if (alumnos.Count > 5)
            {
                if (OnAlumnos != null)
                {
                    OnAlumnos(this, new MateriasEventArgs(Nombre, alumnos.Count));
                }
                   
            }
          
        }
    }
}
