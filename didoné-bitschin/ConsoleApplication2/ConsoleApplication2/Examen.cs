﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public enum TipoExamen
    {
        Parcial,
        Final,
        TrabajoPractico
    }

    public class Examen
    {
        public TipoExamen tipo { get; set; }
    }
}
