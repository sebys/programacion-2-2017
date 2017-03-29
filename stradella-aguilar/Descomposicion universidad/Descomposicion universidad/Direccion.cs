using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descomposicion_universidad
{
    public class Direccion
    {
        Telefono Telefono { get; set; }

        Localidad Localidad { get; set; }

        Provincia Provincia { get; set; }

        Pais Pais { get; set; }
    }
}
