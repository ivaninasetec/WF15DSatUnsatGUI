namespace GUI15DSATUNSAT
{
    partial class Control_output_table_constraints
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.datagridview_output_constraints = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_output_constraints)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview_output_constraints
            // 
            this.datagridview_output_constraints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_output_constraints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview_output_constraints.Location = new System.Drawing.Point(0, 0);
            this.datagridview_output_constraints.Name = "datagridview_output_constraints";
            this.datagridview_output_constraints.Size = new System.Drawing.Size(520, 540);
            this.datagridview_output_constraints.TabIndex = 0;
            // 
            // control_output_table_constraints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datagridview_output_constraints);
            this.Name = "control_output_table_constraints";
            this.Size = new System.Drawing.Size(520, 540);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_output_constraints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView datagridview_output_constraints;
    }
}
