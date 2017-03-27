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
        }
    }

    class Direccion
    {
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string Calle { get; set; }
        public int Telefono { get; set; }

    }

    class Persona
    {
        public Direccion Direccion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

    }

    class Año
    {
        public List<String> Materias { get; set; }

    }

    class Carrera
    {
        public string JefeCatedra { get; set; }
        public List<Año> MateriasAño { get; set; }

    }
    class Materia
    {
        public string Nombre { get; set; }
        public string Condicion { get; set; }
        public string Horarios { get; set; }
    }
    class Alumno: Persona
    {
        public string Carrera { get; set; }
        public List<Materia> MateriasCursadas { get; set; }
         

    }

    class Profesor: Persona
    {
        public List<Materia> MateriasDictadas { get; set; }

    }
}
