using System;
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Data;
using System.Threading;
using SerialPorts;
using System.Text;
using System.Configuration;

namespace SistEti
{
	/// <summary>
	/// Summary description for FImprimeEtiq.
	/// </summary>
	public class FImprimeEtiq : System.Windows.Forms.Form
	{
//		bool boopYaSeImprimioUnaEtiqueta = true;

		

		

		/// <summary>
		/// //////////////////////
		/// </summary>
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbColor;
		private System.Windows.Forms.Label lblContrato;
		private System.Windows.Forms.TextBox tbContrato;
		private System.Windows.Forms.Label lblEstilo;
		private System.Windows.Forms.TextBox tbEstilo;
		private System.Windows.Forms.Label lblCut;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox tbxCorte;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button btImprime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btAceptar;
		private System.Windows.Forms.DataGrid dgUPC;
		private System.Windows.Forms.TextBox tbPassword;
		private string sgCorte="";
		private string sgEtiqId="";
		private string sgTalla ="";
		private string sgTotalPairs = "";
		private string sgUPC ="";
		private string sgTipoCaja ="1";
		private System.Windows.Forms.TextBox tbCantPairs;
		private System.Windows.Forms.Label lblCantPairs;
		private System.Windows.Forms.GroupBox gbCorte;
		private System.Windows.Forms.GroupBox gbxBoxType;
		private System.Windows.Forms.RadioButton rbnBoxType4;
		private System.Windows.Forms.RadioButton rbnBoxType3;
		private System.Windows.Forms.RadioButton rbnBoxType2;
		private System.Windows.Forms.RadioButton rbnBoxType1;
		private System.Windows.Forms.Label lblUPCT;
		private System.Windows.Forms.Label lblTallaT;
		private System.Windows.Forms.Label lblCajaTipo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCancelar;
		bool blImpPrimeravez = true;

		



