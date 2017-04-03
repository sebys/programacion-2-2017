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
            materias = new List<Materia>();
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
            Materia Calculo = new Materia();
            Materia Programacion = new Materia();
            Alumno nuevo = new Alumno();
            Alumno nuevo2 = new Alumno();
            Alumno nuevo3 = new Alumno();


            nuevo.informacion.nombre = "juan";
            nuevo.numeroalumno = 1;
            nuevo2.numeroalumno = 2;
            nuevo3.numeroalumno = 3;

            Calculo.listaalumnos.Add(nuevo);
            Calculo.listaalumnos.Add(nuevo2);

            Programacion.listaalumnos.Add(nuevo);
            Programacion.listaalumnos.Add(nuevo2);
            Programacion.listaalumnos.Add(nuevo3);

            Ingenieria.materias.Add(Programacion);
            Ingenieria.materias.Add(Calculo);

            int a = Ingenieria.TotalAlumnos();
        }
    }
}
