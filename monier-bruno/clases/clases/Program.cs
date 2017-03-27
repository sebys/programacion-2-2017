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

    public class departamento
    {
        public informacionPersonal informacion { get; set; }
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
    
    public class carrera
    {
        public carreras nomebrecarrera { get; set; }
        public List<string> materias { get; set; }
    }

    public class informacionPersonal
    {
        public string direccion { get; set; }
        public string nombre { get; set; }
        public int telefono { get; set; }
        public int edad { get; set; }
    }

    public class universidad
    {
        public informacionPersonal informacion { get; set; }
        public carreras carrera { get; set; }
    }

    public class persona
    {
        public informacionPersonal informacion { get; set; }
    }


    class alumno : persona
    {
        public carrera carrera { get; set; }
        public int asistencias { get; set; }
    }

    class profesor : persona
    {
        public int canthorasdadas { get; set; }
        public carrera carrera { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
