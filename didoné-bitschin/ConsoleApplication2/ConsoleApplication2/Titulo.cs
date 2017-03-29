using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    enum Alcance { Nacional, Internacional}
    class Titulo
    {
        public string Nombre { get; set; }
        public Alcance alcance { get; set; }
        public List<Titulo> titulosintermedios { get; set; }
    }
}
