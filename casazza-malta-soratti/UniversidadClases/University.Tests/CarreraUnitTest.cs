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
            carrera.Materias.Add(materia1);

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
            carrera.Materias.Add(materia1);

            // Act
            var total = carrera.TotalAlumnos();

            // Assert
            Assert.AreEqual(2, total);
        }
    }
}
