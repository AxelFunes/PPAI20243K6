using PPAI20243K6.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI20243K6
{
    public partial class PantallaRankingVinos : Form
    {
        private GestorGenerarRankingVinos gestor;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private string tipoReseña;
        private string tipoVisualizacion;
        

        public PantallaRankingVinos()
        {
            InitializeComponent();
            gestor = new GestorGenerarRankingVinos(this);
            gestor.generarRanking();

        }
        public void solicitarFechasDesdeHasta()
        {
            lbl_FechaFin.Visible = true;
            lbl_FechaInicio.Visible = true;
            dt_FechaFin.Visible = true;
            dt_FechaInicio.Visible=true;
            // Implementación del método para tomar fecha desde
        }

        public DateTime tomarFechaDesde()
        {
            return dt_FechaInicio.Value;
        }

        public DateTime tomarFechaHasta()
        {
            return dt_FechaFin.Value;
        }
        

        public void pedirSeleccionTipoReseña()
        {
            // Implementación del método para pedir selección de tipo de reseña
            lbl_TipoReseña.Visible = true;
            cmb_TipoReseña.Visible = true;
            tomarTipoReseña();
        }

        public void tomarTipoReseña()
        {
            // Implementación del método para tomar tipo de reseña
            if (cmb_TipoReseña.Text!="")
            {
                tipoReseña = cmb_TipoReseña.Text;
                gestor.tomarTipoReseña(tipoReseña);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de Reseña.");
            }
            

        }

        public void pedirSeleccionFormasVisualizacion()
        {
            // Implementación del método para pedir selección de formas de visualización
            gboxSelecTipoVisual.Visible = true;
            tomarTiposFormasVisualizacion();
            if (tipoVisualizacion!="")
            {
                solicitarConfirmacion();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de visualizacion.");
            }
            
        }

        public void tomarTiposFormasVisualizacion()
        {
            // Implementación del método para tomar tipos de formas de visualización
            tipoVisualizacion=gestor.tomarTipoFormasVisualizacion(chk_Excel.Checked, chk_pdf.Checked, chk_pantalla.Checked);

        }


        public void solicitarConfirmacion()
        {
            // Implementación del método para solicitar confirmación
            DialogResult result = MessageBox.Show("Esta seguro que desea confirmar?","Confirmacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Código a ejecutar si se presiona Yes
                tomarConfirmacion();
            }
            else if (result == DialogResult.No)
            {
                // Código a ejecutar si se presiona No

            }

        }

        public void tomarConfirmacion()
        {
            // Implementación del método para tomar confirmación
            gestor.tomarConfirmacion(cmb_TipoReseña.Text, tipoVisualizacion);
        }

        public void informarGeneracionExitosa()
        {
            // Implementación del método para informar generación exitosa
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Limpia la datagrid de reseñas
            dgv_reseñas.Rows.Clear();

            fechaDesde = tomarFechaDesde();
            fechaHasta = tomarFechaHasta();
            

            gestor.fechasConsideracionReseñas(fechaDesde, fechaHasta);
            if (gestor.fechasValidas) 
            {
                pedirSeleccionTipoReseña();
            }
            else
            {
                MessageBox.Show("Debe ingresar fechas Validas.");
            }

            
        }

        private void chk_Excel_CheckedChanged(object sender, EventArgs e)
        {
            chk_pdf.Checked = false;
            chk_pantalla.Checked = false;
        }

        private void chk_pdf_CheckedChanged(object sender, EventArgs e)
        {
            chk_Excel.Checked = false;
            chk_pantalla.Checked = false;
        }

        private void chk_pantalla_CheckedChanged(object sender, EventArgs e)
        {
            chk_pdf.Checked = false;
            chk_Excel.Checked = false;
        }

        public void agregarFilaGrd(DataGridViewRow fila)
        {
            //grdLlamada2.Rows.Clear();
            dgv_reseñas.Rows.Add(fila);
        }
    }
}
