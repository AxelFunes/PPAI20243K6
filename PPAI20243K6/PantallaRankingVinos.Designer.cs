namespace PPAI20243K6
{
    partial class PantallaRankingVinos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lbl_FechaInicio = new System.Windows.Forms.Label();
            this.lbl_FechaFin = new System.Windows.Forms.Label();
            this.dt_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dt_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.lbl_TipoReseña = new System.Windows.Forms.Label();
            this.cmb_TipoReseña = new System.Windows.Forms.ComboBox();
            this.chk_pdf = new System.Windows.Forms.CheckBox();
            this.chk_Excel = new System.Windows.Forms.CheckBox();
            this.chk_pantalla = new System.Windows.Forms.CheckBox();
            this.gboxSelecTipoVisual = new System.Windows.Forms.GroupBox();
            this.dgv_reseñas = new System.Windows.Forms.DataGridView();
            this.c_Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_varietal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ptajes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboxSelecTipoVisual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reseñas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(182, 469);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(93, 34);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lbl_FechaInicio
            // 
            this.lbl_FechaInicio.AutoSize = true;
            this.lbl_FechaInicio.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaInicio.ForeColor = System.Drawing.Color.White;
            this.lbl_FechaInicio.Location = new System.Drawing.Point(53, 67);
            this.lbl_FechaInicio.Name = "lbl_FechaInicio";
            this.lbl_FechaInicio.Size = new System.Drawing.Size(87, 20);
            this.lbl_FechaInicio.TabIndex = 2;
            this.lbl_FechaInicio.Text = "Fecha Inicio";
            this.lbl_FechaInicio.Visible = false;
            // 
            // lbl_FechaFin
            // 
            this.lbl_FechaFin.AutoSize = true;
            this.lbl_FechaFin.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaFin.ForeColor = System.Drawing.Color.White;
            this.lbl_FechaFin.Location = new System.Drawing.Point(53, 95);
            this.lbl_FechaFin.Name = "lbl_FechaFin";
            this.lbl_FechaFin.Size = new System.Drawing.Size(68, 20);
            this.lbl_FechaFin.TabIndex = 3;
            this.lbl_FechaFin.Text = "Fecha Fin";
            this.lbl_FechaFin.Visible = false;
            // 
            // dt_FechaInicio
            // 
            this.dt_FechaInicio.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaInicio.Location = new System.Drawing.Point(154, 65);
            this.dt_FechaInicio.Name = "dt_FechaInicio";
            this.dt_FechaInicio.Size = new System.Drawing.Size(226, 24);
            this.dt_FechaInicio.TabIndex = 4;
            this.dt_FechaInicio.Visible = false;
            // 
            // dt_FechaFin
            // 
            this.dt_FechaFin.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaFin.Location = new System.Drawing.Point(154, 92);
            this.dt_FechaFin.Name = "dt_FechaFin";
            this.dt_FechaFin.Size = new System.Drawing.Size(226, 24);
            this.dt_FechaFin.TabIndex = 5;
            this.dt_FechaFin.Visible = false;
            // 
            // lbl_TipoReseña
            // 
            this.lbl_TipoReseña.AutoSize = true;
            this.lbl_TipoReseña.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoReseña.ForeColor = System.Drawing.Color.White;
            this.lbl_TipoReseña.Location = new System.Drawing.Point(53, 174);
            this.lbl_TipoReseña.Name = "lbl_TipoReseña";
            this.lbl_TipoReseña.Size = new System.Drawing.Size(88, 20);
            this.lbl_TipoReseña.TabIndex = 7;
            this.lbl_TipoReseña.Text = "Tipo Reseña";
            this.lbl_TipoReseña.Visible = false;
            // 
            // cmb_TipoReseña
            // 
            this.cmb_TipoReseña.FormattingEnabled = true;
            this.cmb_TipoReseña.Items.AddRange(new object[] {
            "Sommelier",
            "Normales",
            "Amigos"});
            this.cmb_TipoReseña.Location = new System.Drawing.Point(154, 174);
            this.cmb_TipoReseña.Name = "cmb_TipoReseña";
            this.cmb_TipoReseña.Size = new System.Drawing.Size(121, 21);
            this.cmb_TipoReseña.TabIndex = 8;
            this.cmb_TipoReseña.Visible = false;
            // 
            // chk_pdf
            // 
            this.chk_pdf.AutoSize = true;
            this.chk_pdf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_pdf.Location = new System.Drawing.Point(26, 72);
            this.chk_pdf.Name = "chk_pdf";
            this.chk_pdf.Size = new System.Drawing.Size(57, 21);
            this.chk_pdf.TabIndex = 10;
            this.chk_pdf.Text = "PDF";
            this.chk_pdf.UseVisualStyleBackColor = true;
            this.chk_pdf.CheckedChanged += new System.EventHandler(this.chk_pdf_CheckedChanged);
            // 
            // chk_Excel
            // 
            this.chk_Excel.AutoSize = true;
            this.chk_Excel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Excel.Location = new System.Drawing.Point(26, 33);
            this.chk_Excel.Name = "chk_Excel";
            this.chk_Excel.Size = new System.Drawing.Size(67, 21);
            this.chk_Excel.TabIndex = 9;
            this.chk_Excel.Text = "Excel";
            this.chk_Excel.UseVisualStyleBackColor = true;
            this.chk_Excel.CheckedChanged += new System.EventHandler(this.chk_Excel_CheckedChanged);
            // 
            // chk_pantalla
            // 
            this.chk_pantalla.AutoSize = true;
            this.chk_pantalla.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_pantalla.Location = new System.Drawing.Point(26, 109);
            this.chk_pantalla.Name = "chk_pantalla";
            this.chk_pantalla.Size = new System.Drawing.Size(86, 21);
            this.chk_pantalla.TabIndex = 11;
            this.chk_pantalla.Text = "Pantalla";
            this.chk_pantalla.UseVisualStyleBackColor = true;
            this.chk_pantalla.CheckedChanged += new System.EventHandler(this.chk_pantalla_CheckedChanged);
            // 
            // gboxSelecTipoVisual
            // 
            this.gboxSelecTipoVisual.Controls.Add(this.chk_Excel);
            this.gboxSelecTipoVisual.Controls.Add(this.chk_pantalla);
            this.gboxSelecTipoVisual.Controls.Add(this.chk_pdf);
            this.gboxSelecTipoVisual.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSelecTipoVisual.ForeColor = System.Drawing.Color.White;
            this.gboxSelecTipoVisual.Location = new System.Drawing.Point(56, 269);
            this.gboxSelecTipoVisual.Name = "gboxSelecTipoVisual";
            this.gboxSelecTipoVisual.Size = new System.Drawing.Size(225, 146);
            this.gboxSelecTipoVisual.TabIndex = 19;
            this.gboxSelecTipoVisual.TabStop = false;
            this.gboxSelecTipoVisual.Text = "Tipo Visualizacion";
            this.gboxSelecTipoVisual.Visible = false;
            // 
            // dgv_reseñas
            // 
            this.dgv_reseñas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_reseñas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reseñas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_Promedio,
            this.c_nombre,
            this.c_precio,
            this.c_bodega,
            this.c_varietal,
            this.c_ptajes});
            this.dgv_reseñas.GridColor = System.Drawing.Color.White;
            this.dgv_reseñas.Location = new System.Drawing.Point(385, 65);
            this.dgv_reseñas.Name = "dgv_reseñas";
            this.dgv_reseñas.RowHeadersWidth = 51;
            this.dgv_reseñas.Size = new System.Drawing.Size(656, 374);
            this.dgv_reseñas.TabIndex = 20;
            // 
            // c_Promedio
            // 
            this.c_Promedio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.c_Promedio.HeaderText = "Promedio";
            this.c_Promedio.MinimumWidth = 6;
            this.c_Promedio.Name = "c_Promedio";
            this.c_Promedio.Width = 76;
            // 
            // c_nombre
            // 
            this.c_nombre.HeaderText = "Nombre";
            this.c_nombre.MinimumWidth = 6;
            this.c_nombre.Name = "c_nombre";
            this.c_nombre.Width = 125;
            // 
            // c_precio
            // 
            this.c_precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.c_precio.HeaderText = "Precio";
            this.c_precio.MinimumWidth = 6;
            this.c_precio.Name = "c_precio";
            this.c_precio.Width = 62;
            // 
            // c_bodega
            // 
            this.c_bodega.HeaderText = "Bodega";
            this.c_bodega.MinimumWidth = 6;
            this.c_bodega.Name = "c_bodega";
            this.c_bodega.Width = 125;
            // 
            // c_varietal
            // 
            this.c_varietal.HeaderText = "Varietal";
            this.c_varietal.MinimumWidth = 6;
            this.c_varietal.Name = "c_varietal";
            this.c_varietal.Width = 125;
            // 
            // c_ptajes
            // 
            this.c_ptajes.HeaderText = "Puntajes";
            this.c_ptajes.MinimumWidth = 6;
            this.c_ptajes.Name = "c_ptajes";
            this.c_ptajes.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPAI20243K6.Properties.Resources.vinobodegapequeño;
            this.pictureBox1.Location = new System.Drawing.Point(848, 444);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 155);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaRankingVinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(21)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1091, 608);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_reseñas);
            this.Controls.Add(this.gboxSelecTipoVisual);
            this.Controls.Add(this.cmb_TipoReseña);
            this.Controls.Add(this.lbl_TipoReseña);
            this.Controls.Add(this.dt_FechaFin);
            this.Controls.Add(this.dt_FechaInicio);
            this.Controls.Add(this.lbl_FechaFin);
            this.Controls.Add(this.lbl_FechaInicio);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "PantallaRankingVinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking de Vinos";
            this.gboxSelecTipoVisual.ResumeLayout(false);
            this.gboxSelecTipoVisual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reseñas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lbl_FechaInicio;
        private System.Windows.Forms.Label lbl_FechaFin;
        private System.Windows.Forms.DateTimePicker dt_FechaInicio;
        private System.Windows.Forms.DateTimePicker dt_FechaFin;
        private System.Windows.Forms.Label lbl_TipoReseña;
        private System.Windows.Forms.ComboBox cmb_TipoReseña;
        private System.Windows.Forms.CheckBox chk_pdf;
        private System.Windows.Forms.CheckBox chk_Excel;
        private System.Windows.Forms.CheckBox chk_pantalla;
        private System.Windows.Forms.GroupBox gboxSelecTipoVisual;
        private System.Windows.Forms.DataGridView dgv_reseñas;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_varietal;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ptajes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

