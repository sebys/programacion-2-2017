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
            carrera.CargarMateria(materia);


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
            carrera.CargarMateria(materia);
            carrera.CargarMateria(materia1);


            //act
            var total = carrera.TotalAlumnos();

            //assert
            Assert.AreEqual(2, total);
        }


        [TestMethod]
        public void DeberíaPoderAgregarMateria()
        {
            //arange
            var carrera = new Carrera();
            var materia = new Materia();
            materia.nombremateria = "Programacion";

            //act
            var totalmateria = carrera.CargarMateria(materia);

            //assert
            Assert.AreEqual(1, totalmateria);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void NoDeberíaPoderAgregarMateriaDuplicada()
        {
            //arange
            var carrera = new Carrera();
            var materia = new Materia();
            var materia1 = new Materia();
            var materia2 = new Materia();
            materia.nombremateria = "Programacion";
            materia1.nombremateria = "Programacion";
            materia2.nombremateria = "Calculo";

            //act
            carrera.CargarMateria(materia);
            carrera.CargarMateria(materia1);
            carrera.CargarMateria(materia2);

            //assert - Exected Exception
        }
        [TestMethod]
        public void NoPermitaAgregarMasDeUnaUniversidad()
        {
            //arange
            var un1 = Universidad.AgregarUniversidad();

            //act
            var un2 = Universidad.AgregarUniversidad();

            //assert
            Assert.AreEqual(un1, un2);
        }
    }
}
