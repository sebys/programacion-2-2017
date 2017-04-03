using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace clases.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CarreraDeberiaCalcularTotalAlumnosIgualACero()
        {
            //arange
            var carrera = new Carrera();

            //act
            var total = carrera.TotalAlumnos();

            //assert
            Assert.AreEqual(0, total);
        }

        [TestMethod]
        public void CarreraDeberiaDevolverTotalAlumnos()
        {
            //arange
            Alumno alumno1 = new Alumno() { numeroalumno = 1 };
            Alumno alumno2 = new Alumno() { numeroalumno = 2 };

            Materia materia = new Materia() { nombremateria = "Programacion" };
            materia.listaalumnos.Add(alumno1);
            materia.listaalumnos.Add(alumno2);

            Carrera carrera = new Carrera();
            carrera.materias.Add(materia);


            //act
            var total = carrera.TotalAlumnos();

            //assert
            Assert.AreEqual(2, total);
        }

        [TestMethod]
        public void CarreraDevolverAlumnosNoRepetidos()
        {
            //arange
            Alumno alumno1 = new Alumno() { numeroalumno = 1 };
            Alumno alumno2 = new Alumno() { numeroalumno = 2 };

            Materia materia = new Materia() { nombremateria = "Programacion" };
            materia.listaalumnos.Add(alumno1);
            materia.listaalumnos.Add(alumno2);

            Materia materia1 = new Materia() { nombremateria = "Calculo" };
            materia1.listaalumnos.Add(alumno1);
            materia1.listaalumnos.Add(alumno2);

            Carrera carrera = new Carrera();
            carrera.materias.Add(materia);
            carrera.materias.Add(materia1);


            //act
            var total = carrera.TotalAlumnos();

            //assert
            Assert.AreEqual(2, total);
        }
    }
}
