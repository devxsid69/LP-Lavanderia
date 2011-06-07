using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace SistEti
{
	/// <summary>
	/// Summary description for FImportaCT.
	/// </summary>
	public class FImportaCT : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog ofdArchivoExcel;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label lblRutaArchivo;
		private System.Windows.Forms.TextBox tbxRutaArchivo;
		private System.Windows.Forms.Button btnImportar;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Button btnCancelar;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FImportaCT()
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
			this.ofdArchivoExcel = new System.Windows.Forms.OpenFileDialog();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.tbxRutaArchivo = new System.Windows.Forms.TextBox();
			this.lblRutaArchivo = new System.Windows.Forms.Label();
			this.btnImportar = new System.Windows.Forms.Button();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.lblFecha = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ofdArchivoExcel
			// 
			this.ofdArchivoExcel.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
			this.ofdArchivoExcel.Title = "Archivo a Inportar";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(296, 16);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.TabIndex = 0;
			this.btnBuscar.Text = "Buscar...";
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// tbxRutaArchivo
			// 
			this.tbxRutaArchivo.Enabled = false;
			this.tbxRutaArchivo.Location = new System.Drawing.Point(72, 16);
			this.tbxRutaArchivo.Name = "tbxRutaArchivo";
			this.tbxRutaArchivo.Size = new System.Drawing.Size(216, 20);
			this.tbxRutaArchivo.TabIndex = 1;
			this.tbxRutaArchivo.Text = "";
			// 
			// lblRutaArchivo
			// 
			this.lblRutaArchivo.Location = new System.Drawing.Point(16, 16);
			this.lblRutaArchivo.Name = "lblRutaArchivo";
			this.lblRutaArchivo.Size = new System.Drawing.Size(56, 16);
			this.lblRutaArchivo.TabIndex = 2;
			this.lblRutaArchivo.Text = "Direccion :";
			// 
			// btnImportar
			// 
			this.btnImportar.Location = new System.Drawing.Point(104, 72);
			this.btnImportar.Name = "btnImportar";
			this.btnImportar.TabIndex = 3;
			this.btnImportar.Text = "Importar";
			this.btnImportar.Visible = false;
			this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(72, 40);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(216, 20);
			this.dtpFecha.TabIndex = 15;
			// 
			// lblFecha
			// 
			this.lblFecha.Location = new System.Drawing.Point(24, 40);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(40, 16);
			this.lblFecha.TabIndex = 14;
			this.lblFecha.Text = "Fecha";
			this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(224, 72);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.TabIndex = 16;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.Visible = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FImportaCT
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(378, 112);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.btnImportar);
			this.Controls.Add(this.lblRutaArchivo);
			this.Controls.Add(this.tbxRutaArchivo);
			this.Controls.Add(this.btnBuscar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FImportaCT";
			this.Text = "FImportaCT";
			this.Load += new System.EventHandler(this.FImportaCT_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FImportaCT_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnBuscar_Click(object sender, System.EventArgs e)
		{
			
			if (this.ofdArchivoExcel.ShowDialog() == DialogResult.OK) 
			{			
				this.tbxRutaArchivo.Text = ofdArchivoExcel.FileName; 
				this.btnImportar.Visible = true;
			}
		
			
			
		}

		private void btnImportar_Click(object sender, System.EventArgs e)
		{
			//@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = c:\BASE DE DATOS LP\BD - LP - Lavado y Confeccion.accdb"
			int ilError = 0;
			OleDbConnection odcConexion ;
			
			DataSet dsUPCInf = new DataSet();
			DataSet dsUPCInf2 = new DataSet();
			//DataViewManager dvmDetalle;
			int ilCuttingId = 0;
			try
			{
				string slConexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source ="+this.tbxRutaArchivo.Text+@";Extended Properties =""Excel 12.0;HDR=NO""";
				odcConexion = new OleDbConnection(slConexion);
				odcConexion.Open();
				OleDbCommand odcSelect = new OleDbCommand("Select * from [CAPT$C1:C4]",odcConexion);
				OleDbDataAdapter odaAdapter = new OleDbDataAdapter(odcSelect);
				odaAdapter.Fill(dsUPCInf);
				string sCorte = dsUPCInf.Tables[0].Rows[0][0].ToString(); 
				string sContrato = dsUPCInf.Tables[0].Rows[1][0].ToString();
				string sEstilo = dsUPCInf.Tables[0].Rows[2][0].ToString();
				string sColor = dsUPCInf.Tables[0].Rows[3][0].ToString();
				string slFecha = this.dtpFecha.Text;
				ilCuttingId = SistEti.lpQueries.InsertaCorte(sCorte,sContrato,sEstilo,sColor,slFecha);

				OleDbCommand odcSelect2 = new OleDbCommand("Select * from [CAPT$K1:W5]",odcConexion);
				OleDbDataAdapter odaAdapter2 = new OleDbDataAdapter(odcSelect2);
				odaAdapter2.Fill(dsUPCInf2);

				int iFilTallaLargo = 0;
				int iColTallaAncho = 0;
				int ilColumna= 1;
				int ilFila = 1;
				int ilPrendas=0;
				string sTallaAncho ="";
				string sTallaLargo ="";
				string sTalla ="";

				for(ilFila =1; ilFila < dsUPCInf2.Tables[0].Rows.Count ; ilFila++)
				{					
					for( ilColumna = 1; ilColumna < dsUPCInf2.Tables[0].Columns.Count ; ilColumna++)
					{
						sTallaLargo = dsUPCInf2.Tables[0].Rows[iFilTallaLargo][ilColumna].ToString() + "x";					
						sTallaAncho = dsUPCInf2.Tables[0].Rows[ilFila][iColTallaAncho].ToString();
						sTalla = sTallaLargo+sTallaAncho;
						if(dsUPCInf2.Tables[0].Rows[ilFila][ilColumna].ToString() == "")						
							ilPrendas= 0;						
						else
							ilPrendas = Convert.ToInt32(dsUPCInf2.Tables[0].Rows[ilFila][ilColumna].ToString());
						//int ilResult = SistEti.lpQueries.UpdateTallaCorte(sgCorte,sTalla,ilPrendas);

						
						
						sTalla ="";

					}
				}
				
				//dsUPCInf2



				if(ilError==0)
					odcConexion.Close();

				MessageBox.Show("La Importación Realizada Satisfactoriamente.","Proceso Finalizado",MessageBoxButtons.OK);

			
			}
			catch//(Exception excError)
			{
				ilError =1;
				
				if(ilCuttingId != 0)
				{					
					SistEti.lpQueries.BorraCorte(ilCuttingId);
				}
				

				MessageBox.Show("La Importación No Pudo Ser Completada Satisfactoriamente.","Proceso Incompleto",MessageBoxButtons.OK);
			}

			
			 
		
		}

		private void btnCancelar_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
//		private void btnImportar_Click(object sender, System.EventArgs e)
//		{
//			//@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = c:\BASE DE DATOS LP\BD - LP - Lavado y Confeccion.accdb"
//			int ilError = 0;
//			OleDbConnection odcConexion ;
//			string slConexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = c:\BASE DE DATOS LP\BD - LP - Lavado y Confeccion.accdb";
//			odcConexion = new OleDbConnection(slConexion);
//			odcConexion.Open();
//			OleDbConnection odcConexion1 ;
//			string slConexion1 = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source ="+this.tbxRutaArchivo.Text+@";Extended Properties =""Excel 12.0;HDR=NO""";
//			odcConexion1 = new OleDbConnection(slConexion1);
//			odcConexion1.Open();
//
//			DataSet dsUPCInf = new DataSet();
//			DataSet dsUPCInf2 = new DataSet();
//			//DataViewManager dvmDetalle;
//			OleDbTransaction odtTrans;
//			odtTrans = odcConexion.BeginTransaction();
//			try
//			{
////				OleDbConnection odcConexion2 ;
////				odcConexion2 = new OleDbConnection(slConexion);
////				odcConexion2.Open();				
//				OleDbCommand odcSelect = new OleDbCommand("Select * from [CAPT$C1:C4]",odcConexion1);
//				OleDbDataAdapter odaAdapter = new OleDbDataAdapter(odcSelect);
//				odaAdapter.Fill(dsUPCInf);
//				
//				string sCorte = dsUPCInf.Tables[0].Rows[0][0].ToString(); 
//				string sContrato = dsUPCInf.Tables[0].Rows[1][0].ToString();
//				string sEstilo = dsUPCInf.Tables[0].Rows[2][0].ToString();
//				string sColor = dsUPCInf.Tables[0].Rows[3][0].ToString();
//				int ilCuttingId = SistEti.lpQueries.InsertaCorte(sCorte,sContrato,sEstilo,sColor,odtTrans, odcConexion);
//
//				OleDbCommand odcSelect2 = new OleDbCommand("Select * from [CAPT$K1:T6]",odcConexion1);
//				OleDbDataAdapter odaAdapter2 = new OleDbDataAdapter(odcSelect2);
//				odaAdapter2.Fill(dsUPCInf2);
//
//				int iFilTallaLargo = 0;
//				int iColTallaAncho = 0;
//				int ilColumna= 1;
//				int ilFila = 1;
//				int ilPrendas=0;
//				string sTallaAncho ="";
//				string sTallaLargo ="";
//				string sTalla ="";
//
//				for(ilFila =1; ilFila < dsUPCInf2.Tables[0].Rows.Count ; ilFila++)
//				{					
//					for( ilColumna = 1; ilColumna < dsUPCInf2.Tables[0].Columns.Count ; ilColumna++)
//					{
//						sTallaLargo = dsUPCInf2.Tables[0].Rows[iFilTallaLargo][ilColumna].ToString() + "x";					
//						sTallaAncho = dsUPCInf2.Tables[0].Rows[ilFila][iColTallaAncho].ToString();
//						sTalla = sTallaLargo+sTallaAncho;
//						if(dsUPCInf2.Tables[0].Rows[ilFila][ilColumna].ToString() == "")
//							ilPrendas= 0;						
//						else
//							ilPrendas = Convert.ToInt32(dsUPCInf2.Tables[0].Rows[ilFila][ilColumna].ToString());
//						int ilResult = SistEti.lpQueries.UpdateTallaCorte(ilCuttingId,sTalla,ilPrendas,odtTrans, odcConexion);
//
//						
//						
//						sTalla ="";
//
//					}
//				}
//				
//						//dsUPCInf2
//
//
//
//				if(ilError==0)
//				{
//					odcConexion1.Close();
//				}
//
//				MessageBox.Show("La Importación Realizada Satisfactoriamente.","Proceso Finalizado",MessageBoxButtons.OK);
//				odtTrans.Commit();
//
//			
//			}
//			catch(Exception excError)
//			{
//				ilError =1;
//				MessageBox.Show("La Importación No Pudo Ser Completada Satisfactoriamente.","Proceso Incompleto",MessageBoxButtons.OK);
//				odtTrans.Rollback();
//
//			}
//
//			
//			 
//		
//		}
	}
}
