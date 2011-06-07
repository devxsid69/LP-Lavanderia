namespace SistEti
{
    partial class FEstilo
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
            this.cbxEstiloCodigo = new System.Windows.Forms.ComboBox();
            this.cbxAcabado = new System.Windows.Forms.ComboBox();
            this.lblSeparador1 = new System.Windows.Forms.Label();
            this.tbxModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCode2 = new System.Windows.Forms.TextBox();
            this.lblEstiloText = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxEstiloCodigo
            // 
            this.cbxEstiloCodigo.FormattingEnabled = true;
            this.cbxEstiloCodigo.Items.AddRange(new object[] {
            "Selecciona",
            "J55",
            "J65"});
            this.cbxEstiloCodigo.Location = new System.Drawing.Point(22, 24);
            this.cbxEstiloCodigo.Name = "cbxEstiloCodigo";
            this.cbxEstiloCodigo.Size = new System.Drawing.Size(79, 21);
            this.cbxEstiloCodigo.TabIndex = 0;
            this.cbxEstiloCodigo.Text = "Selecciona";
            // 
            // cbxAcabado
            // 
            this.cbxAcabado.FormattingEnabled = true;
            this.cbxAcabado.Location = new System.Drawing.Point(120, 24);
            this.cbxAcabado.Name = "cbxAcabado";
            this.cbxAcabado.Size = new System.Drawing.Size(111, 21);
            this.cbxAcabado.TabIndex = 1;
            // 
            // lblSeparador1
            // 
            this.lblSeparador1.AutoSize = true;
            this.lblSeparador1.Location = new System.Drawing.Point(107, 27);
            this.lblSeparador1.Name = "lblSeparador1";
            this.lblSeparador1.Size = new System.Drawing.Size(10, 13);
            this.lblSeparador1.TabIndex = 2;
            this.lblSeparador1.Text = "-";
            // 
            // tbxModelo
            // 
            this.tbxModelo.Location = new System.Drawing.Point(253, 25);
            this.tbxModelo.MaxLength = 3;
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.Size = new System.Drawing.Size(41, 20);
            this.tbxModelo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "-";
            // 
            // tbxCode2
            // 
            this.tbxCode2.Location = new System.Drawing.Point(316, 24);
            this.tbxCode2.MaxLength = 2;
            this.tbxCode2.Name = "tbxCode2";
            this.tbxCode2.Size = new System.Drawing.Size(33, 20);
            this.tbxCode2.TabIndex = 6;
            this.tbxCode2.Text = "0W";
            // 
            // lblEstiloText
            // 
            this.lblEstiloText.AutoSize = true;
            this.lblEstiloText.Location = new System.Drawing.Point(66, 72);
            this.lblEstiloText.Name = "lblEstiloText";
            this.lblEstiloText.Size = new System.Drawing.Size(35, 13);
            this.lblEstiloText.TabIndex = 7;
            this.lblEstiloText.Text = "Estilo:";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstilo.Location = new System.Drawing.Point(115, 63);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(19, 25);
            this.lblEstilo.TabIndex = 8;
            this.lblEstilo.Text = "-";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(355, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(26, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FEstilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 131);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblEstiloText);
            this.Controls.Add(this.tbxCode2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxModelo);
            this.Controls.Add(this.lblSeparador1);
            this.Controls.Add(this.cbxAcabado);
            this.Controls.Add(this.cbxEstiloCodigo);
            this.Name = "FEstilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catalogo Estilos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEstiloCodigo;
        private System.Windows.Forms.ComboBox cbxAcabado;
        private System.Windows.Forms.Label lblSeparador1;
        private System.Windows.Forms.TextBox tbxModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCode2;
        private System.Windows.Forms.Label lblEstiloText;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Button btnBuscar;
    }
}