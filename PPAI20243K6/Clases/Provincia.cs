using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI20243K6.Clases
{
    internal class Provincia
    {
        private string nombreProv { get; set; }
        private Pais paisP {get; set; }

        public Provincia(string nombre, string nombrePais)
        {
            nombreProv = nombre;
            
            paisP = new Pais(nombrePais);
        }
        public int ContarRegiones()
        {
            // Implementación del método para contar regiones
            return 0;
        }

        public void agregarPais( string nombre)
        {
            this.paisP = new Pais(nombre);
        }
        public void MostrarRegiones()
        {
            // Implementación del método para mostrar regiones
        }

        public string buscarPais()
        {
            return paisP.getNombre();
        }
    }
}
