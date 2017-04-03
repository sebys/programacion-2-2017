using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApplication2.Test
{
    [TestClass]
    public class CarreraUnitTest
    {
        [TestMethod]
        public void CarreraDeberiaDevolverTotalAlumnos()
        {
            // Arange
            var carrera = new Carrera();

            //Act
            int total = carrera.CantidadAlumnos();

            //Assert
            Assert.AreEqual(0, total);

        }

        [TestMethod]
        public void CarreraDeberiaDevolverTotalAlumnosSinRepetir()
        {
            // Arange = 
            var alumno1 = new Alumno() { Nombre = "A1" };
            var alumno2 = new Alumno() { Nombre = "A2" };

            var materia1 = new Materia() { Nombre = "M1" };
            materia1.Alumnos.Add(alumno1);
            materia1.Alumnos.Add(alumno2);

            var carrera = new Carrera();
            carrera.Materias.Add(materia1);

            //Act
            
            int total = carrera.CantidadAlumnos();

            //Assert
            Assert.AreEqual(2, total);

        }

        [TestMethod]
        public void CarreraDeberiaDevolverTotalAlumnosConALumnosRepetidos()
        {
            // Arange 
            var alumno1 = new Alumno() { Nombre = "A1" };
            var alumno2 = new Alumno() { Nombre = "A2" };

            var materia1 = new Materia() { Nombre = "M1" };
            materia1.Alumnos.Add(alumno1);
            materia1.Alumnos.Add(alumno2);

            var materia2 = new Materia() { Nombre = "M2" };
            materia1.Alumnos.Add(alumno1);

            var carrera = new Carrera();
            carrera.Materias.Add(materia1);
            carrera.Materias.Add(materia2);

            //Act

            int total = carrera.CantidadAlumnos();

            //Assert
            Assert.AreEqual(2, total);

        }
    }
}
