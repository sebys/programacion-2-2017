using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            var carrera = new Carrera();
            carrera.Nombre = "Ingeniería en Computación";
            //carrera.Materias = new List<Materia>();

            var materia1 = new Materia();
            materia1.Nombre = "Programación II";
            //materia1.Alumnos = new List<Alumno>();

            var materia2 = new Materia();
            materia2.Nombre = "Programación II";
            //materia2.Alumnos = new List<Alumno>();

            var alumno1 = new Alumno();
            alumno1.Nombre = "Juan Perez";

            var alumno2 = new Alumno();
            alumno2.Nombre = "Jose Perez";

            materia1.Alumnos.Add(alumno1);
            materia1.Alumnos.Add(alumno2);
            materia2.Alumnos.Add(alumno1);

            carrera.Materias.Add(materia1);
            carrera.Materias.Add(materia2);

            Console.WriteLine(carrera.TotalAlumnos);
            Console.ReadLine();
        }
    }
}
