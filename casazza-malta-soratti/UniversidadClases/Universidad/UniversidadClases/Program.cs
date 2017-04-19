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
        static void Materia_OnAlumnos(object sender, MateriasEventArgs e)
        {
            Console.WriteLine("Nombre: {0}, Alumnos: {1}", e.NombreMateria, e.CantAlumnos);
        }

        static void Main(string[] args)
        {
            Carrera carrera = new Carrera();
            carrera.AgregarMateria(new Materia { Nombre = "M1" });
            Materia materia = new Materia();
            for (int i = 0; i < 10; i++)
            {
                Alumno alumno = new Alumno();
                materia.Alumnos.Add(alumno);
            }
            
            materia.OnAlumnos += new DelegadosMaterias(Materia_OnAlumnos);
            materia.ContarAlumnos(materia.Alumnos);
            Console.ReadLine();

        }


    }

}


