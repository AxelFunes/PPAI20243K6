using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PPAI20243K6.Clases
{
    internal class Vino
    {
        private int añada { get; set; }
        private DateTime fechaActualizacion { get; set; }
        private bool imagenEtiqueta { get; set; }
        private string nombre { get; set; }
        private int notaDeCataBodega { get; set; }
        private float precioARS { get; set; }

        private List<Varietal> Varietal;
        private Bodega Bodega;

        public void CalcularRanking()
        {
            // Implementación del método para calcular ranking
        }

        public void CompararEtiqueta()
        {
            // Implementación del método para comparar etiqueta
        }

        public bool EsDeBodega()
        {
            // Implementación del método para verificar si es de bodega
            return true;
        }

        public bool EsDeRegionVitivinicola()
        {
            // Implementación del método para verificar si es de región vitivinícola
            return false;
        }

        public void BuscarVinosConReseña()
        {
            // Implementación del método para buscar vinos con reseña
        }

        public decimal CalcularPuntajePromedio()
        {
            // Implementación del método para calcular puntaje promedio
            return 0;
        }
    }
}
