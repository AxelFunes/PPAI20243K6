using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI20243K6.Clases
{
    internal class Provincia
    {
        public string nombre { get; set; }
        private Pais pais {get; set; }

        public int ContarRegiones()
        {
            // Implementación del método para contar regiones
            return 0;
        }

        public void MostrarRegiones()
        {
            // Implementación del método para mostrar regiones
        }

        public string buscarPais()
        {
            string nom = this.pais.getNombre();
            // Implementación del método para buscar país
            return nom;
        }
    }
}
