using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI20243K6.Clases
{
    internal class Varietal
    {
        private string descripcion { get; set; }
        private decimal porcentajeComposicion { get; set; }

        public Varietal(string descripcionVar, int porcentaje)
        {
            descripcion = descripcionVar;
            porcentajeComposicion = porcentaje;
        }
        public void ConocerTipoUva()
        {
            // Implementación del método para conocer tipo de uva
        }
        public string getDescripcion()
        {
            return descripcion;
        }
        public bool EsDeTipoUva()
        {
            // Implementación del método para verificar si es de tipo de uva
            return false;
        }

        public void MostrarPorcentaje()
        {
            // Implementación del método para mostrar porcentaje
        }
    }
}
