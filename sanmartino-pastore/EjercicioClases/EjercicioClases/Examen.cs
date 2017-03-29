using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    enum tipoExamen
    {
        Parcial,
        Final,
        TrabajoPractico
    }
    class Examen
    {
        public tipoExamen TipoExamen { get; set; }
    }
}
