using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI20243K6.Clases
{
    internal class RegionVitivinicola
    {
        public string descripcion { get; set; }
        public string nombre { get; set; }

        private Provincia provincia { get; set; }

        public int ContarBodegas()
        {
            // Implementación del método para contar bodegas
            return 0;
        }

        public string getNombre()
        {
            return nombre;
        }
        public string buscarPais()
        {
            string pais= this.provincia.buscarPais();
            return pais;
        }
    }
}
