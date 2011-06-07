using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SistEti
{
	/// <summary>
	/// Summary description for FBuscarCorte.
	/// </summary>
	public class FBuscarCorte : System.Windows.Forms.Form
	{

		public string spCorte;

		private System.Windows.Forms.DataGrid dgBuscarCut;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox tbCorte;
		private System.Windows.Forms.Label lblCorte;
		private System.Windows.Forms.Button btnAcutalizar;


		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FBuscarCorte()
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
			this.dgBuscarCut = new System.Windows.Forms.DataGrid();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tbCorte = new System.Windows.Forms.TextBox();
			this.lblCorte = new System.Windows.Forms.Label();
			this.btnAcutalizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgBuscarCut)).BeginInit();
			this.SuspendLayout();
			// 
			// dgBuscarCut
			// 
			this.dgBuscarCut.DataMember = "";
			this.dgBuscarCut.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgBuscarCut.Location = new System.Drawing.Point(8, 32);
			this.dgBuscarCut.Name = "dgBuscarCut";
			this.dgBuscarCut.ReadOnly = true;
			this.dgBuscarCut.Size = new System.Drawing.Size(424, 192);
			this.dgBuscarCut.TabIndex = 2;
			this.dgBuscarCut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgBuscarCut_MouseDown);
			this.dgBuscarCut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgBuscarCut_MouseUp);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(312, 232);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancelar";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// tbCorte
			// 
			this.tbCorte.Location = new System.Drawing.Point(88, 8);
			this.tbCorte.Name = "tbCorte";
			this.tbCorte.Size = new System.Drawing.Size(128, 20);
			this.tbCorte.TabIndex = 0;
			this.tbCorte.Text = "";
			// 
			// lblCorte
			// 
			this.lblCorte.Location = new System.Drawing.Point(8, 8);
			this.lblCorte.Name = "lblCorte";
			this.lblCorte.Size = new System.Drawing.Size(80, 16);
			this.lblCorte.TabIndex = 3;
			this.lblCorte.Text = "No. Corte :";
			this.lblCorte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAcutalizar
			// 
			this.btnAcutalizar.Location = new System.Drawing.Point(224, 8);
			this.btnAcutalizar.Name = "btnAcutalizar";
			this.btnAcutalizar.TabIndex = 1;
			this.btnAcutalizar.Text = "Actualizar";
			this.btnAcutalizar.Click += new System.EventHandler(this.btnAcutalizar_Click);
			// 
			// FBuscarCorte
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(434, 264);
			this.Controls.Add(this.btnAcutalizar);
			this.Controls.Add(this.lblCorte);
			this.Controls.Add(this.tbCorte);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.dgBuscarCut);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FBuscarCorte";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Buscar Corte";
			this.Load += new System.EventHandler(this.FBuscarCorte_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgBuscarCut)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FBuscarCorte_Load(object sender, System.EventArgs e)
		{
			LlenaDetalle("");
			this.tbCorte.Focus();
		}

		private void LlenaDetalle(string sCorte)
		{
			DataViewManager dvmDetalle;
			DataSet dsDetalle = new DataSet();
			dsDetalle.Clear();
			dsDetalle = SistEti.lpQueries.LlenaListaCT(sCorte);
			dvmDetalle = dsDetalle.DefaultViewManager;
			this.dgBuscarCut.DataSource = dvmDetalle.DataSet.Tables[0];
			this.dgBuscarCut.Refresh();			
		}

		private void dgBuscarCut_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			DataGrid dgGrid = (DataGrid) sender;
			System.Windows.Forms.DataGrid.HitTestInfo htiHit;
			htiHit = dgGrid.HitTest(e.X,e.Y);
			switch(htiHit.Type)
			{
				case System.Windows.Forms.DataGrid.HitTestType.Cell: 
					this.spCorte = Convert.ToString(this.dgBuscarCut[htiHit.Row,0]);
					this.Close();
					break;
			}
		}

		private void dgBuscarCut_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			DataGrid dgGrid = (DataGrid) sender;
			System.Windows.Forms.DataGrid.HitTestInfo htiHit;
			htiHit = dgGrid.HitTest(e.X,e.Y);
			switch(htiHit.Type)
			{
				case System.Windows.Forms.DataGrid.HitTestType.Cell: 
					this.spCorte = Convert.ToString(this.dgBuscarCut[htiHit.Row,0]);
					this.Close();
					break;
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnAcutalizar_Click(object sender, System.EventArgs e)
		{
			LlenaDetalle(this.tbCorte.Text);
		}	
	}
}
