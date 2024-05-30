using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI20243K6.Clases
{
    internal class Reseña
    {
        public string comentario { get; set; }
        public bool esPremium { get; set; }
        public DateTime fechaReseña { get; set; }
        public decimal puntaje { get; set; }

        public bool EsPremium()
        {
            return esPremium;
        }

        public bool SosDeEnofilo()
        {
            // Implementación del método para verificar si es de enófilo
            return true;
        }

        public bool SosDeSommelier()
        {
            // Implementación del método para verificar si es de sommelier
            return true;
        }

        public void BuscarReseña()
        {
            // Implementación del método para buscar reseña
        }

        public bool EsFechaValida()
        {
            // Implementación del método para verificar si la fecha es válida
            return true;
        }

        public decimal GetPuntaje()
        {
            return puntaje;
        }
    }
}
