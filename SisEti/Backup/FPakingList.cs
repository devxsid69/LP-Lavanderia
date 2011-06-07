using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace SistEti
{
	/// <summary>
	/// Summary description for FPakingList.
	/// </summary>
	public class FPakingList : System.Windows.Forms.Form
	{
		private string sgCorte="";
		private string sgTalla ="";
		private string sgTotalPairs = "";
		private string sgUPC ="";
		private static string slCajaSolidas ="1";
		private static string slCajaSaldos ="4";
		private static string slCajaSegundas ="2";
		private static string slCajaTerceras ="3";		
		private System.Windows.Forms.Label lblEstilo;
		private System.Windows.Forms.TextBox tbEstilo;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox tbxCorte;
		private System.Windows.Forms.Label lblCut;
		private System.Windows.Forms.TextBox tbColor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblContrato;
		private System.Windows.Forms.TextBox tbContrato;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.DataGridTableStyle dgsFlat1;		
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcCajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcTalla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcPrendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcTipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcCuttingId;
		private System.Windows.Forms.DataGridTableStyle dgsFlat2;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF2CajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF2Talla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF2Prendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF2TipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF2Id;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF2CuttingId;
		private System.Windows.Forms.DataGridTableStyle dgsFlat3;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF3CajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF3Talla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF3Prendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF3TipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF3Id;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF3CuttingId;
		private System.Windows.Forms.DataGridTableStyle dgsFlat4;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF4CajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF4Talla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF4Prendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF4TipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF4Id;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF4CuttingId;
		private System.Windows.Forms.DataGridTableStyle dgsFlat5;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF5CajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF5Talla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF5Prendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF5TipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF5Id;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF5CuttingId;
		private System.Windows.Forms.DataGridTableStyle dgsFlat6;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF6CajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF6Talla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF6Prendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF6TipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF6Id;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF6CuttingId;
		private System.Windows.Forms.DataGridTableStyle dgsFlat7;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF7CajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF7Talla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF7Prendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF7TipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF7Id;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcF7CuttingId;
		private System.Windows.Forms.DataGridTableStyle dgsFlatS1;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS1CajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS1Talla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS1Prendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS1TipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS1Id;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS1CuttingId;
		private System.Windows.Forms.DataGridTableStyle dgsFlatS2;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS2CajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS2Talla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS2Prendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS2TipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS2Id;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS2CuttingId;
		private System.Windows.Forms.DataGridTableStyle dgsFlatS3;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS3CajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS3Talla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS3Prendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS3TipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS3Id;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFS3CuttingId;
		private System.Windows.Forms.DataGridTableStyle dgsFlatSC1;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFSC1CajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFSC1Talla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFSC1Prendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFSC1TipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFSC1Id;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFSC1CuttingId;
		private System.Windows.Forms.DataGridTableStyle dgsFlatSC2;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFSC2CajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFSC2Talla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFSC2Prendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFSC2TipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFSC2Id;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFSC2CuttingId;
		private System.Windows.Forms.DataGridTableStyle dgsFlatST1;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFST1CajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFST1Talla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFST1Prendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFST1TipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFST1Id;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFST1CuttingId;
		private System.Windows.Forms.DataGridTableStyle dgsFlatST2;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFST2CajaId;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFST2Talla;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFST2Prendas;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFST2TipoCaja;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFST2Id;
		private System.Windows.Forms.DataGridTextBoxColumn dgtbcFST2CuttingId;
		private System.Windows.Forms.DataGrid dgFlat1;
		private System.Windows.Forms.DataGrid dgFlat2;
		private System.Windows.Forms.DataGrid dgFlat3;
		private System.Windows.Forms.DataGrid dgFlat4;
		private System.Windows.Forms.DataGrid dgFlat5;
		private System.Windows.Forms.DataGrid dgFlat6;
		private System.Windows.Forms.DataGrid dgFlat7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGrid dgFlatS1;
		private System.Windows.Forms.DataGrid dgFlatSC1;
		private System.Windows.Forms.DataGrid dgFlatS2;
		private System.Windows.Forms.DataGrid dgFlatS3;
		private System.Windows.Forms.DataGrid dgFlatSC2;
		private System.Windows.Forms.DataGrid dgFlatST1;
		private System.Windows.Forms.DataGrid dgFlatST2;
		private System.Windows.Forms.Label lblFlatS3;
		private System.Windows.Forms.Label lblFlatS2;
		private System.Windows.Forms.Label lblFlatS1;
		private System.Windows.Forms.Label lblFlatSC2;
		private System.Windows.Forms.Label lblFlatSC1;
		private System.Windows.Forms.Label lblFlatST2;
		private System.Windows.Forms.Label lblFlatST1;
		private System.Windows.Forms.Label lblFlatTE2;
		private System.Windows.Forms.Label lblFlatTE1;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnPacking;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FPakingList()
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
			this.lblEstilo = new System.Windows.Forms.Label();
			this.tbEstilo = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.tbxCorte = new System.Windows.Forms.TextBox();
			this.lblCut = new System.Windows.Forms.Label();
			this.tbColor = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lblContrato = new System.Windows.Forms.Label();
			this.tbContrato = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lblFlatTE2 = new System.Windows.Forms.Label();
			this.lblFlatTE1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgFlat7 = new System.Windows.Forms.DataGrid();
			this.dgsFlat7 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcF7CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF7Talla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF7Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF7TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF7Id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF7CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgFlat6 = new System.Windows.Forms.DataGrid();
			this.dgsFlat6 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcF6CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF6Talla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF6Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF6TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF6Id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF6CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgFlat5 = new System.Windows.Forms.DataGrid();
			this.dgsFlat5 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcF5CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF5Talla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF5Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF5TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF5Id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF5CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgFlat4 = new System.Windows.Forms.DataGrid();
			this.dgsFlat4 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcF4CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF4Talla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF4Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF4TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF4Id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF4CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgFlat3 = new System.Windows.Forms.DataGrid();
			this.dgsFlat3 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcF3CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF3Talla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF3Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF3TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF3Id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF3CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgFlat2 = new System.Windows.Forms.DataGrid();
			this.dgsFlat2 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcF2CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF2Talla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF2Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF2TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF2Id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcF2CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgFlat1 = new System.Windows.Forms.DataGrid();
			this.dgsFlat1 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcCajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcTalla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcPrendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcTipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcCuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dgFlatS3 = new System.Windows.Forms.DataGrid();
			this.dgsFlatS3 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcFS3CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS3Talla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS3Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS3TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS3Id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS3CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgFlatS2 = new System.Windows.Forms.DataGrid();
			this.dgsFlatS2 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcFS2CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS2Talla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS2Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS2TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS2Id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS2CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.lblFlatS3 = new System.Windows.Forms.Label();
			this.lblFlatS2 = new System.Windows.Forms.Label();
			this.dgFlatS1 = new System.Windows.Forms.DataGrid();
			this.dgsFlatS1 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcFS1CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS1Talla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS1Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS1TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS1Id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFS1CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.lblFlatS1 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dgFlatSC2 = new System.Windows.Forms.DataGrid();
			this.dgsFlatSC2 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcFSC2CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFSC2Talla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFSC2Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFSC2TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFSC2Id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFSC2CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.lblFlatSC2 = new System.Windows.Forms.Label();
			this.lblFlatSC1 = new System.Windows.Forms.Label();
			this.dgFlatSC1 = new System.Windows.Forms.DataGrid();
			this.dgsFlatSC1 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcFSC1CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFSC1Talla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFSC1Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFSC1TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFSC1Id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFSC1CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.lblFlatST2 = new System.Windows.Forms.Label();
			this.lblFlatST1 = new System.Windows.Forms.Label();
			this.dgFlatST2 = new System.Windows.Forms.DataGrid();
			this.dgsFlatST2 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcFST2CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFST2Talla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFST2Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFST2TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFST2Id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFST2CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgFlatST1 = new System.Windows.Forms.DataGrid();
			this.dgsFlatST1 = new System.Windows.Forms.DataGridTableStyle();
			this.dgtbcFST1CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFST1Talla = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFST1Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFST1TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFST1Id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtbcFST1CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnPacking = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgFlat7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlat6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlat5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlat4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlat3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlat2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlat1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgFlatS3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlatS2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlatS1)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgFlatSC2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlatSC1)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgFlatST2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlatST1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblEstilo
			// 
			this.lblEstilo.Location = new System.Drawing.Point(128, 8);
			this.lblEstilo.Name = "lblEstilo";
			this.lblEstilo.Size = new System.Drawing.Size(40, 16);
			this.lblEstilo.TabIndex = 30;
			this.lblEstilo.Text = "Estilo";
			// 
			// tbEstilo
			// 
			this.tbEstilo.Location = new System.Drawing.Point(136, 24);
			this.tbEstilo.Name = "tbEstilo";
			this.tbEstilo.ReadOnly = true;
			this.tbEstilo.TabIndex = 29;
			this.tbEstilo.Text = "";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(448, 24);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.TabIndex = 27;
			this.btnSearch.Text = "Buscar";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// tbxCorte
			// 
			this.tbxCorte.Location = new System.Drawing.Point(32, 24);
			this.tbxCorte.Name = "tbxCorte";
			this.tbxCorte.TabIndex = 26;
			this.tbxCorte.Text = "";
			// 
			// lblCut
			// 
			this.lblCut.Location = new System.Drawing.Point(32, 8);
			this.lblCut.Name = "lblCut";
			this.lblCut.Size = new System.Drawing.Size(40, 16);
			this.lblCut.TabIndex = 28;
			this.lblCut.Text = "Corte";
			// 
			// tbColor
			// 
			this.tbColor.Location = new System.Drawing.Point(344, 24);
			this.tbColor.Name = "tbColor";
			this.tbColor.ReadOnly = true;
			this.tbColor.TabIndex = 33;
			this.tbColor.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(336, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 34;
			this.label5.Text = "Color";
			// 
			// lblContrato
			// 
			this.lblContrato.Location = new System.Drawing.Point(232, 8);
			this.lblContrato.Name = "lblContrato";
			this.lblContrato.Size = new System.Drawing.Size(56, 16);
			this.lblContrato.TabIndex = 32;
			this.lblContrato.Text = "Contrato";
			// 
			// tbContrato
			// 
			this.tbContrato.Location = new System.Drawing.Point(240, 24);
			this.tbContrato.Name = "tbContrato";
			this.tbContrato.ReadOnly = true;
			this.tbContrato.TabIndex = 31;
			this.tbContrato.Text = "";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(8, 48);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(968, 520);
			this.tabControl1.TabIndex = 35;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lblFlatTE2);
			this.tabPage1.Controls.Add(this.lblFlatTE1);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.dgFlat7);
			this.tabPage1.Controls.Add(this.dgFlat6);
			this.tabPage1.Controls.Add(this.dgFlat5);
			this.tabPage1.Controls.Add(this.dgFlat4);
			this.tabPage1.Controls.Add(this.dgFlat3);
			this.tabPage1.Controls.Add(this.dgFlat2);
			this.tabPage1.Controls.Add(this.dgFlat1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(960, 494);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Primeras";
			// 
			// lblFlatTE2
			// 
			this.lblFlatTE2.Location = new System.Drawing.Point(832, 0);
			this.lblFlatTE2.Name = "lblFlatTE2";
			this.lblFlatTE2.Size = new System.Drawing.Size(100, 16);
			this.lblFlatTE2.TabIndex = 13;
			this.lblFlatTE2.Text = "Flat # ";
			this.lblFlatTE2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lblFlatTE1
			// 
			this.lblFlatTE1.Location = new System.Drawing.Point(672, 0);
			this.lblFlatTE1.Name = "lblFlatTE1";
			this.lblFlatTE1.Size = new System.Drawing.Size(100, 16);
			this.lblFlatTE1.TabIndex = 12;
			this.lblFlatTE1.Text = "Flat # ";
			this.lblFlatTE1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(520, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Flat # 5";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(352, 240);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 10;
			this.label4.Text = "Flat # 4";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(360, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 9;
			this.label3.Text = "Flat # 3";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(192, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "Flat # 2";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "Flat # 1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dgFlat7
			// 
			this.dgFlat7.DataMember = "";
			this.dgFlat7.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dgFlat7.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlat7.Location = new System.Drawing.Point(808, 16);
			this.dgFlat7.Name = "dgFlat7";
			this.dgFlat7.Size = new System.Drawing.Size(152, 472);
			this.dgFlat7.TabIndex = 6;
			this.dgFlat7.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								this.dgsFlat7});
			this.dgFlat7.Tag = "";
			// 
			// dgsFlat7
			// 
			this.dgsFlat7.DataGrid = this.dgFlat7;
			this.dgsFlat7.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																									   this.dgtbcF7CajaId,
																									   this.dgtbcF7Talla,
																									   this.dgtbcF7Prendas,
																									   this.dgtbcF7TipoCaja,
																									   this.dgtbcF7Id,
																									   this.dgtbcF7CuttingId});
			this.dgsFlat7.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlat7.MappingName = "TABLEPLFlat7";
			// 
			// dgtbcF7CajaId
			// 
			this.dgtbcF7CajaId.Format = "";
			this.dgtbcF7CajaId.FormatInfo = null;
			this.dgtbcF7CajaId.HeaderText = "#Caja";
			this.dgtbcF7CajaId.MappingName = "CajaId";
			this.dgtbcF7CajaId.ReadOnly = true;
			this.dgtbcF7CajaId.Width = 35;
			// 
			// dgtbcF7Talla
			// 
			this.dgtbcF7Talla.Format = "";
			this.dgtbcF7Talla.FormatInfo = null;
			this.dgtbcF7Talla.HeaderText = "Talla";
			this.dgtbcF7Talla.MappingName = "Talla";
			this.dgtbcF7Talla.ReadOnly = true;
			this.dgtbcF7Talla.Width = 35;
			// 
			// dgtbcF7Prendas
			// 
			this.dgtbcF7Prendas.Format = "";
			this.dgtbcF7Prendas.FormatInfo = null;
			this.dgtbcF7Prendas.HeaderText = "Cant";
			this.dgtbcF7Prendas.MappingName = "Prendas";
			this.dgtbcF7Prendas.Width = 30;
			// 
			// dgtbcF7TipoCaja
			// 
			this.dgtbcF7TipoCaja.Format = "";
			this.dgtbcF7TipoCaja.FormatInfo = null;
			this.dgtbcF7TipoCaja.HeaderText = "Tipo";
			this.dgtbcF7TipoCaja.MappingName = "TipoCaja";
			this.dgtbcF7TipoCaja.ReadOnly = true;
			this.dgtbcF7TipoCaja.Width = 0;
			// 
			// dgtbcF7Id
			// 
			this.dgtbcF7Id.Format = "";
			this.dgtbcF7Id.FormatInfo = null;
			this.dgtbcF7Id.HeaderText = "Id";
			this.dgtbcF7Id.MappingName = "Id";
			this.dgtbcF7Id.ReadOnly = true;
			this.dgtbcF7Id.Width = 0;
			// 
			// dgtbcF7CuttingId
			// 
			this.dgtbcF7CuttingId.Format = "";
			this.dgtbcF7CuttingId.FormatInfo = null;
			this.dgtbcF7CuttingId.HeaderText = "CorteId";
			this.dgtbcF7CuttingId.MappingName = "CuttingId";
			this.dgtbcF7CuttingId.ReadOnly = true;
			this.dgtbcF7CuttingId.Width = 0;
			// 
			// dgFlat6
			// 
			this.dgFlat6.DataMember = "";
			this.dgFlat6.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dgFlat6.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlat6.Location = new System.Drawing.Point(648, 16);
			this.dgFlat6.Name = "dgFlat6";
			this.dgFlat6.Size = new System.Drawing.Size(152, 472);
			this.dgFlat6.TabIndex = 5;
			this.dgFlat6.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								this.dgsFlat6});
			this.dgFlat6.Tag = "";
			// 
			// dgsFlat6
			// 
			this.dgsFlat6.DataGrid = this.dgFlat6;
			this.dgsFlat6.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																									   this.dgtbcF6CajaId,
																									   this.dgtbcF6Talla,
																									   this.dgtbcF6Prendas,
																									   this.dgtbcF6TipoCaja,
																									   this.dgtbcF6Id,
																									   this.dgtbcF6CuttingId});
			this.dgsFlat6.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlat6.MappingName = "TABLEPLFlat6";
			// 
			// dgtbcF6CajaId
			// 
			this.dgtbcF6CajaId.Format = "";
			this.dgtbcF6CajaId.FormatInfo = null;
			this.dgtbcF6CajaId.HeaderText = "#Caja";
			this.dgtbcF6CajaId.MappingName = "CajaId";
			this.dgtbcF6CajaId.ReadOnly = true;
			this.dgtbcF6CajaId.Width = 35;
			// 
			// dgtbcF6Talla
			// 
			this.dgtbcF6Talla.Format = "";
			this.dgtbcF6Talla.FormatInfo = null;
			this.dgtbcF6Talla.HeaderText = "Talla";
			this.dgtbcF6Talla.MappingName = "Talla";
			this.dgtbcF6Talla.ReadOnly = true;
			this.dgtbcF6Talla.Width = 35;
			// 
			// dgtbcF6Prendas
			// 
			this.dgtbcF6Prendas.Format = "";
			this.dgtbcF6Prendas.FormatInfo = null;
			this.dgtbcF6Prendas.HeaderText = "Cant";
			this.dgtbcF6Prendas.MappingName = "Prendas";
			this.dgtbcF6Prendas.Width = 30;
			// 
			// dgtbcF6TipoCaja
			// 
			this.dgtbcF6TipoCaja.Format = "";
			this.dgtbcF6TipoCaja.FormatInfo = null;
			this.dgtbcF6TipoCaja.HeaderText = "Tipo";
			this.dgtbcF6TipoCaja.MappingName = "TipoCaja";
			this.dgtbcF6TipoCaja.ReadOnly = true;
			this.dgtbcF6TipoCaja.Width = 0;
			// 
			// dgtbcF6Id
			// 
			this.dgtbcF6Id.Format = "";
			this.dgtbcF6Id.FormatInfo = null;
			this.dgtbcF6Id.HeaderText = "Id";
			this.dgtbcF6Id.MappingName = "Id";
			this.dgtbcF6Id.ReadOnly = true;
			this.dgtbcF6Id.Width = 0;
			// 
			// dgtbcF6CuttingId
			// 
			this.dgtbcF6CuttingId.Format = "";
			this.dgtbcF6CuttingId.FormatInfo = null;
			this.dgtbcF6CuttingId.HeaderText = "CorteId";
			this.dgtbcF6CuttingId.MappingName = "CuttingId";
			this.dgtbcF6CuttingId.ReadOnly = true;
			this.dgtbcF6CuttingId.Width = 0;
			// 
			// dgFlat5
			// 
			this.dgFlat5.DataMember = "";
			this.dgFlat5.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dgFlat5.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlat5.Location = new System.Drawing.Point(488, 16);
			this.dgFlat5.Name = "dgFlat5";
			this.dgFlat5.Size = new System.Drawing.Size(152, 472);
			this.dgFlat5.TabIndex = 4;
			this.dgFlat5.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								this.dgsFlat5});
			this.dgFlat5.Tag = "";
			// 
			// dgsFlat5
			// 
			this.dgsFlat5.DataGrid = this.dgFlat5;
			this.dgsFlat5.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																									   this.dgtbcF5CajaId,
																									   this.dgtbcF5Talla,
																									   this.dgtbcF5Prendas,
																									   this.dgtbcF5TipoCaja,
																									   this.dgtbcF5Id,
																									   this.dgtbcF5CuttingId});
			this.dgsFlat5.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlat5.MappingName = "TABLEPLFlat5";
			// 
			// dgtbcF5CajaId
			// 
			this.dgtbcF5CajaId.Format = "";
			this.dgtbcF5CajaId.FormatInfo = null;
			this.dgtbcF5CajaId.HeaderText = "#Caja";
			this.dgtbcF5CajaId.MappingName = "CajaId";
			this.dgtbcF5CajaId.ReadOnly = true;
			this.dgtbcF5CajaId.Width = 35;
			// 
			// dgtbcF5Talla
			// 
			this.dgtbcF5Talla.Format = "";
			this.dgtbcF5Talla.FormatInfo = null;
			this.dgtbcF5Talla.HeaderText = "Talla";
			this.dgtbcF5Talla.MappingName = "Talla";
			this.dgtbcF5Talla.ReadOnly = true;
			this.dgtbcF5Talla.Width = 35;
			// 
			// dgtbcF5Prendas
			// 
			this.dgtbcF5Prendas.Format = "";
			this.dgtbcF5Prendas.FormatInfo = null;
			this.dgtbcF5Prendas.HeaderText = "Cant";
			this.dgtbcF5Prendas.MappingName = "Prendas";
			this.dgtbcF5Prendas.Width = 30;
			// 
			// dgtbcF5TipoCaja
			// 
			this.dgtbcF5TipoCaja.Format = "";
			this.dgtbcF5TipoCaja.FormatInfo = null;
			this.dgtbcF5TipoCaja.HeaderText = "Tipo";
			this.dgtbcF5TipoCaja.MappingName = "TipoCaja";
			this.dgtbcF5TipoCaja.ReadOnly = true;
			this.dgtbcF5TipoCaja.Width = 0;
			// 
			// dgtbcF5Id
			// 
			this.dgtbcF5Id.Format = "";
			this.dgtbcF5Id.FormatInfo = null;
			this.dgtbcF5Id.HeaderText = "Id";
			this.dgtbcF5Id.MappingName = "Id";
			this.dgtbcF5Id.ReadOnly = true;
			this.dgtbcF5Id.Width = 0;
			// 
			// dgtbcF5CuttingId
			// 
			this.dgtbcF5CuttingId.Format = "";
			this.dgtbcF5CuttingId.FormatInfo = null;
			this.dgtbcF5CuttingId.HeaderText = "CorteId";
			this.dgtbcF5CuttingId.MappingName = "CuttingId";
			this.dgtbcF5CuttingId.ReadOnly = true;
			this.dgtbcF5CuttingId.Width = 0;
			// 
			// dgFlat4
			// 
			this.dgFlat4.DataMember = "";
			this.dgFlat4.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dgFlat4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlat4.Location = new System.Drawing.Point(328, 256);
			this.dgFlat4.Name = "dgFlat4";
			this.dgFlat4.Size = new System.Drawing.Size(152, 232);
			this.dgFlat4.TabIndex = 3;
			this.dgFlat4.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								this.dgsFlat4});
			this.dgFlat4.Tag = "";
			// 
			// dgsFlat4
			// 
			this.dgsFlat4.DataGrid = this.dgFlat4;
			this.dgsFlat4.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																									   this.dgtbcF4CajaId,
																									   this.dgtbcF4Talla,
																									   this.dgtbcF4Prendas,
																									   this.dgtbcF4TipoCaja,
																									   this.dgtbcF4Id,
																									   this.dgtbcF4CuttingId});
			this.dgsFlat4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlat4.MappingName = "TABLEPLFlat4";
			// 
			// dgtbcF4CajaId
			// 
			this.dgtbcF4CajaId.Format = "";
			this.dgtbcF4CajaId.FormatInfo = null;
			this.dgtbcF4CajaId.HeaderText = "#Caja";
			this.dgtbcF4CajaId.MappingName = "CajaId";
			this.dgtbcF4CajaId.ReadOnly = true;
			this.dgtbcF4CajaId.Width = 35;
			// 
			// dgtbcF4Talla
			// 
			this.dgtbcF4Talla.Format = "";
			this.dgtbcF4Talla.FormatInfo = null;
			this.dgtbcF4Talla.HeaderText = "Talla";
			this.dgtbcF4Talla.MappingName = "Talla";
			this.dgtbcF4Talla.ReadOnly = true;
			this.dgtbcF4Talla.Width = 35;
			// 
			// dgtbcF4Prendas
			// 
			this.dgtbcF4Prendas.Format = "";
			this.dgtbcF4Prendas.FormatInfo = null;
			this.dgtbcF4Prendas.HeaderText = "Cant";
			this.dgtbcF4Prendas.MappingName = "Prendas";
			this.dgtbcF4Prendas.Width = 30;
			// 
			// dgtbcF4TipoCaja
			// 
			this.dgtbcF4TipoCaja.Format = "";
			this.dgtbcF4TipoCaja.FormatInfo = null;
			this.dgtbcF4TipoCaja.HeaderText = "Tipo";
			this.dgtbcF4TipoCaja.MappingName = "TipoCaja";
			this.dgtbcF4TipoCaja.ReadOnly = true;
			this.dgtbcF4TipoCaja.Width = 0;
			// 
			// dgtbcF4Id
			// 
			this.dgtbcF4Id.Format = "";
			this.dgtbcF4Id.FormatInfo = null;
			this.dgtbcF4Id.HeaderText = "Id";
			this.dgtbcF4Id.MappingName = "Id";
			this.dgtbcF4Id.ReadOnly = true;
			this.dgtbcF4Id.Width = 0;
			// 
			// dgtbcF4CuttingId
			// 
			this.dgtbcF4CuttingId.Format = "";
			this.dgtbcF4CuttingId.FormatInfo = null;
			this.dgtbcF4CuttingId.HeaderText = "CorteId";
			this.dgtbcF4CuttingId.MappingName = "CuttingId";
			this.dgtbcF4CuttingId.ReadOnly = true;
			this.dgtbcF4CuttingId.Width = 0;
			// 
			// dgFlat3
			// 
			this.dgFlat3.DataMember = "";
			this.dgFlat3.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dgFlat3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlat3.Location = new System.Drawing.Point(328, 16);
			this.dgFlat3.Name = "dgFlat3";
			this.dgFlat3.Size = new System.Drawing.Size(152, 224);
			this.dgFlat3.TabIndex = 2;
			this.dgFlat3.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								this.dgsFlat3});
			this.dgFlat3.Tag = "";
			// 
			// dgsFlat3
			// 
			this.dgsFlat3.DataGrid = this.dgFlat3;
			this.dgsFlat3.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																									   this.dgtbcF3CajaId,
																									   this.dgtbcF3Talla,
																									   this.dgtbcF3Prendas,
																									   this.dgtbcF3TipoCaja,
																									   this.dgtbcF3Id,
																									   this.dgtbcF3CuttingId});
			this.dgsFlat3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlat3.MappingName = "TABLEPLFlat3";
			// 
			// dgtbcF3CajaId
			// 
			this.dgtbcF3CajaId.Format = "";
			this.dgtbcF3CajaId.FormatInfo = null;
			this.dgtbcF3CajaId.HeaderText = "#Caja";
			this.dgtbcF3CajaId.MappingName = "CajaId";
			this.dgtbcF3CajaId.ReadOnly = true;
			this.dgtbcF3CajaId.Width = 35;
			// 
			// dgtbcF3Talla
			// 
			this.dgtbcF3Talla.Format = "";
			this.dgtbcF3Talla.FormatInfo = null;
			this.dgtbcF3Talla.HeaderText = "Talla";
			this.dgtbcF3Talla.MappingName = "Talla";
			this.dgtbcF3Talla.ReadOnly = true;
			this.dgtbcF3Talla.Width = 35;
			// 
			// dgtbcF3Prendas
			// 
			this.dgtbcF3Prendas.Format = "";
			this.dgtbcF3Prendas.FormatInfo = null;
			this.dgtbcF3Prendas.HeaderText = "Cant";
			this.dgtbcF3Prendas.MappingName = "Prendas";
			this.dgtbcF3Prendas.Width = 30;
			// 
			// dgtbcF3TipoCaja
			// 
			this.dgtbcF3TipoCaja.Format = "";
			this.dgtbcF3TipoCaja.FormatInfo = null;
			this.dgtbcF3TipoCaja.HeaderText = "Tipo";
			this.dgtbcF3TipoCaja.MappingName = "TipoCaja";
			this.dgtbcF3TipoCaja.ReadOnly = true;
			this.dgtbcF3TipoCaja.Width = 0;
			// 
			// dgtbcF3Id
			// 
			this.dgtbcF3Id.Format = "";
			this.dgtbcF3Id.FormatInfo = null;
			this.dgtbcF3Id.HeaderText = "Id";
			this.dgtbcF3Id.MappingName = "Id";
			this.dgtbcF3Id.ReadOnly = true;
			this.dgtbcF3Id.Width = 0;
			// 
			// dgtbcF3CuttingId
			// 
			this.dgtbcF3CuttingId.Format = "";
			this.dgtbcF3CuttingId.FormatInfo = null;
			this.dgtbcF3CuttingId.HeaderText = "CorteId";
			this.dgtbcF3CuttingId.MappingName = "CuttingId";
			this.dgtbcF3CuttingId.ReadOnly = true;
			this.dgtbcF3CuttingId.Width = 0;
			// 
			// dgFlat2
			// 
			this.dgFlat2.DataMember = "";
			this.dgFlat2.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dgFlat2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlat2.Location = new System.Drawing.Point(168, 16);
			this.dgFlat2.Name = "dgFlat2";
			this.dgFlat2.Size = new System.Drawing.Size(152, 472);
			this.dgFlat2.TabIndex = 1;
			this.dgFlat2.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								this.dgsFlat2});
			this.dgFlat2.Tag = "";
			// 
			// dgsFlat2
			// 
			this.dgsFlat2.DataGrid = this.dgFlat2;
			this.dgsFlat2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																									   this.dgtbcF2CajaId,
																									   this.dgtbcF2Talla,
																									   this.dgtbcF2Prendas,
																									   this.dgtbcF2TipoCaja,
																									   this.dgtbcF2Id,
																									   this.dgtbcF2CuttingId});
			this.dgsFlat2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlat2.MappingName = "TABLEPLFLAT2";
			// 
			// dgtbcF2CajaId
			// 
			this.dgtbcF2CajaId.Format = "";
			this.dgtbcF2CajaId.FormatInfo = null;
			this.dgtbcF2CajaId.HeaderText = "#Caja";
			this.dgtbcF2CajaId.MappingName = "CajaId";
			this.dgtbcF2CajaId.ReadOnly = true;
			this.dgtbcF2CajaId.Width = 35;
			// 
			// dgtbcF2Talla
			// 
			this.dgtbcF2Talla.Format = "";
			this.dgtbcF2Talla.FormatInfo = null;
			this.dgtbcF2Talla.HeaderText = "Talla";
			this.dgtbcF2Talla.MappingName = "Talla";
			this.dgtbcF2Talla.ReadOnly = true;
			this.dgtbcF2Talla.Width = 35;
			// 
			// dgtbcF2Prendas
			// 
			this.dgtbcF2Prendas.Format = "";
			this.dgtbcF2Prendas.FormatInfo = null;
			this.dgtbcF2Prendas.HeaderText = "Cant";
			this.dgtbcF2Prendas.MappingName = "Prendas";
			this.dgtbcF2Prendas.Width = 30;
			// 
			// dgtbcF2TipoCaja
			// 
			this.dgtbcF2TipoCaja.Format = "";
			this.dgtbcF2TipoCaja.FormatInfo = null;
			this.dgtbcF2TipoCaja.HeaderText = "Tipo";
			this.dgtbcF2TipoCaja.MappingName = "TipoCaja";
			this.dgtbcF2TipoCaja.ReadOnly = true;
			this.dgtbcF2TipoCaja.Width = 0;
			// 
			// dgtbcF2Id
			// 
			this.dgtbcF2Id.Format = "";
			this.dgtbcF2Id.FormatInfo = null;
			this.dgtbcF2Id.HeaderText = "Id";
			this.dgtbcF2Id.MappingName = "Id";
			this.dgtbcF2Id.ReadOnly = true;
			this.dgtbcF2Id.Width = 0;
			// 
			// dgtbcF2CuttingId
			// 
			this.dgtbcF2CuttingId.Format = "";
			this.dgtbcF2CuttingId.FormatInfo = null;
			this.dgtbcF2CuttingId.HeaderText = "CorteId";
			this.dgtbcF2CuttingId.MappingName = "CuttingId";
			this.dgtbcF2CuttingId.ReadOnly = true;
			this.dgtbcF2CuttingId.Width = 0;
			// 
			// dgFlat1
			// 
			this.dgFlat1.DataMember = "";
			this.dgFlat1.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dgFlat1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlat1.Location = new System.Drawing.Point(8, 16);
			this.dgFlat1.Name = "dgFlat1";
			this.dgFlat1.Size = new System.Drawing.Size(152, 472);
			this.dgFlat1.TabIndex = 0;
			this.dgFlat1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								this.dgsFlat1});
			this.dgFlat1.Tag = "";
			// 
			// dgsFlat1
			// 
			this.dgsFlat1.DataGrid = this.dgFlat1;
			this.dgsFlat1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																									   this.dgtbcCajaId,
																									   this.dgtbcTalla,
																									   this.dgtbcPrendas,
																									   this.dgtbcTipoCaja,
																									   this.dgtbcId,
																									   this.dgtbcCuttingId});
			this.dgsFlat1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlat1.MappingName = "TABLEPLFLAT1";
			// 
			// dgtbcCajaId
			// 
			this.dgtbcCajaId.Format = "";
			this.dgtbcCajaId.FormatInfo = null;
			this.dgtbcCajaId.HeaderText = "#Caja";
			this.dgtbcCajaId.MappingName = "CajaId";
			this.dgtbcCajaId.ReadOnly = true;
			this.dgtbcCajaId.Width = 35;
			// 
			// dgtbcTalla
			// 
			this.dgtbcTalla.Format = "";
			this.dgtbcTalla.FormatInfo = null;
			this.dgtbcTalla.HeaderText = "Talla";
			this.dgtbcTalla.MappingName = "Talla";
			this.dgtbcTalla.ReadOnly = true;
			this.dgtbcTalla.Width = 35;
			// 
			// dgtbcPrendas
			// 
			this.dgtbcPrendas.Format = "";
			this.dgtbcPrendas.FormatInfo = null;
			this.dgtbcPrendas.HeaderText = "Cant";
			this.dgtbcPrendas.MappingName = "Prendas";
			this.dgtbcPrendas.Width = 30;
			// 
			// dgtbcTipoCaja
			// 
			this.dgtbcTipoCaja.Format = "";
			this.dgtbcTipoCaja.FormatInfo = null;
			this.dgtbcTipoCaja.HeaderText = "Tipo";
			this.dgtbcTipoCaja.MappingName = "TipoCaja";
			this.dgtbcTipoCaja.ReadOnly = true;
			this.dgtbcTipoCaja.Width = 0;
			// 
			// dgtbcId
			// 
			this.dgtbcId.Format = "";
			this.dgtbcId.FormatInfo = null;
			this.dgtbcId.HeaderText = "Id";
			this.dgtbcId.MappingName = "Id";
			this.dgtbcId.ReadOnly = true;
			this.dgtbcId.Width = 0;
			// 
			// dgtbcCuttingId
			// 
			this.dgtbcCuttingId.Format = "";
			this.dgtbcCuttingId.FormatInfo = null;
			this.dgtbcCuttingId.HeaderText = "CorteId";
			this.dgtbcCuttingId.MappingName = "CuttingId";
			this.dgtbcCuttingId.ReadOnly = true;
			this.dgtbcCuttingId.Width = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dgFlatS3);
			this.tabPage2.Controls.Add(this.dgFlatS2);
			this.tabPage2.Controls.Add(this.lblFlatS3);
			this.tabPage2.Controls.Add(this.lblFlatS2);
			this.tabPage2.Controls.Add(this.dgFlatS1);
			this.tabPage2.Controls.Add(this.lblFlatS1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(960, 494);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Saldos";
			// 
			// dgFlatS3
			// 
			this.dgFlatS3.DataMember = "";
			this.dgFlatS3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlatS3.Location = new System.Drawing.Point(328, 16);
			this.dgFlatS3.Name = "dgFlatS3";
			this.dgFlatS3.Size = new System.Drawing.Size(152, 472);
			this.dgFlatS3.TabIndex = 13;
			this.dgFlatS3.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								 this.dgsFlatS3});
			// 
			// dgsFlatS3
			// 
			this.dgsFlatS3.DataGrid = this.dgFlatS3;
			this.dgsFlatS3.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																										this.dgtbcFS3CajaId,
																										this.dgtbcFS3Talla,
																										this.dgtbcFS3Prendas,
																										this.dgtbcFS3TipoCaja,
																										this.dgtbcFS3Id,
																										this.dgtbcFS3CuttingId});
			this.dgsFlatS3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlatS3.MappingName = "TABLEPLFlatS3";
			// 
			// dgtbcFS3CajaId
			// 
			this.dgtbcFS3CajaId.Format = "";
			this.dgtbcFS3CajaId.FormatInfo = null;
			this.dgtbcFS3CajaId.HeaderText = "#Caja";
			this.dgtbcFS3CajaId.MappingName = "CajaId";
			this.dgtbcFS3CajaId.ReadOnly = true;
			this.dgtbcFS3CajaId.Width = 35;
			// 
			// dgtbcFS3Talla
			// 
			this.dgtbcFS3Talla.Format = "";
			this.dgtbcFS3Talla.FormatInfo = null;
			this.dgtbcFS3Talla.HeaderText = "Talla";
			this.dgtbcFS3Talla.MappingName = "Talla";
			this.dgtbcFS3Talla.ReadOnly = true;
			this.dgtbcFS3Talla.Width = 35;
			// 
			// dgtbcFS3Prendas
			// 
			this.dgtbcFS3Prendas.Format = "";
			this.dgtbcFS3Prendas.FormatInfo = null;
			this.dgtbcFS3Prendas.HeaderText = "Cant";
			this.dgtbcFS3Prendas.MappingName = "Prendas";
			this.dgtbcFS3Prendas.Width = 30;
			// 
			// dgtbcFS3TipoCaja
			// 
			this.dgtbcFS3TipoCaja.Format = "";
			this.dgtbcFS3TipoCaja.FormatInfo = null;
			this.dgtbcFS3TipoCaja.HeaderText = "Tipo";
			this.dgtbcFS3TipoCaja.MappingName = "TipoCaja";
			this.dgtbcFS3TipoCaja.ReadOnly = true;
			this.dgtbcFS3TipoCaja.Width = 0;
			// 
			// dgtbcFS3Id
			// 
			this.dgtbcFS3Id.Format = "";
			this.dgtbcFS3Id.FormatInfo = null;
			this.dgtbcFS3Id.HeaderText = "Id";
			this.dgtbcFS3Id.MappingName = "Id";
			this.dgtbcFS3Id.ReadOnly = true;
			this.dgtbcFS3Id.Width = 0;
			// 
			// dgtbcFS3CuttingId
			// 
			this.dgtbcFS3CuttingId.Format = "";
			this.dgtbcFS3CuttingId.FormatInfo = null;
			this.dgtbcFS3CuttingId.HeaderText = "CorteId";
			this.dgtbcFS3CuttingId.MappingName = "CuttingId";
			this.dgtbcFS3CuttingId.ReadOnly = true;
			this.dgtbcFS3CuttingId.Width = 0;
			// 
			// dgFlatS2
			// 
			this.dgFlatS2.DataMember = "";
			this.dgFlatS2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlatS2.Location = new System.Drawing.Point(168, 16);
			this.dgFlatS2.Name = "dgFlatS2";
			this.dgFlatS2.Size = new System.Drawing.Size(152, 472);
			this.dgFlatS2.TabIndex = 12;
			this.dgFlatS2.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								 this.dgsFlatS2});
			// 
			// dgsFlatS2
			// 
			this.dgsFlatS2.DataGrid = this.dgFlatS2;
			this.dgsFlatS2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																										this.dgtbcFS2CajaId,
																										this.dgtbcFS2Talla,
																										this.dgtbcFS2Prendas,
																										this.dgtbcFS2TipoCaja,
																										this.dgtbcFS2Id,
																										this.dgtbcFS2CuttingId});
			this.dgsFlatS2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlatS2.MappingName = "TABLEPLFlatS2";
			// 
			// dgtbcFS2CajaId
			// 
			this.dgtbcFS2CajaId.Format = "";
			this.dgtbcFS2CajaId.FormatInfo = null;
			this.dgtbcFS2CajaId.HeaderText = "#Caja";
			this.dgtbcFS2CajaId.MappingName = "CajaId";
			this.dgtbcFS2CajaId.ReadOnly = true;
			this.dgtbcFS2CajaId.Width = 35;
			// 
			// dgtbcFS2Talla
			// 
			this.dgtbcFS2Talla.Format = "";
			this.dgtbcFS2Talla.FormatInfo = null;
			this.dgtbcFS2Talla.HeaderText = "Talla";
			this.dgtbcFS2Talla.MappingName = "Talla";
			this.dgtbcFS2Talla.ReadOnly = true;
			this.dgtbcFS2Talla.Width = 35;
			// 
			// dgtbcFS2Prendas
			// 
			this.dgtbcFS2Prendas.Format = "";
			this.dgtbcFS2Prendas.FormatInfo = null;
			this.dgtbcFS2Prendas.HeaderText = "Cant";
			this.dgtbcFS2Prendas.MappingName = "Prendas";
			this.dgtbcFS2Prendas.Width = 30;
			// 
			// dgtbcFS2TipoCaja
			// 
			this.dgtbcFS2TipoCaja.Format = "";
			this.dgtbcFS2TipoCaja.FormatInfo = null;
			this.dgtbcFS2TipoCaja.HeaderText = "Tipo";
			this.dgtbcFS2TipoCaja.MappingName = "TipoCaja";
			this.dgtbcFS2TipoCaja.ReadOnly = true;
			this.dgtbcFS2TipoCaja.Width = 0;
			// 
			// dgtbcFS2Id
			// 
			this.dgtbcFS2Id.Format = "";
			this.dgtbcFS2Id.FormatInfo = null;
			this.dgtbcFS2Id.HeaderText = "Id";
			this.dgtbcFS2Id.MappingName = "Id";
			this.dgtbcFS2Id.ReadOnly = true;
			this.dgtbcFS2Id.Width = 0;
			// 
			// dgtbcFS2CuttingId
			// 
			this.dgtbcFS2CuttingId.Format = "";
			this.dgtbcFS2CuttingId.FormatInfo = null;
			this.dgtbcFS2CuttingId.HeaderText = "CorteId";
			this.dgtbcFS2CuttingId.MappingName = "CuttingId";
			this.dgtbcFS2CuttingId.ReadOnly = true;
			this.dgtbcFS2CuttingId.Width = 0;
			// 
			// lblFlatS3
			// 
			this.lblFlatS3.Location = new System.Drawing.Point(360, 0);
			this.lblFlatS3.Name = "lblFlatS3";
			this.lblFlatS3.Size = new System.Drawing.Size(100, 16);
			this.lblFlatS3.TabIndex = 11;
			this.lblFlatS3.Text = "Flat #";
			this.lblFlatS3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lblFlatS2
			// 
			this.lblFlatS2.Location = new System.Drawing.Point(192, 0);
			this.lblFlatS2.Name = "lblFlatS2";
			this.lblFlatS2.Size = new System.Drawing.Size(100, 16);
			this.lblFlatS2.TabIndex = 10;
			this.lblFlatS2.Text = "Flat #";
			this.lblFlatS2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dgFlatS1
			// 
			this.dgFlatS1.DataMember = "";
			this.dgFlatS1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlatS1.Location = new System.Drawing.Point(8, 16);
			this.dgFlatS1.Name = "dgFlatS1";
			this.dgFlatS1.Size = new System.Drawing.Size(152, 472);
			this.dgFlatS1.TabIndex = 9;
			this.dgFlatS1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								 this.dgsFlatS1});
			// 
			// dgsFlatS1
			// 
			this.dgsFlatS1.DataGrid = this.dgFlatS1;
			this.dgsFlatS1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																										this.dgtbcFS1CajaId,
																										this.dgtbcFS1Talla,
																										this.dgtbcFS1Prendas,
																										this.dgtbcFS1TipoCaja,
																										this.dgtbcFS1Id,
																										this.dgtbcFS1CuttingId});
			this.dgsFlatS1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlatS1.MappingName = "TABLEPLFlatS1";
			// 
			// dgtbcFS1CajaId
			// 
			this.dgtbcFS1CajaId.Format = "";
			this.dgtbcFS1CajaId.FormatInfo = null;
			this.dgtbcFS1CajaId.HeaderText = "#Caja";
			this.dgtbcFS1CajaId.MappingName = "CajaId";
			this.dgtbcFS1CajaId.ReadOnly = true;
			this.dgtbcFS1CajaId.Width = 35;
			// 
			// dgtbcFS1Talla
			// 
			this.dgtbcFS1Talla.Format = "";
			this.dgtbcFS1Talla.FormatInfo = null;
			this.dgtbcFS1Talla.HeaderText = "Talla";
			this.dgtbcFS1Talla.MappingName = "Talla";
			this.dgtbcFS1Talla.ReadOnly = true;
			this.dgtbcFS1Talla.Width = 35;
			// 
			// dgtbcFS1Prendas
			// 
			this.dgtbcFS1Prendas.Format = "";
			this.dgtbcFS1Prendas.FormatInfo = null;
			this.dgtbcFS1Prendas.HeaderText = "Cant";
			this.dgtbcFS1Prendas.MappingName = "Prendas";
			this.dgtbcFS1Prendas.Width = 30;
			// 
			// dgtbcFS1TipoCaja
			// 
			this.dgtbcFS1TipoCaja.Format = "";
			this.dgtbcFS1TipoCaja.FormatInfo = null;
			this.dgtbcFS1TipoCaja.HeaderText = "Tipo";
			this.dgtbcFS1TipoCaja.MappingName = "TipoCaja";
			this.dgtbcFS1TipoCaja.ReadOnly = true;
			this.dgtbcFS1TipoCaja.Width = 0;
			// 
			// dgtbcFS1Id
			// 
			this.dgtbcFS1Id.Format = "";
			this.dgtbcFS1Id.FormatInfo = null;
			this.dgtbcFS1Id.HeaderText = "Id";
			this.dgtbcFS1Id.MappingName = "Id";
			this.dgtbcFS1Id.ReadOnly = true;
			this.dgtbcFS1Id.Width = 0;
			// 
			// dgtbcFS1CuttingId
			// 
			this.dgtbcFS1CuttingId.Format = "";
			this.dgtbcFS1CuttingId.FormatInfo = null;
			this.dgtbcFS1CuttingId.HeaderText = "CorteId";
			this.dgtbcFS1CuttingId.MappingName = "CuttingId";
			this.dgtbcFS1CuttingId.ReadOnly = true;
			this.dgtbcFS1CuttingId.Width = 0;
			// 
			// lblFlatS1
			// 
			this.lblFlatS1.Location = new System.Drawing.Point(32, 0);
			this.lblFlatS1.Name = "lblFlatS1";
			this.lblFlatS1.Size = new System.Drawing.Size(100, 16);
			this.lblFlatS1.TabIndex = 8;
			this.lblFlatS1.Text = "Flat #";
			this.lblFlatS1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dgFlatSC2);
			this.tabPage3.Controls.Add(this.lblFlatSC2);
			this.tabPage3.Controls.Add(this.lblFlatSC1);
			this.tabPage3.Controls.Add(this.dgFlatSC1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(960, 494);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Segundas";
			// 
			// dgFlatSC2
			// 
			this.dgFlatSC2.DataMember = "";
			this.dgFlatSC2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlatSC2.Location = new System.Drawing.Point(168, 16);
			this.dgFlatSC2.Name = "dgFlatSC2";
			this.dgFlatSC2.Size = new System.Drawing.Size(152, 472);
			this.dgFlatSC2.TabIndex = 11;
			this.dgFlatSC2.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dgsFlatSC2});
			// 
			// dgsFlatSC2
			// 
			this.dgsFlatSC2.DataGrid = this.dgFlatSC2;
			this.dgsFlatSC2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																										 this.dgtbcFSC2CajaId,
																										 this.dgtbcFSC2Talla,
																										 this.dgtbcFSC2Prendas,
																										 this.dgtbcFSC2TipoCaja,
																										 this.dgtbcFSC2Id,
																										 this.dgtbcFSC2CuttingId});
			this.dgsFlatSC2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlatSC2.MappingName = "TABLEPLFlatSC2";
			// 
			// dgtbcFSC2CajaId
			// 
			this.dgtbcFSC2CajaId.Format = "";
			this.dgtbcFSC2CajaId.FormatInfo = null;
			this.dgtbcFSC2CajaId.HeaderText = "#Caja";
			this.dgtbcFSC2CajaId.MappingName = "CajaId";
			this.dgtbcFSC2CajaId.ReadOnly = true;
			this.dgtbcFSC2CajaId.Width = 35;
			// 
			// dgtbcFSC2Talla
			// 
			this.dgtbcFSC2Talla.Format = "";
			this.dgtbcFSC2Talla.FormatInfo = null;
			this.dgtbcFSC2Talla.HeaderText = "Talla";
			this.dgtbcFSC2Talla.MappingName = "Talla";
			this.dgtbcFSC2Talla.ReadOnly = true;
			this.dgtbcFSC2Talla.Width = 35;
			// 
			// dgtbcFSC2Prendas
			// 
			this.dgtbcFSC2Prendas.Format = "";
			this.dgtbcFSC2Prendas.FormatInfo = null;
			this.dgtbcFSC2Prendas.HeaderText = "Cant";
			this.dgtbcFSC2Prendas.MappingName = "Prendas";
			this.dgtbcFSC2Prendas.Width = 30;
			// 
			// dgtbcFSC2TipoCaja
			// 
			this.dgtbcFSC2TipoCaja.Format = "";
			this.dgtbcFSC2TipoCaja.FormatInfo = null;
			this.dgtbcFSC2TipoCaja.HeaderText = "Tipo";
			this.dgtbcFSC2TipoCaja.MappingName = "TipoCaja";
			this.dgtbcFSC2TipoCaja.ReadOnly = true;
			this.dgtbcFSC2TipoCaja.Width = 0;
			// 
			// dgtbcFSC2Id
			// 
			this.dgtbcFSC2Id.Format = "";
			this.dgtbcFSC2Id.FormatInfo = null;
			this.dgtbcFSC2Id.HeaderText = "Id";
			this.dgtbcFSC2Id.MappingName = "Id";
			this.dgtbcFSC2Id.ReadOnly = true;
			this.dgtbcFSC2Id.Width = 0;
			// 
			// dgtbcFSC2CuttingId
			// 
			this.dgtbcFSC2CuttingId.Format = "";
			this.dgtbcFSC2CuttingId.FormatInfo = null;
			this.dgtbcFSC2CuttingId.HeaderText = "CorteId";
			this.dgtbcFSC2CuttingId.MappingName = "CuttingId";
			this.dgtbcFSC2CuttingId.ReadOnly = true;
			this.dgtbcFSC2CuttingId.Width = 0;
			// 
			// lblFlatSC2
			// 
			this.lblFlatSC2.Location = new System.Drawing.Point(192, 0);
			this.lblFlatSC2.Name = "lblFlatSC2";
			this.lblFlatSC2.Size = new System.Drawing.Size(100, 16);
			this.lblFlatSC2.TabIndex = 10;
			this.lblFlatSC2.Text = "Flat #";
			this.lblFlatSC2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lblFlatSC1
			// 
			this.lblFlatSC1.Location = new System.Drawing.Point(32, 0);
			this.lblFlatSC1.Name = "lblFlatSC1";
			this.lblFlatSC1.Size = new System.Drawing.Size(100, 16);
			this.lblFlatSC1.TabIndex = 9;
			this.lblFlatSC1.Text = "Flat #";
			this.lblFlatSC1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dgFlatSC1
			// 
			this.dgFlatSC1.DataMember = "";
			this.dgFlatSC1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlatSC1.Location = new System.Drawing.Point(8, 16);
			this.dgFlatSC1.Name = "dgFlatSC1";
			this.dgFlatSC1.Size = new System.Drawing.Size(152, 472);
			this.dgFlatSC1.TabIndex = 0;
			this.dgFlatSC1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dgsFlatSC1});
			// 
			// dgsFlatSC1
			// 
			this.dgsFlatSC1.DataGrid = this.dgFlatSC1;
			this.dgsFlatSC1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																										 this.dgtbcFSC1CajaId,
																										 this.dgtbcFSC1Talla,
																										 this.dgtbcFSC1Prendas,
																										 this.dgtbcFSC1TipoCaja,
																										 this.dgtbcFSC1Id,
																										 this.dgtbcFSC1CuttingId});
			this.dgsFlatSC1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlatSC1.MappingName = "TABLEPLFlatSC1";
			// 
			// dgtbcFSC1CajaId
			// 
			this.dgtbcFSC1CajaId.Format = "";
			this.dgtbcFSC1CajaId.FormatInfo = null;
			this.dgtbcFSC1CajaId.HeaderText = "#Caja";
			this.dgtbcFSC1CajaId.MappingName = "CajaId";
			this.dgtbcFSC1CajaId.ReadOnly = true;
			this.dgtbcFSC1CajaId.Width = 35;
			// 
			// dgtbcFSC1Talla
			// 
			this.dgtbcFSC1Talla.Format = "";
			this.dgtbcFSC1Talla.FormatInfo = null;
			this.dgtbcFSC1Talla.HeaderText = "Talla";
			this.dgtbcFSC1Talla.MappingName = "Talla";
			this.dgtbcFSC1Talla.ReadOnly = true;
			this.dgtbcFSC1Talla.Width = 35;
			// 
			// dgtbcFSC1Prendas
			// 
			this.dgtbcFSC1Prendas.Format = "";
			this.dgtbcFSC1Prendas.FormatInfo = null;
			this.dgtbcFSC1Prendas.HeaderText = "Cant";
			this.dgtbcFSC1Prendas.MappingName = "Prendas";
			this.dgtbcFSC1Prendas.Width = 30;
			// 
			// dgtbcFSC1TipoCaja
			// 
			this.dgtbcFSC1TipoCaja.Format = "";
			this.dgtbcFSC1TipoCaja.FormatInfo = null;
			this.dgtbcFSC1TipoCaja.HeaderText = "Tipo";
			this.dgtbcFSC1TipoCaja.MappingName = "TipoCaja";
			this.dgtbcFSC1TipoCaja.ReadOnly = true;
			this.dgtbcFSC1TipoCaja.Width = 0;
			// 
			// dgtbcFSC1Id
			// 
			this.dgtbcFSC1Id.Format = "";
			this.dgtbcFSC1Id.FormatInfo = null;
			this.dgtbcFSC1Id.HeaderText = "Id";
			this.dgtbcFSC1Id.MappingName = "Id";
			this.dgtbcFSC1Id.ReadOnly = true;
			this.dgtbcFSC1Id.Width = 0;
			// 
			// dgtbcFSC1CuttingId
			// 
			this.dgtbcFSC1CuttingId.Format = "";
			this.dgtbcFSC1CuttingId.FormatInfo = null;
			this.dgtbcFSC1CuttingId.HeaderText = "CorteId";
			this.dgtbcFSC1CuttingId.MappingName = "CuttingId";
			this.dgtbcFSC1CuttingId.ReadOnly = true;
			this.dgtbcFSC1CuttingId.Width = 0;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.lblFlatST2);
			this.tabPage4.Controls.Add(this.lblFlatST1);
			this.tabPage4.Controls.Add(this.dgFlatST2);
			this.tabPage4.Controls.Add(this.dgFlatST1);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(960, 494);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Terceras";
			// 
			// lblFlatST2
			// 
			this.lblFlatST2.Location = new System.Drawing.Point(192, 0);
			this.lblFlatST2.Name = "lblFlatST2";
			this.lblFlatST2.Size = new System.Drawing.Size(100, 16);
			this.lblFlatST2.TabIndex = 11;
			this.lblFlatST2.Text = "Flat #";
			this.lblFlatST2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lblFlatST1
			// 
			this.lblFlatST1.Location = new System.Drawing.Point(32, 0);
			this.lblFlatST1.Name = "lblFlatST1";
			this.lblFlatST1.Size = new System.Drawing.Size(100, 16);
			this.lblFlatST1.TabIndex = 10;
			this.lblFlatST1.Text = "Flat #";
			this.lblFlatST1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dgFlatST2
			// 
			this.dgFlatST2.DataMember = "";
			this.dgFlatST2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlatST2.Location = new System.Drawing.Point(168, 16);
			this.dgFlatST2.Name = "dgFlatST2";
			this.dgFlatST2.Size = new System.Drawing.Size(152, 472);
			this.dgFlatST2.TabIndex = 1;
			this.dgFlatST2.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dgsFlatST2});
			// 
			// dgsFlatST2
			// 
			this.dgsFlatST2.DataGrid = this.dgFlatST2;
			this.dgsFlatST2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																										 this.dgtbcFST2CajaId,
																										 this.dgtbcFST2Talla,
																										 this.dgtbcFST2Prendas,
																										 this.dgtbcFST2TipoCaja,
																										 this.dgtbcFST2Id,
																										 this.dgtbcFST2CuttingId});
			this.dgsFlatST2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlatST2.MappingName = "TABLEPLFlatST2";
			// 
			// dgtbcFST2CajaId
			// 
			this.dgtbcFST2CajaId.Format = "";
			this.dgtbcFST2CajaId.FormatInfo = null;
			this.dgtbcFST2CajaId.HeaderText = "#Caja";
			this.dgtbcFST2CajaId.MappingName = "CajaId";
			this.dgtbcFST2CajaId.ReadOnly = true;
			this.dgtbcFST2CajaId.Width = 35;
			// 
			// dgtbcFST2Talla
			// 
			this.dgtbcFST2Talla.Format = "";
			this.dgtbcFST2Talla.FormatInfo = null;
			this.dgtbcFST2Talla.HeaderText = "Talla";
			this.dgtbcFST2Talla.MappingName = "Talla";
			this.dgtbcFST2Talla.ReadOnly = true;
			this.dgtbcFST2Talla.Width = 35;
			// 
			// dgtbcFST2Prendas
			// 
			this.dgtbcFST2Prendas.Format = "";
			this.dgtbcFST2Prendas.FormatInfo = null;
			this.dgtbcFST2Prendas.HeaderText = "Cant";
			this.dgtbcFST2Prendas.MappingName = "Prendas";
			this.dgtbcFST2Prendas.Width = 30;
			// 
			// dgtbcFST2TipoCaja
			// 
			this.dgtbcFST2TipoCaja.Format = "";
			this.dgtbcFST2TipoCaja.FormatInfo = null;
			this.dgtbcFST2TipoCaja.HeaderText = "Tipo";
			this.dgtbcFST2TipoCaja.MappingName = "TipoCaja";
			this.dgtbcFST2TipoCaja.ReadOnly = true;
			this.dgtbcFST2TipoCaja.Width = 0;
			// 
			// dgtbcFST2Id
			// 
			this.dgtbcFST2Id.Format = "";
			this.dgtbcFST2Id.FormatInfo = null;
			this.dgtbcFST2Id.HeaderText = "Id";
			this.dgtbcFST2Id.MappingName = "Id";
			this.dgtbcFST2Id.ReadOnly = true;
			this.dgtbcFST2Id.Width = 0;
			// 
			// dgtbcFST2CuttingId
			// 
			this.dgtbcFST2CuttingId.Format = "";
			this.dgtbcFST2CuttingId.FormatInfo = null;
			this.dgtbcFST2CuttingId.HeaderText = "CorteId";
			this.dgtbcFST2CuttingId.MappingName = "CuttingId";
			this.dgtbcFST2CuttingId.ReadOnly = true;
			this.dgtbcFST2CuttingId.Width = 0;
			// 
			// dgFlatST1
			// 
			this.dgFlatST1.DataMember = "";
			this.dgFlatST1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgFlatST1.Location = new System.Drawing.Point(8, 16);
			this.dgFlatST1.Name = "dgFlatST1";
			this.dgFlatST1.Size = new System.Drawing.Size(152, 472);
			this.dgFlatST1.TabIndex = 0;
			this.dgFlatST1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dgsFlatST1});
			// 
			// dgsFlatST1
			// 
			this.dgsFlatST1.DataGrid = this.dgFlatST1;
			this.dgsFlatST1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																										 this.dgtbcFST1CajaId,
																										 this.dgtbcFST1Talla,
																										 this.dgtbcFST1Prendas,
																										 this.dgtbcFST1TipoCaja,
																										 this.dgtbcFST1Id,
																										 this.dgtbcFST1CuttingId});
			this.dgsFlatST1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsFlatST1.MappingName = "TABLEPLFlatST1";
			// 
			// dgtbcFST1CajaId
			// 
			this.dgtbcFST1CajaId.Format = "";
			this.dgtbcFST1CajaId.FormatInfo = null;
			this.dgtbcFST1CajaId.HeaderText = "#Caja";
			this.dgtbcFST1CajaId.MappingName = "CajaId";
			this.dgtbcFST1CajaId.ReadOnly = true;
			this.dgtbcFST1CajaId.Width = 35;
			// 
			// dgtbcFST1Talla
			// 
			this.dgtbcFST1Talla.Format = "";
			this.dgtbcFST1Talla.FormatInfo = null;
			this.dgtbcFST1Talla.HeaderText = "Talla";
			this.dgtbcFST1Talla.MappingName = "Talla";
			this.dgtbcFST1Talla.ReadOnly = true;
			this.dgtbcFST1Talla.Width = 35;
			// 
			// dgtbcFST1Prendas
			// 
			this.dgtbcFST1Prendas.Format = "";
			this.dgtbcFST1Prendas.FormatInfo = null;
			this.dgtbcFST1Prendas.HeaderText = "Cant";
			this.dgtbcFST1Prendas.MappingName = "Prendas";
			this.dgtbcFST1Prendas.Width = 30;
			// 
			// dgtbcFST1TipoCaja
			// 
			this.dgtbcFST1TipoCaja.Format = "";
			this.dgtbcFST1TipoCaja.FormatInfo = null;
			this.dgtbcFST1TipoCaja.HeaderText = "Tipo";
			this.dgtbcFST1TipoCaja.MappingName = "TipoCaja";
			this.dgtbcFST1TipoCaja.ReadOnly = true;
			this.dgtbcFST1TipoCaja.Width = 0;
			// 
			// dgtbcFST1Id
			// 
			this.dgtbcFST1Id.Format = "";
			this.dgtbcFST1Id.FormatInfo = null;
			this.dgtbcFST1Id.HeaderText = "Id";
			this.dgtbcFST1Id.MappingName = "Id";
			this.dgtbcFST1Id.ReadOnly = true;
			this.dgtbcFST1Id.Width = 0;
			// 
			// dgtbcFST1CuttingId
			// 
			this.dgtbcFST1CuttingId.Format = "";
			this.dgtbcFST1CuttingId.FormatInfo = null;
			this.dgtbcFST1CuttingId.HeaderText = "CorteId";
			this.dgtbcFST1CuttingId.MappingName = "CuttingId";
			this.dgtbcFST1CuttingId.ReadOnly = true;
			this.dgtbcFST1CuttingId.Width = 0;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(552, 24);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.TabIndex = 36;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.Visible = false;
			// 
			// btnPacking
			// 
			this.btnPacking.Location = new System.Drawing.Point(712, 24);
			this.btnPacking.Name = "btnPacking";
			this.btnPacking.Size = new System.Drawing.Size(120, 23);
			this.btnPacking.TabIndex = 37;
			this.btnPacking.Text = "Genera Packing List";
			this.btnPacking.Visible = false;
			this.btnPacking.Click += new System.EventHandler(this.btnPacking_Click);
			// 
			// FPakingList
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(978, 568);
			this.Controls.Add(this.btnPacking);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.lblEstilo);
			this.Controls.Add(this.tbEstilo);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.tbxCorte);
			this.Controls.Add(this.lblCut);
			this.Controls.Add(this.tbColor);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblContrato);
			this.Controls.Add(this.tbContrato);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FPakingList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FPakingList";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FPakingList_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgFlat7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlat6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlat5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlat4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlat3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlat2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlat1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgFlatS3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlatS2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlatS1)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgFlatSC2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlatSC1)).EndInit();
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgFlatST2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFlatST1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region private void btnSearch_Click(object sender, System.EventArgs e)
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
				
				DataSet dsDetalle1 = new DataSet();
				DataViewManager dvmDetalle1;
				dvmDetalle1= dsDetalle1.DefaultViewManager;

				this.dgFlat1.DataSource = dvmDetalle1;
				this.dgFlat2.DataSource = dvmDetalle1;
				this.dgFlat3.DataSource = dvmDetalle1;
				this.dgFlat4.DataSource = dvmDetalle1;
				this.dgFlat5.DataSource = dvmDetalle1;
				this.dgFlat6.DataSource = dvmDetalle1;
				this.dgFlat7.DataSource = dvmDetalle1;
				this.dgFlatS1.DataSource = dvmDetalle1;
				this.dgFlatS2.DataSource = dvmDetalle1;
				this.dgFlatS3.DataSource = dvmDetalle1;
				this.dgFlatSC1.DataSource = dvmDetalle1;
				this.dgFlatSC2.DataSource = dvmDetalle1;
				this.dgFlatST1.DataSource = dvmDetalle1;
				this.dgFlatST2.DataSource = dvmDetalle1;
				LlenaDetalle();
				this.btnGuardar.Visible=true;
				this.btnPacking.Visible=true;
			}		
		}
		#endregion

		#region Llena Detalle Tarimas
		/// <summary>
		/// 
		/// </summary>
		private void LlenaDetalle()
		{
			int ilSumaFilas = 0;
			int ilFlatNumber = 1;

			#region Declaracion DATAVIEWS y DATASETS
			DataViewManager dvmDetalleFlat1;
			DataViewManager dvmDetalleFlat2;
			DataViewManager dvmDetalleFlat3;
			DataViewManager dvmDetalleFlat4;
			DataViewManager dvmDetalleFlat5;
			DataViewManager dvmDetalleFlat6;
			DataViewManager dvmDetalleFlat7;
			//Saldos
			DataViewManager dvmDetalleFlatS1;
			DataViewManager dvmDetalleFlatS2;
			DataViewManager dvmDetalleFlatS3;
			//Segundas
			DataViewManager dvmDetalleFlatSC1;
			DataViewManager dvmDetalleFlatSC2;			
			//Terceras
			DataViewManager dvmDetalleFlatST1;
			DataViewManager dvmDetalleFlatST2;
			//
			DataSet dsDetalleFlat1 = new DataSet();
			DataSet dsDetalleFlat2 = new DataSet();
			DataSet dsDetalleFlat3 = new DataSet();
			DataSet dsDetalleFlat4 = new DataSet();
			DataSet dsDetalleFlat5 = new DataSet();
			DataSet dsDetalleFlat6 = new DataSet();
			DataSet dsDetalleFlat7 = new DataSet();
			//Saldos
			DataSet dsDetalleFlatS1 = new DataSet();
			DataSet dsDetalleFlatS2 = new DataSet();
			DataSet dsDetalleFlatS3 = new DataSet();
			//Segundas
			DataSet dsDetalleFlatSC1 = new DataSet();
			DataSet dsDetalleFlatSC2 = new DataSet();
			//Terceras
			DataSet dsDetalleFlatST1 = new DataSet();
			DataSet dsDetalleFlatST2 = new DataSet();
			#endregion

			#region Primeras
			//FLAT1
			dsDetalleFlat1 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"1","25","0");
			dvmDetalleFlat1 = dsDetalleFlat1.DefaultViewManager;
			dvmDetalleFlat1.DataSet.Tables[0].TableName="TABLEPLFLAT1";			
			this.dgFlat1.DataSource = dvmDetalleFlat1.DataSet.Tables[0];
			ilFlatNumber=ilFlatNumber+1;
			//FLAT2
			ilSumaFilas = dsDetalleFlat1.Tables[0].Rows.Count;
			dsDetalleFlat2 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"1","25",ilSumaFilas.ToString());
			dvmDetalleFlat2 = dsDetalleFlat2.DefaultViewManager;
			dvmDetalleFlat2.DataSet.Tables[0].TableName="TABLEPLFLAT2";			
			this.dgFlat2.DataSource = dvmDetalleFlat2.DataSet.Tables[0];
			ilFlatNumber=ilFlatNumber+1;
			//FLAT3
			ilSumaFilas = dsDetalleFlat1.Tables[0].Rows.Count + dsDetalleFlat2.Tables[0].Rows.Count;
			dsDetalleFlat3 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"1","10",ilSumaFilas.ToString());
			dvmDetalleFlat3 = dsDetalleFlat3.DefaultViewManager;
			dvmDetalleFlat3.DataSet.Tables[0].TableName="TABLEPLFLAT3";
			this.dgFlat3.DataSource = dvmDetalleFlat3.DataSet.Tables[0];
			ilFlatNumber=ilFlatNumber+1;
			//FLAT4
			ilSumaFilas = dsDetalleFlat1.Tables[0].Rows.Count + dsDetalleFlat2.Tables[0].Rows.Count +dsDetalleFlat3.Tables[0].Rows.Count;
			dsDetalleFlat4 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"1","10",ilSumaFilas.ToString());
			dvmDetalleFlat4 = dsDetalleFlat4.DefaultViewManager;
			dvmDetalleFlat4.DataSet.Tables[0].TableName="TABLEPLFLAT4";
			this.dgFlat4.DataSource = dvmDetalleFlat4.DataSet.Tables[0];
			ilFlatNumber=ilFlatNumber+1;
			//FLAT5
			ilSumaFilas = dsDetalleFlat1.Tables[0].Rows.Count + dsDetalleFlat2.Tables[0].Rows.Count +dsDetalleFlat3.Tables[0].Rows.Count+dsDetalleFlat4.Tables[0].Rows.Count;
			dsDetalleFlat5 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"1","25",ilSumaFilas.ToString());
			dvmDetalleFlat5 = dsDetalleFlat5.DefaultViewManager;
			dvmDetalleFlat5.DataSet.Tables[0].TableName="TABLEPLFLAT5";
			this.dgFlat5.DataSource = dvmDetalleFlat5.DataSet.Tables[0];
			ilFlatNumber=ilFlatNumber+1;
			//FLAT6			
			if(this.tbEstilo.Text.Substring(0,3)=="J65")
			{
				ilSumaFilas = dsDetalleFlat1.Tables[0].Rows.Count + dsDetalleFlat2.Tables[0].Rows.Count +dsDetalleFlat3.Tables[0].Rows.Count+dsDetalleFlat4.Tables[0].Rows.Count+dsDetalleFlat5.Tables[0].Rows.Count;
				dsDetalleFlat6 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"1","25",ilSumaFilas.ToString());
				if((dsDetalleFlat6.Tables[0].Rows.Count>0)&&(dsDetalleFlat6.Tables.Count>0))
				{
					dvmDetalleFlat6 = dsDetalleFlat6.DefaultViewManager;
					dvmDetalleFlat6.DataSet.Tables[0].TableName="TABLEPLFLAT6";
					this.dgFlat6.DataSource = dvmDetalleFlat6.DataSet.Tables[0];			
					this.lblFlatTE2.Text="Flat # "+ilFlatNumber.ToString();
					ilFlatNumber=ilFlatNumber+1;

					//FLAT7
					ilSumaFilas = dsDetalleFlat1.Tables[0].Rows.Count + dsDetalleFlat2.Tables[0].Rows.Count +dsDetalleFlat3.Tables[0].Rows.Count+dsDetalleFlat4.Tables[0].Rows.Count+dsDetalleFlat5.Tables[0].Rows.Count+dsDetalleFlat6.Tables[0].Rows.Count;
					dsDetalleFlat7 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"1","25",ilSumaFilas.ToString());
					if((dsDetalleFlat7.Tables[0].Rows.Count>0)&&(dsDetalleFlat6.Tables.Count>0))
					{
						dvmDetalleFlat7 = dsDetalleFlat7.DefaultViewManager;
						dvmDetalleFlat7.DataSet.Tables[0].TableName="TABLEPLFLAT7";
						this.dgFlat7.DataSource = dvmDetalleFlat7.DataSet.Tables[0];
						this.lblFlatTE2.Text="Flat # "+ilFlatNumber.ToString();
						ilFlatNumber=ilFlatNumber+1;
				
					}
				}
			}
			#endregion

			#region Saldos
			//FLATSaldos1
			ilSumaFilas = 0;
			dsDetalleFlatS1 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"4","25",ilSumaFilas.ToString());
			if(dsDetalleFlatS1.Tables[0].Rows.Count>0)
			{
				dvmDetalleFlatS1 = dsDetalleFlatS1.DefaultViewManager;
				dvmDetalleFlatS1.DataSet.Tables[0].TableName="TABLEPLFLATS1";
				this.dgFlatS1.DataSource = dvmDetalleFlatS1.DataSet.Tables[0];
				this.lblFlatS1.Text="Flat # "+ilFlatNumber.ToString();
				ilFlatNumber=ilFlatNumber+1;				
			

				//FLATSaldos2
				ilSumaFilas = Convert.ToInt32(dsDetalleFlatS1.Tables[0].Rows[dsDetalleFlatS1.Tables[0].Rows.Count-1][0].ToString());
				dsDetalleFlatS2 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"4","25",ilSumaFilas.ToString());
				if(dsDetalleFlatS2.Tables[0].Rows.Count>0)
				{
					dvmDetalleFlatS2 = dsDetalleFlatS2.DefaultViewManager;
					dvmDetalleFlatS2.DataSet.Tables[0].TableName="TABLEPLFLATS2";
					this.dgFlatS2.DataSource = dvmDetalleFlatS2.DataSet.Tables[0];
					this.lblFlatS2.Text="Flat # "+ilFlatNumber.ToString();
					ilFlatNumber=ilFlatNumber+1;				
				

					//FLATSaldos3
					ilSumaFilas = Convert.ToInt32(dsDetalleFlatS2.Tables[0].Rows[dsDetalleFlatS1.Tables[0].Rows.Count-1][0].ToString());
					dsDetalleFlatS3 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"4","35",ilSumaFilas.ToString());
					if(dsDetalleFlatS3.Tables[0].Rows.Count>0)
					{
						dvmDetalleFlatS3 = dsDetalleFlatS3.DefaultViewManager;
						dvmDetalleFlatS3.DataSet.Tables[0].TableName="TABLEPLFLATS3";
						this.dgFlatS3.DataSource = dvmDetalleFlatS3.DataSet.Tables[0];
						this.lblFlatS3.Text="Flat # "+ilFlatNumber.ToString();
						ilFlatNumber=ilFlatNumber+1;				
					}
				}
			}
			#endregion

			#region Segundas
			//FLATSegundas1
			ilSumaFilas = 0;
			dsDetalleFlatSC1 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"2","25",ilSumaFilas.ToString());
			if(dsDetalleFlatSC1.Tables[0].Rows.Count>0)
			{
				dvmDetalleFlatSC1 = dsDetalleFlatSC1.DefaultViewManager;
				dvmDetalleFlatSC1.DataSet.Tables[0].TableName="TABLEPLFLATSC1";
				this.dgFlatSC1.DataSource = dvmDetalleFlatSC1.DataSet.Tables[0];
				this.lblFlatSC1.Text="Flat # "+ilFlatNumber.ToString();
				ilFlatNumber=ilFlatNumber+1;

				//FLATSegundas2
				ilSumaFilas = Convert.ToInt32(dsDetalleFlatSC1.Tables[0].Rows[dsDetalleFlatSC1.Tables[0].Rows.Count-1][0].ToString());
				dsDetalleFlatSC2 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"4","25",ilSumaFilas.ToString());
				if(dsDetalleFlatSC2.Tables[0].Rows.Count>0)
				{
					dvmDetalleFlatSC2 = dsDetalleFlatSC2.DefaultViewManager;
					dvmDetalleFlatSC2.DataSet.Tables[0].TableName="TABLEPLFLATSC2";
					this.dgFlatSC2.DataSource = dvmDetalleFlatSC2.DataSet.Tables[0];
					this.lblFlatSC2.Text="Flat # "+ilFlatNumber.ToString();
					ilFlatNumber=ilFlatNumber+1;
				}
			}
			#endregion

			#region Terceras
			//FLATTerceras1
			ilSumaFilas = 0;
			dsDetalleFlatST1 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"3","25",ilSumaFilas.ToString());
			if(dsDetalleFlatST1.Tables[0].Rows.Count>0)
			{
				dvmDetalleFlatST1 = dsDetalleFlatST1.DefaultViewManager;
				dvmDetalleFlatST1.DataSet.Tables[0].TableName="TABLEPLFlatST1";
				this.dgFlatST1.DataSource = dvmDetalleFlatST1.DataSet.Tables[0];
				this.lblFlatST1.Text="Flat # "+ilFlatNumber.ToString();
				ilFlatNumber=ilFlatNumber+1;

				//FLATTerceras2
				ilSumaFilas = Convert.ToInt32(dsDetalleFlatST1.Tables[0].Rows[dsDetalleFlatST1.Tables[0].Rows.Count-1][0].ToString());
				dsDetalleFlatST2 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"3","25",ilSumaFilas.ToString());
				if(dsDetalleFlatST2.Tables[0].Rows.Count>0)
				{
					dvmDetalleFlatST2 = dsDetalleFlatST2.DefaultViewManager;
					dvmDetalleFlatST2.DataSet.Tables[0].TableName="TABLEPLFlatST2";
					this.dgFlatST2.DataSource = dvmDetalleFlatST2.DataSet.Tables[0];
					this.lblFlatST2.Text="Flat # "+ilFlatNumber.ToString();
					ilFlatNumber=ilFlatNumber+1;
				}
			}
			#endregion

			
		}
		#endregion

		private void FPakingList_Load(object sender, System.EventArgs e)
		{
		
		}

		#region private void btnPacking_Click(object sender, System.EventArgs e)
		private void btnPacking_Click(object sender, System.EventArgs e)
		{
			int ilNumeroTarima = 1;
			string slArchivoHTML="";

			string slEstilo = this.tbEstilo.Text.Substring(0,3);

			#region Inicializa ArchivoHTML

			slArchivoHTML=@"
				<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.0 Transitional//EN"">
<html>
	<head>
		<title></title>
		<meta content=""Microsoft Visual Studio .NET 7.1"" name=""GENERATOR"">
		<meta content=""http://schemas.microsoft.com/intellisense/ie5"" name=""vs_targetSchema"">
	</head>
	<body>
";
			#endregion
			System.IO.StreamWriter arcHTML;

			
			if(((DataTable)dgFlat1.DataSource).Rows.Count>=1)
			{
				#region exporta primeras 5 tarimas si tienen datos
				slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas,ilNumeroTarima,this.dgFlat1)+"\n";
				ilNumeroTarima=ilNumeroTarima+1;
				if(((DataTable)dgFlat2.DataSource).Rows.Count>=1)
				{
					slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas,ilNumeroTarima,this.dgFlat2)+"\n";
					ilNumeroTarima=ilNumeroTarima+1;
					if(((DataTable)dgFlat3.DataSource).Rows.Count>=1)
					{
						slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas,ilNumeroTarima,this.dgFlat3)+"\n";
						ilNumeroTarima=ilNumeroTarima+1;
						if(((DataTable)dgFlat4.DataSource).Rows.Count>=1)
						{
							slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas,ilNumeroTarima,this.dgFlat4)+"\n";
							ilNumeroTarima=ilNumeroTarima+1;
							if(((DataTable)dgFlat5.DataSource).Rows.Count>=1)
							{
								slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas,ilNumeroTarima,this.dgFlat5)+"\n";
								ilNumeroTarima=ilNumeroTarima+1;
							}
						}
					}
				}
				#endregion			

				#region Exporta si es tallas Extras
				//revisa si el corte es talla extra
				if(slEstilo=="J65")
				{
					//revisa si los DTGrid para TE tienen Informacion
					if(((DataTable)dgFlat6.DataSource).Rows.Count>=1)
					{
						slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas,ilNumeroTarima,this.dgFlat6)+"\n";
						ilNumeroTarima=ilNumeroTarima++;
						if(((DataTable)dgFlat7.DataSource).Rows.Count>=1)
						{
							slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas,ilNumeroTarima,this.dgFlat7)+"\n";
							ilNumeroTarima=ilNumeroTarima++;
						}
					}
				}
				#endregion

				#region Exporta Saldos
				try
				{
					if(((DataTable)this.dgFlatS1.DataSource).Rows.Count>=1)
					{
					
						slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSaldos,ilNumeroTarima,this.dgFlatS1)+"\n";
						ilNumeroTarima=ilNumeroTarima+1;
						if(((DataTable)dgFlatS2.DataSource).Rows.Count>=1)
						{
							slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSaldos,ilNumeroTarima,this.dgFlatS2)+"\n";
							ilNumeroTarima=ilNumeroTarima+1;
						}
					}
				}
				catch
				{}
				#endregion

				#region Exporta Segundas y Terceras
				try
				{
					if(((DataTable)this.dgFlatSC1.DataSource).Rows.Count>=1)
						slArchivoHTML = slArchivoHTML + GeneraReporteEmbarqueSegTer(slCajaSegundas,ilNumeroTarima,this.dgFlatSC1,this.dgFlatSC2);
					if(((DataTable)this.dgFlatST1.DataSource).Rows.Count>=1)
						slArchivoHTML = slArchivoHTML + GeneraReporteEmbarqueSegTer(slCajaTerceras,ilNumeroTarima,this.dgFlatST1,this.dgFlatST2);
				}
				catch
				{}
				#endregion

				slArchivoHTML = slArchivoHTML + @"</body>
