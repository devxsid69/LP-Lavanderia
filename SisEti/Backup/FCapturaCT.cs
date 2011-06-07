using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.IO;
using System.Configuration;


namespace SistEti
{
	/// <summary>
	/// Summary description for FCapturaCT.
	/// </summary>
	public class FCapturaCT : System.Windows.Forms.Form
	{
		private string sgCorte ="";
		private bool bgModoEdicion = false;
		private System.Windows.Forms.TextBox tbCorte;
		private System.Windows.Forms.TextBox tbContrato;
		private System.Windows.Forms.Label lblCorte;
		private System.Windows.Forms.Label lblContrato;
		private System.Windows.Forms.Label lblEstilo;
		private System.Windows.Forms.Label lblColor;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGrid dtgCapturaMzCT;
		private System.Windows.Forms.ComboBox cbxColor;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Timer tmrActualiza;
		private System.Windows.Forms.Label lblTotalT;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxEstilos;
		private System.Windows.Forms.Button btnExpAcum;
		private System.Windows.Forms.Button btnExportaListaPL;
		private System.ComponentModel.IContainer components;

		public FCapturaCT()
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
			this.components = new System.ComponentModel.Container();
			this.tbCorte = new System.Windows.Forms.TextBox();
			this.tbContrato = new System.Windows.Forms.TextBox();
			this.cbxColor = new System.Windows.Forms.ComboBox();
			this.lblCorte = new System.Windows.Forms.Label();
			this.lblContrato = new System.Windows.Forms.Label();
			this.lblEstilo = new System.Windows.Forms.Label();
			this.lblColor = new System.Windows.Forms.Label();
			this.dtgCapturaMzCT = new System.Windows.Forms.DataGrid();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.lblFecha = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lblTotalT = new System.Windows.Forms.Label();
			this.tmrActualiza = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.cbxEstilos = new System.Windows.Forms.ComboBox();
			this.btnExpAcum = new System.Windows.Forms.Button();
			this.btnExportaListaPL = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtgCapturaMzCT)).BeginInit();
			this.SuspendLayout();
			// 
			// tbCorte
			// 
			this.tbCorte.Location = new System.Drawing.Point(16, 40);
			this.tbCorte.MaxLength = 9;
			this.tbCorte.Name = "tbCorte";
			this.tbCorte.TabIndex = 0;
			this.tbCorte.Text = "";
			this.tbCorte.TextChanged += new System.EventHandler(this.tbCorte_TextChanged);
			// 
			// tbContrato
			// 
			this.tbContrato.Location = new System.Drawing.Point(128, 40);
			this.tbContrato.MaxLength = 5;
			this.tbContrato.Name = "tbContrato";
			this.tbContrato.TabIndex = 1;
			this.tbContrato.Text = "";
			this.tbContrato.TextChanged += new System.EventHandler(this.tbContrato_TextChanged);
			// 
			// cbxColor
			// 
			this.cbxColor.Enabled = false;
			this.cbxColor.Items.AddRange(new object[] {
														  "Selecciona",
														  "LTSW",
														  "DKSW",
														  "MEDSW"});
			this.cbxColor.Location = new System.Drawing.Point(352, 40);
			this.cbxColor.Name = "cbxColor";
			this.cbxColor.Size = new System.Drawing.Size(121, 21);
			this.cbxColor.TabIndex = 3;
			this.cbxColor.Text = "Selecciona";
			// 
			// lblCorte
			// 
			this.lblCorte.Location = new System.Drawing.Point(24, 24);
			this.lblCorte.Name = "lblCorte";
			this.lblCorte.Size = new System.Drawing.Size(88, 16);
			this.lblCorte.TabIndex = 4;
			this.lblCorte.Text = "Corte*";
			this.lblCorte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblContrato
			// 
			this.lblContrato.Location = new System.Drawing.Point(136, 24);
			this.lblContrato.Name = "lblContrato";
			this.lblContrato.Size = new System.Drawing.Size(88, 16);
			this.lblContrato.TabIndex = 5;
			this.lblContrato.Text = "Contrato*";
			this.lblContrato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblEstilo
			// 
			this.lblEstilo.Location = new System.Drawing.Point(248, 24);
			this.lblEstilo.Name = "lblEstilo";
			this.lblEstilo.Size = new System.Drawing.Size(88, 16);
			this.lblEstilo.TabIndex = 6;
			this.lblEstilo.Text = "Estilo*";
			this.lblEstilo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblColor
			// 
			this.lblColor.Location = new System.Drawing.Point(360, 24);
			this.lblColor.Name = "lblColor";
			this.lblColor.Size = new System.Drawing.Size(88, 16);
			this.lblColor.TabIndex = 7;
			this.lblColor.Text = "Color*";
			this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtgCapturaMzCT
			// 
			this.dtgCapturaMzCT.AllowDrop = true;
			this.dtgCapturaMzCT.AllowSorting = false;
			this.dtgCapturaMzCT.DataMember = "";
			this.dtgCapturaMzCT.Enabled = false;
			this.dtgCapturaMzCT.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dtgCapturaMzCT.Location = new System.Drawing.Point(8, 64);
			this.dtgCapturaMzCT.Name = "dtgCapturaMzCT";
			this.dtgCapturaMzCT.PreferredColumnWidth = 50;
			this.dtgCapturaMzCT.Size = new System.Drawing.Size(800, 224);
			this.dtgCapturaMzCT.TabIndex = 5;
			this.dtgCapturaMzCT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgCapturaMzCT_KeyDown);
			this.dtgCapturaMzCT.CurrentCellChanged += new System.EventHandler(this.dtgCapturaMzCT_CurrentCellChanged);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(616, 296);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.TabIndex = 6;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(720, 296);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.TabIndex = 7;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(512, 296);
			this.btnExport.Name = "btnExport";
			this.btnExport.TabIndex = 11;
			this.btnExport.Text = "Empaque";
			this.btnExport.Visible = false;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// lblFecha
			// 
			this.lblFecha.Location = new System.Drawing.Point(480, 24);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(88, 16);
			this.lblFecha.TabIndex = 12;
			this.lblFecha.Text = "Fecha*";
			this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(480, 40);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(104, 20);
			this.dtpFecha.TabIndex = 4;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(592, 40);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.TabIndex = 14;
			this.btnSearch.Text = "Buscar";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lblTotalT
			// 
			this.lblTotalT.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTotalT.Location = new System.Drawing.Point(176, 288);
			this.lblTotalT.Name = "lblTotalT";
			this.lblTotalT.Size = new System.Drawing.Size(144, 40);
			this.lblTotalT.TabIndex = 15;
			this.lblTotalT.Text = "0";
			this.lblTotalT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tmrActualiza
			// 
			this.tmrActualiza.Tick += new System.EventHandler(this.tmrActualiza_Tick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 288);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 40);
			this.label1.TabIndex = 16;
			this.label1.Text = "TOTAL :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbxEstilos
			// 
			this.cbxEstilos.Location = new System.Drawing.Point(232, 40);
			this.cbxEstilos.Name = "cbxEstilos";
			this.cbxEstilos.Size = new System.Drawing.Size(121, 21);
			this.cbxEstilos.TabIndex = 2;
			this.cbxEstilos.Text = "Selecciona";
			this.cbxEstilos.SelectedIndexChanged += new System.EventHandler(this.cbxEstilos_SelectedIndexChanged);
			// 
			// btnExpAcum
			// 
			this.btnExpAcum.Location = new System.Drawing.Point(504, 328);
			this.btnExpAcum.Name = "btnExpAcum";
			this.btnExpAcum.Size = new System.Drawing.Size(128, 23);
			this.btnExpAcum.TabIndex = 17;
			this.btnExpAcum.Text = "Exportar Acumulado";
			this.btnExpAcum.Visible = false;
			this.btnExpAcum.Click += new System.EventHandler(this.btnExpAcum_Click);
			// 
			// btnExportaListaPL
			// 
			this.btnExportaListaPL.Location = new System.Drawing.Point(352, 296);
			this.btnExportaListaPL.Name = "btnExportaListaPL";
			this.btnExportaListaPL.Size = new System.Drawing.Size(128, 23);
			this.btnExportaListaPL.TabIndex = 18;
			this.btnExportaListaPL.Text = "Exportar Listado";
			this.btnExportaListaPL.Click += new System.EventHandler(this.btnExportaListaPL_Click);
			// 
			// FCapturaCT
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(824, 358);
			this.Controls.Add(this.btnExportaListaPL);
			this.Controls.Add(this.btnExpAcum);
			this.Controls.Add(this.cbxEstilos);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTotalT);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dtgCapturaMzCT);
			this.Controls.Add(this.lblColor);
			this.Controls.Add(this.lblEstilo);
			this.Controls.Add(this.lblContrato);
			this.Controls.Add(this.lblCorte);
			this.Controls.Add(this.cbxColor);
			this.Controls.Add(this.tbContrato);
			this.Controls.Add(this.tbCorte);
			this.Name = "FCapturaCT";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cutting Ticket";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FCapturaCT_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgCapturaMzCT)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region private void btnGuardar_Click(object sender, System.EventArgs e)
		private void btnGuardar_Click(object sender, System.EventArgs e)
		{
			bool blValidaExitenciaCorte = false;
			int ilCuttingId=0;
			string []slHeaders = new string[]{"","30","32","33","34","36","38","40","42","44","46","48","50"};
			if((this.tbCorte.Text != "") &&  (this.tbCorte.Text != "") && (this.tbCorte.Text != "")&&((this.cbxColor.Text != "Selecciona"))) 
			{
				if((ValidaTextoCorte(tbCorte.Text))&& (ValidaTextoContrato(this.tbContrato.Text)))
				{
					try
					{
						string slFecha = dtpFecha.Value.Date.Day.ToString()+"/"+dtpFecha.Value.Date.Month.ToString()+"/"+dtpFecha.Value.Date.Year.ToString();
						if(bgModoEdicion)
						{						
							SistEti.lpQueries.ActualizaCorte(this.sgCorte, this.tbCorte.Text,this.tbContrato.Text,this.cbxEstilos.Text,this.cbxColor.Text,slFecha);
						}
						else
						{
							blValidaExitenciaCorte = SistEti.lpQueries.VerificaExistenciaCorte(this.tbCorte.Text);
							if(!blValidaExitenciaCorte)
							{
								ilCuttingId = SistEti.lpQueries.InsertaCorte(this.tbCorte.Text,this.tbContrato.Text,this.cbxEstilos.Text,this.cbxColor.Text,slFecha);
								sgCorte = ilCuttingId.ToString();
							}
						}
						if(!blValidaExitenciaCorte)
						{
							for(int ilRow = 0; ilRow < 4; ilRow++)
							{
								string slAncho = Convert.ToString(dtgCapturaMzCT[ilRow,0]);
								string slTalla = "";
								for(int ilCol = 1; ilCol < 13 ;ilCol++)
								{ 						
									int ilPrendas = Convert.ToInt32(dtgCapturaMzCT[ilRow,ilCol]);
									slTalla = slHeaders[ilCol]+ slAncho;
									int ilResult = SistEti.lpQueries.UpdateTallaCorte(sgCorte,slTalla,ilPrendas);
								}
							}
							MessageBox.Show("La información fue guardada satisfactoriamente.","Proceso Completo",MessageBoxButtons.OK);
							bgModoEdicion = true;
						}
						else
						{
							MessageBox.Show("El Corte que Esta Intentando dar de Alta ya Existe.","Proceso Incompleto",MessageBoxButtons.OK);
						}
					}
					catch
					{
						//ilError =1;
				
						if(ilCuttingId != 0)
						{					
							SistEti.lpQueries.BorraCorte(ilCuttingId);
						}
						MessageBox.Show("La información no pudo ser guardada satisfactoriamente.","Proceso Incompleto",MessageBoxButtons.OK);
					}
				}
				else
				{
					if(((tbCorte.Text.Length!=8)||(tbCorte.Text.Length!=9))||(this.tbContrato.Text.Length==5))
						MessageBox.Show(@"La captura del CORTE ""LL####000"" o CONTRATO ""L####"" no cumple son los requisitos.","Captura Incorrecta",MessageBoxButtons.OK);
				}
				
			}
			else
			{
				MessageBox.Show("Llene los campos obligatorios *.","Proceso Incompleto",MessageBoxButtons.OK);
			}
		}
		#endregion //private void btnGuardar_Click(object sender, System.EventArgs e)

		private void btnCancelar_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void FCapturaCT_Load(object sender, System.EventArgs e)
		{
			llenaCombodeEstilo();
			llenaMatriz();
		}
		
		private void llenaCombodeEstilo()
		{
			DataSet dsMatriz = new DataSet();
			dsMatriz = SistEti.lpQueries.LlenaEstilos();

			if((dsMatriz.Tables.Count>0)&&(dsMatriz.Tables[0].Rows.Count>0))
			{
				for(int ilCont = 0 ; ilCont < dsMatriz.Tables[0].Rows.Count; ilCont ++)
					this.cbxEstilos.Items.Add(dsMatriz.Tables[0].Rows[ilCont][1].ToString());
			}

		}

		private void llenaMatriz()
		{
			DataSet dsMatriz = new DataSet();
			dsMatriz = SistEti.lpQueries.LlenaMatrizCaptCT();
			DataViewManager dvmDetalle;
			dvmDetalle = dsMatriz.DefaultViewManager;
			dvmDetalle.DataSet.Tables[0].Columns[0].ReadOnly=true;
			for(int ilRow = 1; ilRow <dvmDetalle.DataSet.Tables[0].Columns.Count; ilRow++)
			{
				dvmDetalle.DataSet.Tables[0].Columns[ilRow].DefaultValue=0;
				dvmDetalle.DataSet.Tables[0].Columns[ilRow].DataType = System.Type.GetType("System.Int32");
			}
			
			string slEstilo = this.cbxEstilos.Text.Substring(0,3);
			switch(slEstilo)
			{
				case "J55":					
					dvmDetalle.DataSet.Tables[0].Columns[10].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[11].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[12].ReadOnly=true;
					
					break;
				case "J65":
					dvmDetalle.DataSet.Tables[0].Columns[1].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[2].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[3].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[4].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[5].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[6].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[7].ReadOnly=true;				
					dvmDetalle.DataSet.Tables[0].Columns[8].ReadOnly=true;
					//dvmDetalle.DataSet.Tables[0].Columns[9].ReadOnly=true;
					break;				
				default:
					break;
			}
			this.dtgCapturaMzCT.DataSource = dvmDetalle.DataSet.Tables[0];
			this.dtgCapturaMzCT.Refresh();
		}

		private int  GeneraReporteEmbarque(string slTipoCaja, int ilFlatNumber)
		{
			string slCorte = this.tbCorte.Text;
			string slEstilo = this.cbxEstilos.Text;
			string slContrato = this.tbContrato.Text;
			string slColor =this.cbxColor.Text;

			string slFlatType ="";
			string slFlatNumber ="";
			string slCasesFlat ="";
			string slDozensFlat ="";
			string slTalla ="";
			string slPairs ="";
			string slTotalPairs ="0";
			int ilRow =0;
			int ilNoCajaCons=0;			
			bool blCreaArchivo = true;
			int ilCTotalCajas = 0;
			
			DataSet dsDetalle = new DataSet();			
			dsDetalle = SistEti.lpQueries.LlenaPLCT(this.sgCorte,slTipoCaja,"100 PERCENT ","0");

			switch(slTipoCaja)
			{
				case "1":
					slFlatType ="Solids";
					break;
				case "2":
					slFlatType ="Seconds";
					break;
				case "3":
					slFlatType ="Thirds";
					break;
				case "4":
					slFlatType ="Solids";
					break;
			}

			System.IO.StreamWriter arcHTML;
			while(blCreaArchivo)
			{			
				#region AchivoHTML slArchivoHTML
				string slArchivoHTML ="";
				string slEncabezado1 ="";
				string slEncabezado2 ="";
				string slDetalle ="";
				string slFooter = "";
				

				switch(ilFlatNumber)
				{
					case 1:
						ilCTotalCajas = ilCTotalCajas + 25;
						break;
					case 2 :
						ilCTotalCajas = ilCTotalCajas + 25;
						break;
					case 3:
						ilCTotalCajas = ilCTotalCajas + 10;
						break;
					case 4:
						ilCTotalCajas = ilCTotalCajas + 10;
						break;
					case 5 :
						ilCTotalCajas = ilCTotalCajas + 25;
						break;
					case 6:
						if(slTipoCaja=="1")
							ilCTotalCajas = ilCTotalCajas + 10;
						else
							ilCTotalCajas = ilCTotalCajas + 25;

						break;
					case 7 :
						if(slTipoCaja=="1")
							ilCTotalCajas = ilCTotalCajas + 25;
						else
							ilCTotalCajas = ilCTotalCajas + 25;						
						break;						
					default:
						ilCTotalCajas = ilCTotalCajas + 25;
						break;
				}
				if(ilCTotalCajas > dsDetalle.Tables[0].Rows.Count)
				{
					ilCTotalCajas = dsDetalle.Tables[0].Rows.Count;
				}
				if(dsDetalle.Tables[0].Rows.Count==0)
					blCreaArchivo = false;

				#region Detalle
				slDetalle = slDetalle +@"			
			<TR><!--Fila 13-->
				<TD ></TD>
				<TD colspan =""5"">
					<table border=""1"" cellspacing=-1 cellpadding=1 bordercolor=""000000"">
						<TR>
							<TD style=""WIDTH: 90px"">
								<P align=""center"">CASE No.</P>
							</TD>
							<TD style=""WIDTH: 58px"">
								<P align=""center"">SIZE</P>
							</TD>
							<TD>
								<P align=""center"">PAIRS</P>
							</TD>				
						</TR>
					";	
				int ilCaja =0;
				slTotalPairs="0";
				for(ilRow = ilNoCajaCons ;ilRow <ilCTotalCajas/*dsDetalle.Tables[0].Rows.Count*/; ilRow++)
				{
					ilCaja = ilCaja + 1;
					slTalla = dsDetalle.Tables[0].Rows[ilRow][1].ToString();
					slPairs = dsDetalle.Tables[0].Rows[ilRow][2].ToString();
					slTotalPairs = Convert.ToString( Convert.ToInt64(slTotalPairs)+Convert.ToInt64(slPairs));
					slDetalle = slDetalle +@"		
						<TR>				
							<TD style=""WIDTH: 90px""><P align=""center"">"+Convert.ToString(ilRow+1)+@"</P></TD>
							<TD style=""WIDTH: 58px""><P align=""center"">"+slTalla+@"</P></TD>
							<TD><P align=""center"">"+slPairs+@"</P></TD>					
						</TR>
				";
				}
				ilNoCajaCons=ilRow;
				slDetalle = slDetalle +@"
					<TR>						
						<TD style=""WIDTH: 90px"" align=""center"">TOTAL</TD>
						<TD style=""WIDTH: 58px"" align=""center"">"+ilCaja.ToString()+@"</TD>						
						<TD align=""center"">"+slTotalPairs+@"</TD>						
					</TR>			
				</table>
				</TD>
				<TD ></TD>
			</TR>";
				if(ilCaja<43)
				{
					for(int ilRow2 = ilCaja+1 ; ilRow2<=31 ;ilRow2++)
					{
						slDetalle = slDetalle+@"	
					<TR><!--Fila 1-->
						<TD ></TD>
						<TD>&nbsp;</TD>
						<TD>&nbsp;</TD>
						<TD></TD>
						<TD></TD>
						<TD></TD>
						<TD></TD>
					</TR>
					";
					}
					slDetalle = slDetalle +@"
					";

				}
	
				#region Detalle 2
				//			slArchivoHTML= slArchivoHTML+@"		<TR> <!--Fila 14-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 15-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 16-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 17-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 18-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 19-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 20-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 21-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 22-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 23-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 24-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 25-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 26-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 27-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 28-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 29-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 30-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 31-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 32-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 33-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 34-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 35-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 36-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 37-->
				//				<TD style=""WIDTH: 56px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 38-->
				//				<TD style=""WIDTH: 56px; HEIGHT: 18px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 39-->
				//				<TD style=""WIDTH: 56px; HEIGHT: 18px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 40-->
				//				<TD style=""WIDTH: 56px; HEIGHT: 18px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 41-->
				//				<TD style=""WIDTH: 56px; HEIGHT: 18px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//			<TR> <!--Fila 42-->
				//				<TD style=""WIDTH: 56px; HEIGHT: 18px""></TD>
				//				<TD style=""WIDTH: 72px""></TD>
				//				<TD style=""WIDTH: 58px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD style=""WIDTH: 11px""></TD>
				//				<TD style=""WIDTH: 25px""></TD>
				//				<TD style=""WIDTH: 2px""></TD>
				//				<TD style=""WIDTH: 3px""></TD>
				//				<TD style=""WIDTH: 164px""></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//				<TD></TD>
				//			</TR>
				//";
				#endregion //Detalle 2
				#endregion //DETALLE

				slCasesFlat = ilCaja.ToString();
				slDozensFlat = Convert.ToString(Math.Round(Convert.ToDouble(slTotalPairs)/12,2 ));

				#region Encabezado1
				slEncabezado1 = @"
<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.0 Transitional//EN"">
<html>
	<head>
		<title></title>
		<meta content=""Microsoft Visual Studio .NET 7.1"" name=""GENERATOR"">
		<meta content=""http://schemas.microsoft.com/intellisense/ie5"" name=""vs_targetSchema"">
	</head>
	<body>
		<TABLE id=""TABLESM"" cellSpacing=""1"" cellPadding=""1"" width=""750"" border=""0"">
			<TR><!--Fila 1-->
				<TD style=""WIDTH:3%;""></TD>
				<TD style=""WIDTH:22%;""></TD>
				<TD style=""WIDTH:23%;""></TD>
				<TD style=""WIDTH:2%;""></TD>
				<TD style=""WIDTH:27%;""></TD>
				<TD style=""WIDTH:20%;""></TD>
				<TD style=""WIDTH:3%;""></TD>
			</TR>
			<TR><!--Fila 2-->
				<TD  ></TD>
				<TD colspan=""5""><P align=""center""><STRONG>SHIPPING MANIFEST - BOXED GOODS</STRONG></P></TD>				
				<TD  ></TD>
			</TR>
			<TR><!--Fila 3-->
				<TD  ></TD>
				<TD><P align=""center""><STRONG>&nbsp;"+slFlatType+@"</STRONG></P></TD>
				<TD></TD>
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
			</TR>
			<TR><!--Fila 4-->
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
			</TR>
			<TR><!--Fila 5-->
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
				<TD align=""right"">FLAT No.</TD>
				<TD><P align=""center""><STRONG>"+ilFlatNumber.ToString()+@"</STRONG></P></TD>
				<TD  ></TD>
			</TR>
			<TR><!--Fila 6-->
				<TD  ></TD>
				<TD>SHIPPED FROM</TD>
				<TD><STRONG><P align=""center"">INISA</P>	</STRONG></TD>
				<TD  ></TD>
				<TD>SHIPPED TO</TD>
				<TD><P align=""center""><STRONG>FLYNN</STRONG></P></TD>
				<TD  ></TD>			
			</TR>";
				#endregion //Encabezado

				#region Encabezado2
				slEncabezado2 = @"
			<TR><!--Fila 7-->
				<TD style=""WIDTH:3%;""></TD>
				<TD>DATE SHIPPED</TD>
				<TD></TD>
				<TD style=""WIDTH:4%;""></TD>
				<TD>SHIPPING RECORD No.</TD>
				<TD><STRONG><P align=""center""></P></STRONG></TD>
				<TD style=""WIDTH:3%;""></TD>
			</TR>
			<TR><!--Fila 8-->
				<TD style=""WIDTH:3%;""></TD>
				<TD>CUT No. SERIES</TD>
				<TD><P align=""center""><STRONG>"+slCorte+@"</STRONG></P></TD>
				<TD style=""WIDTH:4%;""></TD>
				<TD>MFG. STYLE No.</TD>
				<TD><STRONG><P align=""center"">"+slEstilo+@"</P>	</STRONG></TD>
				<TD style=""WIDTH:3%;""></TD>
			</TR>			
			<TR><!--Fila 9-->
				<TD style=""WIDTH:3%;""></TD>
				<TD>INTERNAL No.</TD>
				<TD><P align=""center""><STRONG>"+slContrato+@"</STRONG></P></TD>
				<TD style=""WIDTH:4%;""></TD>
				<TD>COLOR</TD>
				<TD><STRONG><P align=""center"">"+slColor+@"</P>	</STRONG></TD>
				<TD style=""WIDTH:3%;""></TD>
			</TR>			
			<TR><!--Fila 10-->
				<TD style=""WIDTH:3%;""></TD>
				<TD>CASES ON FLAT</TD>
				<TD><P align=""center""><STRONG>"+slCasesFlat+@"</STRONG></P></TD>
				<TD style=""WIDTH:4%;""></TD>
				<TD>DOZENS ON FLAT</TD>
				<TD><P align=""center""><STRONG>"+slDozensFlat+@"</STRONG></P></TD>
				<TD style=""WIDTH:3%;""></TD>
			</TR>			
			<TR><!--Fila 10-->
				<TD style=""WIDTH:3%;""></TD>
				<TD colspan=""5""><P align=""center""><STRONG>COMPLETE ONE ROW FOR EACH CASE ON EACH FLAT</STRONG></P></TD>
				<TD style=""WIDTH:3%;""></TD>
			</TR>
			<TR> <!--Fila 11-->
				<TD style=""WIDTH:3%;""></TD>
				<TD></TD>
				<TD></TD>
				<TD style=""WIDTH:4%;""></TD>
				<TD></TD>
				<TD></TD>
				<TD style=""WIDTH:3%;""></TD>				
			</TR>			
";
				#endregion //Encabezado2

				#region Footer
				ilRow=ilRow-1;
				slFooter = @"
			
			<TR><!--Fila 44-->
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
			</TR>
			<TR><!--Fila 45-->
				<TD  ></TD>
				<TD>DATE RECEIVED</TD>
				<TD></TD>
				<TD  ></TD>
				<TD>VERIFIED&nbsp;AND RECEIVED BY</TD>
				<TD></TD>
				<TD  ></TD>
			</TR>
			<TR><!--Fila 46-->
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
				<TD></TD>
				<TD align=""right"">SM - 95</TD>
				<TD  ></TD>
			</TR>
			<TR><!--Fila 47-->
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
			</TR>
			<TR><!--Fila 48-->
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
			</TR>
			<TR><!--Fila 49-->
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
			</TR>
			<TR><!--Fila 50-->
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
			</TR>
			<TR><!--Fila 51-->
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
			</TR>
		</TABLE>
	</body>
</html>";
				#endregion //Footer
				#endregion AchivoHTML

				if(blCreaArchivo)
				{
					slArchivoHTML = slEncabezado1 + slEncabezado2 + slDetalle + slFooter;

					arcHTML = new System.IO.StreamWriter(@"C:\PACKING LIST\"+slCorte+" - Flat - "+ilFlatNumber.ToString()+".html");
					arcHTML.Write(slArchivoHTML);
					arcHTML.Close();
				}

				if(ilNoCajaCons+1>dsDetalle.Tables[0].Rows.Count)
					blCreaArchivo = false;

				ilFlatNumber=ilFlatNumber+1;				
			}
			return ilFlatNumber;
		}

		private void btnExport_Click(object sender, System.EventArgs e)
		{
			int ilFlatNumber = 1;
			ilFlatNumber = GeneraReporteEmbarque("1",ilFlatNumber);
			//ilFlatNumber = GeneraReporteEmbarque("4",ilFlatNumber);
			//ilFlatNumber = GeneraReporteEmbarque("2",ilFlatNumber);
			//ilFlatNumber = GeneraReporteEmbarque("3",ilFlatNumber);
			#region EXCEL			
			//			DataViewManager dvmDetalle;
			//			DataSet dsDetalle = new DataSet();
			//			dsDetalle.Clear();
			//			dsDetalle = SistEti.lpQueries.LlenaListaCT("");
			//			dvmDetalle = dsDetalle.DefaultViewManager;
			//			/////////////////////////////////
			//			System.IO.StreamWriter excelDoc;
			//			excelDoc = new System.IO.StreamWriter(@"C:\ARchivo.xls");
			//			const string startExcelXML = "<xml version>\r\n<Workbook " + 
			//					  "xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"\r\n" + 
			//					  " xmlns:o=\"urn:schemas-microsoft-com:office:office\"\r\n " + 
			//					  "xmlns:x=\"urn:schemas-    microsoft-com:office:" + 
			//					  "excel\"\r\n xmlns:ss=\"urn:schemas-microsoft-com:" + 
			//					  "office:spreadsheet\">\r\n <Styles>\r\n " + 
			//					  "<Style ss:ID=\"Default\" ss:Name=\"Normal\">\r\n " + 
			//					  "<Alignment ss:Vertical=\"Bottom\"/>\r\n <Borders/>" + 
			//					  "\r\n <Font/>\r\n <Interior/>\r\n <NumberFormat/>" + 
			//					  "\r\n <Protection/>\r\n </Style>\r\n " + 
			//					  "<Style ss:ID=\"BoldColumn\">\r\n <Font " + 
			//					  "x:Family=\"Swiss\" ss:Bold=\"1\"/>\r\n </Style>\r\n " + 
			//					  "<Style     ss:ID=\"StringLiteral\">\r\n <NumberFormat" + 
			//					  " ss:Format=\"@\"/>\r\n </Style>\r\n <Style " + 
			//					  "ss:ID=\"Decimal\">\r\n <NumberFormat " + 
			//					  "ss:Format=\"0.0000\"/>\r\n </Style>\r\n " + 
			//					  "<Style ss:ID=\"Integer\">\r\n <NumberFormat " + 
			//					  "ss:Format=\"0\"/>\r\n </Style>\r\n <Style " + 
			//					  "ss:ID=\"DateLiteral\">\r\n <NumberFormat " + 
			//					  "ss:Format=\"mm/dd/yyyy;@\"/>\r\n </Style>\r\n " + 
			//					  "</Styles>\r\n ";
			//			const string endExcelXML = "</Workbook>";
			//
			//			int rowCount = 0;
			//			int sheetCount = 1;
			//			excelDoc.Write(startExcelXML);
			//			excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
			//			excelDoc.Write("<Table>");
			//			excelDoc.Write("<Row>");
			//			for(int x = 0; x < dsDetalle.Tables[0].Columns.Count; x++)
			//			{
			//				excelDoc.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
			//				excelDoc.Write(dsDetalle.Tables[0].Columns[x].ColumnName);
			//				excelDoc.Write("</Data></Cell>");
			//			}
			//			excelDoc.Write("</Row>");
			//			foreach(DataRow x in dsDetalle.Tables[0].Rows)
			//			{
			//				rowCount++;
			//				//if the number of rows is > 64000 create a new page to continue output
			//				if(rowCount==64000) 
			//				{
			//					rowCount = 0;
			//					sheetCount++;
			//					excelDoc.Write("</Table>");
			//					excelDoc.Write(" </Worksheet>");
			//					excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
			//					excelDoc.Write("<Table>");
			//				}
			//				excelDoc.Write("<Row>");
			//				for(int y = 0; y < dsDetalle.Tables[0].Columns.Count; y++)
			//				{
			//					System.Type rowType;
			//					rowType = x[y].GetType();
			//					switch(rowType.ToString())
			//					{
			//						case "System.String":
			//							string XMLstring = x[y].ToString();
			//							XMLstring = XMLstring.Trim();
			//							XMLstring = XMLstring.Replace("&","&");
			//							XMLstring = XMLstring.Replace(">",">");
			//							XMLstring = XMLstring.Replace("<","<");
			//							excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" + 
			//								"<Data ss:Type=\"String\">");
			//							excelDoc.Write(XMLstring);
			//							excelDoc.Write("</Data></Cell>");
			//							break;
			//						case "System.DateTime":
			//							//Excel has a specific Date Format of YYYY-MM-DD followed by  
			//							//the letter 'T' then hh:mm:sss.lll Example 2005-01-31T24:01:21.000
			//							//The Following Code puts the date stored in XMLDate 
			//							//to the format above
			//							DateTime XMLDate = (DateTime)x[y];
			//							string XMLDatetoString = ""; //Excel Converted Date
			//							XMLDatetoString = XMLDate.Year.ToString() +
			//								"-" + 
			//								(XMLDate.Month < 10 ? "0" + 
			//								XMLDate.Month.ToString() : XMLDate.Month.ToString()) +
			//								"-" +
			//								(XMLDate.Day < 10 ? "0" + 
			//								XMLDate.Day.ToString() : XMLDate.Day.ToString()) +
			//								"T" +
			//								(XMLDate.Hour < 10 ? "0" + 
			//								XMLDate.Hour.ToString() : XMLDate.Hour.ToString()) +
			//								":" +
			//								(XMLDate.Minute < 10 ? "0" + 
			//								XMLDate.Minute.ToString() : XMLDate.Minute.ToString()) +
			//								":" +
			//								(XMLDate.Second < 10 ? "0" + 
			//								XMLDate.Second.ToString() : XMLDate.Second.ToString()) + 
			//								".000";
			//							excelDoc.Write("<Cell ss:StyleID=\"DateLiteral\">" + 
			//								"<Data ss:Type=\"DateTime\">");
			//							excelDoc.Write(XMLDatetoString);
			//							excelDoc.Write("</Data></Cell>");
			//							break;
			//						case "System.Boolean":
			//							excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" + 
			//								"<Data ss:Type=\"String\">");
			//							excelDoc.Write(x[y].ToString());
			//							excelDoc.Write("</Data></Cell>");
			//							break;
			//						case "System.Int16":
			//						case "System.Int32":
			//						case "System.Int64":
			//						case "System.Byte":
			//							excelDoc.Write("<Cell ss:StyleID=\"Integer\">" + 
			//								"<Data ss:Type=\"Number\">");
			//							excelDoc.Write(x[y].ToString());
			//							excelDoc.Write("</Data></Cell>");
			//							break;
			//						case "System.Decimal":
			//						case "System.Double":
			//							excelDoc.Write("<Cell ss:StyleID=\"Decimal\">" + 
			//								"<Data ss:Type=\"Number\">");
			//							excelDoc.Write(x[y].ToString());
			//							excelDoc.Write("</Data></Cell>");
			//							break;
			//						case "System.DBNull":
			//							excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" + 
			//								"<Data ss:Type=\"String\">");
			//							excelDoc.Write("");
			//							excelDoc.Write("</Data></Cell>");
			//							break;
			//						default:
			//							throw(new Exception(rowType.ToString() + " not handled."));
			//					}
			//				}
			//				excelDoc.Write("</Row>");
			//			}
			//			excelDoc.Write("</Table>");
			//			excelDoc.Write(" </Worksheet>");
			//			excelDoc.Write(endExcelXML);
			//			excelDoc.Close();
		
			#endregion
		}

		#region private void btnSearch_Click(object sender, System.EventArgs e)
		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			FBuscarCorte FBuscar = new FBuscarCorte();
			FBuscar.ShowDialog(this);			
			string slCorte = FBuscar.spCorte;
			if((slCorte!= "")&&(slCorte!= null))
			{
				this.sgCorte = slCorte;
				DataSet dsDetalle = new DataSet();			
				dsDetalle = SistEti.lpQueries.LlenaCTporID(slCorte);	
				//NoCorte, Contrato, Estilo, Color 
				this.tbCorte.Text = dsDetalle.Tables[0].Rows[0][0].ToString();				
				this.tbContrato.Text = dsDetalle.Tables[0].Rows[0][1].ToString();
				this.cbxEstilos.Text = dsDetalle.Tables[0].Rows[0][2].ToString();
				this.cbxColor.Text = dsDetalle.Tables[0].Rows[0][3].ToString();
				LlenaTallaQTY();
				bgModoEdicion=true;
				GeneraTotalPrendas();
				this.btnExport.Visible=true;
				//this.btnExpAcum.Visible=true;
				this.btnExportaListaPL.Visible =true;
			}
		}
		#endregion //private void btnSearch_Click(object sender, System.EventArgs e)

		#region private void LlenaTallaQTY()
		private void LlenaTallaQTY()
		{			
			DataViewManager dvmDetalle;
			DataSet dsDetalle = new DataSet();
			dsDetalle.Clear();
			dsDetalle = SistEti.lpQueries.LlenaTallaCT(this.sgCorte);
			dvmDetalle = dsDetalle.DefaultViewManager;
			dvmDetalle.DataSet.Tables[0].Columns[0].ReadOnly=true;
			string slEstilo = this.cbxEstilos.Text.Substring(0,3);
			switch(slEstilo)
			{
				case "J55":
					dvmDetalle.DataSet.Tables[0].Columns[10].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[11].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[12].ReadOnly=true;
					
					break;
				case "J65":
					dvmDetalle.DataSet.Tables[0].Columns[1].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[2].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[3].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[4].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[5].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[6].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[7].ReadOnly=true;				
					dvmDetalle.DataSet.Tables[0].Columns[8].ReadOnly=true;
					dvmDetalle.DataSet.Tables[0].Columns[9].ReadOnly=true;
					break;				
				default:
					break;
			}
			this.dtgCapturaMzCT.DataSource = dvmDetalle.DataSet.Tables[0];
			this.dtgCapturaMzCT.Refresh();		

			
		}
		#endregion //private void LlenaTallaQTY()

		private void dtgCapturaMzCT_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			/*int ilTotal = 0;
			DataGrid dgGrid = (DataGrid) sender;
			
			for(int ilContRow = 1; ilContRow < 4 ; ilContRow++)
			{
				for(int ilContCol = 1; ilContCol < 13 ; ilContCol++)
				{
					ilTotal = ilTotal + Convert.ToInt32(this.dtgCapturaMzCT[ilContRow,ilContCol]);
				}
			}
			
			this.lblTotalT.Text = ilTotal.ToString();*/
				
		}

		private void tmrActualiza_Tick(object sender, System.EventArgs e)
		{
			int ilTotal = 0;
			for(int ilContRow = 1; ilContRow < 4 ; ilContRow++)
			{
				for(int ilContCol = 1; ilContCol < 4 ; ilContCol++)
				{
					ilTotal = ilTotal + Convert.ToInt32(this.dtgCapturaMzCT[ilContRow,ilContCol]);
				}		
			}
			this.lblTotalT.Text = ilTotal.ToString();
		
		
		}

		private void GeneraTotalPrendas()
		{
			int ilTotal = 0;
			for(int ilContRow = 0; ilContRow < 4 ; ilContRow++)
			{
				for(int ilContCol = 1; ilContCol < 13 ; ilContCol++)
				{
					ilTotal = ilTotal + Convert.ToInt32(this.dtgCapturaMzCT[ilContRow,ilContCol]);
				}		
			}
			this.lblTotalT.Text = ilTotal.ToString();
		}



		private void dtgCapturaMzCT_CurrentCellChanged(object sender, System.EventArgs e)
		{
			GeneraTotalPrendas();			
		}

		private void cbxEstilos_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.dtgCapturaMzCT.Enabled = true;
			string slColor = this.cbxEstilos.Text.Substring(4,3);
			switch(slColor)
			{
				case "106":
					this.cbxColor.Text = "MEDSW";
					break;
				case "116":
					this.cbxColor.Text = "DKSW";
					break;
				case "126":
					this.cbxColor.Text = "LTSW";
					break;
				default:
					break;
			}
			llenaMatriz();
		}

		private void tbCorte_TextChanged(object sender, System.EventArgs e)
		{
			bool blResult = ValidaTextoCorte(tbCorte.Text);
			
		}

		#region  validaCorte
		private bool ValidaTextoCorte(string slCorte)
		{
			bool blValidado = false;
			StringBuilder sblCorte = new StringBuilder( slCorte);
			if((sblCorte.Length==8)||(sblCorte.Length==9))

				try
				{
					blValidado = (ValidaLetra(Convert.ToChar(sblCorte[0]))&&ValidaLetra(Convert.ToChar(sblCorte[1]))&&ValidaNumero(Convert.ToChar(sblCorte[2]))&&ValidaNumero(Convert.ToChar(sblCorte[2]))&&ValidaNumero(Convert.ToChar(sblCorte[3]))&&ValidaNumero(Convert.ToChar(sblCorte[4]))&&ValidaNumero(Convert.ToChar(sblCorte[5]))&&ValidaLetraoDigito(Convert.ToChar(sblCorte[6]))&&ValidaLetraoDigito(Convert.ToChar(sblCorte[7])));
					if((sblCorte.Length==9)&&(blValidado))
						blValidado = ValidaLetraoDigito(Convert.ToChar(sblCorte[8]));
					if(!blValidado)
						MessageBox.Show(@"El Corte Ingresado no fue Capturado Correctamente""LL####000""","Captura Incorrecta",MessageBoxButtons.OK);
					
				}
				catch
				{
					blValidado = false;
				}
			return blValidado;
		}
		#endregion

		private bool ValidaLetraoDigito(char clLetra)
		{
			if((char.IsLetter(clLetra))||(clLetra=='-')||(char.IsNumber(clLetra)))
				return true;
			else
				return false;
		}


		private bool ValidaLetra(char clLetra)
		{
			if(char.IsLetter(clLetra))
				return true;
			else
				return false;
		}

		private bool ValidaNumero(char clNumero)
		{
			if(char.IsNumber(clNumero))
				return true;
			else
				return false;
		}

		private void tbContrato_TextChanged(object sender, System.EventArgs e)
		{
			bool blResultado = ValidaTextoContrato(this.tbContrato.Text);
		}

		#region  validaCorte
		private bool ValidaTextoContrato(string slContrato)
		{
			bool blValidado = false;
			StringBuilder sblCorte = new StringBuilder(slContrato);
			if(sblCorte.Length==5)

				try
				{
					blValidado = (ValidaLetra(Convert.ToChar(sblCorte[0]))&&ValidaNumero(Convert.ToChar(sblCorte[1]))&&ValidaNumero(Convert.ToChar(sblCorte[2]))&&ValidaNumero(Convert.ToChar(sblCorte[3]))&&ValidaNumero(Convert.ToChar(sblCorte[4])));
					if((sblCorte.Length==9)&&(blValidado))
						blValidado = ValidaLetraoDigito(Convert.ToChar(sblCorte[8]));
					if(!blValidado)
						MessageBox.Show(@"El Contrato Ingresado no fue Capturado Correctamente""L####""","Captura Incorrecta",MessageBoxButtons.OK);
					
				}
				catch
				{
					blValidado = false;
				}
			return blValidado;
		}
		#endregion

		private int GeneraTotalPrendas(DataSet dsDetalleSuma)
		{
			int ilTotal = 0;
			for(int ilContRow = 0; ilContRow < 4 ; ilContRow++)
			{
				for(int ilContCol = 1; ilContCol < 13 ; ilContCol++)
				{
					ilTotal = ilTotal + Convert.ToInt32(dsDetalleSuma.Tables[0].Rows[ilContRow][ilContCol].ToString());
				}		
			}
			return ilTotal;
		}

		#region Exportar anterior
		private void btnExpAcum_Click(object sender, System.EventArgs e)
		{
			string slArchivoExcel ="";
			string slEncabezado ="";
			string slDetalle ="";
			string slFooter ="";

			DataSet dsDetalle1st = new DataSet();
			dsDetalle1st.Clear();
			dsDetalle1st = SistEti.lpQueries.LlenaTallaCTCaptPrim(this.sgCorte);			
			if((dsDetalle1st.Tables.Count>0)&&(dsDetalle1st.Tables[0].Rows.Count>0))
			{
				
			

				DataSet dsDetalle2st = new DataSet();
				dsDetalle2st.Clear();
				dsDetalle2st = SistEti.lpQueries.LlenaTallaCTCaptSegTerc(this.sgCorte);			
			
				#region Archivo Excel
				#region Encabezado
				slEncabezado =@"
<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.01 Transitional//EN""
""http://www.w3.org/TR/html4/loose.dtd"">
<html>
<head>
<title>Untitled Document</title>
<meta http-equiv=""Content-Type"" content=""text/html; charset=iso-8859-1"">
<style type=""text/css"">
<!--
.style1 {
	font-family: Arial, Helvetica, sans-serif;
	font-weight: bold;
}
-->
</style>
</head>

<body>
<table border=""0"" width=""750"">
	<tr>
		<td colspan=""5"">
		</td>
	</tr>
	<tr>
		<td colspan=""5""><div align=""center""><span class=""style1"">LAVAMEX
	    </span></div></td>
	</tr>
	<tr>
		<td>&nbsp;</td>
		<td></td>
		<td></td>
		<td></td>
		<td></td>
	</tr>
	<tr>
		<td colspan=""5""><div align=""center"">1STS & 2NDS</div></td>
	</tr>
";
				#endregion
				#region Encabezado 2
				slEncabezado=slEncabezado+@"
	<tr>
		<td></td>
		<td>FECHA:</td>
		<td></td>
		<td></td>
		<td></td>
	</tr>
	<tr>
		<td></td>
		<td colspan=""3"">
			<table border=""1"" cellpadding=""-1"" cellspacing=""-1"">
				<TR>
					<td colspan=""2"">CUT
					</td>
					<td colspan=""6"">"+this.tbCorte.Text+@"
					</td>
				</TR>
				<TR>
					<td colspan=""2"">STYLE
					</td>
					<td colspan=""6"">"+this.cbxEstilos.Text+@"
					</td>
				</TR>
				<TR>
					<td colspan=""2"">TOTAL # PAIRS
					</td>
					<td colspan=""6"">"+Convert.ToString((GeneraTotalPrendas(dsDetalle1st)+GeneraTotalPrendas(dsDetalle2st)))+@"
					</td>
				</TR>
				<TR>
					<td colspan=""2""># OF FIRST
					</td>
					<td colspan=""6"">"+Convert.ToString(GeneraTotalPrendas(dsDetalle1st))+@"
					</td>
				</TR>
				<TR>
					<td colspan=""2""># OF SECONDS
					</td>
					<td colspan=""6"">"+Convert.ToString(GeneraTotalPrendas(dsDetalle2st))+@"
					</td>
				</TR>
				<TR>
					<td colspan=""2""># PAIR SHORTS
					</td>
					<td colspan=""6"">
					</td>
				</TR>
			</table>
		</td>
		<td></td>
	</tr>
	<tr>
		<td></td>
		<td colspan=""3""></td>
		<td></td>
	</tr>
	<tr>
		<td>&nbsp;</td>
		<td></td>
		<td></td>
		<td></td>
		<td></td>
	</tr>
";
				#endregion
				#region DEtalle
				slDetalle =slDetalle +@"
	<tr>		
		<td colspan=""8"">
		<table border=""1"" cellpadding=""-1"" cellspacing=""-1"">
			<tr>
				<td width = ""50"" nowrap>SIZES</td>
				<td width = ""50"" nowrap>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;30</td>
				<td width = ""50"" nowrap>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;32</td>
				<td width = ""50"" nowrap>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;33</td>
				<td width = ""50"" nowrap>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;34</td>
				<td width = ""50"" nowrap>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;36</td>
				<td width = ""50"" nowrap>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;38</td>
				<td width = ""50"" nowrap>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;40</td>
				<td width = ""50"" nowrap>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;42</td>
				<td width = ""50"" nowrap>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;44</td>
				<td width = ""50"" nowrap>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;46</td>
				<td width = ""50"" nowrap>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;48</td>
				<td width = ""50"" nowrap>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;50</td>
			</tr>";

				string slFila1 = "";
				string slFila2 = "";
				for(int i =0 ; i <4 ; i++)			
				{
					slFila1 =@"<tr>";
					slFila2 =@"<tr>";				
					for(int j =0 ; j <13 ; j++)
					{		
						//					slDetalle =slDetalle +@"<tr>
						//				<td rowspan=""2"">"+dsDetalle1st.Tables[0].Columns[i].ColumnName+@"</td>";

						if(j==0)
						{
							slFila1 =@"<td rowspan=""2"">"+dsDetalle1st.Tables[0].Rows[i][j].ToString()+@"</td>";
						}
						else
						{
							slFila1 =slFila1 +@"<td>"+dsDetalle1st.Tables[0].Rows[i][j].ToString()+@"</td>";
							slFila2 =slFila2 +@"<td>"+dsDetalle2st.Tables[0].Rows[i][j].ToString()+@"</td>";
						}
						/*<td></td>
						<td></td>
						<td></td>
						<td></td>
						<td></td>
						<td></td>
						<td></td>
						<td></td>
						<td></td>
						<td></td>
						<td></td>";*/
					}
					slFila1 =slFila1 +@"</tr>";
					slFila2 =slFila2 +@"</tr>";
					slDetalle =slDetalle +slFila1+slFila2;
				}
			
				slDetalle = slDetalle + @"
			</table>
		</td>
		
	</tr>";
				#endregion
				#region Detalle
				string slDetalle1 =@"
	<tr>
		<td></td>
		<td colspan=""3"">
		<table border=""1"" cellpadding=""-1"" cellspacing=""-1"">
			<tr>
				<td>SIZES</td>
				<td>30</td>
				<td>32</td>
				<td>33</td>
				<td>34</td>
				<td>36</td>
				<td>38</td>
				<td>40</td>
				<td>42</td>
				<td>44</td>
				<td>46</td>
				<td>48</td>
				<td>50</td>
			</tr>
			<tr>
				<td rowspan=""2"">29</td>
				<td>-</td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
			</tr>
			<tr>				
				<td>-</td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
			</tr>
			<tr>
				<td rowspan=""2"">30</td>
				<td>-</td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
			</tr>
			<tr>				
				<td>-</td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
			</tr>
			<tr>
				<td rowspan=""2"">32</td>
				<td>-</td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
			</tr>
			<tr>				
				<td>-</td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
			</tr>
			<tr>
				<td rowspan=""2"">34</td>
				<td>-</td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
			</tr>
			<tr>				
				<td>-</td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
				<td></td>
			</tr>
		</table>
		</td>
		<td></td>
	</tr>";
				#endregion
				#region Footer
				slFooter = slFooter+@"
	<tr>
		<td>&nbsp;</td>
		<td></td>
		<td></td>
		<td></td>
		<td></td>
	</tr>
	<tr>
		<td colspan=""5"">FIRMAS DE RECEPCION Y ENTREGA DE SEGUNDAS</td>		
	</tr>
	<tr>
		<td>&nbsp;</td>
		<td></td>
		<td></td>
		<td></td>
		<td></td>
	</tr>
	<tr>
		<td>&nbsp;</td>
		<td></td>
		<td></td>
		<td></td>
		<td></td>
	</tr>
	<tr>
		<td></td>
		<td colspan=""3"" align=""center"">
			<table border=""0"">
				<tr>
					<TD>&nbsp;</TD>
					<TD>CANT.</TD>
					<TD>FIRMA</TD>
					<TD>&nbsp;</TD>
					<TD>CANT.</TD>
					<TD>FIRMA</TD>
					<TD>&nbsp;</TD>
					<TD>CANT.</TD>
					<TD>FIRMA</TD>
					<TD>&nbsp;</TD>
				</tr>
				<tr>
					<TD>&nbsp;</TD>
					<TD colspan=""2""></TD>
					<TD>&nbsp;</TD>
					<TD colspan=""2""></TD>
					<TD>&nbsp;</TD>
					<TD colspan=""2""></TD>
					<TD>&nbsp;</TD>
				</tr>
				<tr>
					<TD>&nbsp;</TD>
					<TD colspan=""2"">________________</TD>
					<TD>&nbsp;</TD>
					<TD colspan=""2"">________________</TD>
					<TD>&nbsp;</TD>
					<TD colspan=""2"">________________</TD>
					<TD>&nbsp;</TD>
				</tr>
				<tr>
					<TD nowrap>&nbsp;</TD>
					<TD colspan=""2"" nowrap><div align=""center"">CALIDAD<\DIV></TD>
					<TD nowrap>&nbsp;</TD>
					<TD colspan=""2"" nowrap><div align=""center"">EMPAQUE<\DIV></TD>					
					<TD colspan=""4"" nowrap><div align=""center"">ALMACEN DE SEGUNDAS<\DIV></TD>					
				</tr>
			</table>			
		</td>		
		<td></td>
	</tr>
</table>
</body>
</html>
			";
				#endregion
				#endregion // Archivo Excel

				slArchivoExcel = slEncabezado + slDetalle +slFooter;
				System.IO.StreamWriter arcHTML;
				try
				{
					arcHTML = new System.IO.StreamWriter(@"C:\"+ConfigurationSettings.AppSettings["FolderPL"]+@"\Acumulado_Corte.xls");
					arcHTML.Write(slArchivoExcel);
					arcHTML.Close();
					MessageBox.Show( "El Archivo se genero correctamente.", "EXPORTACION COMPLETADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch
				{
					MessageBox.Show( "Error al Generar el Archivo.", "ERROR DE EXPORTACION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
			}
			else
			{
				MessageBox.Show( "No se puede generar el archivo debido a que no existe informacion para exportar.", "ERROR DE EXPORTACION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		#endregion


		#region 
		#endregion 

		#region Exportar Archivo Excel Solidas Saldos Segundas Terceras
		private System.IO.StreamWriter GeneraDataSetEnArchivo(DataSet dsDetalle, System.IO.StreamWriter excelDoc, bool blEncabezado,string slTipo)
		{
			
			int sheetCount = 1;
			int rowCount = 0;
			excelDoc.Write("<Row>");
			excelDoc.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
			excelDoc.Write(slTipo);
			excelDoc.Write("</Data></Cell>");
			excelDoc.Write("</Row>");
			if(blEncabezado)
			{
				//GENERA ENCABEZADO
				excelDoc.Write("<Row>");
				for(int x = 0; x < dsDetalle.Tables[0].Columns.Count; x++)
				{
					excelDoc.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
					excelDoc.Write(dsDetalle.Tables[0].Columns[x].ColumnName);
					excelDoc.Write("</Data></Cell>");
				}
				excelDoc.Write("</Row>");
			}

			
			foreach(DataRow x in dsDetalle.Tables[0].Rows)
			{

				rowCount++;
				//if the number of rows is > 64000 create a new page to continue output
				if(rowCount==64000) 
				{
					rowCount = 0;
					sheetCount++;
					excelDoc.Write("</Table>");
					excelDoc.Write(" </Worksheet>");
					excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
					excelDoc.Write("<Table>");
				}
				
				excelDoc.Write("<Row>");
				for(int y = 0; y < dsDetalle.Tables[0].Columns.Count; y++)
				{
					System.Type rowType;
					rowType = x[y].GetType();
					switch(rowType.ToString())
					{
						case "System.String":
							string XMLstring = x[y].ToString();
							XMLstring = XMLstring.Trim();
							XMLstring = XMLstring.Replace("&","&");
							XMLstring = XMLstring.Replace(">",">");
							XMLstring = XMLstring.Replace("<","<");
							excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" + 
								"<Data ss:Type=\"String\">");
							excelDoc.Write(XMLstring);
							excelDoc.Write("</Data></Cell>");
							break;
						case "System.DateTime":
							//Excel has a specific Date Format of YYYY-MM-DD followed by  
							//the letter 'T' then hh:mm:sss.lll Example 2005-01-31T24:01:21.000
							//The Following Code puts the date stored in XMLDate 
							//to the format above
							DateTime XMLDate = (DateTime)x[y];
							string XMLDatetoString = ""; //Excel Converted Date
							XMLDatetoString = XMLDate.Year.ToString() +
								"-" + 
								(XMLDate.Month < 10 ? "0" + 
								XMLDate.Month.ToString() : XMLDate.Month.ToString()) +
								"-" +
								(XMLDate.Day < 10 ? "0" + 
								XMLDate.Day.ToString() : XMLDate.Day.ToString()) +
								"T" +
								(XMLDate.Hour < 10 ? "0" + 
								XMLDate.Hour.ToString() : XMLDate.Hour.ToString()) +
								":" +
								(XMLDate.Minute < 10 ? "0" + 
								XMLDate.Minute.ToString() : XMLDate.Minute.ToString()) +
								":" +
								(XMLDate.Second < 10 ? "0" + 
								XMLDate.Second.ToString() : XMLDate.Second.ToString()) + 
								".000";
							excelDoc.Write("<Cell ss:StyleID=\"DateLiteral\">" + 
								"<Data ss:Type=\"DateTime\">");
							excelDoc.Write(XMLDatetoString);
							excelDoc.Write("</Data></Cell>");
							break;
						case "System.Boolean":
							excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" + 
								"<Data ss:Type=\"String\">");
							excelDoc.Write(x[y].ToString());
							excelDoc.Write("</Data></Cell>");
							break;
						case "System.Int16":
						case "System.Int32":
						case "System.Int64":
						case "System.Byte":
							excelDoc.Write("<Cell ss:StyleID=\"Integer\">" + 
								"<Data ss:Type=\"Number\">");
							excelDoc.Write(x[y].ToString());
							excelDoc.Write("</Data></Cell>");
							break;
						case "System.Decimal":
						case "System.Double":
							excelDoc.Write("<Cell ss:StyleID=\"Decimal\">" + 
								"<Data ss:Type=\"Number\">");
							excelDoc.Write(x[y].ToString());
							excelDoc.Write("</Data></Cell>");
							break;
						case "System.DBNull":
							excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" + 
								"<Data ss:Type=\"String\">");
							excelDoc.Write("");
							excelDoc.Write("</Data></Cell>");
							break;
						default:
							throw(new Exception(rowType.ToString() + " not handled."));
					}
				}
				excelDoc.Write("</Row>");
			}

			return excelDoc;
		}
		#endregion

		private void GeneraListaPackingList()
		{
			try
			{
				/*	DataViewManager dvmDetalle;
					DataSet dsDetalle = new DataSet();
					dsDetalle.Clear();
					dsDetalle = SistEti.lpQueries.LlenaListaPL(this.sgCorte,"1");
					dsDetalle = SistEti.lpQueries.LlenaListaPL(this.sgCorte,"1");
				DataRow drFila = dsDetalle.Tables[0].NewRow();
				while(dsDetalle.Tables[0].Rows.Count<=130)
				{
					drFila = dsDetalle.Tables[0].NewRow();
					dsDetalle .Tables[0].Rows.Add(drFila);
				}
					dvmDetalle = dsDetalle.DefaultViewManager;
				*/
				/////////////////////////////////
				System.IO.StreamWriter excelDoc;
				excelDoc = new System.IO.StreamWriter(@"C:\"+ConfigurationSettings.AppSettings["FolderPL"]+@"\ListaPackingList.xls");
				const string startExcelXML = "<xml version>\r\n<Workbook " + 
						  "xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"\r\n" + 
						  " xmlns:o=\"urn:schemas-microsoft-com:office:office\"\r\n " + 
						  "xmlns:x=\"urn:schemas-    microsoft-com:office:" + 
						  "excel\"\r\n xmlns:ss=\"urn:schemas-microsoft-com:" + 
						  "office:spreadsheet\">\r\n <Styles>\r\n " + 
						  "<Style ss:ID=\"Default\" ss:Name=\"Normal\">\r\n " + 
						  "<Alignment ss:Vertical=\"Bottom\"/>\r\n <Borders/>" + 
						  "\r\n <Font/>\r\n <Interior/>\r\n <NumberFormat/>" + 
						  "\r\n <Protection/>\r\n </Style>\r\n " + 
						  "<Style ss:ID=\"BoldColumn\">\r\n <Font " + 
						  "x:Family=\"Swiss\" ss:Bold=\"1\"/>\r\n </Style>\r\n " + 
						  "<Style     ss:ID=\"StringLiteral\">\r\n <NumberFormat" + 
						  " ss:Format=\"@\"/>\r\n </Style>\r\n <Style " + 
						  "ss:ID=\"Decimal\">\r\n <NumberFormat " + 
						  "ss:Format=\"0.0000\"/>\r\n </Style>\r\n " + 
						  "<Style ss:ID=\"Integer\">\r\n <NumberFormat " + 
						  "ss:Format=\"0\"/>\r\n </Style>\r\n <Style " + 
						  "ss:ID=\"DateLiteral\">\r\n <NumberFormat " + 
						  "ss:Format=\"mm/dd/yyyy;@\"/>\r\n </Style>\r\n " + 
						  "</Styles>\r\n ";
				const string endExcelXML = "</Workbook>";				
				int sheetCount = 1;
				excelDoc.Write(startExcelXML);
				excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
				excelDoc.Write("<Table>");				
				DataViewManager dvmDetalle;
				DataSet dsDetalle = new DataSet();

				#region Datos Corte
				dsDetalle = SistEti.lpQueries.LlenaCTporID(this.sgCorte);	
				excelDoc = GeneraDataSetEnArchivo(dsDetalle,excelDoc,true,"Datos del Corte");
				#endregion

				#region Matriz
				dsDetalle = SistEti.lpQueries.LlenaTallaCT(this.sgCorte);
				excelDoc = GeneraDataSetEnArchivo(dsDetalle,excelDoc,true,"Matriz de Tallas del Pedido");
				#endregion


				//////////Primeras
				dsDetalle.Clear();
				dsDetalle = SistEti.lpQueries.LlenaListaPL(this.sgCorte,"1");			
				DataRow drFila = dsDetalle.Tables[0].NewRow();
				if((dsDetalle.Tables.Count>0)&&(dsDetalle.Tables[0].Rows.Count>0))
				{
					while(dsDetalle.Tables[0].Rows.Count<130)
					{
						drFila = dsDetalle.Tables[0].NewRow();
						dsDetalle .Tables[0].Rows.Add(drFila);
					}
					//dvmDetalle = dsDetalle.DefaultViewManager;					
				}
				else
				{
					int cont = 0;
					while(cont<130)
					{
						drFila = dsDetalle.Tables[0].NewRow();
						dsDetalle.Tables[0].Rows.Add(drFila);
						cont=cont+1;
					}
				}
				excelDoc = GeneraDataSetEnArchivo(dsDetalle,excelDoc,true,"SOLIDAS");

				DataSet dsDetalleTallas = new DataSet();
				/////////////Saldos
				dsDetalle.Clear();
				dsDetalle = SistEti.lpQueries.LlenaListaPL(this.sgCorte,"4");			
				
				#region Inserta Espacion Cuando Hay Cambio de Caja
				if((dsDetalle.Tables.Count>0)&&(dsDetalle.Tables[0].Rows.Count>0))
				{
					for(int ilRow = 0 ; ilRow < dsDetalle.Tables[0].Rows.Count; ilRow++)
					{drFila = dsDetalle.Tables[0].NewRow();
						if(ilRow>0)
							if((dsDetalle.Tables[0].Rows[ilRow-1][0].ToString() != dsDetalle.Tables[0].Rows[ilRow][0].ToString())&&(dsDetalle.Tables[0].Rows[ilRow-1][0].ToString()!=""))
								dsDetalle.Tables[0].Rows.InsertAt(drFila,ilRow);
					}
				}				
				#endregion
				if((dsDetalle.Tables.Count>0)&&(dsDetalle.Tables[0].Rows.Count>0))
				{
					while(dsDetalle.Tables[0].Rows.Count<90)
					{
						drFila = dsDetalle.Tables[0].NewRow();
						dsDetalle .Tables[0].Rows.Add(drFila);
					}					
					//dvmDetalle = dsDetalle.DefaultViewManager;					
				}
				else
				{
					int cont = 0;
					while(cont<90)
					{
						drFila = dsDetalle.Tables[0].NewRow();
						dsDetalle.Tables[0].Rows.Add(drFila);
						cont=cont+1;
					}
				}
				excelDoc = GeneraDataSetEnArchivo(dsDetalle,excelDoc,false,"SALDOS");

				////////////SEGUNDAS
				dsDetalle.Clear();
				dsDetalle = SistEti.lpQueries.LlenaListaPL(this.sgCorte,"2");		
	
				#region Inserta Espacion Cuando Hay Cambio de Caja
				if((dsDetalle.Tables.Count>0)&&(dsDetalle.Tables[0].Rows.Count>0))
				{
					for(int ilRow = 0 ; ilRow < dsDetalle.Tables[0].Rows.Count; ilRow++)
					{
							drFila = dsDetalle.Tables[0].NewRow();
						if(ilRow>0)
							if((dsDetalle.Tables[0].Rows[ilRow-1][0].ToString() != dsDetalle.Tables[0].Rows[ilRow][0].ToString())&&(dsDetalle.Tables[0].Rows[ilRow-1][0].ToString()!=""))
								dsDetalle.Tables[0].Rows.InsertAt(drFila,ilRow);
					}
				}				
				#endregion
				
				if((dsDetalle.Tables.Count>0)&&(dsDetalle.Tables[0].Rows.Count>0))
				{
					while(dsDetalle.Tables[0].Rows.Count<180)
					{
						drFila = dsDetalle.Tables[0].NewRow();
						dsDetalle .Tables[0].Rows.Add(drFila);
					}
					//dvmDetalle = dsDetalle.DefaultViewManager;
					excelDoc = GeneraDataSetEnArchivo(dsDetalle,excelDoc,false,"SEGUNDAS");
				}
				
				////////////TERCERAS
				dsDetalle.Clear();
				dsDetalle = SistEti.lpQueries.LlenaListaPL(this.sgCorte,"3");			
				#region Inserta Espacion Cuando Hay Cambio de Caja
				if((dsDetalle.Tables.Count>0)&&(dsDetalle.Tables[0].Rows.Count>0))
				{
					for(int ilRow = 0 ; ilRow < dsDetalle.Tables[0].Rows.Count; ilRow++)
					{
							drFila = dsDetalle.Tables[0].NewRow();
						if(ilRow>0)
							if((dsDetalle.Tables[0].Rows[ilRow-1][0].ToString() != dsDetalle.Tables[0].Rows[ilRow][0].ToString())&&(dsDetalle.Tables[0].Rows[ilRow-1][0].ToString()!=""))
								dsDetalle.Tables[0].Rows.InsertAt(drFila,ilRow);
					}
				}				
				#endregion
				if((dsDetalle.Tables.Count>0)&&(dsDetalle.Tables[0].Rows.Count>0))
				{
					while(dsDetalle.Tables[0].Rows.Count<90)
					{
						drFila = dsDetalle.Tables[0].NewRow();
						dsDetalle .Tables[0].Rows.Add(drFila);
					}
					//dvmDetalle = dsDetalle.DefaultViewManager;
					excelDoc = GeneraDataSetEnArchivo(dsDetalle,excelDoc,false,"TERCERAS");
				}

				excelDoc.Write("</Table>");
				excelDoc.Write(" </Worksheet>");
				excelDoc.Write(endExcelXML);
				excelDoc.Close();
				MessageBox.Show( "El Archivo se genero correctamente.", "EXPORTACION COMPLETADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(Exception exError)
			{
				MessageBox.Show( "Error al generar el archivo o posiblemente no existan datos para exportar.", "Error al Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		
			
		}

		private void btnExportaListaPL_Click(object sender, System.EventArgs e)
		{
			GeneraListaPackingList();
		}
	}
}
