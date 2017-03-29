using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public enum carreras
    {
        ingenieria, abogacia, turismo
    }

    public class Materia
    {
        public string nombremateria { get; set; }
        public int canthoras { get; set; }
        public bool promocion { get; set; }
    }

    public class InformacionPersonal
    {
        public string direccion { get; set; }
        public string nombre { get; set; }
        public int telefono { get; set; }
        public int edad { get; set; }
    }


    public class Persona
    {
        public InformacionPersonal informacion { get; set; }
        public double buenaconducta { get; set; }
    }


    public class Alumno : Persona
    {
        public Carrera carrera { get; set; }
        public int asistencias { get; set; }
    }

    class Profesor : Persona
    {
        public int canthorasdadas { get; set; }
        public Carrera carrera { get; set; }
        public int antiguedad { get; set; }
        public double sueldo { get; set; }
    }

    public class Carrera
    {
        public carreras nomebrecarrera { get; set; }
        public List<Materia> materias { get; set; }
        public int añoscursados { get; set; }
        public List<Alumno> listaalumnos { get; set; }
    }




    /// <summary>
    /// ////////////////
    /// </summary>




    public class departamento
    {
        public InformacionPersonal informacion { get; set; }
    }

    public class cuota
    {
        public double importe { get; set; }
        public DateTime fecha { get; set; }
    }

    public class contable : departamento
    {
        public cuota cuota { get; set; }
    }
    
    

   

    public class universidad
    {
        public InformacionPersonal informacion { get; set; }
        public carreras carrera { get; set; }
    }

   
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
