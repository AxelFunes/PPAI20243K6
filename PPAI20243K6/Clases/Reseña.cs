using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI20243K6.Clases
{
    internal class Reseña
    {
        private string comentario { get; set; }
        private bool esPremium { get; set; }
        private DateTime fechaReseña { get; set; }
        private int puntaje { get; set; }

        public Reseña(string comentarioRes, bool esPremiumRes, DateTime fechaReseñaRes, int puntajeRes)
        {
            comentario = comentarioRes;
            esPremium = esPremiumRes;
            fechaReseña = fechaReseñaRes;
            puntaje = puntajeRes;
        }
        public bool EsPremium()
        {
            return esPremium;
        }
        //public int getFechaReseña()
        //{
        //    return fechaReseña;
        //}
        public bool SosDeEnofilo()
        {
            // Implementación del método para verificar si es de enófilo
            return true;
        }

        public bool sosDeSommelier(bool premium)
        {
            // Implementación del método para verificar si es de sommelier
            return (esPremium==premium);
        }

        public void BuscarReseña()
        {
            // Implementación del método para buscar reseña
        }

        

        public bool esFechaValida(DateTime fechaDesde, DateTime fechaHasta)
        {
            // Implementación del método para verificar si la fecha es válida

            if (fechaReseña >= fechaDesde && fechaReseña <= fechaHasta)
            {
                return true;
            }
            else
            {
                return false;
            }          
        }


        public int getPuntaje()
        {
            return puntaje;
        }
    }
}
