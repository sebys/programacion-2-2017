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

    public class Direccion
    {
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string Calle { get; set; }
        public int Telefono { get; set; }

    }

    public enum DepartamentosAcademicos { Santiago, Rafaela, Olivos, Jujuy}

    public class universidad
    {
        public List<DepartamentosAcademicos> Departamentos { get; set; }
    }

    public class Persona
    {
        public Direccion DireccionPersona { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

    }

    public class Año
    {
        public List<Materia> Materias { get; set; }

    }
    
    public class Carrera
    {

        public string JefeCatedra { get; set; }
        public List<Año> MateriasAño { get; set; }
        public int AñosCursado { get; set; }
        public List<DepartamentosAcademicos> DepartamentosCursado { get; set; }
        public List<string> Titulos { get; set; }
        
        public int TotalAlumnos()
        {
            bool Existe = false;
            List<Alumno> AlumnosTotales = new List<Alumno>();

            foreach (var Año in this.MateriasAño)
            {
                foreach (var Materia in Año.Materias)
                {
                    foreach (var item2 in Materia.Alummnos)
                    {
                        foreach (var item in AlumnosTotales)
                        {
                            if (item.Nombre==item2.Nombre)
                            {
                                Existe = true;
                            }
                        }
                        if (Existe == false)
                        {
                            AlumnosTotales.Add(item2);
                        }
                    }
                }
            }
            return AlumnosTotales.Count;
        }
    }
    public class Materia
    {
        public string Nombre { get; set; }
        public string Condicion { get; set; }
        public string Horarios { get; set; }
        public List<Materia> CorrelativasFuertes { get; set; }
        public List<Materia> CorrelativasDebiles { get; set; }
        public List<Alumno> Alummnos { get; set;}
        public bool RendirLibre { get; set; }
        public bool Promocionar { get; set; }

    }

    public class Alumno : Persona
    {
        public string Carrera { get; set; }
        public List<Materia> MateriasCursadas { get; set; }

    }

    public class Profesor : Persona
    {
        public List<Materia> MateriasDictadas { get; set; }
        public List<string> Titulos { get; set; }
        public int Antiguedad { get; set; }
        public List<string> Trabajos { get; set; }
        public int HorasSemanales { get; set; }


    }
}