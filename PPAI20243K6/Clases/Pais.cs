using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI20243K6.Clases
{
    internal class Pais
    {
        private string nombrePais { get; set; }
        public Pais(string nombre)
        {
            nombrePais = nombre;
        }

        public int contarBodega()
        {
            // Implementación del método para contar bodegas
            return 0;
        }

        public string getNombre()
        {
            return nombrePais;
        }
    }
}
