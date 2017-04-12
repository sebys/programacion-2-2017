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
            var nuevacarrera = Carrera.agregarcarrera("Ingenieria");

            //act
            var total = nuevacarrera.TotalAlumnos();

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

            var nuevacarrera = Carrera.agregarcarrera("Ingenieria");
            nuevacarrera.CargarMateria(materia);


            //act
            var total = nuevacarrera.TotalAlumnos();

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

            var nuevacarrera = Carrera.agregarcarrera("Ingenieria");
            nuevacarrera.CargarMateria(materia);
            nuevacarrera.CargarMateria(materia1);


            //act
            var total = nuevacarrera.TotalAlumnos();

            //assert
            Assert.AreEqual(2, total);
        }


        [TestMethod]
        public void DeberíaPoderAgregarMateria()
        {
            //arange
            var nuevacarrera = Carrera.agregarcarrera("Ingenieria");
            var materia = new Materia();
            materia.nombremateria = "Programacion";

            //act
            var totalmateria = nuevacarrera.CargarMateria(materia);

            //assert
            Assert.AreEqual(1, totalmateria);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void NoDeberíaPoderAgregarMateriaDuplicada()
        {
            //arange
            var nuevacarrera = Carrera.agregarcarrera("Ingenieria");
            var materia = new Materia();
            var materia1 = new Materia();
            var materia2 = new Materia();
            materia.nombremateria = "Programacion";
            materia1.nombremateria = "Programacion";
            materia2.nombremateria = "Calculo";

            //act
            nuevacarrera.CargarMateria(materia);
            nuevacarrera.CargarMateria(materia1);
            nuevacarrera.CargarMateria(materia2);

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

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void NoPermitaAgregarMasDeUnaCarreraConElMismoNombre()
        {
            //arange
            Carrera.agregarcarrera("Ingenieria");

            //act
            Carrera.agregarcarrera("Ingenieria");

            //assert -Expected Exception
        }
    }
}
