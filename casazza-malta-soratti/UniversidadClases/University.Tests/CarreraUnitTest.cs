using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication21;
using ConsoleApplication21.UniversidadClases;

namespace University.Tests
{
    [TestClass]
    public class CarreraUnitTest
    {
        [TestMethod]
        public void CarreraDeberiaDevolverTotalAlumnos()
        {
            // Arrange
            var carrera = new Carrera();

            // Act
            var total = carrera.TotalAlumnos();


            // Assert
            Assert.AreEqual(0, total);
        }
        [TestMethod]
        public void CarreraDeberiaDevolverTotalAlumnosNoRepetir()
        {
            // Arrange
            var alumno1 = new Alumno()
            {
                informacion = new InformacionPersonal { Nombre = "A1" }
            };

            var alumno2 = new Alumno()
            {
                informacion = new InformacionPersonal { Nombre = "A2" }
            };

            var materia1 = new Materia() { Nombre = "M1" };
            materia1.Alumnos.Add(alumno1);
            materia1.Alumnos.Add(alumno2);

            var carrera = new Carrera();
            carrera.AgregarMateria(materia1);

            // Act
            var total = carrera.TotalAlumnos();


            // Assert
            Assert.AreEqual(2, total);
        }

        [TestMethod]
        public void CarreraDeberiaDevolverTotalAlumnosRepetido()
        {
            // Arrange
            var alumno1 = new Alumno()
            {
                informacion = new InformacionPersonal { Nombre = "A1" }
            };

            var alumno2 = new Alumno()
            {
                informacion = new InformacionPersonal { Nombre = "A2" }
            };

            var materia1 = new Materia() { Nombre = "M1" };
            materia1.Alumnos.Add(alumno1);
            materia1.Alumnos.Add(alumno2);
            materia1.Alumnos.Add(alumno1);
            materia1.Alumnos.Add(alumno2);

            var carrera = new Carrera();

            carrera.AgregarMateria(materia1);

            // Act
            var total = carrera.TotalAlumnos();

            // Assert
            Assert.AreEqual(2, total);
        }

        [TestMethod]
        public void DeberíaPoderAgregarMateria()
        {
            //Arrange
            var materia1 = new Materia() { Nombre = "M1" };

            var carrera = new Carrera();
            carrera.AgregarMateria(materia1);


            // Act

            var total = carrera.CantidadMaterias();


            // Assert
            Assert.AreEqual(1, total);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void NoDeberíaPoderAgregarMateriaDuplicada()
        {
            //Arrange
            var materia1 = new Materia() { Nombre = "M1" };
            var materia2 = new Materia() { Nombre = "M2" };

            var carrera = new Carrera();
            carrera.AgregarMateria(materia1);
            carrera.AgregarMateria(materia2);
            carrera.AgregarMateria(materia1);


            // Act

           // var total = carrera.Materias.Count;


            // Assert
            ////Assert.AreEqual(1, total);
        }

        [TestMethod]
        public void ComprobarSingleton()
        {
            //Arrange
            InformacionPersonal info = new InformacionPersonal();
            InformacionPersonal info1 = new InformacionPersonal();
            
            bool variable;


            // Act PREGUNTAAAAAAAAR
            if (Universidad.ObtenerUniversidad(clases.carreras.Abogacia, info) == Universidad.ObtenerUniversidad(clases.carreras.Ingenieria, info1))
            {
                variable = true;

            }
            else
            {
                variable = false;
            }

            // Assert
            Assert.AreEqual(true, variable);
        }
    }
}