</html>";
				#region Exportacion
				try
				{
					arcHTML = new System.IO.StreamWriter(@"C:\"+ConfigurationSettings.AppSettings["FolderPL"]+@"\"+this.tbxCorte.Text+".html");
					arcHTML.Write(slArchivoHTML);
					arcHTML.Close();
					MessageBox.Show( "El Archivo se genero correctamente.", "EXPORTACION COMPLETADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch
				{
					MessageBox.Show( "Error al Generar el Archivo.", "ERROR DE EXPORTACION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
				#endregion
			
			}
			else
			{MessageBox.Show( "Imposible denerar el archivo debido a que existen lectura de prendas.", "ERROR DE EXPORTACION", MessageBoxButtons.OK, MessageBoxIcon.Stop);}
		}	
		#endregion	

		#region private string GeneraReporteEmbarque(string slTipoCaja, int ilFlatNumber, DataGrid dgDetalleFlat)
		private string GeneraReporteEmbarque(string slTipoCaja, int ilFlatNumber, DataGrid dgDetalleFlat)
		{
			string slCorte = this.tbxCorte.Text;
			string slEstilo = this.tbEstilo.Text;
			string slContrato = this.tbContrato.Text;
			string slColor =this.tbColor.Text;
			string slArchivoHTML ="";

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
			
			//DataSet dsDetalle = new DataSet();			
			//dsDetalle = SistEti.lpQueries.LlenaPLCT(this.sgCorte,slTipoCaja,"100%","0");

			switch(slTipoCaja)
			{
				case "1":
					slFlatType ="";
					break;
				case "2":
					slFlatType ="Seconds";
					break;
				case "3":
					slFlatType ="Thirds";
					break;
				case "4":
					slFlatType ="";
					break;
			}

			
			blCreaArchivo=true;
			//while(blCreaArchivo)
		{			
			#region AchivoHTML slArchivoHTML
				
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
			int rowCount = ((DataTable)dgDetalleFlat.DataSource).Rows.Count;
			//				dgDetalleFlat.TableStyles.Count;
			if(ilCTotalCajas > rowCount)
			{
				ilCTotalCajas = rowCount;
			}
			if(rowCount==0)
				blCreaArchivo = false;

			#region Detalle
			slDetalle = slDetalle +@"			
			<TR><!--Fila 13-->
				<TD ></TD>
				<TD colspan =""5"" height =""730"" valign=top>
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
				slTalla = dgDetalleFlat[ilRow,1].ToString();
				slPairs = dgDetalleFlat[ilRow,2].ToString();
				slTotalPairs = Convert.ToString( Convert.ToInt64(slTotalPairs)+Convert.ToInt64(slPairs));
				slDetalle = slDetalle +@"		
						<TR>				
							<TD style=""WIDTH: 90px""><P align=""center"">"+Convert.ToString(ilRow+1)+@"</P></TD>
							<TD style=""WIDTH: 58px""><P align=""center"">"+slTalla+@"</P></TD>
							<TD><P align=""center"">"+slPairs+@"</P></TD>";

				slDetalle = slDetalle +@"
						</TR>";
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
			/*if(ilCaja<43)
				{
					for(int ilRow2 = ilCaja+1 ; ilRow2<=33 ;ilRow2++)
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

				}*/
	
			#endregion //DETALLE

			slCasesFlat = ilCaja.ToString();
			slDozensFlat = Convert.ToString(Math.Round(Convert.ToDouble(slTotalPairs)/12,2 ));

			#region Encabezado1
			slEncabezado1 = @"
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
				<TD  >&nbsp;</TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
			</TR>			
		</TABLE>";
			#endregion //Footer
			#endregion AchivoHTML

			//				if(blCreaArchivo)
			//				{
			//					slArchivoHTML = slEncabezado1 + slEncabezado2 + slDetalle + slFooter;
			//
			//					arcHTML = new System.IO.StreamWriter(@"C:\PACKING LIST\"+slCorte+" - Flat - "+ilFlatNumber.ToString()+".html");
			//					arcHTML.Write(slArchivoHTML);
			//					arcHTML.Close();
			//				}
			slArchivoHTML = slEncabezado1 + slEncabezado2 + slDetalle + slFooter;
				
			//if(ilNoCajaCons+1>dgDetalleFlat.)
			//	blCreaArchivo = false;

			ilFlatNumber=ilFlatNumber+1;				
		}
			//		return ilFlatNumber;
			return slArchivoHTML;
		}
		#endregion

		#region private string GeneraReporteEmbarqueSegTer(string slTipoCaja, int ilFlatNumber,DataGrid dgDetalleFlat1,DataGrid dgDetalleFlat2)
		/// <summary>
		/// GENERA TARIMA PARA SEGUNDAS O TERCERAS
		/// </summary>
		/// <param name="slTipoCaja"></param>
		/// <param name="ilFlatNumber"></param>
		/// <returns></returns>
		private string GeneraReporteEmbarqueSegTer(string slTipoCaja, int ilFlatNumber,DataGrid dgDetalleFlat1,DataGrid dgDetalleFlat2)
		{
			string slCorte = this.tbxCorte.Text;
			string slEstilo = this.tbEstilo.Text;
			string slContrato = this.tbContrato.Text;
			string slColor =this.tbColor.Text;
			string slArchivoHTML ="";

			string slFlatType ="";
			string slFlatNumber ="";
			string slCasesFlat ="0";
			string slDozensFlat ="0";
			string slTalla ="";
			string slPairs ="0";
			string slTotalPairs ="0";
			int ilRow =0;
			int ilNoCajaCons=0;			
			bool blCreaArchivo = true;
			int ilCTotalCajas = 0;
			
			//DataSet dsDetalle = new DataSet();			
			//dsDetalle = SistEti.lpQueries.LlenaPLCT(this.sgCorte,slTipoCaja,"100%","0");

			switch(slTipoCaja)
			{
				case "1":
					slFlatType ="";
					break;
				case "2":
					slFlatType ="Seconds";
					break;
				case "3":
					slFlatType ="Thirds";
					break;
				case "4":
					slFlatType ="";
					break;
			}

			
			blCreaArchivo=true;
	
			
			#region AchivoHTML slArchivoHTML
				
			string slEncabezado1 ="";
			string slEncabezado2 ="";
			string slDetalle ="";
			string slFooter = "";
				

			#region commented
			/*	switch(ilFlatNumber)
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
				}*/
			#endregion
			//int rowCount = ((DataTable)dgDetalleFlat.DataSource).Rows.Count;
			//				dgDetalleFlat.TableStyles.Count;
			/*if(ilCTotalCajas > rowCount)
			{
				ilCTotalCajas = rowCount;
			}*/
			

			#region Detalle

			slDetalle = slDetalle +@"			
			<TR><!--Fila 13-->
				<TD ></TD>
				<TD colspan =""5"" height =""730"" valign=top>
					";
			slDetalle = slDetalle +@"
						<TABLE border=""0"" valign =top>
							<TR>
								<TD >
									"+generaDetalleTarima(dgDetalleFlat1,0,ref slCasesFlat,ref slDozensFlat) +@"	
								</TD>";
			try
			{
				if(((DataTable)dgDetalleFlat2.DataSource).Rows.Count>=1)
				{
					slDetalle = slDetalle +@"
								<TD>
									"+generaDetalleTarima(dgDetalleFlat2,((DataTable)dgDetalleFlat1.DataSource).Rows.Count,ref slCasesFlat,ref slDozensFlat) +@"
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TD>
			</TR>";			
				}
			}
			catch
			{
				slDetalle = slDetalle +@"
								<TD></TD>
							</TR>
						</TABLE>
					</TD>
				</TD>
				<TD ></TD>
			</TR>";			
			}	
			#endregion //DETALLE

			int rowCount = ((DataTable)dgDetalleFlat1.DataSource).Rows.Count;
			try
			{
				rowCount=rowCount+((DataTable)dgDetalleFlat2.DataSource).Rows.Count;
			}
			catch
			{
			}
			//slCasesFlat = rowCount.ToString();
			slDozensFlat = Convert.ToString(Math.Round(Convert.ToDouble(slDozensFlat)/12,2 ));

			#region Encabezado1
			slEncabezado1 = @"
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
				<TD  >&nbsp;</TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
				<TD></TD>
				<TD></TD>
				<TD  ></TD>
			</TR>			
		</TABLE>";
			#endregion //Footer
			#endregion AchivoHTML

			//				if(blCreaArchivo)
			//				{
			//					slArchivoHTML = slEncabezado1 + slEncabezado2 + slDetalle + slFooter;
			//
			//					arcHTML = new System.IO.StreamWriter(@"C:\PACKING LIST\"+slCorte+" - Flat - "+ilFlatNumber.ToString()+".html");
			//					arcHTML.Write(slArchivoHTML);
			//					arcHTML.Close();
			//				}
			slArchivoHTML = slEncabezado1 + slEncabezado2 + slDetalle + slFooter;
				
			//if(ilNoCajaCons+1>dgDetalleFlat.)
			//	blCreaArchivo = false;

			ilFlatNumber=ilFlatNumber+1;				
		
			//		return ilFlatNumber;
			return slArchivoHTML;
		}
		#endregion

		#region private string generaDetalleTarima(DataGrid dgDetalleFlat, int ilNoCajaCons)
		private string generaDetalleTarima(DataGrid dgDetalleFlat, int ilNoCajaCons,ref string slCases,ref string slTotalPairs)
		{
			int rowCount = ((DataTable)dgDetalleFlat.DataSource).Rows.Count+ilNoCajaCons;
			int ilRow =0;

			string slDetalle="";
			string slTalla ="";
			string slPairs = "";

			slDetalle = slDetalle +@"
						<TABLE border=""1"" cellspacing=-1 cellpadding=1 bordercolor=""000000"">
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
			
			ilCaja=1;
			string slCajaID="";
			for(ilRow = ilNoCajaCons ;ilRow <rowCount/*dsDetalle.Tables[0].Rows.Count*/; ilRow++)
			{				
				slCajaID = dgDetalleFlat[ilRow,0].ToString();
				slTalla = dgDetalleFlat[ilRow,1].ToString();
				slPairs = dgDetalleFlat[ilRow,2].ToString();
				slTotalPairs = Convert.ToString( Convert.ToInt64(slTotalPairs)+Convert.ToInt64(slPairs));
				slDetalle = slDetalle +@"		
						<TR>				
							<TD style=""WIDTH: 90px""><P align=""center"">"+Convert.ToString(ilCaja)+@"</P></TD>
							<TD style=""WIDTH: 58px""><P align=""center"">"+slTalla+@"</P></TD>
							<TD><P align=""center"">"+slPairs+@"</P></TD>
						</TR>";
				if(ilRow+1<rowCount)
				{
					if(slCajaID!=dgDetalleFlat[ilRow+1,0].ToString())
					{
						ilCaja = ilCaja + 1;
						slDetalle = slDetalle +@"		
						<TR>				
							<TD>&nbsp;</TD>
							<TD>&nbsp;</TD>
							<TD>&nbsp;</TD>
						</TR>";
					}
				}
			}
			ilNoCajaCons=ilRow;
			slDetalle = slDetalle +@"
					<TR>						
						<TD style=""WIDTH: 90px"" align=""center"">TOTAL</TD>
						<TD style=""WIDTH: 58px"" align=""center"">"+ilCaja.ToString()+@"</TD>						
						<TD align=""center"">"+slTotalPairs+@"</TD>						
					</TR>			
				</table>
				";
			slCases=Convert.ToString(Convert.ToInt32(slCases)+ilCaja);
			return slDetalle;
		}
		#endregion
	}
}
