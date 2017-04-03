using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioClases;

namespace EjemploTest
{
    [TestClass]
    public class CarreraUnitTest
    {
        [TestMethod]
        public void CarreraDevTotAlumSinRepetir()
        {
            // Arrange
            
            var alumno1 = new Alumno() { Nombre = "A1" };
            var alumno2 = new Alumno() { Nombre = "A2" };

            var materia1 = new Materia() { NombreMateria = "M1" };           
            materia1.Alumnos.Add(alumno1);
            materia1.Alumnos.Add(alumno2);
            materia1.Alumnos.Add(alumno1);
            materia1.Alumnos.Add(alumno2);
            materia1.Alumnos.Add(alumno2);
            var materia2 = new Materia() { NombreMateria = "M2" };
            materia2.Alumnos.Add(alumno1);
            materia2.Alumnos.Add(alumno2);
            materia2.Alumnos.Add(alumno2);
            materia2.Alumnos.Add(alumno2);
            materia2.Alumnos.Add(alumno2);
            materia2.Alumnos.Add(alumno2);

            var carrera = new Carrera();
            carrera.Materia.Add(materia1);
            carrera.Materia.Add(materia2);
            
            // Act

            var total = carrera.CantidadAlumnos();

            //Assert
            Assert.AreEqual(1, total);
            //El primer indice es el valor que pienso obtener, y el segundo es el valor con el que se compara

        }
    }
}