		public FImprimeEtiq()
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbColor = new System.Windows.Forms.TextBox();
			this.lblContrato = new System.Windows.Forms.Label();
			this.tbContrato = new System.Windows.Forms.TextBox();
			this.lblEstilo = new System.Windows.Forms.Label();
			this.tbEstilo = new System.Windows.Forms.TextBox();
			this.lblCut = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.tbxCorte = new System.Windows.Forms.TextBox();
			this.btImprime = new System.Windows.Forms.Button();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btAceptar = new System.Windows.Forms.Button();
			this.dgUPC = new System.Windows.Forms.DataGrid();
			this.tbCantPairs = new System.Windows.Forms.TextBox();
			this.lblCantPairs = new System.Windows.Forms.Label();
			this.gbCorte = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.gbxBoxType = new System.Windows.Forms.GroupBox();
			this.rbnBoxType4 = new System.Windows.Forms.RadioButton();
			this.rbnBoxType3 = new System.Windows.Forms.RadioButton();
			this.rbnBoxType2 = new System.Windows.Forms.RadioButton();
			this.rbnBoxType1 = new System.Windows.Forms.RadioButton();
			this.lblCajaTipo = new System.Windows.Forms.Label();
			this.lblTallaT = new System.Windows.Forms.Label();
			this.lblUPCT = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgUPC)).BeginInit();
			this.gbCorte.SuspendLayout();
			this.gbxBoxType.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(328, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 25;
			this.label1.Text = "Color";
			// 
			// tbColor
			// 
			this.tbColor.Location = new System.Drawing.Point(336, 32);
			this.tbColor.Name = "tbColor";
			this.tbColor.ReadOnly = true;
			this.tbColor.TabIndex = 24;
			this.tbColor.Text = "";
			// 
			// lblContrato
			// 
			this.lblContrato.Location = new System.Drawing.Point(224, 16);
			this.lblContrato.Name = "lblContrato";
			this.lblContrato.Size = new System.Drawing.Size(56, 16);
			this.lblContrato.TabIndex = 23;
			this.lblContrato.Text = "Contrato";
			// 
			// tbContrato
			// 
			this.tbContrato.Location = new System.Drawing.Point(232, 32);
			this.tbContrato.Name = "tbContrato";
			this.tbContrato.ReadOnly = true;
			this.tbContrato.TabIndex = 22;
			this.tbContrato.Text = "";
			// 
			// lblEstilo
			// 
			this.lblEstilo.Location = new System.Drawing.Point(120, 16);
			this.lblEstilo.Name = "lblEstilo";
			this.lblEstilo.Size = new System.Drawing.Size(40, 16);
			this.lblEstilo.TabIndex = 21;
			this.lblEstilo.Text = "Estilo";
			// 
			// tbEstilo
			// 
			this.tbEstilo.Location = new System.Drawing.Point(128, 32);
			this.tbEstilo.Name = "tbEstilo";
			this.tbEstilo.ReadOnly = true;
			this.tbEstilo.TabIndex = 20;
			this.tbEstilo.Text = "";
			// 
			// lblCut
			// 
			this.lblCut.Location = new System.Drawing.Point(24, 16);
			this.lblCut.Name = "lblCut";
			this.lblCut.Size = new System.Drawing.Size(40, 16);
			this.lblCut.TabIndex = 19;
			this.lblCut.Text = "Corte";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(440, 29);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.TabIndex = 18;
			this.btnSearch.Text = "Buscar";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// tbxCorte
			// 
			this.tbxCorte.Location = new System.Drawing.Point(24, 32);
			this.tbxCorte.Name = "tbxCorte";
			this.tbxCorte.TabIndex = 17;
			this.tbxCorte.Text = "";
			// 
			// btImprime
			// 
			this.btImprime.Location = new System.Drawing.Point(472, 328);
			this.btImprime.Name = "btImprime";
			this.btImprime.TabIndex = 26;
			this.btImprime.Text = "Imprimir";
			this.btImprime.Visible = false;
			this.btImprime.Click += new System.EventHandler(this.btImprime_Click);
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(88, 16);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.TabIndex = 27;
			this.tbPassword.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 28;
			this.label2.Text = "Contraseña:";
			// 
			// btAceptar
			// 
			this.btAceptar.Location = new System.Drawing.Point(192, 16);
			this.btAceptar.Name = "btAceptar";
			this.btAceptar.TabIndex = 29;
			this.btAceptar.Text = "Aceptar";
			this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
			// 
			// dgUPC
			// 
			this.dgUPC.DataMember = "";
			this.dgUPC.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgUPC.Location = new System.Drawing.Point(24, 56);
			this.dgUPC.Name = "dgUPC";
			this.dgUPC.ReadOnly = true;
			this.dgUPC.Size = new System.Drawing.Size(584, 264);
			this.dgUPC.TabIndex = 30;
			this.dgUPC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgUPC_MouseUp);
			// 
			// tbCantPairs
			// 
			this.tbCantPairs.Location = new System.Drawing.Point(400, 328);
			this.tbCantPairs.Name = "tbCantPairs";
			this.tbCantPairs.Size = new System.Drawing.Size(64, 20);
			this.tbCantPairs.TabIndex = 31;
			this.tbCantPairs.Text = "";
			// 
			// lblCantPairs
			// 
			this.lblCantPairs.Location = new System.Drawing.Point(344, 328);
			this.lblCantPairs.Name = "lblCantPairs";
			this.lblCantPairs.Size = new System.Drawing.Size(56, 16);
			this.lblCantPairs.TabIndex = 32;
			this.lblCantPairs.Text = "Cantidad :";
			// 
			// gbCorte
			// 
			this.gbCorte.Controls.Add(this.label4);
			this.gbCorte.Controls.Add(this.label3);
			this.gbCorte.Controls.Add(this.gbxBoxType);
			this.gbCorte.Controls.Add(this.lblCajaTipo);
			this.gbCorte.Controls.Add(this.lblTallaT);
			this.gbCorte.Controls.Add(this.lblUPCT);
			this.gbCorte.Controls.Add(this.lblEstilo);
			this.gbCorte.Controls.Add(this.tbEstilo);
			this.gbCorte.Controls.Add(this.tbCantPairs);
			this.gbCorte.Controls.Add(this.btnSearch);
			this.gbCorte.Controls.Add(this.tbxCorte);
			this.gbCorte.Controls.Add(this.btImprime);
			this.gbCorte.Controls.Add(this.dgUPC);
			this.gbCorte.Controls.Add(this.lblCut);
			this.gbCorte.Controls.Add(this.lblCantPairs);
			this.gbCorte.Controls.Add(this.tbColor);
			this.gbCorte.Controls.Add(this.label1);
			this.gbCorte.Controls.Add(this.lblContrato);
			this.gbCorte.Controls.Add(this.tbContrato);
			this.gbCorte.Location = new System.Drawing.Point(8, 40);
			this.gbCorte.Name = "gbCorte";
			this.gbCorte.Size = new System.Drawing.Size(616, 408);
			this.gbCorte.TabIndex = 33;
			this.gbCorte.TabStop = false;
			this.gbCorte.Visible = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(184, 328);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 38;
			this.label4.Text = "TALLA";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 328);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 16);
			this.label3.TabIndex = 37;
			this.label3.Text = "UPC";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gbxBoxType
			// 
			this.gbxBoxType.Controls.Add(this.rbnBoxType4);
			this.gbxBoxType.Controls.Add(this.rbnBoxType3);
			this.gbxBoxType.Controls.Add(this.rbnBoxType2);
			this.gbxBoxType.Controls.Add(this.rbnBoxType1);
			this.gbxBoxType.Location = new System.Drawing.Point(16, 352);
			this.gbxBoxType.Name = "gbxBoxType";
			this.gbxBoxType.Size = new System.Drawing.Size(368, 48);
			this.gbxBoxType.TabIndex = 33;
			this.gbxBoxType.TabStop = false;
			this.gbxBoxType.Text = "Tipo de Caja";
			// 
			// rbnBoxType4
			// 
			this.rbnBoxType4.Location = new System.Drawing.Point(280, 16);
			this.rbnBoxType4.Name = "rbnBoxType4";
			this.rbnBoxType4.Size = new System.Drawing.Size(80, 24);
			this.rbnBoxType4.TabIndex = 3;
			this.rbnBoxType4.Text = "Saldos";
			this.rbnBoxType4.CheckedChanged += new System.EventHandler(this.rbnBoxType4_CheckedChanged);
			// 
			// rbnBoxType3
			// 
			this.rbnBoxType3.Location = new System.Drawing.Point(192, 16);
			this.rbnBoxType3.Name = "rbnBoxType3";
			this.rbnBoxType3.Size = new System.Drawing.Size(80, 24);
			this.rbnBoxType3.TabIndex = 2;
			this.rbnBoxType3.Text = "Terceras";
			this.rbnBoxType3.CheckedChanged += new System.EventHandler(this.rbnBoxType3_CheckedChanged);
			// 
			// rbnBoxType2
			// 
			this.rbnBoxType2.Location = new System.Drawing.Point(104, 16);
			this.rbnBoxType2.Name = "rbnBoxType2";
			this.rbnBoxType2.Size = new System.Drawing.Size(80, 24);
			this.rbnBoxType2.TabIndex = 1;
			this.rbnBoxType2.Text = "Segundas";
			this.rbnBoxType2.CheckedChanged += new System.EventHandler(this.rbnBoxType2_CheckedChanged);
			// 
			// rbnBoxType1
			// 
			this.rbnBoxType1.Checked = true;
			this.rbnBoxType1.Location = new System.Drawing.Point(16, 16);
			this.rbnBoxType1.Name = "rbnBoxType1";
			this.rbnBoxType1.Size = new System.Drawing.Size(80, 24);
			this.rbnBoxType1.TabIndex = 0;
			this.rbnBoxType1.TabStop = true;
			this.rbnBoxType1.Text = "Solidas";
			this.rbnBoxType1.CheckedChanged += new System.EventHandler(this.rbnBoxType1_CheckedChanged);
			// 
			// lblCajaTipo
			// 
			this.lblCajaTipo.Location = new System.Drawing.Point(376, 376);
			this.lblCajaTipo.Name = "lblCajaTipo";
			this.lblCajaTipo.TabIndex = 36;
			this.lblCajaTipo.Text = "1";
			this.lblCajaTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCajaTipo.Visible = false;
			// 
			// lblTallaT
			// 
			this.lblTallaT.Location = new System.Drawing.Point(232, 328);
			this.lblTallaT.Name = "lblTallaT";
			this.lblTallaT.TabIndex = 35;
			this.lblTallaT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblUPCT
			// 
			this.lblUPCT.Location = new System.Drawing.Point(64, 328);
			this.lblUPCT.Name = "lblUPCT";
			this.lblUPCT.TabIndex = 34;
			this.lblUPCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(720, 336);
			this.button1.Name = "button1";
			this.button1.TabIndex = 34;
			this.button1.Text = "button1";
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(656, 56);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(216, 248);
			this.textBox1.TabIndex = 35;
			this.textBox1.Text = "";
			this.textBox1.Visible = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(728, 24);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 36;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.Visible = false;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(528, 456);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.TabIndex = 39;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FImprimeEtiq
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(634, 480);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.gbCorte);
			this.Controls.Add(this.btAceptar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancelar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FImprimeEtiq";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FImprimeEtiq";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dgUPC)).EndInit();
			this.gbCorte.ResumeLayout(false);
			this.gbxBoxType.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			FBuscarCorte FBuscar = new FBuscarCorte();
			FBuscar.ShowDialog(this);			
			string slCorte = FBuscar.spCorte;	
			this.sgCorte = slCorte;
			if((this.sgCorte!= "")&&(this.sgCorte!= null))
			{
				DataSet dsDetalle = new DataSet();			
				dsDetalle = SistEti.lpQueries.LlenaCTporID(slCorte);	
				//NoCorte, Contrato, Estilo, Color 
				this.tbxCorte.Text = dsDetalle.Tables[0].Rows[0][0].ToString();				
				this.tbContrato.Text = dsDetalle.Tables[0].Rows[0][1].ToString();
				this.tbEstilo.Text = dsDetalle.Tables[0].Rows[0][2].ToString();
				this.tbColor.Text = dsDetalle.Tables[0].Rows[0][3].ToString();											
				LlenaDetalle();
			}			
		}

		#region private void LlenaDetalle()
		private void LlenaDetalle()
		{
			DataViewManager dvmDetalle;
			DataSet dsDetalle = new DataSet();
			dsDetalle.Clear();
			dsDetalle = SistEti.lpQueries.LlenaDetCTUPCIMP(this.sgCorte);
			dvmDetalle = dsDetalle.DefaultViewManager;
			this.dgUPC.DataSource = dvmDetalle.DataSet.Tables[0];
			
			this.dgUPC.Refresh();
			
		}
		#endregion //private void LlenaDetalle()

		#region private void LenaUPCDetalle()
		private void LenaUPCDetalle()
		{
			DataViewManager dvmDetalle;
			DataSet dsDetalle = new DataSet();
			dsDetalle.Clear();
			dsDetalle = SistEti.lpQueries.LlenaDetUPC(this.sgCorte);			
			dvmDetalle = dsDetalle.DefaultViewManager;
			this.dgUPC.DataSource = dvmDetalle.DataSet.Tables[0];
			this.dgUPC.Refresh();		
		}
		#endregion //private void LenaUPCDetalle()

		private void dgUPC_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			DataGrid dgGrid = (DataGrid) sender;
			System.Windows.Forms.DataGrid.HitTestInfo htiHit;
			htiHit = dgGrid.HitTest(e.X,e.Y);
			switch(htiHit.Type)
			{
				case System.Windows.Forms.DataGrid.HitTestType.Cell: 
					sgUPC = Convert.ToString(this.dgUPC[htiHit.Row,0]);
					this.lblUPCT.Text = sgUPC;
					this.tbCantPairs.Text = Convert.ToString(this.dgUPC[htiHit.Row,2]);
					sgTalla = Convert.ToString(this.dgUPC[htiHit.Row,1]);
					this.lblTallaT.Text = sgTalla;					
					this.dgUPC.Select(htiHit.Row);
					this.btImprime.Visible=true;
					this.sgEtiqId=Convert.ToString(this.dgUPC[htiHit.Row,3]);
					
					//this.Close();
					break;
			}
		}
		private void actualizaInfEitq()
		{
			int ilContImp=1;
			int ilResult =0;
			DataSet dsInfoEtiq = new DataSet();
			dsInfoEtiq = SistEti.lpQueries.obtenInfoEtiq(this.sgEtiqId);
			
			string slFecha = DateTime.Now.ToString();
			if((dsInfoEtiq.Tables.Count>0)&&(dsInfoEtiq.Tables[0].Rows.Count>0))
			{
				ilContImp = Convert.ToInt32(dsInfoEtiq.Tables[0].Rows[0][1].ToString());
				ilContImp++;
				ilResult = SistEti.lpQueries.ActualizaEtiqInfo(this.sgEtiqId,ilContImp.ToString(),slFecha);
			}
			else
			{
				
				string slEtiquetaId = SistEti.lpQueries.traeEtiquetaId(this.lblUPCT.Text,this.sgCorte);
				if(slEtiquetaId!="0")
				{						
					int iResultEtiq = SistEti.lpQueries.InsertaInformacionEtiq(this.sgEtiqId,slFecha,ConfigurationSettings.AppSettings["NomPC"]);
				}				
			}

		}


		private void btImprime_Click(object sender, System.EventArgs e)
		{
			string slMessage = "";
			slMessage = SistEti.lpUtils.Imprime(this.tbxCorte.Text,this.tbContrato.Text,this.tbEstilo.Text,this.sgTalla,this.tbCantPairs.Text,this.sgUPC,this.tbColor.Text,sgTipoCaja,sgEtiqId);
			actualizaInfEitq();
			if(slMessage!="")
				MessageBox.Show(slMessage, "ERROR DE IMPRESION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
		}

		private void btAceptar_Click(object sender, System.EventArgs e)
		{
			if(this.tbPassword.Text==ConfigurationSettings.AppSettings["Password"])
			{
				gbCorte.Visible = true;
			}
			else
			{
				MessageBox.Show("Contraseña Incorrecta, intente Nuevamente.", "Contraseña Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		#region 		private void rbnBoxType1_CheckedChanged(object sender, System.EventArgs e)
		private void rbnBoxType1_CheckedChanged(object sender, System.EventArgs e)
		{
			
			sgTipoCaja = "1";
			this.lblCajaTipo.Text = sgTipoCaja;
		}
		#endregion //private void rbnBoxType1_CheckedChanged(object sender, System.EventArgs e)

		#region private void rbnBoxType2_CheckedChanged(object sender, System.EventArgs e)
		private void rbnBoxType2_CheckedChanged(object sender, System.EventArgs e)
		{
			
			sgTipoCaja = "2";
			this.lblCajaTipo.Text = sgTipoCaja;
		}
		#endregion //private void rbnBoxType2_CheckedChanged(object sender, System.EventArgs e)

		#region private void rbnBoxType3_CheckedChanged(object sender, System.EventArgs e)
		private void rbnBoxType3_CheckedChanged(object sender, System.EventArgs e)
		{
			
			sgTipoCaja = "3";
			this.lblCajaTipo.Text = sgTipoCaja;
		}
		#endregion //private void rbnBoxType3_CheckedChanged(object sender, System.EventArgs e)

		#region private void rbnBoxType4_CheckedChanged(object sender, System.EventArgs e)
		private void rbnBoxType4_CheckedChanged(object sender, System.EventArgs e)
		{
			
			sgTipoCaja = "4";
			this.lblCajaTipo.Text = sgTipoCaja;
		}
		#endregion //private void rbnBoxType4_CheckedChanged(object sender, System.EventArgs e)

		#region IMPRIME
		#region private void private void imprime(string slCorte, string slContrato, string slEstilo, string slTalla, string slCant,string slUPC, string slColor)
		[DllImport("kernel32.dll")] internal static extern IntPtr CreateFile(string name, int desiredAccess, int shareMode, IntPtr securityAttributes,int creationDisposition, int dwFlagsAndAttributes, IntPtr templateFile);
		private string Imprime(string slCorte, string slContrato, string slEstilo, string slTalla, string slCant,string slUPC, string slColor, string slTipoCaja)
		{
			char cr = (char)13;
			
			string mensaje="";

			string slUPCAlterno = GeneraSegUpc(slTalla);
			String [] saCorte = new string[2]; 

			saCorte = slCorte.Split('-');
			slCorte = saCorte[1]+saCorte[0];

			string sCol =slColor.Substring(0,1);
			switch(sCol)
			{
				case "L":
					slColor="LTSW";
					break;
				case "D":
					slColor="DKSW";
					break;
				case "M":
					slColor="MEDSW";
                    break;
                case "B":
                    slColor = "BLACK";
					break;
				default:					
					break;
			}

			string slTipoImpresora = ConfigurationSettings.AppSettings["Impresora"];

			if(slTipoImpresora=="1")
			{
				
				
				if( slTipoCaja == "1")
				{
					#region Etiqueta Solidas
					mensaje += "^XA"+ cr;
					mensaje += "^LH0,0"+ cr;
					mensaje += "^FO50,35^A0,,95,75^FDFLYNN^FS"+ cr;
					mensaje += "^FO500,35^A0,,45,65^FDPOS BIN STOCK^FS"+cr;
					mensaje += "^FO340,35^A0,,65,25^FD" + DateTime.Today.ToString("MM/yy") + "^FS" + cr;				
					mensaje += "^FO330,110^B3N,,120^FD" + slUPC + "^FS"+ cr;
					mensaje += "^FO95,140^A0,,65,45^FD" + slContrato  + "^FS"+ cr;
					mensaje += "^FO60,240^A0,,45,55^FD" + slEstilo + "^FS" + cr;				
					mensaje += "^FO100,280^A0,,65,45^FD" + slCorte + "^FS" + cr;
					mensaje += "^FO450,260^B3N,,90,N^FD" + slCorte + "^FS" + cr;				
					mensaje += "^FO120,425^A0,,60,30^FDPAIR^FS" + cr;
					mensaje += "^FO350,405^A0,,85,55^FD" + String.Format("{0:000}",slCant ) + "^FS" + cr;
					mensaje += "^FO630,385^B3N,,85,N^FD" + String.Format("{0:000}",slCant ) + "^FS" + cr;
					mensaje += "^FO50,505^A0,,60,30^FDS/" + slEstilo.Substring(7,3)  + "^FS" + cr;
					mensaje += "^FO220,505^A0,,60,30^FD" + slColor + "^FS" + cr;
					mensaje += "^FO530,505^A0,,60,30^FD  SZ " + slTalla + "^FS" + cr;
					mensaje += "^FO780,580^A0,,20,30^FDS^FS" + cr;
					mensaje += "^XZ" + cr;
					#endregion
				}
				else
				{
					#region Etiqueta Saldos, Segundas y Terceras
					string slTipoEtiqueta = "";					
					switch(slTipoCaja )
					{
						case "2":
							slTipoEtiqueta = "IRREGULARS";
							
							break;
						case "3":
							slTipoEtiqueta = "IRREGULARS";							
							break;
						case "4":
							slTipoEtiqueta = "THIRDS";
                            break;
                        case "5":
                            slTipoEtiqueta = "RAGS";
                            break;
					}
					
					mensaje += "^XA"+ cr;
					mensaje += "^LH0,0"+ cr;
					mensaje += "^FO50,35^A0,,95,75^FDFLYNN^FS"+ cr;
					mensaje += "^FO500,35^A0,,45,65^FDPOS BIN STOCK^FS"+cr;
					mensaje += "^FO340,35^A0,,65,25^FD" + DateTime.Today.ToString("MM/yy") + "^FS" + cr;				
					mensaje += "^FO330,110^B3N,,120^FD" + slUPC + "^FS"+ cr;
					mensaje += "^FO95,140^A0,,65,45^FD" + slContrato  + "^FS"+ cr;
					mensaje += "^FO60,240^A0,,45,55^FD" + slEstilo + "^FS" + cr;				
					mensaje += "^FO100,280^A0,,65,45^FD" + slCorte + "^FS" + cr;
					mensaje += "^FO450,260^B3N,,90,N^FD" + slCorte + "^FS" + cr;				
					mensaje += "^FO120,425^A0,,60,30^FDPAIR^FS" + cr;
					mensaje += "^FO350,405^A0,,85,55^FD" + String.Format("{0:000}",slCant ) + "^FS" + cr;
					mensaje += "^FO630,385^B3N,,85,N^FD" + String.Format("{0:000}",slCant ) + "^FS" + cr;
					mensaje += "^FO50,505^A0,,60,30^FDS/" + slEstilo.Substring(7,3)  + "^FS" + cr;
					mensaje += "^FO220,505^A0,,60,30^FD" + slColor + "^FS" + cr;
					mensaje += "^FO530,505^A0,,60,30^FD  SZ " + slTalla + "^FS" + cr;
					mensaje += "^FO780,580^A0,,20,30^FDS^FS" + cr;
					mensaje += "^XZ" + cr;
					#endregion
				}

			}
			else
			{
				if( slTipoCaja == "1")
				{
					#region Etiqueta Solidas
					mensaje =@"
O
q815
S4
D5
ZT
JF

N
B422,103,0,3,2,4,109,N,"""+slUPC+@"""
A483,212,0,1,2,2,N,"""+slUPC +@"""
A24,34,0,2,4,5,N,""FLYNN""
A302,37,0,2,2,3,N,"""+DateTime.Today.ToString("MM/yy")+@"""
A444,37,0,2,2,3,N,""POS BIN STOCK""
A71,131,0,2,2,3,N,"""+slContrato+@"""
A67,242,0,2,2,2,N,"""+slEstilo +@"""
A116,286,0,2,2,3,N,"""+slCorte +@"""
B493,262,0,3,2,4,88,N,"""+slCorte+@"""
B534,387,0,3,3,6,63,N,"""+slCant+@"""
A596,529,0,2,2,3,N,"""+slTalla+@"""
A495,529,0,2,2,3,N,""SZ""
A71,406,0,2,2,3,N,""PAIR""
A359,390,0,2,3,4,N,"""+slCant +@"""
A63,526,0,2,2,3,N,""S/305""
A235,526,0,2,2,3,N,"""+slColor +@"""
P1";
					#endregion
				}
				else
				{
					#region Etiqueta Saldos, Segundas y Terceras
					string slTipoEtiqueta = "";
					
					switch(slTipoCaja )
					{
						case "2":
							slTipoEtiqueta = "IRREGULARS";
							
							break;
						case "3":
							slTipoEtiqueta = "IRREGULARS";							
							break;
						case "4":
							slTipoEtiqueta = "THIRDS";
							break;
                        case "5":
                            slTipoEtiqueta = "RAGS";
                            break;
					}
					
					mensaje =@"
O
q815
S4
D5
ZT
JF

N
B424,108,0,3,2,4,73,N,"""+slUPC+@"""
A545,181,0,1,1,2,N,"""+slUPC +@"""
A31,23,0,2,4,5,N,""FLYNN""
A350,27,0,2,2,3,N,"""+DateTime.Today.ToString("MM/yy")+@"""
A514,27,0,2,2,3,N,"""+slTipoEtiqueta+@"""
A95,123,0,2,2,3,N,"""+slContrato+@"""
A45,220,0,2,2,2,N,"""+slEstilo+@"""
A89,367,0,2,2,3,N,"""+slCorte+@"""
B424,221,0,3,2,4,74,N,"""+slUPCAlterno+@"""
A545,295,0,1,1,2,N,"""+slUPCAlterno+@"""
B492,333,0,3,2,4,73,N,"""+slCorte+@"""
B527,430,0,3,3,6,73,N,"""+slCant+@"""
A596,529,0,2,2,3,N,"""+slTalla+@"""
A495,529,0,2,2,3,N,""SZ""
A70,454,0,2,2,3,N,""PAIR""
A365,444,0,2,3,4,N,"""+slCant +@"""
A63,526,0,2,2,3,N,""S/305""
A235,526,0,2,2,3,N,"""+slColor +@"""
A384,238,0,2,1,1,N,""UPC""
P1";
					#endregion
				}
			}
			

			this.textBox1.Text = mensaje;
			return SendToLpt1(mensaje);

		}
		#endregion //private void imprime()

		#region public static void SendToLpt1(string message)
		private string SendToLpt1(string message)
		{
			FileStream fs = null;
			IntPtr handle = CreateFile(
				"LPT1",
				(int) FileAccess.Write, 
				(int) FileShare.Read, 
				IntPtr.Zero, 
				(int) FileMode.Open, 
				0, 
				IntPtr.Zero);
			if (handle.ToInt32() != -1)
			{
				try
				{
					fs = new FileStream(handle, FileAccess.Write);
					byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
					fs.Write(msg, 0, msg.Length);
					fs.Close();
				}
				catch
				{
					return "No se ha encontrado la Impresora";
				}
			}
			else
			{
				return "No se puede abrir el puerto de Impresión";
			}
			return "";
		}
		#endregion //public static void SendToLpt1(string message)

		public static  string GeneraSegUpc(string slTalla)
		{
			if(Convert.ToInt32(slTalla.Substring(0,2))<=44)
				return "000000000002";
			else
				return "000000000001";
		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{

			string slmsn =@"

O
q815
S4
D5
ZT
JF

N
B424,108,0,3,2,4,73,N,""754819076892""
A545,181,0,1,1,2,N,""754819076892""
A31,23,0,2,4,5,N,""FLYNN""
A350,27,0,2,2,3,N,""09/08""
A514,27,0,2,2,3,N,""IRREGULARS""
A95,123,0,2,2,3,N,""F4275""
A45,220,0,2,2,2,N,""J55-116305-0W""
A89,367,0,2,2,3,N,""3DF0460""
B424,221,0,3,2,4,74,N,""000000000002""
A545,295,0,1,1,2,N,""000000000002""
B492,333,0,3,2,4,73,N,""3DF0460""
B527,430,0,3,3,6,73,N,""21""
A596,529,0,2,2,3,N,""33X30""
A495,529,0,2,2,3,N,""SZ""
A70,454,0,2,2,3,N,""PAIR""
A108,260,0,2,1,2,N,""J55-102000-00R""
A365,444,0,2,3,4,N,""21""
A63,526,0,2,2,3,N,""S/305""
A235,526,0,2,2,3,N,""DKSW""
A384,238,0,2,1,1,N,""UPC""
P1

";
	if(this.checkBox1.Checked)
			SendToLpt1(this.textBox1.Text);
			else
		SendToLpt1(slmsn);
		}

		private void btnCancelar_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		

	}
}
