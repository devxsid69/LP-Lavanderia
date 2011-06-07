using System;
using System.Configuration;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;



namespace SistEti
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FLeerEtiq : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label lblCut;
		private System.Windows.Forms.GroupBox gbxBoxType;
		private System.Windows.Forms.RadioButton rbnBoxType1;
		private System.Windows.Forms.RadioButton rbnBoxType2;
		private System.Windows.Forms.RadioButton rbnBoxType3;
		private System.Windows.Forms.RadioButton rbnBoxType4;
		private System.Windows.Forms.Label lblPairs;
		private System.Windows.Forms.Label lblUPC;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblPairCounterT;
		private System.Windows.Forms.Label lblNoCorte;
		private System.Windows.Forms.Label lblTallaT;
		private System.Windows.Forms.Label lblTalla;
		private System.Windows.Forms.TextBox tbxUPC;
		private System.Windows.Forms.Label lblUPCT;
		private System.Windows.Forms.Label lblTotalPairs;
		private System.Windows.Forms.Label lblDe1t;
		private System.Windows.Forms.DataGrid dgDetalleLect;
		private System.Windows.Forms.Button btnGuardarCaja;
		private System.Windows.Forms.Button btnCancelarCaja;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox tbxCorte;
		private string sTipoCaja="1";
		private System.Windows.Forms.Label lblEstilo;
		private System.Windows.Forms.Label lblContrato;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGrid dgTallaQty;
		private System.Windows.Forms.TextBox tbEstilo;
		private System.Windows.Forms.TextBox tbContrato;
		private System.Windows.Forms.TextBox tbColor;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblEstiloT;
		private string sgCorte ="";
		private string sgEtiqId ="";
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabControl dgFaltante;
		private System.Windows.Forms.DataGrid dgCaptura;
		private System.Windows.Forms.Label lblTOTEMP;
		private System.Windows.Forms.Label lblTOTAL;
		private System.Windows.Forms.DataGrid dgCantFaltante;
		private System.Windows.Forms.Label lblTotalPCorte;
		private System.Windows.Forms.Label lblTotCorte;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTotalPCapt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblTotalPFalt;
		private System.Windows.Forms.Label lblCaja;
		private System.Windows.Forms.Label lblCajaNum;
		private System.Windows.Forms.Label lblCaptPorc;
		private System.Windows.Forms.Label lblFaltPorc;
		private bool blPregunta =true;
		[DllImport("kernel32.dll")] 
		private static extern int Beep(int dwFreq, int dwDuration);

