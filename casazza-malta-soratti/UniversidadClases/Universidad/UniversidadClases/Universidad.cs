using clases;
using ConsoleApplication21.UniversidadClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
   public class Universidad
    {
        public InformacionPersonal Informacion { get; set; }
        public carreras carrera { get; set; }

        private Universidad(carreras carrera, InformacionPersonal info)
        {
            this.carrera = carrera;
            this.Informacion = info;
        }

        private static Universidad university;

        public static Universidad ObtenerUniversidad(carreras carrera, InformacionPersonal info)
        {
            if (university != null)
            {
                return university;
            }
            university = new Universidad(carrera, info);
            return university;
        }


    }
}
