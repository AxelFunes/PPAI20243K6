using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        private List<Reseña> Reseñas;

        private List<Varietal> Varietal;
        private Bodega Bodega;
        

        public Vino(int añada, DateTime fechaActualizacion, bool imagenEtiqueta, string nombre, int notaCata, float precioARS, string coordUbicacionBodega, string descripBodega, string historiaBodega, string nombreBodega, int periodoActualizacionBodega)
        {
            //Id = id;
            //DescripcionOperador = desc;
            //DetalleOpcionRequerida = detalleOpReq;
            //Duracion = duracion;
            //EncuestaEnviada = encuestaEnviada;
            //ObservacionAuditor = observAuditor;
            Varietal= new List<Varietal>();
            Reseñas = new List<Reseña>();
            Bodega = new Bodega(coordUbicacionBodega, descripBodega, historiaBodega, nombreBodega, periodoActualizacionBodega);
            //CambiosEst.Add(primerCambioEstado);
            //RespuestasCliente = new List<RespuestaDeCliente>();

        }

        public void agregarVarietal(Varietal var)
        {
            Varietal.Add(var);
        }

        public void agregarReseña(Reseña res)
        {
            Reseñas.Add(res);
        }
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

        public bool buscarVinosConReseña(int fechaDesde, int fechaHasta)
        {
            // Implementación del método para buscar vinos con reseña
            int? fecha = null;
            for (int i = 0; i < this.Reseñas.Count; i++)
            {
                if (this.Reseñas[i].esFechaValida(fechaDesde, fechaHasta))
                {
                    if (this.Reseñas[i].sosDeSommelier()) 

                    {


                    }

                }  
            }
            return (fecha >= fechaDesde && fecha <= fechaHasta);


        }

        public decimal CalcularPuntajePromedio()
        {
            // Implementación del método para calcular puntaje promedio
            return 0;
        }
    }
}
