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
        static void Main(string[] args)
        {
            Carrera carrera = new Carrera();
            carrera.AgregarMateria(new Materia {Nombre = "M1" });
            Console.WriteLine(Convert.ToString(carrera.CantidadMaterias()));
            Console.ReadLine();
        }
    }
}
