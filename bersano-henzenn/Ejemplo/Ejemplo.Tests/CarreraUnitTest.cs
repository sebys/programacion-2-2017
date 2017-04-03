using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejemplo.Tests
{
    [TestClass]
    public class CarreraUnitTest
    {
        [TestMethod]
        public void CarreraDeberiaCalcularTotalAlumnosEnCeroCuandoNoExisten()
        {
            // Arrange
            var carrera = new Carrera();

            // Act
            var total = carrera.TotalAlumnos;

            // Assert
            Assert.AreEqual(0, total);
        }

        [TestMethod]
        public void CarreraCalcularTotalAlumnosConAlumnosNoRepetidos()
        {
            // Arrange
            var alumno1 = new Alumno() { Nombre = "A1" };
            var alumno2 = new Alumno() { Nombre = "A2" };

            var materia1 = new Materia() { Nombre = "M1" };
            materia1.Alumnos.Add(alumno1);
            materia1.Alumnos.Add(alumno2);

            var carrera = new Carrera();
            carrera.Materias.Add(materia1);

            // Act
            var total = carrera.TotalAlumnos;

            // Assert
            Assert.AreEqual(2, total);
        }

        [TestMethod]
        public void CarreraDeberiaCalcularTotalAlumnosConAlumnosRepetidos()
        {
            // Arrange
            var alumno1 = new Alumno() { Nombre = "A1" };
            var alumno2 = new Alumno() { Nombre = "A2" };

            var materia1 = new Materia() { Nombre = "M1" };
            materia1.Alumnos.Add(alumno1);
            materia1.Alumnos.Add(alumno2);

            var materia2 = new Materia() { Nombre = "M2" };
            materia2.Alumnos.Add(alumno1);

            var carrera = new Carrera();
            carrera.Materias.Add(materia1);
            carrera.Materias.Add(materia2);

            // Act
            var total = carrera.TotalAlumnos;

            // Assert
            Assert.AreEqual(2, total);
        }
        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void NoDeberíaPoderAgregarMateriaDuplicada()
        {

        }
    }
}
