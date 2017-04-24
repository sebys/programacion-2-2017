using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    public class Materia
    {
        public Materia()
        {
            Alumnos = new ObservableCollection<Alumno>();
            Alumnos.CollectionChanged += AlumnosOnCollectionChanged;
        }

        //SOBRECARGA DE CONSTRUCTORES
        public Materia(List<Profesor> profes) : this()
        {
            Profesores = profes;
        }

        public const int MaxAlumno = 2;
        public event MaximoALumnoDelegate OnMaximoAlumno;

        public string Nombre { get; set; }
        public List<Materia> CorrelativasDebiles { get; set; }
        public List<Materia> CorrelativasFuertes { get; set; }
        public int CantidadHoras { get; set; }
        public List<Profesor> Profesores { get; set; }
        public ObservableCollection<Alumno> Alumnos { get; set; }
        public Horario Horario { get; set; }

        //METODO DEL EVENTO
        public void AlumnosOnCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewStartingIndex + 1 >= MaxAlumno)
            {
                if (OnMaximoAlumno != null)
                {
                    OnMaximoAlumno(this, new MaximoAlumnosEventArgs(Nombre, Alumnos.Count()));
                }
            }
            //throw new NotImplementedException();
        }

        //REESCRIBO EL MÉTODO ToString
        public override string ToString()
        {
            return Nombre;
        }
    }
}
