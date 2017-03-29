using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descomposicion_universidad
{
    public class Universidad
    {
        List<Edificio> Edificios { get; set; }

        List<Aula> Aulas { get; set; }

        List<Departamento> Deptos { get; set; }

        List<Carrera> Carreras { get; set; }

        Direccion Direccion { get; set; }
    }
}
