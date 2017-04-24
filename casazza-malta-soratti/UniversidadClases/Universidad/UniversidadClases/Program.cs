using ConsoleApplication21;
using ConsoleApplication21.UniversidadClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public enum carreras
    {
        Ingenieria, Abogacia, Contaduria, Psicologia
    }


    class Program
    {
        static void Materia_OnAlumnos(object sender, MateriasEventArgs e, List<Alumno> Alumnos)
        {
            int band = 0;
            foreach (Alumno item in Alumnos)
            {
                    if (item.Nombre == e.alumno.Nombre)
                    {
                         Console.WriteLine("Esta repetido gato");
                         band = 1;
                    }
                }
            if (band == 0)
            {
                Console.WriteLine("No esta repetido gato");
            }
            

        }

        static void Main(string[] args)
        {
            Carrera carrera = new Carrera();
            carrera.AgregarMateria(new Materia { Nombre = "M1" });
            Materia materia = new Materia();
            Alumno alumno = new Alumno();
            alumno.Nombre = "Nico";
            materia.AgregarAlumnos(alumno);
            materia.OnAlumnos += new DelegadosMaterias(Materia_OnAlumnos);
            materia.AgregarAlumnos(alumno);
            
           

            Console.ReadLine();

        }


    }

}