//		public enum MessageBeepType
//		{
//			Default = -1,
//			Ok = 0x00000000,
//			Error = 0x00000010,
//			Question = 0x00000020,
//			Warning = 0x00000030,
//			Information = 0x00000040,
//		}		
//
//		[DllImport("user32.dll", SetLastError=true)]
//		public static extern bool MessageBeep(
//			MessageBeepType type
//			);


		public FLeerEtiq()
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
				if (components != null) 
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
			this.tbxCorte = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lblPairCounterT = new System.Windows.Forms.Label();
			this.lblCut = new System.Windows.Forms.Label();
			this.gbxBoxType = new System.Windows.Forms.GroupBox();
			this.rbnBoxType4 = new System.Windows.Forms.RadioButton();
			this.rbnBoxType3 = new System.Windows.Forms.RadioButton();
			this.rbnBoxType2 = new System.Windows.Forms.RadioButton();
			this.rbnBoxType1 = new System.Windows.Forms.RadioButton();
			this.lblPairs = new System.Windows.Forms.Label();
			this.lblUPC = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblCaja = new System.Windows.Forms.Label();
			this.lblCajaNum = new System.Windows.Forms.Label();
			this.lblTOTAL = new System.Windows.Forms.Label();
			this.lblTOTEMP = new System.Windows.Forms.Label();
			this.lblDe1t = new System.Windows.Forms.Label();
			this.lblTotalPairs = new System.Windows.Forms.Label();
			this.lblUPCT = new System.Windows.Forms.Label();
			this.tbxUPC = new System.Windows.Forms.TextBox();
			this.lblTalla = new System.Windows.Forms.Label();
			this.lblTallaT = new System.Windows.Forms.Label();
			this.lblNoCorte = new System.Windows.Forms.Label();
			this.lblEstiloT = new System.Windows.Forms.Label();
			this.btnCancelarCaja = new System.Windows.Forms.Button();
			this.btnGuardarCaja = new System.Windows.Forms.Button();
			this.dgDetalleLect = new System.Windows.Forms.DataGrid();
			this.tbEstilo = new System.Windows.Forms.TextBox();
			this.lblEstilo = new System.Windows.Forms.Label();
			this.tbContrato = new System.Windows.Forms.TextBox();
			this.lblContrato = new System.Windows.Forms.Label();
			this.tbColor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgTallaQty = new System.Windows.Forms.DataGrid();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dgFaltante = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dgCaptura = new System.Windows.Forms.DataGrid();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dgCantFaltante = new System.Windows.Forms.DataGrid();
			this.lblTotalPCorte = new System.Windows.Forms.Label();
			this.lblTotCorte = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTotalPCapt = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblTotalPFalt = new System.Windows.Forms.Label();
			this.lblCaptPorc = new System.Windows.Forms.Label();
			this.lblFaltPorc = new System.Windows.Forms.Label();
			this.gbxBoxType.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDetalleLect)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgTallaQty)).BeginInit();
			this.dgFaltante.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgCaptura)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgCantFaltante)).BeginInit();
			this.SuspendLayout();
			// 
			// tbxCorte
			// 
			this.tbxCorte.Location = new System.Drawing.Point(8, 24);
			this.tbxCorte.Name = "tbxCorte";
			this.tbxCorte.TabIndex = 1;
			this.tbxCorte.Text = "";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(421, 23);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Buscar";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lblPairCounterT
			// 
			this.lblPairCounterT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPairCounterT.Location = new System.Drawing.Point(464, 56);
			this.lblPairCounterT.Name = "lblPairCounterT";
			this.lblPairCounterT.Size = new System.Drawing.Size(56, 24);
			this.lblPairCounterT.TabIndex = 3;
			this.lblPairCounterT.Text = "0";
			this.lblPairCounterT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCut
			// 
			this.lblCut.Location = new System.Drawing.Point(16, 8);
			this.lblCut.Name = "lblCut";
			this.lblCut.Size = new System.Drawing.Size(40, 16);
			this.lblCut.TabIndex = 4;
			this.lblCut.Text = "Corte";
			// 
			// gbxBoxType
			// 
			this.gbxBoxType.Controls.Add(this.rbnBoxType4);
			this.gbxBoxType.Controls.Add(this.rbnBoxType3);
			this.gbxBoxType.Controls.Add(this.rbnBoxType2);
			this.gbxBoxType.Controls.Add(this.rbnBoxType1);
			this.gbxBoxType.Location = new System.Drawing.Point(8, 48);
			this.gbxBoxType.Name = "gbxBoxType";
			this.gbxBoxType.Size = new System.Drawing.Size(368, 48);
			this.gbxBoxType.TabIndex = 5;
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
			this.rbnBoxType4.Visible = false;
			this.rbnBoxType4.CheckedChanged += new System.EventHandler(this.rbnBoxType4_CheckedChanged);
			// 
			// rbnBoxType3
			// 
			this.rbnBoxType3.Location = new System.Drawing.Point(192, 16);
			this.rbnBoxType3.Name = "rbnBoxType3";
			this.rbnBoxType3.Size = new System.Drawing.Size(80, 24);
			this.rbnBoxType3.TabIndex = 2;
			this.rbnBoxType3.Text = "Terceras";
			this.rbnBoxType3.Visible = false;
			this.rbnBoxType3.CheckedChanged += new System.EventHandler(this.rbnBoxType3_CheckedChanged);
			// 
			// rbnBoxType2
			// 
			this.rbnBoxType2.Location = new System.Drawing.Point(104, 16);
			this.rbnBoxType2.Name = "rbnBoxType2";
			this.rbnBoxType2.Size = new System.Drawing.Size(80, 24);
			this.rbnBoxType2.TabIndex = 1;
			this.rbnBoxType2.Text = "Segundas";
			this.rbnBoxType2.Visible = false;
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
			// lblPairs
			// 
			this.lblPairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPairs.Location = new System.Drawing.Point(464, 16);
			this.lblPairs.Name = "lblPairs";
			this.lblPairs.Size = new System.Drawing.Size(152, 32);
			this.lblPairs.TabIndex = 6;
			this.lblPairs.Text = "Prendas";
			this.lblPairs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblUPC
			// 
			this.lblUPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblUPC.Location = new System.Drawing.Point(40, 16);
			this.lblUPC.Name = "lblUPC";
			this.lblUPC.Size = new System.Drawing.Size(104, 32);
			this.lblUPC.TabIndex = 7;
			this.lblUPC.Text = "UPC";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblCaja);
			this.groupBox1.Controls.Add(this.lblCajaNum);
			this.groupBox1.Controls.Add(this.lblTOTAL);
			this.groupBox1.Controls.Add(this.lblTOTEMP);
			this.groupBox1.Controls.Add(this.lblDe1t);
			this.groupBox1.Controls.Add(this.lblTotalPairs);
			this.groupBox1.Controls.Add(this.lblUPCT);
			this.groupBox1.Controls.Add(this.tbxUPC);
			this.groupBox1.Controls.Add(this.lblTalla);
			this.groupBox1.Controls.Add(this.lblTallaT);
			this.groupBox1.Controls.Add(this.lblNoCorte);
			this.groupBox1.Controls.Add(this.lblEstiloT);
			this.groupBox1.Controls.Add(this.lblUPC);
			this.groupBox1.Controls.Add(this.lblPairs);
			this.groupBox1.Controls.Add(this.lblPairCounterT);
			this.groupBox1.Controls.Add(this.btnCancelarCaja);
			this.groupBox1.Controls.Add(this.btnGuardarCaja);
			this.groupBox1.Location = new System.Drawing.Point(8, 400);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(944, 128);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Etiqueta";
			// 
			// lblCaja
			// 
			this.lblCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCaja.Location = new System.Drawing.Point(808, 56);
			this.lblCaja.Name = "lblCaja";
			this.lblCaja.Size = new System.Drawing.Size(56, 24);
			this.lblCaja.TabIndex = 22;
			this.lblCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCajaNum
			// 
			this.lblCajaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCajaNum.Location = new System.Drawing.Point(736, 16);
			this.lblCajaNum.Name = "lblCajaNum";
			this.lblCajaNum.Size = new System.Drawing.Size(192, 40);
			this.lblCajaNum.TabIndex = 21;
			this.lblCajaNum.Text = "Total Cajas";
			this.lblCajaNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTOTAL
			// 
			this.lblTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTOTAL.Location = new System.Drawing.Point(408, 88);
			this.lblTOTAL.Name = "lblTOTAL";
			this.lblTOTAL.Size = new System.Drawing.Size(128, 32);
			this.lblTOTAL.TabIndex = 18;
			this.lblTOTAL.Text = "TOTAL";
			// 
			// lblTOTEMP
			// 
			this.lblTOTEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTOTEMP.Location = new System.Drawing.Point(544, 88);
			this.lblTOTEMP.Name = "lblTOTEMP";
			this.lblTOTEMP.Size = new System.Drawing.Size(88, 32);
			this.lblTOTEMP.TabIndex = 17;
			this.lblTOTEMP.Text = "0";
			this.lblTOTEMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDe1t
			// 
			this.lblDe1t.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblDe1t.Location = new System.Drawing.Point(520, 56);
			this.lblDe1t.Name = "lblDe1t";
			this.lblDe1t.Size = new System.Drawing.Size(40, 24);
			this.lblDe1t.TabIndex = 16;
			this.lblDe1t.Text = "de";
			this.lblDe1t.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTotalPairs
			// 
			this.lblTotalPairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTotalPairs.Location = new System.Drawing.Point(568, 56);
			this.lblTotalPairs.Name = "lblTotalPairs";
			this.lblTotalPairs.Size = new System.Drawing.Size(56, 24);
			this.lblTotalPairs.TabIndex = 15;
			this.lblTotalPairs.Text = "0";
			this.lblTotalPairs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblUPCT
			// 
			this.lblUPCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblUPCT.Location = new System.Drawing.Point(8, 56);
			this.lblUPCT.Name = "lblUPCT";
			this.lblUPCT.Size = new System.Drawing.Size(216, 24);
			this.lblUPCT.TabIndex = 14;
			this.lblUPCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbxUPC
			// 
			this.tbxUPC.Enabled = false;
			this.tbxUPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbxUPC.Location = new System.Drawing.Point(16, 96);
			this.tbxUPC.MaxLength = 12;
			this.tbxUPC.Name = "tbxUPC";
			this.tbxUPC.Size = new System.Drawing.Size(160, 23);
			this.tbxUPC.TabIndex = 13;
			this.tbxUPC.Text = "";
			this.tbxUPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUPC_KeyPress);
			// 
			// lblTalla
			// 
			this.lblTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTalla.Location = new System.Drawing.Point(640, 16);
			this.lblTalla.Name = "lblTalla";
			this.lblTalla.Size = new System.Drawing.Size(88, 32);
			this.lblTalla.TabIndex = 12;
			this.lblTalla.Text = "Talla";
			// 
			// lblTallaT
			// 
			this.lblTallaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTallaT.Location = new System.Drawing.Point(624, 56);
			this.lblTallaT.Name = "lblTallaT";
			this.lblTallaT.Size = new System.Drawing.Size(104, 24);
			this.lblTallaT.TabIndex = 11;
			this.lblTallaT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNoCorte
			// 
			this.lblNoCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblNoCorte.Location = new System.Drawing.Point(240, 16);
			this.lblNoCorte.Name = "lblNoCorte";
			this.lblNoCorte.Size = new System.Drawing.Size(176, 32);
			this.lblNoCorte.TabIndex = 10;
			this.lblNoCorte.Text = "Estilo";
			this.lblNoCorte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblEstiloT
			// 
			this.lblEstiloT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblEstiloT.Location = new System.Drawing.Point(232, 56);
			this.lblEstiloT.Name = "lblEstiloT";
			this.lblEstiloT.Size = new System.Drawing.Size(200, 24);
			this.lblEstiloT.TabIndex = 9;
			this.lblEstiloT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelarCaja
			// 
			this.btnCancelarCaja.Location = new System.Drawing.Point(304, 96);
			this.btnCancelarCaja.Name = "btnCancelarCaja";
			this.btnCancelarCaja.TabIndex = 12;
			this.btnCancelarCaja.Text = "Cancelar";
			this.btnCancelarCaja.Click += new System.EventHandler(this.btnCancelarCaja_Click);
			// 
			// btnGuardarCaja
			// 
			this.btnGuardarCaja.Location = new System.Drawing.Point(200, 96);
			this.btnGuardarCaja.Name = "btnGuardarCaja";
			this.btnGuardarCaja.TabIndex = 11;
			this.btnGuardarCaja.Text = "Guardar";
			this.btnGuardarCaja.Visible = false;
			this.btnGuardarCaja.Click += new System.EventHandler(this.btnGuardarCaja_Click);
			// 
			// dgDetalleLect
			// 
			this.dgDetalleLect.DataMember = "";
			this.dgDetalleLect.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgDetalleLect.Location = new System.Drawing.Point(8, 280);
			this.dgDetalleLect.Name = "dgDetalleLect";
			this.dgDetalleLect.ReadOnly = true;
			this.dgDetalleLect.Size = new System.Drawing.Size(944, 120);
			this.dgDetalleLect.TabIndex = 10;
			// 
			// tbEstilo
			// 
			this.tbEstilo.Location = new System.Drawing.Point(112, 24);
			this.tbEstilo.Name = "tbEstilo";
			this.tbEstilo.ReadOnly = true;
			this.tbEstilo.TabIndex = 11;
			this.tbEstilo.Text = "";
			// 
			// lblEstilo
			// 
			this.lblEstilo.Location = new System.Drawing.Point(112, 8);
			this.lblEstilo.Name = "lblEstilo";
			this.lblEstilo.Size = new System.Drawing.Size(40, 16);
			this.lblEstilo.TabIndex = 12;
			this.lblEstilo.Text = "Estilo";
			// 
			// tbContrato
			// 
			this.tbContrato.Location = new System.Drawing.Point(216, 24);
			this.tbContrato.Name = "tbContrato";
			this.tbContrato.ReadOnly = true;
			this.tbContrato.TabIndex = 13;
			this.tbContrato.Text = "";
			// 
			// lblContrato
			// 
			this.lblContrato.Location = new System.Drawing.Point(216, 8);
			this.lblContrato.Name = "lblContrato";
			this.lblContrato.Size = new System.Drawing.Size(56, 16);
			this.lblContrato.TabIndex = 14;
			this.lblContrato.Text = "Contrato";
			// 
			// tbColor
			// 
			this.tbColor.Location = new System.Drawing.Point(320, 24);
			this.tbColor.Name = "tbColor";
			this.tbColor.ReadOnly = true;
			this.tbColor.TabIndex = 15;
			this.tbColor.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(320, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 16;
			this.label1.Text = "Color";
			// 
			// dgTallaQty
			// 
			this.dgTallaQty.AllowSorting = false;
			this.dgTallaQty.DataMember = "";
			this.dgTallaQty.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgTallaQty.Location = new System.Drawing.Point(0, 0);
			this.dgTallaQty.Name = "dgTallaQty";
			this.dgTallaQty.PreferredColumnWidth = 50;
			this.dgTallaQty.ReadOnly = true;
			this.dgTallaQty.Size = new System.Drawing.Size(936, 160);
			this.dgTallaQty.TabIndex = 17;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(592, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 18;
			this.button1.Text = "button1";
			this.button1.Visible = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(672, 8);
			this.button2.Name = "button2";
			this.button2.TabIndex = 20;
			this.button2.Text = "button2";
			this.button2.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(600, 48);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(192, 40);
			this.textBox1.TabIndex = 19;
			this.textBox1.Text = "";
			this.textBox1.Visible = false;
			// 
			// dgFaltante
			// 
			this.dgFaltante.Controls.Add(this.tabPage1);
			this.dgFaltante.Controls.Add(this.tabPage2);
			this.dgFaltante.Controls.Add(this.tabPage3);
			this.dgFaltante.Location = new System.Drawing.Point(8, 96);
			this.dgFaltante.Name = "dgFaltante";
			this.dgFaltante.SelectedIndex = 0;
			this.dgFaltante.Size = new System.Drawing.Size(944, 184);
			this.dgFaltante.TabIndex = 22;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dgTallaQty);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(936, 158);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Corte";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dgCaptura);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(936, 158);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Capturas";
			// 
			// dgCaptura
			// 
			this.dgCaptura.DataMember = "";
			this.dgCaptura.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgCaptura.Location = new System.Drawing.Point(0, 0);
			this.dgCaptura.Name = "dgCaptura";
			this.dgCaptura.PreferredColumnWidth = 50;
			this.dgCaptura.ReadOnly = true;
			this.dgCaptura.Size = new System.Drawing.Size(936, 160);
			this.dgCaptura.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dgCantFaltante);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(936, 158);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Faltantes";
			// 
			// dgCantFaltante
			// 
			this.dgCantFaltante.DataMember = "";
			this.dgCantFaltante.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgCantFaltante.Location = new System.Drawing.Point(0, 0);
			this.dgCantFaltante.Name = "dgCantFaltante";
			this.dgCantFaltante.PreferredColumnWidth = 50;
			this.dgCantFaltante.ReadOnly = true;
			this.dgCantFaltante.Size = new System.Drawing.Size(936, 160);
			this.dgCantFaltante.TabIndex = 0;
			// 
			// lblTotalPCorte
			// 
			this.lblTotalPCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTotalPCorte.Location = new System.Drawing.Point(752, 0);
			this.lblTotalPCorte.Name = "lblTotalPCorte";
			this.lblTotalPCorte.Size = new System.Drawing.Size(152, 32);
			this.lblTotalPCorte.TabIndex = 19;
			this.lblTotalPCorte.Text = "0";
			this.lblTotalPCorte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTotCorte
			// 
			this.lblTotCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTotCorte.Location = new System.Drawing.Point(496, 0);
			this.lblTotCorte.Name = "lblTotCorte";
			this.lblTotCorte.Size = new System.Drawing.Size(264, 32);
			this.lblTotCorte.TabIndex = 19;
			this.lblTotCorte.Text = "TOTAL CORTE:";
			this.lblTotCorte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(496, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(264, 32);
			this.label2.TabIndex = 23;
			this.label2.Text = "TOTAL CAPT.:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTotalPCapt
			// 
			this.lblTotalPCapt.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTotalPCapt.Location = new System.Drawing.Point(752, 32);
			this.lblTotalPCapt.Name = "lblTotalPCapt";
			this.lblTotalPCapt.Size = new System.Drawing.Size(152, 32);
			this.lblTotalPCapt.TabIndex = 24;
			this.lblTotalPCapt.Text = "0";
			this.lblTotalPCapt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(496, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(264, 32);
			this.label4.TabIndex = 25;
			this.label4.Text = "TOTAL FALT.:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTotalPFalt
			// 
			this.lblTotalPFalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTotalPFalt.Location = new System.Drawing.Point(752, 64);
			this.lblTotalPFalt.Name = "lblTotalPFalt";
			this.lblTotalPFalt.Size = new System.Drawing.Size(152, 32);
			this.lblTotalPFalt.TabIndex = 26;
			this.lblTotalPFalt.Text = "0";
			this.lblTotalPFalt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCaptPorc
			// 
			this.lblCaptPorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCaptPorc.Location = new System.Drawing.Point(904, 32);
			this.lblCaptPorc.Name = "lblCaptPorc";
			this.lblCaptPorc.Size = new System.Drawing.Size(160, 32);
			this.lblCaptPorc.TabIndex = 27;
			this.lblCaptPorc.Text = "0%";
			this.lblCaptPorc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFaltPorc
			// 
			this.lblFaltPorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblFaltPorc.Location = new System.Drawing.Point(904, 64);
			this.lblFaltPorc.Name = "lblFaltPorc";
			this.lblFaltPorc.Size = new System.Drawing.Size(160, 32);
			this.lblFaltPorc.TabIndex = 28;
			this.lblFaltPorc.Text = "0%";
			this.lblFaltPorc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FLeerEtiq
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1058, 536);
			this.Controls.Add(this.lblFaltPorc);
			this.Controls.Add(this.lblCaptPorc);
			this.Controls.Add(this.lblTotalPFalt);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblTotalPCapt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTotCorte);
			this.Controls.Add(this.lblTotalPCorte);
			this.Controls.Add(this.dgFaltante);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.tbColor);
			this.Controls.Add(this.tbContrato);
			this.Controls.Add(this.tbEstilo);
			this.Controls.Add(this.tbxCorte);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblContrato);
			this.Controls.Add(this.lblEstilo);
			this.Controls.Add(this.dgDetalleLect);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbxBoxType);
			this.Controls.Add(this.lblCut);
			this.Controls.Add(this.btnSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FLeerEtiq";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Lectura  de  Etiquetas - Solidas";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FLeerEtiq_Load);
			this.gbxBoxType.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgDetalleLect)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgTallaQty)).EndInit();
			this.dgFaltante.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgCaptura)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgCantFaltante)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region private void tbxUPC_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		int iCounter =0;
		private void tbxUPC_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			bool bUPC = false;
			DataSet dsUPC = new DataSet();
			int ilResultTalla = 0;
			int ilValidaCantP = 0;

			if(e.KeyChar == (char)Keys.Return)
			{			
				if(this.tbxUPC.Text.Length == 12)
				{
					if(Convert.ToInt32(this.lblPairCounterT.Text)== 0)
					{	
						bUPC = true;				
					}
					else
					{
						if(this.tbxUPC.Text == this.lblUPCT.Text)
						{
							bUPC = true;
						}				
					}
			
					//this.lblUPCT.Text ==
					if(bUPC)
					{
						dsUPC = SistEti.lpQueries.VerificaUPC(this.tbxUPC.Text,this.tbEstilo.Text);
						if((dsUPC.Tables.Count>=1)&&(dsUPC.Tables[0].Rows.Count>=1))
						{
							this.lblEstiloT.Text = dsUPC.Tables[0].Rows[0]["Estilo"].ToString();
							this.lblTallaT.Text = dsUPC.Tables[0].Rows[0]["Talla"].ToString();						
							this.lblUPCT.Text = dsUPC.Tables[0].Rows[0]["UPC"].ToString();
							this.lblTotalPairs.Text = dsUPC.Tables[0].Rows[0]["Prendas"].ToString();
							ilResultTalla = VerificaTallaEstilo (this.lblTallaT.Text,this.tbEstilo.Text);
							dsUPC = SistEti.lpQueries.VerificaTOTPrendasxCORTE(this.lblUPCT.Text,this.sgCorte,this.sTipoCaja);
							if((dsUPC.Tables.Count>0)&&(dsUPC.Tables[0].Rows.Count>0))
								this.lblTOTEMP.Text = dsUPC.Tables[0].Rows[0][0].ToString();
							else
								this.lblTOTEMP.Text = "0";

							iCounter = Convert.ToInt32(this.lblPairCounterT.Text);
							iCounter = iCounter+1; 
							this.lblPairCounterT.Text = iCounter.ToString(); 
							iCounter =0;
							if(this.rbnBoxType1.Checked)
								this.gbxBoxType.Enabled=false;
							if(ilResultTalla==1)
							{
								MessageBox.Show( "Estilo y Talla no Solicitados en el Corte Ingresado. ", "ERROR DE CAPTURA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
								this.lblPairCounterT.Text="0";
								this.lblEstiloT.Text = "";
								this.lblTallaT.Text = "";
								this.lblUPCT.Text = "";
								this.lblTotalPairs.Text = "0";								
								this.gbxBoxType.Enabled=true;								
								LlenaDetalle();

							}
							else
								ilValidaCantP = ValidaCantidadPrendas();
							if((ilValidaCantP==1)&&(blPregunta))
							{
								Beep(500, 200); 
								DialogResult drResultado;
								drResultado = MessageBox.Show( "La siguiente Captura Excedara el Numero de Prendas Solicitadas.", "NOTIFICACION DE CAPTURA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2,MessageBoxOptions.DefaultDesktopOnly);
								while(drResultado == DialogResult.Cancel)
									drResultado = MessageBox.Show( "La siguiente Captura Excedara el Numero de Prendas Solicitadas.", "NOTIFICACION DE CAPTURA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2,MessageBoxOptions.DefaultDesktopOnly);
								
								blPregunta=false;
							}
						}
						else
						{
							Beep(500, 200); 
							DialogResult drResultado;							
							drResultado = MessageBox.Show( "El Estilo del UPC no corresponde al Estilo del Corte.", "NOTIFICACION DE CAPTURA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2,MessageBoxOptions.DefaultDesktopOnly);
							while(drResultado == DialogResult.Cancel)
								drResultado = MessageBox.Show( "El Estilo del UPC no corresponde al Estilo del Corte.", "NOTIFICACION DE CAPTURA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2,MessageBoxOptions.DefaultDesktopOnly);
							
							
						}

					}
					else
					{
						Beep(800, 500); 
						DialogResult drResultado;
						drResultado = MessageBox.Show( "El UPC no corresponde al que se esta capturando.", "NOTIFICACION DE CAPTURA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2,MessageBoxOptions.DefaultDesktopOnly);
						while(drResultado == DialogResult.Cancel)
							drResultado = MessageBox.Show( "El UPC no corresponde al que se esta capturando.", "NOTIFICACION DE CAPTURA", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2,MessageBoxOptions.DefaultDesktopOnly);
						
						//MsgBeep(MsgBeepType.Ok);
						
						//PlaySound(@"\Windows\Voicebeep",System.IntPtr.Zero,(int)0x20000|0x0);
					}
					if((this.lblTotalPairs.Text==this.lblPairCounterT.Text)&&(this.lblPairCounterT.Text!="0"))
					{
						ProcGuardaCaja();
//						int iResult = SistEti.lpQueries.InsertaCaja(this.sgCorte,this.tbColor.Text,this.lblTallaT.Text ,this.lblTotalPairs.Text,this.lblUPCT.Text,this.lblPairCounterT.Text,sTipoCaja);	
//						imprime();
//						this.lblPairCounterT.Text="0";
//						this.lblEstiloT.Text = "";
//						this.lblTallaT.Text = "";
//						this.lblUPCT.Text = "";
//						this.lblTotalPairs.Text = "0";						
//						LlenaDetalle();						
//						this.gbxBoxType.Enabled=true;
//						blPregunta=true;
					}
					
				}
				this.tbxUPC.Text="";
			}				
			
		}
		#endregion //private void tbxUPC_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)

		#region private int ValidaCantidadPrendas()
		private int ValidaCantidadPrendas()
		{
			int ilResult = 0;
			int ilCantPEmp = 0;
			int ilCantPPed = 0;
			DataSet dsCantP = new DataSet();
			dsCantP = SistEti.lpQueries.traeCantPrendas(this.tbxUPC.Text,this.sgCorte);
			if(dsCantP.Tables[0].Rows[0][0].ToString()!="")
			ilCantPEmp = Convert.ToInt32(dsCantP.Tables[0].Rows[0][0].ToString());
			dsCantP = SistEti.lpQueries.RevisaTalla(this.lblTallaT.Text,this.sgCorte);
			if(dsCantP.Tables.Count!=0)
			ilCantPPed = Convert.ToInt32(dsCantP.Tables[0].Rows[0][0].ToString());

			ilCantPEmp = ilCantPEmp+ Convert.ToInt32(this.lblTotalPairs.Text);
			if(ilCantPEmp<ilCantPPed)
				ilResult=0;
			else
				ilResult=1;
			return ilResult;			
		}
		#endregion //private int ValidaCantidadPrendas()

		#region 		private void rbnBoxType1_CheckedChanged(object sender, System.EventArgs e)
		private void rbnBoxType1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.tbxUPC.Enabled = true;
			this.tbxUPC.Focus();
            this.btnGuardarCaja.Visible=false;
			sTipoCaja = "1";
		}
		#endregion //private void rbnBoxType1_CheckedChanged(object sender, System.EventArgs e)

		#region private void rbnBoxType2_CheckedChanged(object sender, System.EventArgs e)
		private void rbnBoxType2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.tbxUPC.Enabled = true;
			this.tbxUPC.Focus();
			this.btnGuardarCaja.Visible=true;
			sTipoCaja = "2";
		}
		#endregion //private void rbnBoxType2_CheckedChanged(object sender, System.EventArgs e)

		#region private void rbnBoxType3_CheckedChanged(object sender, System.EventArgs e)
		private void rbnBoxType3_CheckedChanged(object sender, System.EventArgs e)
		{
			this.tbxUPC.Enabled = true;
			this.tbxUPC.Focus();
			this.btnGuardarCaja.Visible=true;
			sTipoCaja = "3";
		}
		#endregion //private void rbnBoxType3_CheckedChanged(object sender, System.EventArgs e)

		#region private void rbnBoxType4_CheckedChanged(object sender, System.EventArgs e)
		private void rbnBoxType4_CheckedChanged(object sender, System.EventArgs e)
		{
			this.tbxUPC.Enabled = true;
			this.tbxUPC.Focus();
			this.btnGuardarCaja.Visible=true;
			sTipoCaja = "4";
		}
		#endregion //private void rbnBoxType4_CheckedChanged(object sender, System.EventArgs e)

		private void FLeerEtiq_Load(object sender, System.EventArgs e)
		{
			
		}

		#region private void ProcGuardaCaja()
		private void ProcGuardaCaja()
		{			
			string slCajaId = SistEti.lpQueries.RegresaConsecutivoCaja(this.sgCorte);
			slCajaId = Convert.ToString(Convert.ToInt32(slCajaId)+1);
			int iResult = SistEti.lpQueries.InsertaCaja(this.sgCorte,this.tbColor.Text,this.lblTallaT.Text ,this.lblTotalPairs.Text,this.lblUPCT.Text,this.lblPairCounterT.Text,sTipoCaja,slCajaId);				
			//Agregado para Guardar Informacion de la Etiqueta Lineas 940 - 949 : 19 sep 09
			if(iResult ==1)
			{
				string slEtiquetaId = SistEti.lpQueries.traeEtiquetaId(this.lblUPCT.Text,this.sgCorte);
				sgEtiqId =slEtiquetaId;
				if(slEtiquetaId!="0")
				{
					string slFecha = DateTime.Now.ToString();
					int iResultEtiq = SistEti.lpQueries.InsertaInformacionEtiq(slEtiquetaId,slFecha,ConfigurationSettings.AppSettings["NomPC"]);

				}
			}
			
			imprime();
			this.lblPairCounterT.Text="0";
			this.lblEstiloT.Text = "";
			this.lblTallaT.Text = "";
			this.lblUPCT.Text = "";
			this.lblTotalPairs.Text = "0";	
			this.lblTOTEMP.Text="0";		
			LlenaDetalle();
			LenaTallaCaptQTY();
			LlenaTallaCaptQTYFaltante();

			//actualiza el total del prendas del corte
			DataSet dsDetalle = new DataSet();			
			dsDetalle = SistEti.lpQueries.LlenaCTporID(this.sgCorte);	
			this.lblTotalPCapt.Text = dsDetalle.Tables[0].Rows[0][4].ToString();
			GeneraTotalPrendas();
			this.lblTotalPFalt.Text=Convert.ToString(Convert.ToInt32(this.lblTotalPCorte.Text)-Convert.ToInt32(this.lblTotalPCapt.Text));
			this.lblCaptPorc.Text=Convert.ToString(Convert.ToInt32(((Convert.ToDecimal(this.lblTotalPCapt.Text)/Convert.ToDecimal(this.lblTotalPCorte.Text))*100)))+"%";
			this.lblFaltPorc.Text=Convert.ToString(100-Convert.ToInt32(((Convert.ToDecimal(this.lblTotalPCapt.Text)/Convert.ToDecimal(this.lblTotalPCorte.Text))*100)))+"%";;

			this.gbxBoxType.Enabled=true;
			blPregunta=true;
			this.tbxUPC.Focus();
			this.tbxUPC.Focus();
			//Consecutivo Caja
			slCajaId = SistEti.lpQueries.RegresaConsecutivoCaja(this.sgCorte);			
			this.lblCaja.Text=slCajaId;
			if((slCajaId=="25")||(slCajaId=="50")||(slCajaId=="60")||(slCajaId=="70")||(slCajaId=="95")||(slCajaId=="105")||(slCajaId=="130"))
			{				
				MessageBox.Show( "NUMERO DE CAJAS CAPTURADAS SON: "+slCajaId,"REVISAR TARIMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		#endregion //private void ProcGuardaCaja()

		#region private void LlenaDetalle()
		private void LlenaDetalle()
		{
			DataViewManager dvmDetalle;
			DataSet dsDetalle = new DataSet();
			dsDetalle.Clear();
			dsDetalle = SistEti.lpQueries.LlenaDetCT(this.sgCorte);			
			dvmDetalle = dsDetalle.DefaultViewManager;
			this.dgDetalleLect.DataSource = dvmDetalle.DataSet.Tables[0];
			
			this.dgDetalleLect.Refresh();
			
		}
		#endregion //private void LlenaDetalle()

		#region private void btnGuardarCaja_Click(object sender, System.EventArgs e)
		private void btnGuardarCaja_Click(object sender, System.EventArgs e)
		{
			if(this.lblUPCT.Text!="")
			{
				ProcGuardaCaja();
			}
			else
			{
				MessageBox.Show( "Debes de Ingresar un UPC para Guardar la Informacion.", "ERROR DE GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
//			int iResult = SistEti.lpQueries.InsertaCaja(this.sgCorte,this.tbColor.Text,this.lblTallaT.Text ,this.lblTotalPairs.Text,this.lblUPCT.Text,this.lblPairCounterT.Text,sTipoCaja);	
//			imprime();
//			this.lblPairCounterT.Text="0";
//			this.lblEstiloT.Text = "";
//			this.lblTallaT.Text = "";
//			this.lblUPCT.Text = "";
//			this.lblTotalPairs.Text = "0";						
//			LlenaDetalle();
//			this.gbxBoxType.Enabled=true;
//			blPregunta=true;
		}
		#endregion //private void btnGuardarCaja_Click(object sender, System.EventArgs e)

		#region private void btnCancelarCaja_Click(object sender, System.EventArgs e)
		private void btnCancelarCaja_Click(object sender, System.EventArgs e)
		{
			//int iResult = SistEti.lpQueries.InsertaCaja("1","",this.lblTallaT.Text ,this.lblTotalPairs.Text,this.lblUPCT.Text,this.lblPairCounterT.Text );	
			this.lblPairCounterT.Text="0";
			this.lblEstiloT.Text = "";
			this.lblTallaT.Text = "";
			this.lblUPCT.Text = "";
			this.lblTotalPairs.Text = "0";						
			LlenaDetalle();
			this.gbxBoxType.Enabled=true;		
			this.tbxUPC.Focus();
			blPregunta=true;
		}
		#endregion //private void btnCancelarCaja_Click(object sender, System.EventArgs e)

		#region private void GeneraTotalPrendas()
		private void GeneraTotalPrendas()
		{
			int ilTotal = 0;
			for(int ilContRow = 0; ilContRow < 4 ; ilContRow++)
			{
				for(int ilContCol = 1; ilContCol < 13 ; ilContCol++)
				{
					ilTotal = ilTotal + Convert.ToInt32(this.dgTallaQty[ilContRow,ilContCol]);
				}		
			}
			this.lblTotalPCorte.Text = ilTotal.ToString();
		}
		#endregion()

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
				this.tbxCorte.Text = dsDetalle.Tables[0].Rows[0][0].ToString();				
				this.tbContrato.Text = dsDetalle.Tables[0].Rows[0][1].ToString();
				this.tbEstilo.Text = dsDetalle.Tables[0].Rows[0][2].ToString();
				this.tbColor.Text = dsDetalle.Tables[0].Rows[0][3].ToString();
				
				LlenaDetalle();
				LlenaTallaQTY();
				//				try
				//				{
				LenaTallaCaptQTY();
				LlenaTallaCaptQTYFaltante();

				this.lblTotalPCapt.Text = dsDetalle.Tables[0].Rows[0][4].ToString();
				GeneraTotalPrendas();
				this.lblTotalPFalt.Text=Convert.ToString(Convert.ToInt32(this.lblTotalPCorte.Text)-Convert.ToInt32(this.lblTotalPCapt.Text));
				this.lblCaptPorc.Text=Convert.ToString(Convert.ToInt32(((Convert.ToDecimal(this.lblTotalPCapt.Text)/Convert.ToDecimal(this.lblTotalPCorte.Text))*100)))+"%";
				this.lblFaltPorc.Text=Convert.ToString(100-Convert.ToInt32(((Convert.ToDecimal(this.lblTotalPCapt.Text)/Convert.ToDecimal(this.lblTotalPCorte.Text))*100)))+"%";;

				this.gbxBoxType.Enabled = true;
				this.tbxUPC.Enabled = true;
				this.tbxUPC.Focus();

				//Consecutivo Caja
				string slCajaId = SistEti.lpQueries.RegresaConsecutivoCaja(this.sgCorte);
				
				this.lblCaja.Text=slCajaId;
				//				}
				//				catch(Exception err)
				//				{
				//					string slError = err.Message;
				//				}
			}
//			else
//			{
//				this.gbxBoxType.Enabled = false;								
//				this.tbxUPC.Enabled=false;
//				this.tbxCorte.Focus();				
//			}		
//
//			this.tbxUPC.Enabled = false;				
//			this.tbxCorte.Focus();
//			this.btnGuardarCaja.Visible=false;
//			rbnBoxType1.Checked = false;
//			rbnBoxType2.Checked = false;
//			rbnBoxType3.Checked = false;
//			rbnBoxType4.Checked = false;

		}
		#endregion //private void btnSearch_Click(object sender, System.EventArgs e)

		#region public int VerificaTallaEstilo(string slTalla,string slEstilo)
		public int VerificaTallaEstilo(string slTalla,string slEstilo)
		{
			int ilResult = 0;
			DataSet dsDetalle = new DataSet();
            dsDetalle = SistEti.lpQueries.RevisaTalla(slTalla,this.sgCorte);
			if(dsDetalle.Tables[0].Rows[0][0].ToString()=="0")
			{
				ilResult = 1;
			}
			else
			{
				ilResult = 0;
				if(this.tbEstilo.Text!=this.lblEstiloT.Text)
					ilResult = 1;
			}

			return ilResult;
		}
		#endregion //public int VerificaTallaEstilo(string slTalla,string slEstilo)

		#region private void LlenaTallaQTY()
		private void LlenaTallaQTY()
		{
			DataViewManager dvmDetalle;
			DataSet dsDetalle = new DataSet();
			dsDetalle.Clear();
			dsDetalle = SistEti.lpQueries.LlenaTallaCT(this.sgCorte);			
			dvmDetalle = dsDetalle.DefaultViewManager;
			this.dgTallaQty.DataSource = dvmDetalle.DataSet.Tables[0];
			this.dgTallaQty.Refresh();		
		}
		#endregion //private void LlenaTallaQTY()

		#region private void LenaTallaCaptQTY()
		private void LenaTallaCaptQTY()
		{
			DataViewManager dvmDetalle;
			DataSet dsDetalle = new DataSet();
			dsDetalle.Clear();
			dsDetalle = SistEti.lpQueries.LlenaTallaCTCapt(this.sgCorte);			
			dvmDetalle = dsDetalle.DefaultViewManager;
			this.dgCaptura.DataSource = dvmDetalle.DataSet.Tables[0];
			this.dgCaptura.Refresh();		
		}
		#endregion //private void LenaTallaCaptQTY()

		#region private void LenaTallaCaptQTYFaltante()
		private void LlenaTallaCaptQTYFaltante()
		{
			DataViewManager dvmDetalle1;
			DataSet dsDetalle1 = new DataSet();
			dsDetalle1.Clear();
			dsDetalle1 = SistEti.lpQueries.LlenaTallaCT(this.sgCorte);			
			dvmDetalle1 = dsDetalle1.DefaultViewManager;
			//this.dgTallaQty.DataSource = dvmDetalle.DataSet.Tables[0];
			//this.dgTallaQty.Refresh();	

			DataViewManager dvmDetalle2;
			DataSet dsDetalle2 = new DataSet();
			dsDetalle2.Clear();
			dsDetalle2 = SistEti.lpQueries.LlenaTallaCTCapt(this.sgCorte);			
			

			if((dsDetalle2.Tables.Count!=0)&&(dsDetalle2.Tables[0].Rows.Count!=0))
			{
				for(int ilContR=0; ilContR<dsDetalle1.Tables[0].Rows.Count;ilContR++)
				{
					for(int ilContC=1; ilContC<dsDetalle1.Tables[0].Columns.Count;ilContC++)
					{
						dsDetalle2.Tables[0].Rows[ilContR][ilContC] = Convert.ToString(Convert.ToInt32(dsDetalle1.Tables[0].Rows[ilContR][ilContC])-Convert.ToInt32(dsDetalle2.Tables[0].Rows[ilContR][ilContC]));
					}
				}
				dvmDetalle2 = dsDetalle2.DefaultViewManager;
				this.dgCantFaltante.DataSource = dvmDetalle2.DataSet.Tables[0];
				this.dgCantFaltante.Refresh();	
			}
		}		
		#endregion

		#region private void imprime()
		//[DllImport("kernel32.dll")] internal static extern IntPtr CreateFile(string name, int desiredAccess, int shareMode, IntPtr securityAttributes,int creationDisposition, int dwFlagsAndAttributes, IntPtr templateFile);
		private void imprime()
		{
			string slMessage = "";
			slMessage = SistEti.lpUtils.Imprime(this.tbxCorte.Text,this.tbContrato.Text,this.tbEstilo.Text,this.lblTallaT.Text,this.lblPairCounterT.Text,this.lblUPCT.Text,this.tbColor.Text,this.sTipoCaja.ToString(),sgEtiqId);
			if(slMessage!="")
				MessageBox.Show(slMessage, "ERROR DE IMPRESION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//			char cr = (char)13;			
//			string mensaje="";
//			String [] saCorte = new string[2]; 
//
//			mensaje += "^XA";
//			mensaje += cr;
//			mensaje += "^LH0,0";
//			mensaje += cr;
//			mensaje += "^FO50,35^A0,,95,75^FDFLYNN^FS";
//			mensaje += cr;
//			mensaje += "^FO500,35^A0,,45,65^FDPOS BIN STOCK^FS";
//			mensaje += cr;
//			mensaje += "^FO340,35^A0,,65,25^FD" + DateTime.Today.ToString("MM/yy") + "^FS";
//			mensaje += cr;
//			//mensaje += "^FO340,35^A0,,65,25^FD" + DateTime.Today.ToString("MM/yy") + "^FS";
//			//mensaje += cr;
//			mensaje += "^FO330,110^B3N,,120^FD" + this.lblUPCT.Text + "^FS";
//			mensaje += cr;
//			mensaje += "^FO95,140^A0,,65,45^FD" + this.tbContrato.Text  + "^FS";
//			mensaje += cr;
//			mensaje += "^FO60,240^A0,,45,55^FD" + this.tbEstilo.Text + "^FS";
//			mensaje += cr;
//			saCorte = this.tbxCorte.Text.Split('-');
//			string slCorte = saCorte[1]+saCorte[0];
//			mensaje += "^FO100,280^A0,,65,45^FD" + slCorte + "^FS";
//			mensaje += cr;
//			mensaje += "^FO450,260^B3N,,90,N^FD" + slCorte + "^FS";
//			mensaje += cr;
//			//mensaje += "^FO60,340^B3N,,40^FD" + rsTemp.Tables[0].Rows[i]["etid"].ToString() + "^FS";
//			//mensaje += cr;
//			mensaje += "^FO120,425^A0,,60,30^FDPAIR^FS";
//			mensaje += cr;
//			mensaje += "^FO350,405^A0,,85,55^FD" + String.Format("{0:000}",this.lblTotalPairs.Text ) + "^FS";
//			mensaje += cr;
//			mensaje += "^FO630,385^B3N,,85,N^FD" + String.Format("{0:000}",this.lblTotalPairs.Text ) + "^FS";
//			mensaje += cr;
//			string slColor = this.tbColor.Text;
//			string sCol =slColor.Substring(0,1);
//			switch(sCol)
//			{
//				case "L":
//					slColor="LTSW";
//					break;
//				case "D":
//					slColor="DKSW";
//					break;
//				case "M":
//					slColor="MEDSW";
//					break;
//				default:					
//					break;
//
//			}
//			string slEstilo = this.tbEstilo.Text;
//			mensaje += "^FO50,505^A0,,60,30^FDS/" + slEstilo.Substring(7,3)  + "^FS";
//			mensaje += cr;
//			mensaje += "^FO220,505^A0,,60,30^FD" + slColor + "^FS";
//			mensaje += cr;
//			mensaje += "^FO530,505^A0,,60,30^FD  SZ " + this.lblTallaT.Text + "^FS";
//			mensaje += cr;
//			mensaje += "^FO780,580^A0,,20,30^FDS^FS";
//			mensaje += cr;
//			mensaje += "^XZ";
//			mensaje += cr;
//
//			//this.textBox1.Text = mensaje;
//			SendToLpt1(mensaje);

		}
		#endregion //private void imprime()

		#region public static void SendToLpt1(string message)
//		public static void SendToLpt1(string message)
//		{
//			FileStream fs = null;
//			IntPtr handle = CreateFile(
//				"LPT1",
//				(int) FileAccess.Write, 
//				(int) FileShare.Read, 
//				IntPtr.Zero, 
//				(int) FileMode.Open, 
//				0, 
//				IntPtr.Zero);
//			if (handle.ToInt32() != -1)
//			{
//				try
//				{
//					fs = new FileStream(handle, FileAccess.Write);
//					byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
//					fs.Write(msg, 0, msg.Length);
//					fs.Close();
//				}
//				catch
//				{
//					MessageBox.Show( "No se ha encontrado la Impresora", "ERROR DE IMPRESION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//				}
//			}
//			else
//			{
//				MessageBox.Show( "No se puede abrir el puerto de Impresión", "ERROR DE IMPRESION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//			}
//		}
		#endregion //public static void SendToLpt1(string message)

		#region para Pruebas
		private void button1_Click(object sender, System.EventArgs e)
		{
			imprime();
		
		}

		
		#endregion para Puebras

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		//[STAThread]
		//static void Main() 
		//{
		//	Application.Run(new Form1());
		//}
	}
}
