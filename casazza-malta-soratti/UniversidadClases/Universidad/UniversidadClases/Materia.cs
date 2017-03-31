﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21.UniversidadClases
{
    class Materia
    {
        public string Nombre { get; set; }
        public int CantidadHoras { get; set; }
        public List<Alumno> Alumnos { get; set; }

        public Materia()
        {
            Alumnos = new List<Alumno>();
        }
    }
}
