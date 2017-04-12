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

    public class Universidad
    {
        private static Universidad nuevauniversidad;
        public InformacionPersonal informacion { get; set; }
        private static List<carreras> listacarreras = new List<carreras>();


        private Universidad()
        {
            this.informacion = new InformacionPersonal();
        }

        public static Universidad AgregarUniversidad()
        {
            if (nuevauniversidad == null)
            {
                nuevauniversidad = new Universidad();
                nuevauniversidad.informacion.nombre = "UCSE";
            }
            return nuevauniversidad;
        }

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
        private static List<Carrera> listadecarreras = new List<Carrera>();
        public string nomebrecarrera { get; set; }
        private List<Materia> listamaterias;
        public int añoscursados { get; set; }
        public bool enc { get; set; }

        private Carrera()
        {
            añoscursados = 5;
            this.listamaterias = new List<Materia>();
            
        }

        public static Carrera agregarcarrera(string nombre)  
        {
            foreach (var carrera in listadecarreras)
            {
                if (carrera.nomebrecarrera == nombre)
                {
                    throw new NotSupportedException("No se puede agregar un objeto duplicado.");

                    return carrera;
                }
            }

            Carrera nuevacarrera = new Carrera();
            nuevacarrera.nomebrecarrera = nombre;
            listadecarreras.Add(nuevacarrera);
            return nuevacarrera;
        }








        public Carrera(List<Materia> listamaterias) : this()
        {
            CargarMateria(listamaterias);
        }

        public int TotalAlumnos() 
        {
            enc = false;
            int cantidadalumnos = 0;
            List<Alumno> totalalumnos = new List<Alumno>();

            foreach (var materia in listamaterias)
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

            foreach (Materia materia in listamaterias)
            {
                if (materia.nombremateria == nuevamateria.nombremateria)
                {
                    enc = true;
                    break;
                }
            }
            if (enc == false)
            {
                listamaterias.Add(nuevamateria);
            }           
            else
            {
                throw new NotSupportedException("No se puede agregar un objeto duplicado.");
            }

            return listamaterias.Count();
        }

        public int CargarMateria(List<Materia> listamaterias)
        {
            int cantidadmateria = 0;
            foreach (var materia in listamaterias)
            {
               cantidadmateria = CargarMateria(materia);
            }

            return cantidadmateria;
        }


    }

        /// <summary>
        /// ////////////////
        /// </summary>

            





        //public static Universidad AgregarUniversidad(string nombre)   HACER CON CARRERA
        //{
        //    foreach (var universidad in listauniversidades)
        //    {
        //        if (universidad.informacion.nombre == nombre)
        //        {
        //            return universidad;
        //        }
        //    }
        //    nuevauniversidad = new Universidad();
        //    nuevauniversidad.informacion.nombre = nombre;
        //    listauniversidades.Add(nuevauniversidad);
        //    return nuevauniversidad;
        //}












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
    
    

   
    
    class Program
    {
        static void Main(string[] args)
        {
            var Ingenieria = Carrera.agregarcarrera("Ingenieria");
            Materia materia1 = new Materia();
            Materia materia2 = new Materia();
            materia1.nombremateria = "Calculo";

            materia2.nombremateria = "Calculo";


            Ingenieria.CargarMateria(materia1);
            Ingenieria.CargarMateria(materia2);
        }
    }
}
