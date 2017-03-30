using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descomposicion_universidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno() { Nombre = "Emanuel Stradella"};

            Alumno a2 = new Alumno() { Nombre = "Julio Aguilar"};

            Profesor p = new Profesor()
            {
                Nombre = "Sebis",
                DNI = 00000000
            };

            Profesor p2 = new Profesor()
            {
                Nombre = "Guille",
                DNI = 00000001
            };

            Materia m = new Materia()
            {
                Nombre = "Programación II",
                Titular = p
            };

            m.Alumnos.Add(a1);
            m.Alumnos.Add(a2);

            Materia m2 = new Materia()
            {
                Nombre = "Sistemas Operativos II",
                Titular = p2
            };

            m.Alumnos.Add(a1);
            m.Alumnos.Add(a2);

            Carrera c = new Carrera()
            {
                CargaHoraria = 4080,
                Coordinador = "Dario Karchesky"
            };

            c.Materias.Add(m);
            c.Materias.Add(m2);
            Console.Write("Total de alumnos: " + c.TotalAlumnos());
            Console.ReadKey();
        }
    }
}
