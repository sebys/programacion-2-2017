using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Universidad //singleton simple
    {
        private Universidad(string nombre, int id)
        {
            this.Nombre = nombre;
            this.ID = id;
        }

        private static Universidad universidad; //es estatico porque al implementarlo un metodo estatico debe serlo y privado porque nadie debe poder acceder a el para evitar el duplicado
        public int ID { get; set; }
        public string Nombre { get; set; }
        public List<Carrera> Carreras { get; set; }

        public static Universidad ObtenerUniversidad(string nombre, int id)
        {
            if (universidad != null)
            {
                return universidad;
            } 
            else
            {
                universidad = new Universidad(nombre,id);
                return universidad;
            }     
            
        }       
    }

    public class AdministradorDeUniversidades //ver con lista
    {
        private AdministradorDeUniversidades(string nombre, int id)
        {
            this.Nombre = nombre;
            this.ID = id;
        }

        private static List<Universidad> Universidades = new List<Universidad>();
        public int ID { get; set; }
        public string Nombre { get; set; }
        public List<Carrera> Carreras { get; set; }
        static public int CantidadUniversidades { get { return Universidades.Count(); } }

        public static Universidad ObtenerUniversidad(string nombre, int id)
        {
            foreach (var uni in Universidades)
            {
                if (uni.Nombre == nombre && uni.ID == id)
                {
                    return uni; //cuando hace el return termina el metodo? Porque sino ahi abajo se crearia otra instancia
                }
            }
            var universidad = Universidad.ObtenerUniversidad(nombre, id);
            Universidades.Add(universidad);
            return universidad;                   
        }       
    }
}
