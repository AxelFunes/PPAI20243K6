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
        public int fechaReseña { get; set; }
        public int puntaje { get; set; }

        public Reseña(string comentarioRes, bool esPremiumRes, int fechaReseñaRes, int puntajeRes)
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
        public int getFechaReseña()
        {
            return fechaReseña;
        }
        public bool SosDeEnofilo()
        {
            // Implementación del método para verificar si es de enófilo
            return true;
        }

        public bool sosDeSommelier()
        {
            // Implementación del método para verificar si es de sommelier
            return esPremium;
        }

        public void BuscarReseña()
        {
            // Implementación del método para buscar reseña
        }

        public bool esFechaValida(int fechaDesde, int fechaHasta)
        {
            // Implementación del método para verificar si la fecha es válida
            
            //for (int i = 0; i < this.Reseñas.Count; i++)
            //{
            //    if (this.Reseñas[i].esFechaValida())
            //        fecha = this.Reseñas[i].getFechaReseña();

            //}
            return (fechaReseña >= fechaDesde && fechaReseña <= fechaHasta);
        }

        public decimal GetPuntaje()
        {
            return puntaje;
        }
    }
}
