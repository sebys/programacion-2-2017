using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descomposicion_universidad
{
    public class Carrera
    {
        public int PlazoPlanificado { get; set; } = 0;

        public int CargaHoraria { get; set; } = 0;

        public string Coordinador { get; set; } = "";

        public List<Profesor> Profesores { get; set; } = new List<Profesor>();
        
        public List<Materia> Materias { get; set; } = new List<Materia>();

        public int TotalAlumnos()
        {
            int total = 0;
            
            List<Alumno> alumnosContados = new List<Alumno>();

            foreach (Materia m in Materias)
            {
                List<Alumno> alumnosMateria = m.RetornarAlumnos();

                foreach (Alumno a in alumnosMateria)
                {
                    if (!alumnosContados.Exists(x => x.Nombre == a.Nombre))
                        alumnosContados.Add(a);
                }
            }

            total = alumnosContados.Count;

            return total;
        }
    }
}
