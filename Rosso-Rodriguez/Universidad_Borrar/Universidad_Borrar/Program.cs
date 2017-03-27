using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad_Borrar
{
    public class Universidad
    {
        public DatosParticulares DatoUniversidad { get; set; }
        public Carrera CarreraUniversidad { get; set; }

    }
    public class Carrera
    {
        public string Nombre { get; set; }
        public CicloLectivo CicloCarrera { get; set; }
        public Materia MateriaCarrera { get; set; }
        public Profesores ProfeCarrera { get; set; }

    }
    public class Materia
    {
        public string Nombre { get; set; }
        public Examenes ExamenMateria { get; set; }
        public Horario HorarioMateria { get; set; }
        
    }
    public class CicloLectivo
    {

    }
    public class Horario
    {

    }
    public class Alumnos
    {

    }
    public class Profesores
    {

    }
    public class Examenes
    {
        public string Parcial { get; set; }
        public string TrabajoPractico { get; set; }
        public string Final { get; set; }
    }
    public class DatosParticulares
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int DNI { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
