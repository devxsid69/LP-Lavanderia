using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SistEti
{
	/// <summary>
	/// Summary description for FInfImpEtiq.
	/// </summary>
	public class FInfImpEtiq : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnAcutalizar;
		private System.Windows.Forms.Label lblCorte;
		private System.Windows.Forms.TextBox tbCorte;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.DataGrid dgBuscarCut;
		private System.Windows.Forms.TextBox tbEtiqueta;
		private System.Windows.Forms.Label lblEtiqueta;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FInfImpEtiq()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAcutalizar = new System.Windows.Forms.Button();
			this.lblCorte = new System.Windows.Forms.Label();
			this.tbCorte = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.dgBuscarCut = new System.Windows.Forms.DataGrid();
			this.tbEtiqueta = new System.Windows.Forms.TextBox();
			this.lblEtiqueta = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgBuscarCut)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAcutalizar
			// 
			this.btnAcutalizar.Location = new System.Drawing.Point(480, 8);
			this.btnAcutalizar.Name = "btnAcutalizar";
			this.btnAcutalizar.TabIndex = 6;
			this.btnAcutalizar.Text = "Actualizar";
			this.btnAcutalizar.Click += new System.EventHandler(this.btnAcutalizar_Click);
			// 
			// lblCorte
			// 
			this.lblCorte.Location = new System.Drawing.Point(8, 8);
			this.lblCorte.Name = "lblCorte";
			this.lblCorte.Size = new System.Drawing.Size(80, 16);
			this.lblCorte.TabIndex = 8;
			this.lblCorte.Text = "No. Corte :";
			this.lblCorte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbCorte
			// 
			this.tbCorte.Location = new System.Drawing.Point(88, 8);
			this.tbCorte.Name = "tbCorte";
			this.tbCorte.Size = new System.Drawing.Size(128, 20);
			this.tbCorte.TabIndex = 5;
			this.tbCorte.Text = "";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(576, 320);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancelar";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// dgBuscarCut
			// 
			this.dgBuscarCut.DataMember = "";
			this.dgBuscarCut.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgBuscarCut.Location = new System.Drawing.Point(0, 40);
			this.dgBuscarCut.Name = "dgBuscarCut";
			this.dgBuscarCut.ReadOnly = true;
			this.dgBuscarCut.Size = new System.Drawing.Size(664, 272);
			this.dgBuscarCut.TabIndex = 7;
			// 
			// tbEtiqueta
			// 
			this.tbEtiqueta.Location = new System.Drawing.Point(320, 8);
			this.tbEtiqueta.Name = "tbEtiqueta";
			this.tbEtiqueta.Size = new System.Drawing.Size(128, 20);
			this.tbEtiqueta.TabIndex = 10;
			this.tbEtiqueta.Text = "";
			// 
			// lblEtiqueta
			// 
			this.lblEtiqueta.Location = new System.Drawing.Point(240, 8);
			this.lblEtiqueta.Name = "lblEtiqueta";
			this.lblEtiqueta.Size = new System.Drawing.Size(80, 16);
			this.lblEtiqueta.TabIndex = 11;
			this.lblEtiqueta.Text = "No. Etiqueta :";
			this.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FInfImpEtiq
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(666, 344);
			this.Controls.Add(this.lblEtiqueta);
			this.Controls.Add(this.tbEtiqueta);
			this.Controls.Add(this.btnAcutalizar);
			this.Controls.Add(this.lblCorte);
			this.Controls.Add(this.tbCorte);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.dgBuscarCut);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FInfImpEtiq";
			this.Text = "FInfImpEtiq";
			this.Load += new System.EventHandler(this.FInfImpEtiq_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgBuscarCut)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAcutalizar_Click(object sender, System.EventArgs e)
		{
			LlenaDetalle();
		}

		private void LlenaDetalle()
		{
			string sCorte = this.tbCorte.Text;
			string EtiquetaId = this.tbEtiqueta.Text;
			DataViewManager dvmDetalle;
			DataSet dsDetalle = new DataSet();
			dsDetalle.Clear();
			dsDetalle = SistEti.lpQueries.LlenaInfEtiq(sCorte,EtiquetaId);
			dvmDetalle = dsDetalle.DefaultViewManager;
			this.dgBuscarCut.DataSource = dvmDetalle.DataSet.Tables[0];
			this.dgBuscarCut.Refresh();			
		}


		private void FInfImpEtiq_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
