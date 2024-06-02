using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI20243K6.Clases
{
    internal class GestorGenerarRankingVinos
    {
        public PantallaRankingVinos PantallaAsociada;
        public int reportesAGenerar { get; set; }
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        public bool fechasValidas;
        private List<Vino> arrayVinos;


        public GestorGenerarRankingVinos(PantallaRankingVinos pantalla)
        {
            
            PantallaAsociada = pantalla;
            
        }
        public void generarRanking()
        {
            //cargar los objetos



            PantallaAsociada.solicitarFechasDesdeHasta();
            // Implementación del método para generar ranking
        }

        public void fechasConsideracionReseñas(DateTime fechaDesde, DateTime fechaHasta)
        {
            // Implementación del método para considerar fechas de reseñas
            validarFechas(fechaDesde,fechaHasta);
        }

        public void validarFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            // Implementación del método para validar fechas
            if (fechaDesde<fechaHasta)
            {
                this.fechaDesde = fechaDesde;
                this.fechaHasta = fechaHasta;
                fechasValidas = true;
            }
            else
            {
                fechasValidas = false;
            }
        }

        public void buscarTiposReseña()
        {
            // Implementación del método para buscar tipos de reseña
        }

        public void tomarTipoReseña(string tipoReseña)
        {
            // Implementación del método para tomar tipo de reseña

            PantallaAsociada.pedirSeleccionFormasVisualizacion();

        }

        public string tomarTipoFormasVisualizacion(bool chkExcel, bool chkpdf, bool chkpantalla)
        {
            // Implementación del método para tomar tipo de formas de visualización
            string tipoVis = "";
            if (chkExcel)
            {
                tipoVis = "excel";
            }
            else
            {
                if (chkpdf)
                {
                    tipoVis = "pdf";
                }
                else
                {
                    if (chkpantalla)
                    {
                        tipoVis = "pantalla";
                    }

                }
            }
            return tipoVis;
        }

        public void tomarConfirmacion()
        {
            // Implementación del método para tomar confirmación
            buscarVinosReseñasPeriodo();
        }

        public void buscarVinosReseñasPeriodo()
        {
            List<Vino> vinos = arrayVinos;
            
        }
        public void ordenarVinoPorPromedio()
        {
            // Implementación del método para ordenar vino por promedio
        }

        public void FinCU()
        {
            // Implementación del método para finalizar el caso de uso
        }
    }
}
