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

            Carrera carrera = new Carrera();
            Materia M1 = new Materia();
            Año primero = new Año();
            var alumno1 = new Alumno() { Nombre = "AL1" };
            var alumno2 = new Alumno() { Nombre = "AL2" };
            M1.Alumnos.Add(alumno1);
            M1.Alumnos.Add(alumno2);
            primero.Materias.Add(M1);
            carrera.MateriasAño.Add(primero);
      
            //act
            var total = carrera.TotalAlumnos();
            //assert
            Assert.AreEqual(2, total);
        }
    }

    public class UniversidadesTest
    {
        public void DeberiaAgregarUniversidad()
        {
            //arrange

            DepartamentosAcademicos d = DepartamentosAcademicos.Rafaela;
            Universidad universidad = new Universidad(d);

            //act
            Universidad.AgregarDepartamento(d);
            //assert
            Assert.AreEqual(1,)
        }
    }
}
