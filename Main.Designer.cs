namespace pryMarconiSP4
{
    partial class Main
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
            this.lstTotales = new System.Windows.Forms.ListBox();
            this.txtMozoDia = new System.Windows.Forms.TextBox();
            this.btnMozoDia = new System.Windows.Forms.Button();
            this.btnTotales = new System.Windows.Forms.Button();
            this.btnValidarDatos = new System.Windows.Forms.Button();
            this.dgvMozos = new System.Windows.Forms.DataGridView();
            this.mozo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bebidas_sin_alcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bebidas_con_alcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozos)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTotales
            // 
            this.lstTotales.FormattingEnabled = true;
            this.lstTotales.Location = new System.Drawing.Point(393, 261);
            this.lstTotales.Name = "lstTotales";
            this.lstTotales.Size = new System.Drawing.Size(120, 121);
            this.lstTotales.TabIndex = 11;
            // 
            // txtMozoDia
            // 
            this.txtMozoDia.Location = new System.Drawing.Point(124, 272);
            this.txtMozoDia.Name = "txtMozoDia";
            this.txtMozoDia.Size = new System.Drawing.Size(124, 20);
            this.txtMozoDia.TabIndex = 10;
            // 
            // btnMozoDia
            // 
            this.btnMozoDia.Location = new System.Drawing.Point(12, 261);
            this.btnMozoDia.Name = "btnMozoDia";
            this.btnMozoDia.Size = new System.Drawing.Size(106, 41);
            this.btnMozoDia.TabIndex = 9;
            this.btnMozoDia.Text = "Mozo del Día";
            this.btnMozoDia.UseVisualStyleBackColor = true;
            this.btnMozoDia.Click += new System.EventHandler(this.btnMozoDia_Click);
            // 
            // btnTotales
            // 
            this.btnTotales.Enabled = false;
            this.btnTotales.Location = new System.Drawing.Point(281, 261);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(106, 41);
            this.btnTotales.TabIndex = 8;
            this.btnTotales.Text = "Totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // btnValidarDatos
            // 
            this.btnValidarDatos.Location = new System.Drawing.Point(407, 164);
            this.btnValidarDatos.Name = "btnValidarDatos";
            this.btnValidarDatos.Size = new System.Drawing.Size(106, 41);
            this.btnValidarDatos.TabIndex = 7;
            this.btnValidarDatos.Text = "Validar Datos";
            this.btnValidarDatos.UseVisualStyleBackColor = true;
            this.btnValidarDatos.Click += new System.EventHandler(this.btnValidarDatos_Click);
            // 
            // dgvMozos
            // 
            this.dgvMozos.AllowUserToAddRows = false;
            this.dgvMozos.AllowUserToDeleteRows = false;
            this.dgvMozos.AllowUserToResizeColumns = false;
            this.dgvMozos.AllowUserToResizeRows = false;
            this.dgvMozos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMozos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mozo,
            this.Comidas,
            this.Bebidas_sin_alcohol,
            this.Bebidas_con_alcohol,
            this.Postres});
            this.dgvMozos.Location = new System.Drawing.Point(12, 12);
            this.dgvMozos.Name = "dgvMozos";
            this.dgvMozos.RowHeadersVisible = false;
            this.dgvMozos.Size = new System.Drawing.Size(503, 146);
            this.dgvMozos.TabIndex = 6;
            // 
            // mozo
            // 
            this.mozo.HeaderText = "Mozo";
            this.mozo.Name = "mozo";
            this.mozo.ReadOnly = true;
            // 
            // Comidas
            // 
            this.Comidas.HeaderText = "Comidas";
            this.Comidas.Name = "Comidas";
            // 
            // Bebidas_sin_alcohol
            // 
            this.Bebidas_sin_alcohol.HeaderText = "Bebidas sin alcohol";
            this.Bebidas_sin_alcohol.Name = "Bebidas_sin_alcohol";
            // 
            // Bebidas_con_alcohol
            // 
            this.Bebidas_con_alcohol.HeaderText = "Bebidas con alcohol";
            this.Bebidas_con_alcohol.Name = "Bebidas_con_alcohol";
            // 
            // Postres
            // 
            this.Postres.HeaderText = "Postres";
            this.Postres.Name = "Postres";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 394);
            this.Controls.Add(this.lstTotales);
            this.Controls.Add(this.txtMozoDia);
            this.Controls.Add(this.btnMozoDia);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.btnValidarDatos);
            this.Controls.Add(this.dgvMozos);
            this.Name = "Main";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTotales;
        private System.Windows.Forms.TextBox txtMozoDia;
        private System.Windows.Forms.Button btnMozoDia;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.Button btnValidarDatos;
        private System.Windows.Forms.DataGridView dgvMozos;
        private System.Windows.Forms.DataGridViewTextBoxColumn mozo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bebidas_sin_alcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bebidas_con_alcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postres;
    }
}

