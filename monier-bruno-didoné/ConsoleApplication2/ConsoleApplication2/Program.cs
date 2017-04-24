using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Materia materia = new Materia();
            materia.Nombre = "Programación 2";
            materia.OnMaximoAlumno += new MaximoALumnoDelegate(Materia_OnMaximoAlumno);

            //AGREGO ALUMNOS
            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Lucas";
            materia.Alumnos.Add(alumno1);
            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Juan";
            materia.Alumnos.Add(alumno2);
            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Pedro";
            materia.Alumnos.Add(alumno3);

            Console.ReadLine();

        }

        private static void Materia_OnMaximoAlumno1(object sender, MaximoAlumnosEventArgs e)
        {
            Console.WriteLine("La assasasa materia {0} superó el máximo {1} de alumnos , su cantidad de alumnos es: {2} ", sender, Materia.MaxAlumno, e.CantidadAlumnos);
        }

        private static void Materia_OnMaximoAlumno(object sender, MaximoAlumnosEventArgs e)
        {
            Console.WriteLine("La materia {0} superó el máximo {1} de alumnos , su cantidad de alumnos es: {2} ", sender, Materia.MaxAlumno, e.CantidadAlumnos);
        }

    }
}
