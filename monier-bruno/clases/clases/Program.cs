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
        public List<Alumno> listaalumnos { get; set; }

        public Materia()
        {
            listaalumnos = new List<Alumno>();
        }
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

        public Persona()
        {
           this.informacion = new InformacionPersonal();
        }
    }

    public class Alumno : Persona
    {
        public Carrera carrera { get; set; }
        public int asistencias { get; set; }
        public int numeroalumno { get; set; }
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
        public bool enc { get; set; }

        public Carrera()
        {
            añoscursados = 5;
            this.materias = new List<Materia>();
        }

        public int TotalAlumnos()
        {
            enc = false;
            int cantidadalumnos = 0;
            List<Alumno> totalalumnos = new List<Alumno>();

            foreach (var materia in materias)
            {
                foreach (var alumno1 in materia.listaalumnos)
                {
                    foreach (var alumno2 in totalalumnos)
                    {
                        if (alumno2.numeroalumno == alumno1.numeroalumno)
                        {
                            enc = true;
                            break;
                        }
                    }
                    if (enc == false)
                    {
                        totalalumnos.Add(alumno1);
                    }
                }
            }
            cantidadalumnos = cantidadalumnos + totalalumnos.Count();

            return cantidadalumnos;
        }

        public int CargarMateria ( Materia nuevamateria )
        {  
            enc = false;

            foreach (Materia materia in materias)
            {
                if (materia.nombremateria == nuevamateria.nombremateria)
                {
                    enc = true;
                    break;
                }
            }
            if (enc == false)
            {
                materias.Add(nuevamateria);
            }           
            else
            {
                throw new NotSupportedException("No se puede agregar un objeto duplicado.");
            }

            return materias.Count();
        }
    }

    /// <summary>
    /// ////////////////
    /// </summary>

        
    public class departamento
    {
        public InformacionPersonal informacion1 { get; set; }
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
            Carrera Ingenieria = new Carrera();
            Materia materia1 = new Materia();
            Materia materia2 = new Materia();
            materia1.nombremateria = "Calculo";

            materia2.nombremateria = "Calculo";


            Ingenieria.CargarMateria(materia1);
            Ingenieria.CargarMateria(materia2);
        }
    }
}
