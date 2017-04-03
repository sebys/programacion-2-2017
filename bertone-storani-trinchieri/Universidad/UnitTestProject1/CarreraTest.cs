using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;

namespace UnitTestProject1
{
    [TestClass]
    public class CarreraTest
    {
        [TestMethod]
        public void CarreraDeberiaDevolverTotalAlumnos()
        {
            //arrange
            var carrera = new Carrera();
            Materia M1 = new Materia();
            Año primero = new Año();
            //Materia materias = new Materia();


            carrera.MateriasAño.Add(primero);
            primero.Materias.Add(M1);            
            

            var alumno1 = new Alumno() { Nombre = "AL1" };
            var alumno2 = new Alumno() { Nombre = "AL2" };

            M1.Alummnos.Add(alumno1);
            M1.Alummnos.Add(alumno2);

            //act
            var total = carrera.TotalAlumnos();
            //assert
            Assert.AreEqual(2, total);
        }
    }
}
