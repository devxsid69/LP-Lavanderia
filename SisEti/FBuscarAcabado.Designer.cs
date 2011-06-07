namespace SistEti
{
    partial class FBuscarAcabado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAcabado = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvAcabados = new System.Windows.Forms.DataGridView();
            this.IdAcabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcabadoClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtiquetaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lpQueriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcabados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpQueriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acabado:";
            // 
            // tbxAcabado
            // 
            this.tbxAcabado.Location = new System.Drawing.Point(72, 10);
            this.tbxAcabado.Name = "tbxAcabado";
            this.tbxAcabado.Size = new System.Drawing.Size(82, 20);
            this.tbxAcabado.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(160, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvAcabados
            // 
            this.dgvAcabados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcabados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAcabado,
            this.AcabadoClave,
            this.EtiquetaDescripcion,
            this.Descripcion});
            this.dgvAcabados.Location = new System.Drawing.Point(12, 37);
            this.dgvAcabados.Name = "dgvAcabados";
            this.dgvAcabados.Size = new System.Drawing.Size(400, 186);
            this.dgvAcabados.TabIndex = 4;
            this.dgvAcabados.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvAcabados_MouseUp);
            // 
            // IdAcabado
            // 
            this.IdAcabado.DataPropertyName = "ID";
            this.IdAcabado.HeaderText = "Id";
            this.IdAcabado.Name = "IdAcabado";
            this.IdAcabado.ReadOnly = true;
            this.IdAcabado.Visible = false;
            // 
            // AcabadoClave
            // 
            this.AcabadoClave.DataPropertyName = "Clave";
            this.AcabadoClave.HeaderText = "Clave";
            this.AcabadoClave.Name = "AcabadoClave";
            this.AcabadoClave.ReadOnly = true;
            // 
            // EtiquetaDescripcion
            // 
            this.EtiquetaDescripcion.DataPropertyName = "Etiqueta";
            this.EtiquetaDescripcion.HeaderText = "Etiqueta";
            this.EtiquetaDescripcion.Name = "EtiquetaDescripcion";
            this.EtiquetaDescripcion.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // lpQueriesBindingSource
            // 
            this.lpQueriesBindingSource.DataSource = typeof(SistEti.lpQueries);
            // 
            // FBuscarAcabado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 264);
            this.Controls.Add(this.dgvAcabados);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxAcabado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FBuscarAcabado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Acabado";
            this.Load += new System.EventHandler(this.FBuscarAcabado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcabados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpQueriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAcabado;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvAcabados;
        private System.Windows.Forms.BindingSource lpQueriesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAcabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcabadoClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtiquetaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}