using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PPAI20243K6.Clases
{
    internal class Bodega
    {
        private string coordenadasUbicacion { get; set; }
        private string descripcion { get; set; }
        private string historia { get; set; }
        private string nombre { get; set; }
        private int periodoActualizacion { get; set; }
        private List<Reseña> Reseñas;
        private RegionVitivinicola RegionVitivinicola;

        public Bodega(string coordUbicacionBodega, string descripBodega, string historiaBodega, string nombreBodega, int periodoActualizacionBodega)
        {
            coordenadasUbicacion = coordUbicacionBodega;
            descripcion = descripBodega;
            historia = historiaBodega;
            nombre = nombreBodega;
            periodoActualizacion = periodoActualizacionBodega;
        }

        public int ContarReseñas()
        {
            // Implementación del método para contar reseñas
            return 0;
        }

        public void MostrarTodosVinos()
        {
            // Implementación del método para mostrar todos los vinos
        }

        public string GetNombre()
        {
            return nombre;
        }
    }
}
