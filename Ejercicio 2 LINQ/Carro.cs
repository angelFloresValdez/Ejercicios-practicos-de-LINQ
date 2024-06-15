using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_2_LINQ
{
     [DebuggerDisplay("{Nombre}")]
  
    
         public class Carro
    {
        public string Nombre { get; set; }
        public int Año { get; set; }
        public bool Viejo { get; set; }
        public DateTime FechaFabricacion { get; set; }

        public List<string> Fallas = new List<string>();
        public int EmpresaId { get; set; }
    }
    
}