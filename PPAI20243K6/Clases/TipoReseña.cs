using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI20243K6.Clases
{
    internal class TipoReseña
    {
        private string nombre { get; set; }
        private string descripcion { get; set; }

        public string GetNombre()
        {
            return nombre;
        }

        public bool EsSommelier()
        {
            // Implementación del método para verificar si es sommelier
            return true;
        }
    }
}
