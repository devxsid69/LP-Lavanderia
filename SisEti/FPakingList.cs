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
        private static string slCajaGarras = "5";
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
        private System.Windows.Forms.TabPage tabPage5;
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblFlatS3;
		private System.Windows.Forms.Label lblFlatS2;
        private System.Windows.Forms.Label lblFlatS1;
		private System.Windows.Forms.Label lblFlatST2;
		private System.Windows.Forms.Label lblFlatST1;
		private System.Windows.Forms.Label lblFlatTE2;
        private System.Windows.Forms.Label lblFlatTE1;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnPacking;
        private DataGridTextBoxColumn dgtbcFSG1CuttingId;
        private DataGridTextBoxColumn dgtbcFSG1Id;
        private DataGridTextBoxColumn dgtbcFSG1TipoCaja;
        private DataGridTextBoxColumn dgtbcFSG1Prendas;
        private DataGridTextBoxColumn dgtbcFSG1Talla;
        private DataGridTextBoxColumn dgtbcFSG1CajaId;
        private DataGridTextBoxColumn dgtbcFSG2CuttingId;
        private DataGridTextBoxColumn dgtbcFSG2Id;
        private DataGridTextBoxColumn dgtbcFSG2TipoCaja;
        private DataGridTextBoxColumn dgtbcFSG2Prendas;
        private DataGridTextBoxColumn dgtbcFSG2Talla;
        private DataGridTextBoxColumn dgtbcFSG2CajaId;
        private DataGridTextBoxColumn dgtbcFST1CuttingId;
        private DataGridTextBoxColumn dgtbcFST1Id;
        private DataGridTextBoxColumn dgtbcFST1TipoCaja;
        private DataGridTextBoxColumn dgtbcFST1Prendas;
        private DataGridTextBoxColumn dgtbcFST1Talla;
        private DataGridTextBoxColumn dgtbcFST1CajaId;
        private DataGridTableStyle dgsFlatST1;
        private DataSet dsFlat;
        private DataTable dsFlatTable;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private BindingSource bindingSource1;
        private Label lblFlatSC1;
        private DataGridView dgvFlat1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridView dgvFlat3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridView dgvFlat2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridView dgvFlat5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private DataGridView dgvFlat4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridTextBoxColumn dgtbcF4CuttingId;
        private DataGridTextBoxColumn dgtbcF4Id;
        private DataGridTextBoxColumn dgtbcF4TipoCaja;
        private DataGridTextBoxColumn dgtbcF4Prendas;
        private DataGridTextBoxColumn dgtbcF4Talla;
        private DataGridTextBoxColumn dgtbcF4CajaId;
        private DataGridView dgvFlat6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private DataGridView dgvFlat7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private DataGridView dgvFlatS1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private DataGridView dgvFlatS2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private DataGridView dgvFlatS3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private Label lblFlatSC2;
        private DataGridView dgvFlatSC2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridView dgvFlatSC1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private DataGridView dgvFlatST2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn82;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;
        private DataGridView dgvFlatST1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private DataGridView dgvFlatSG2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn85;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn87;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;
        private DataGridView dgvFlatSG1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn91;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn92;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn93;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn94;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn95;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn96;
        private Label lblFlatSG2;
        private Label lblFlatSG1;
        private IContainer components;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvFlat7 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsFlat = new System.Data.DataSet();
            this.dsFlatTable = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dgvFlat6 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlat5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlat4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlat3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlat2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlat1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFlatTE2 = new System.Windows.Forms.Label();
            this.lblFlatTE1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvFlatS3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlatS2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlatS1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFlatS3 = new System.Windows.Forms.Label();
            this.lblFlatS2 = new System.Windows.Forms.Label();
            this.lblFlatS1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblFlatSC2 = new System.Windows.Forms.Label();
            this.dgvFlatSC2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlatSC1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFlatSC1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvFlatST2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn79 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn81 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn82 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn83 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn84 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlatST1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn73 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn74 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn76 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn77 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn78 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFlatST2 = new System.Windows.Forms.Label();
            this.lblFlatST1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvFlatSG2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn85 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn86 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn87 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn88 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn89 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlatSG1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn91 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn92 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn93 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn94 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn95 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn96 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFlatSG2 = new System.Windows.Forms.Label();
            this.lblFlatSG1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnPacking = new System.Windows.Forms.Button();
            this.dgtbcFSG1CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFSG1Id = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFSG1TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFSG1Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFSG1Talla = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFSG1CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFSG2CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFSG2Id = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFSG2TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFSG2Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFSG2Talla = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFSG2CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFST1CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFST1Id = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFST1TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFST1Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFST1Talla = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcFST1CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgsFlatST1 = new System.Windows.Forms.DataGridTableStyle();
            this.dgtbcF4CuttingId = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcF4Id = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcF4TipoCaja = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcF4Prendas = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcF4Talla = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dgtbcF4CajaId = new System.Windows.Forms.DataGridTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlatTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatS3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatS1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatSC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatSC1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatST2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatST1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatSG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatSG1)).BeginInit();
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
            this.tbEstilo.Size = new System.Drawing.Size(100, 20);
            this.tbEstilo.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(448, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxCorte
            // 
            this.tbxCorte.Location = new System.Drawing.Point(32, 24);
            this.tbxCorte.Name = "tbxCorte";
            this.tbxCorte.Size = new System.Drawing.Size(100, 20);
            this.tbxCorte.TabIndex = 26;
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
            this.tbColor.Size = new System.Drawing.Size(100, 20);
            this.tbColor.TabIndex = 33;
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
            this.tbContrato.Size = new System.Drawing.Size(100, 20);
            this.tbContrato.TabIndex = 31;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(7, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 520);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvFlat7);
            this.tabPage1.Controls.Add(this.dgvFlat6);
            this.tabPage1.Controls.Add(this.dgvFlat5);
            this.tabPage1.Controls.Add(this.dgvFlat4);
            this.tabPage1.Controls.Add(this.dgvFlat3);
            this.tabPage1.Controls.Add(this.dgvFlat2);
            this.tabPage1.Controls.Add(this.dgvFlat1);
            this.tabPage1.Controls.Add(this.lblFlatTE2);
            this.tabPage1.Controls.Add(this.lblFlatTE1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(960, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Primeras";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvFlat7
            // 
            this.dgvFlat7.AllowUserToAddRows = false;
            this.dgvFlat7.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat7.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFlat7.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat7.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFlat7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlat7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48});
            this.dgvFlat7.DataSource = this.bindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlat7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFlat7.Location = new System.Drawing.Point(760, 19);
            this.dgvFlat7.Name = "dgvFlat7";
            this.dgvFlat7.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat7.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFlat7.RowHeadersWidth = 10;
            this.dgvFlat7.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat7.RowTemplate.Height = 16;
            this.dgvFlat7.Size = new System.Drawing.Size(142, 467);
            this.dgvFlat7.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn43.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            this.dataGridViewTextBoxColumn43.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn43.Width = 40;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn44.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            this.dataGridViewTextBoxColumn44.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn44.Width = 45;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn45.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            this.dataGridViewTextBoxColumn45.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn45.Width = 35;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn46.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.dataGridViewTextBoxColumn46.Visible = false;
            this.dataGridViewTextBoxColumn46.Width = 5;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn47.HeaderText = "Id";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            this.dataGridViewTextBoxColumn47.Visible = false;
            this.dataGridViewTextBoxColumn47.Width = 5;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn48.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            this.dataGridViewTextBoxColumn48.Visible = false;
            this.dataGridViewTextBoxColumn48.Width = 5;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tFlat";
            this.bindingSource1.DataSource = this.dsFlat;
            // 
            // dsFlat
            // 
            this.dsFlat.DataSetName = "dsFlat";
            this.dsFlat.Tables.AddRange(new System.Data.DataTable[] {
            this.dsFlatTable});
            // 
            // dsFlatTable
            // 
            this.dsFlatTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dsFlatTable.TableName = "tFlat";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "#Caja";
            this.dataColumn1.ColumnName = "CajaId";
            this.dataColumn1.DefaultValue = "0";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Talla";
            this.dataColumn2.DefaultValue = "";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Cant";
            this.dataColumn3.ColumnName = "Prendas";
            this.dataColumn3.DefaultValue = "0";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Tipo";
            this.dataColumn4.ColumnName = "TipoCaja";
            this.dataColumn4.DefaultValue = "0";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Id";
            this.dataColumn5.DefaultValue = "0";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "CuttingID";
            this.dataColumn6.DefaultValue = "0";
            // 
            // dgvFlat6
            // 
            this.dgvFlat6.AllowUserToAddRows = false;
            this.dgvFlat6.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat6.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFlat6.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFlat6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlat6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42});
            this.dgvFlat6.DataSource = this.bindingSource1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlat6.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFlat6.Location = new System.Drawing.Point(604, 19);
            this.dgvFlat6.Name = "dgvFlat6";
            this.dgvFlat6.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat6.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFlat6.RowHeadersWidth = 10;
            this.dgvFlat6.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat6.RowTemplate.Height = 16;
            this.dgvFlat6.Size = new System.Drawing.Size(142, 467);
            this.dgvFlat6.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn37.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            this.dataGridViewTextBoxColumn37.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn37.Width = 40;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn38.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            this.dataGridViewTextBoxColumn38.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn38.Width = 45;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn39.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.dataGridViewTextBoxColumn39.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn39.Width = 35;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn40.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Visible = false;
            this.dataGridViewTextBoxColumn40.Width = 5;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn41.HeaderText = "Id";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.Visible = false;
            this.dataGridViewTextBoxColumn41.Width = 5;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn42.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            this.dataGridViewTextBoxColumn42.Visible = false;
            this.dataGridViewTextBoxColumn42.Width = 5;
            // 
            // dgvFlat5
            // 
            this.dgvFlat5.AllowUserToAddRows = false;
            this.dgvFlat5.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFlat5.AutoGenerateColumns = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFlat5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlat5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36});
            this.dgvFlat5.DataSource = this.bindingSource1;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlat5.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFlat5.Location = new System.Drawing.Point(451, 19);
            this.dgvFlat5.Name = "dgvFlat5";
            this.dgvFlat5.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat5.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvFlat5.RowHeadersWidth = 10;
            this.dgvFlat5.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat5.RowTemplate.Height = 16;
            this.dgvFlat5.Size = new System.Drawing.Size(142, 467);
            this.dgvFlat5.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn31.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn31.Width = 40;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn32.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn32.Width = 45;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn33.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn33.Width = 35;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn34.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Visible = false;
            this.dataGridViewTextBoxColumn34.Width = 5;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn35.HeaderText = "Id";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Visible = false;
            this.dataGridViewTextBoxColumn35.Width = 5;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn36.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.dataGridViewTextBoxColumn36.Visible = false;
            this.dataGridViewTextBoxColumn36.Width = 5;
            // 
            // dgvFlat4
            // 
            this.dgvFlat4.AllowUserToAddRows = false;
            this.dgvFlat4.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvFlat4.AutoGenerateColumns = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvFlat4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlat4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30});
            this.dgvFlat4.DataSource = this.bindingSource1;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlat4.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvFlat4.Location = new System.Drawing.Point(299, 262);
            this.dgvFlat4.Name = "dgvFlat4";
            this.dgvFlat4.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat4.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvFlat4.RowHeadersWidth = 10;
            this.dgvFlat4.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat4.RowTemplate.Height = 16;
            this.dgvFlat4.Size = new System.Drawing.Size(142, 224);
            this.dgvFlat4.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn25.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn25.Width = 40;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn26.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn26.Width = 45;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn27.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn27.Width = 35;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn28.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Visible = false;
            this.dataGridViewTextBoxColumn28.Width = 5;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn29.HeaderText = "Id";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Visible = false;
            this.dataGridViewTextBoxColumn29.Width = 5;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn30.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Visible = false;
            this.dataGridViewTextBoxColumn30.Width = 5;
            // 
            // dgvFlat3
            // 
            this.dgvFlat3.AllowUserToAddRows = false;
            this.dgvFlat3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvFlat3.AutoGenerateColumns = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvFlat3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlat3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.dgvFlat3.DataSource = this.bindingSource1;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlat3.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvFlat3.Location = new System.Drawing.Point(299, 19);
            this.dgvFlat3.Name = "dgvFlat3";
            this.dgvFlat3.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat3.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvFlat3.RowHeadersWidth = 10;
            this.dgvFlat3.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat3.RowTemplate.Height = 16;
            this.dgvFlat3.Size = new System.Drawing.Size(142, 224);
            this.dgvFlat3.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn19.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn19.Width = 40;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn20.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn20.Width = 45;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn21.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn21.Width = 35;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn22.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Visible = false;
            this.dataGridViewTextBoxColumn22.Width = 5;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn23.HeaderText = "Id";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Visible = false;
            this.dataGridViewTextBoxColumn23.Width = 5;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn24.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Visible = false;
            this.dataGridViewTextBoxColumn24.Width = 5;
            // 
            // dgvFlat2
            // 
            this.dgvFlat2.AllowUserToAddRows = false;
            this.dgvFlat2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvFlat2.AutoGenerateColumns = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvFlat2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlat2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dgvFlat2.DataSource = this.bindingSource1;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlat2.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvFlat2.Location = new System.Drawing.Point(151, 19);
            this.dgvFlat2.Name = "dgvFlat2";
            this.dgvFlat2.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat2.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvFlat2.RowHeadersWidth = 10;
            this.dgvFlat2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat2.RowTemplate.Height = 16;
            this.dgvFlat2.Size = new System.Drawing.Size(142, 467);
            this.dgvFlat2.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn13.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn13.Width = 40;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn14.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn14.Width = 45;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn15.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn15.Width = 35;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn16.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            this.dataGridViewTextBoxColumn16.Width = 5;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn17.HeaderText = "Id";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            this.dataGridViewTextBoxColumn17.Width = 5;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn18.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            this.dataGridViewTextBoxColumn18.Width = 5;
            // 
            // dgvFlat1
            // 
            this.dgvFlat1.AllowUserToAddRows = false;
            this.dgvFlat1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvFlat1.AutoGenerateColumns = false;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvFlat1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlat1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvFlat1.DataSource = this.bindingSource1;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlat1.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvFlat1.Location = new System.Drawing.Point(3, 19);
            this.dgvFlat1.Name = "dgvFlat1";
            this.dgvFlat1.ReadOnly = true;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlat1.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvFlat1.RowHeadersWidth = 10;
            this.dgvFlat1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlat1.RowTemplate.Height = 16;
            this.dgvFlat1.Size = new System.Drawing.Size(142, 467);
            this.dgvFlat1.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn7.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 40;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn8.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.Width = 45;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.Width = 35;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn10.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 5;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn11.HeaderText = "Id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 5;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn12.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 5;
            // 
            // lblFlatTE2
            // 
            this.lblFlatTE2.Location = new System.Drawing.Point(771, 0);
            this.lblFlatTE2.Name = "lblFlatTE2";
            this.lblFlatTE2.Size = new System.Drawing.Size(100, 16);
            this.lblFlatTE2.TabIndex = 13;
            this.lblFlatTE2.Text = "Flat # ";
            this.lblFlatTE2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblFlatTE1
            // 
            this.lblFlatTE1.Location = new System.Drawing.Point(620, 0);
            this.lblFlatTE1.Name = "lblFlatTE1";
            this.lblFlatTE1.Size = new System.Drawing.Size(100, 16);
            this.lblFlatTE1.TabIndex = 12;
            this.lblFlatTE1.Text = "Flat # ";
            this.lblFlatTE1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(470, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Flat # 5";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(319, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Flat # 4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(319, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Flat # 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(177, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Flat # 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Flat # 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvFlatS3);
            this.tabPage2.Controls.Add(this.dgvFlatS2);
            this.tabPage2.Controls.Add(this.dgvFlatS1);
            this.tabPage2.Controls.Add(this.lblFlatS3);
            this.tabPage2.Controls.Add(this.lblFlatS2);
            this.tabPage2.Controls.Add(this.lblFlatS1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(960, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saldos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvFlatS3
            // 
            this.dgvFlatS3.AllowUserToAddRows = false;
            this.dgvFlatS3.AllowUserToDeleteRows = false;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatS3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvFlatS3.AutoGenerateColumns = false;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatS3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvFlatS3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlatS3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn62,
            this.dataGridViewTextBoxColumn63,
            this.dataGridViewTextBoxColumn64,
            this.dataGridViewTextBoxColumn65,
            this.dataGridViewTextBoxColumn66});
            this.dgvFlatS3.DataSource = this.bindingSource1;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlatS3.DefaultCellStyle = dataGridViewCellStyle31;
            this.dgvFlatS3.Location = new System.Drawing.Point(299, 19);
            this.dgvFlatS3.Name = "dgvFlatS3";
            this.dgvFlatS3.ReadOnly = true;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatS3.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvFlatS3.RowHeadersWidth = 10;
            this.dgvFlatS3.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatS3.RowTemplate.Height = 16;
            this.dgvFlatS3.Size = new System.Drawing.Size(142, 467);
            this.dgvFlatS3.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn61.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.ReadOnly = true;
            this.dataGridViewTextBoxColumn61.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn61.Width = 40;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn62.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.ReadOnly = true;
            this.dataGridViewTextBoxColumn62.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn62.Width = 45;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn63.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.ReadOnly = true;
            this.dataGridViewTextBoxColumn63.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn63.Width = 35;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn64.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.ReadOnly = true;
            this.dataGridViewTextBoxColumn64.Visible = false;
            this.dataGridViewTextBoxColumn64.Width = 5;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn65.HeaderText = "Id";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.ReadOnly = true;
            this.dataGridViewTextBoxColumn65.Visible = false;
            this.dataGridViewTextBoxColumn65.Width = 5;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn66.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn66.ReadOnly = true;
            this.dataGridViewTextBoxColumn66.Visible = false;
            this.dataGridViewTextBoxColumn66.Width = 5;
            // 
            // dgvFlatS2
            // 
            this.dgvFlatS2.AllowUserToAddRows = false;
            this.dgvFlatS2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatS2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvFlatS2.AutoGenerateColumns = false;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatS2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvFlatS2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlatS2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60});
            this.dgvFlatS2.DataSource = this.bindingSource1;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlatS2.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvFlatS2.Location = new System.Drawing.Point(151, 19);
            this.dgvFlatS2.Name = "dgvFlatS2";
            this.dgvFlatS2.ReadOnly = true;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatS2.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvFlatS2.RowHeadersWidth = 10;
            this.dgvFlatS2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatS2.RowTemplate.Height = 16;
            this.dgvFlatS2.Size = new System.Drawing.Size(142, 467);
            this.dgvFlatS2.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn55.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            this.dataGridViewTextBoxColumn55.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn55.Width = 40;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn56.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.ReadOnly = true;
            this.dataGridViewTextBoxColumn56.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn56.Width = 45;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn57.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.ReadOnly = true;
            this.dataGridViewTextBoxColumn57.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn57.Width = 35;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn58.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            this.dataGridViewTextBoxColumn58.Visible = false;
            this.dataGridViewTextBoxColumn58.Width = 5;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn59.HeaderText = "Id";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            this.dataGridViewTextBoxColumn59.Visible = false;
            this.dataGridViewTextBoxColumn59.Width = 5;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn60.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.ReadOnly = true;
            this.dataGridViewTextBoxColumn60.Visible = false;
            this.dataGridViewTextBoxColumn60.Width = 5;
            // 
            // dgvFlatS1
            // 
            this.dgvFlatS1.AllowUserToAddRows = false;
            this.dgvFlatS1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatS1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvFlatS1.AutoGenerateColumns = false;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatS1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dgvFlatS1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlatS1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54});
            this.dgvFlatS1.DataSource = this.bindingSource1;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlatS1.DefaultCellStyle = dataGridViewCellStyle39;
            this.dgvFlatS1.Location = new System.Drawing.Point(3, 19);
            this.dgvFlatS1.Name = "dgvFlatS1";
            this.dgvFlatS1.ReadOnly = true;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatS1.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvFlatS1.RowHeadersWidth = 10;
            this.dgvFlatS1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatS1.RowTemplate.Height = 16;
            this.dgvFlatS1.Size = new System.Drawing.Size(142, 467);
            this.dgvFlatS1.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn49.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            this.dataGridViewTextBoxColumn49.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn49.Width = 40;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn50.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            this.dataGridViewTextBoxColumn50.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn50.Width = 45;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn51.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            this.dataGridViewTextBoxColumn51.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn51.Width = 35;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn52.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            this.dataGridViewTextBoxColumn52.Visible = false;
            this.dataGridViewTextBoxColumn52.Width = 5;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn53.HeaderText = "Id";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.ReadOnly = true;
            this.dataGridViewTextBoxColumn53.Visible = false;
            this.dataGridViewTextBoxColumn53.Width = 5;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn54.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            this.dataGridViewTextBoxColumn54.Visible = false;
            this.dataGridViewTextBoxColumn54.Width = 5;
            // 
            // lblFlatS3
            // 
            this.lblFlatS3.Location = new System.Drawing.Point(321, 0);
            this.lblFlatS3.Name = "lblFlatS3";
            this.lblFlatS3.Size = new System.Drawing.Size(100, 16);
            this.lblFlatS3.TabIndex = 11;
            this.lblFlatS3.Text = "Flat #";
            this.lblFlatS3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblFlatS2
            // 
            this.lblFlatS2.Location = new System.Drawing.Point(177, 0);
            this.lblFlatS2.Name = "lblFlatS2";
            this.lblFlatS2.Size = new System.Drawing.Size(100, 16);
            this.lblFlatS2.TabIndex = 10;
            this.lblFlatS2.Text = "Flat #";
            this.lblFlatS2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblFlatS1
            // 
            this.lblFlatS1.Location = new System.Drawing.Point(16, 0);
            this.lblFlatS1.Name = "lblFlatS1";
            this.lblFlatS1.Size = new System.Drawing.Size(100, 16);
            this.lblFlatS1.TabIndex = 8;
            this.lblFlatS1.Text = "Flat #";
            this.lblFlatS1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblFlatSC2);
            this.tabPage3.Controls.Add(this.dgvFlatSC2);
            this.tabPage3.Controls.Add(this.dgvFlatSC1);
            this.tabPage3.Controls.Add(this.lblFlatSC1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(960, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Segundas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblFlatSC2
            // 
            this.lblFlatSC2.Location = new System.Drawing.Point(177, 0);
            this.lblFlatSC2.Name = "lblFlatSC2";
            this.lblFlatSC2.Size = new System.Drawing.Size(100, 16);
            this.lblFlatSC2.TabIndex = 18;
            this.lblFlatSC2.Text = "Flat #";
            this.lblFlatSC2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dgvFlatSC2
            // 
            this.dgvFlatSC2.AllowUserToAddRows = false;
            this.dgvFlatSC2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatSC2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            this.dgvFlatSC2.AutoGenerateColumns = false;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatSC2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.dgvFlatSC2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlatSC2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvFlatSC2.DataSource = this.bindingSource1;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlatSC2.DefaultCellStyle = dataGridViewCellStyle43;
            this.dgvFlatSC2.Location = new System.Drawing.Point(151, 19);
            this.dgvFlatSC2.Name = "dgvFlatSC2";
            this.dgvFlatSC2.ReadOnly = true;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatSC2.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.dgvFlatSC2.RowHeadersWidth = 10;
            this.dgvFlatSC2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatSC2.RowTemplate.Height = 16;
            this.dgvFlatSC2.Size = new System.Drawing.Size(142, 467);
            this.dgvFlatSC2.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn1.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn2.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 45;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 35;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn4.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn6.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 5;
            // 
            // dgvFlatSC1
            // 
            this.dgvFlatSC1.AllowUserToAddRows = false;
            this.dgvFlatSC1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatSC1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle45;
            this.dgvFlatSC1.AutoGenerateColumns = false;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatSC1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.dgvFlatSC1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlatSC1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn67,
            this.dataGridViewTextBoxColumn68,
            this.dataGridViewTextBoxColumn69,
            this.dataGridViewTextBoxColumn70,
            this.dataGridViewTextBoxColumn71,
            this.dataGridViewTextBoxColumn72});
            this.dgvFlatSC1.DataSource = this.bindingSource1;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlatSC1.DefaultCellStyle = dataGridViewCellStyle47;
            this.dgvFlatSC1.Location = new System.Drawing.Point(3, 19);
            this.dgvFlatSC1.Name = "dgvFlatSC1";
            this.dgvFlatSC1.ReadOnly = true;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatSC1.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.dgvFlatSC1.RowHeadersWidth = 10;
            this.dgvFlatSC1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatSC1.RowTemplate.Height = 16;
            this.dgvFlatSC1.Size = new System.Drawing.Size(142, 467);
            this.dgvFlatSC1.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn67.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            this.dataGridViewTextBoxColumn67.ReadOnly = true;
            this.dataGridViewTextBoxColumn67.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn67.Width = 40;
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn68.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn68.ReadOnly = true;
            this.dataGridViewTextBoxColumn68.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn68.Width = 45;
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn69.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn69.ReadOnly = true;
            this.dataGridViewTextBoxColumn69.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn69.Width = 35;
            // 
            // dataGridViewTextBoxColumn70
            // 
            this.dataGridViewTextBoxColumn70.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn70.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
            this.dataGridViewTextBoxColumn70.ReadOnly = true;
            this.dataGridViewTextBoxColumn70.Visible = false;
            this.dataGridViewTextBoxColumn70.Width = 5;
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn71.HeaderText = "Id";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn71.ReadOnly = true;
            this.dataGridViewTextBoxColumn71.Visible = false;
            this.dataGridViewTextBoxColumn71.Width = 5;
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn72.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            this.dataGridViewTextBoxColumn72.ReadOnly = true;
            this.dataGridViewTextBoxColumn72.Visible = false;
            this.dataGridViewTextBoxColumn72.Width = 5;
            // 
            // lblFlatSC1
            // 
            this.lblFlatSC1.Location = new System.Drawing.Point(16, 0);
            this.lblFlatSC1.Name = "lblFlatSC1";
            this.lblFlatSC1.Size = new System.Drawing.Size(100, 16);
            this.lblFlatSC1.TabIndex = 9;
            this.lblFlatSC1.Text = "Flat #";
            this.lblFlatSC1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvFlatST2);
            this.tabPage4.Controls.Add(this.dgvFlatST1);
            this.tabPage4.Controls.Add(this.lblFlatST2);
            this.tabPage4.Controls.Add(this.lblFlatST1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(960, 494);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Terceras";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvFlatST2
            // 
            this.dgvFlatST2.AllowUserToAddRows = false;
            this.dgvFlatST2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatST2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle49;
            this.dgvFlatST2.AutoGenerateColumns = false;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatST2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle50;
            this.dgvFlatST2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlatST2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn79,
            this.dataGridViewTextBoxColumn80,
            this.dataGridViewTextBoxColumn81,
            this.dataGridViewTextBoxColumn82,
            this.dataGridViewTextBoxColumn83,
            this.dataGridViewTextBoxColumn84});
            this.dgvFlatST2.DataSource = this.bindingSource1;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlatST2.DefaultCellStyle = dataGridViewCellStyle51;
            this.dgvFlatST2.Location = new System.Drawing.Point(151, 19);
            this.dgvFlatST2.Name = "dgvFlatST2";
            this.dgvFlatST2.ReadOnly = true;
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle52.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle52.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatST2.RowHeadersDefaultCellStyle = dataGridViewCellStyle52;
            this.dgvFlatST2.RowHeadersWidth = 10;
            this.dgvFlatST2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatST2.RowTemplate.Height = 16;
            this.dgvFlatST2.Size = new System.Drawing.Size(142, 467);
            this.dgvFlatST2.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn79
            // 
            this.dataGridViewTextBoxColumn79.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn79.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn79.Name = "dataGridViewTextBoxColumn79";
            this.dataGridViewTextBoxColumn79.ReadOnly = true;
            this.dataGridViewTextBoxColumn79.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn79.Width = 40;
            // 
            // dataGridViewTextBoxColumn80
            // 
            this.dataGridViewTextBoxColumn80.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn80.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn80.Name = "dataGridViewTextBoxColumn80";
            this.dataGridViewTextBoxColumn80.ReadOnly = true;
            this.dataGridViewTextBoxColumn80.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn80.Width = 45;
            // 
            // dataGridViewTextBoxColumn81
            // 
            this.dataGridViewTextBoxColumn81.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn81.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn81.Name = "dataGridViewTextBoxColumn81";
            this.dataGridViewTextBoxColumn81.ReadOnly = true;
            this.dataGridViewTextBoxColumn81.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn81.Width = 35;
            // 
            // dataGridViewTextBoxColumn82
            // 
            this.dataGridViewTextBoxColumn82.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn82.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn82.Name = "dataGridViewTextBoxColumn82";
            this.dataGridViewTextBoxColumn82.ReadOnly = true;
            this.dataGridViewTextBoxColumn82.Visible = false;
            this.dataGridViewTextBoxColumn82.Width = 5;
            // 
            // dataGridViewTextBoxColumn83
            // 
            this.dataGridViewTextBoxColumn83.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn83.HeaderText = "Id";
            this.dataGridViewTextBoxColumn83.Name = "dataGridViewTextBoxColumn83";
            this.dataGridViewTextBoxColumn83.ReadOnly = true;
            this.dataGridViewTextBoxColumn83.Visible = false;
            this.dataGridViewTextBoxColumn83.Width = 5;
            // 
            // dataGridViewTextBoxColumn84
            // 
            this.dataGridViewTextBoxColumn84.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn84.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn84.Name = "dataGridViewTextBoxColumn84";
            this.dataGridViewTextBoxColumn84.ReadOnly = true;
            this.dataGridViewTextBoxColumn84.Visible = false;
            this.dataGridViewTextBoxColumn84.Width = 5;
            // 
            // dgvFlatST1
            // 
            this.dgvFlatST1.AllowUserToAddRows = false;
            this.dgvFlatST1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatST1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle53;
            this.dgvFlatST1.AutoGenerateColumns = false;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatST1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.dgvFlatST1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlatST1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn73,
            this.dataGridViewTextBoxColumn74,
            this.dataGridViewTextBoxColumn75,
            this.dataGridViewTextBoxColumn76,
            this.dataGridViewTextBoxColumn77,
            this.dataGridViewTextBoxColumn78});
            this.dgvFlatST1.DataSource = this.bindingSource1;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle55.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlatST1.DefaultCellStyle = dataGridViewCellStyle55;
            this.dgvFlatST1.Location = new System.Drawing.Point(3, 19);
            this.dgvFlatST1.Name = "dgvFlatST1";
            this.dgvFlatST1.ReadOnly = true;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatST1.RowHeadersDefaultCellStyle = dataGridViewCellStyle56;
            this.dgvFlatST1.RowHeadersWidth = 10;
            this.dgvFlatST1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatST1.RowTemplate.Height = 16;
            this.dgvFlatST1.Size = new System.Drawing.Size(142, 467);
            this.dgvFlatST1.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn73
            // 
            this.dataGridViewTextBoxColumn73.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn73.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
            this.dataGridViewTextBoxColumn73.ReadOnly = true;
            this.dataGridViewTextBoxColumn73.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn73.Width = 40;
            // 
            // dataGridViewTextBoxColumn74
            // 
            this.dataGridViewTextBoxColumn74.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn74.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
            this.dataGridViewTextBoxColumn74.ReadOnly = true;
            this.dataGridViewTextBoxColumn74.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn74.Width = 45;
            // 
            // dataGridViewTextBoxColumn75
            // 
            this.dataGridViewTextBoxColumn75.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn75.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn75.Name = "dataGridViewTextBoxColumn75";
            this.dataGridViewTextBoxColumn75.ReadOnly = true;
            this.dataGridViewTextBoxColumn75.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn75.Width = 35;
            // 
            // dataGridViewTextBoxColumn76
            // 
            this.dataGridViewTextBoxColumn76.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn76.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn76.Name = "dataGridViewTextBoxColumn76";
            this.dataGridViewTextBoxColumn76.ReadOnly = true;
            this.dataGridViewTextBoxColumn76.Visible = false;
            this.dataGridViewTextBoxColumn76.Width = 5;
            // 
            // dataGridViewTextBoxColumn77
            // 
            this.dataGridViewTextBoxColumn77.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn77.HeaderText = "Id";
            this.dataGridViewTextBoxColumn77.Name = "dataGridViewTextBoxColumn77";
            this.dataGridViewTextBoxColumn77.ReadOnly = true;
            this.dataGridViewTextBoxColumn77.Visible = false;
            this.dataGridViewTextBoxColumn77.Width = 5;
            // 
            // dataGridViewTextBoxColumn78
            // 
            this.dataGridViewTextBoxColumn78.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn78.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn78.Name = "dataGridViewTextBoxColumn78";
            this.dataGridViewTextBoxColumn78.ReadOnly = true;
            this.dataGridViewTextBoxColumn78.Visible = false;
            this.dataGridViewTextBoxColumn78.Width = 5;
            // 
            // lblFlatST2
            // 
            this.lblFlatST2.Location = new System.Drawing.Point(177, 0);
            this.lblFlatST2.Name = "lblFlatST2";
            this.lblFlatST2.Size = new System.Drawing.Size(100, 16);
            this.lblFlatST2.TabIndex = 11;
            this.lblFlatST2.Text = "Flat #";
            this.lblFlatST2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblFlatST1
            // 
            this.lblFlatST1.Location = new System.Drawing.Point(16, 0);
            this.lblFlatST1.Name = "lblFlatST1";
            this.lblFlatST1.Size = new System.Drawing.Size(100, 16);
            this.lblFlatST1.TabIndex = 10;
            this.lblFlatST1.Text = "Flat #";
            this.lblFlatST1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvFlatSG2);
            this.tabPage5.Controls.Add(this.dgvFlatSG1);
            this.tabPage5.Controls.Add(this.lblFlatSG2);
            this.tabPage5.Controls.Add(this.lblFlatSG1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(960, 494);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Garras";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvFlatSG2
            // 
            this.dgvFlatSG2.AllowUserToAddRows = false;
            this.dgvFlatSG2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatSG2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle57;
            this.dgvFlatSG2.AutoGenerateColumns = false;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatSG2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
            this.dgvFlatSG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlatSG2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn85,
            this.dataGridViewTextBoxColumn86,
            this.dataGridViewTextBoxColumn87,
            this.dataGridViewTextBoxColumn88,
            this.dataGridViewTextBoxColumn89,
            this.dataGridViewTextBoxColumn90});
            this.dgvFlatSG2.DataSource = this.bindingSource1;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlatSG2.DefaultCellStyle = dataGridViewCellStyle59;
            this.dgvFlatSG2.Location = new System.Drawing.Point(151, 19);
            this.dgvFlatSG2.Name = "dgvFlatSG2";
            this.dgvFlatSG2.ReadOnly = true;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatSG2.RowHeadersDefaultCellStyle = dataGridViewCellStyle60;
            this.dgvFlatSG2.RowHeadersWidth = 10;
            this.dgvFlatSG2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatSG2.RowTemplate.Height = 16;
            this.dgvFlatSG2.Size = new System.Drawing.Size(142, 467);
            this.dgvFlatSG2.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn85
            // 
            this.dataGridViewTextBoxColumn85.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn85.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn85.Name = "dataGridViewTextBoxColumn85";
            this.dataGridViewTextBoxColumn85.ReadOnly = true;
            this.dataGridViewTextBoxColumn85.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn85.Width = 40;
            // 
            // dataGridViewTextBoxColumn86
            // 
            this.dataGridViewTextBoxColumn86.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn86.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn86.Name = "dataGridViewTextBoxColumn86";
            this.dataGridViewTextBoxColumn86.ReadOnly = true;
            this.dataGridViewTextBoxColumn86.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn86.Width = 45;
            // 
            // dataGridViewTextBoxColumn87
            // 
            this.dataGridViewTextBoxColumn87.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn87.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn87.Name = "dataGridViewTextBoxColumn87";
            this.dataGridViewTextBoxColumn87.ReadOnly = true;
            this.dataGridViewTextBoxColumn87.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn87.Width = 35;
            // 
            // dataGridViewTextBoxColumn88
            // 
            this.dataGridViewTextBoxColumn88.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn88.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn88.Name = "dataGridViewTextBoxColumn88";
            this.dataGridViewTextBoxColumn88.ReadOnly = true;
            this.dataGridViewTextBoxColumn88.Visible = false;
            this.dataGridViewTextBoxColumn88.Width = 5;
            // 
            // dataGridViewTextBoxColumn89
            // 
            this.dataGridViewTextBoxColumn89.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn89.HeaderText = "Id";
            this.dataGridViewTextBoxColumn89.Name = "dataGridViewTextBoxColumn89";
            this.dataGridViewTextBoxColumn89.ReadOnly = true;
            this.dataGridViewTextBoxColumn89.Visible = false;
            this.dataGridViewTextBoxColumn89.Width = 5;
            // 
            // dataGridViewTextBoxColumn90
            // 
            this.dataGridViewTextBoxColumn90.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn90.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn90.Name = "dataGridViewTextBoxColumn90";
            this.dataGridViewTextBoxColumn90.ReadOnly = true;
            this.dataGridViewTextBoxColumn90.Visible = false;
            this.dataGridViewTextBoxColumn90.Width = 5;
            // 
            // dgvFlatSG1
            // 
            this.dgvFlatSG1.AllowUserToAddRows = false;
            this.dgvFlatSG1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatSG1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle61;
            this.dgvFlatSG1.AutoGenerateColumns = false;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatSG1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle62;
            this.dgvFlatSG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlatSG1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn91,
            this.dataGridViewTextBoxColumn92,
            this.dataGridViewTextBoxColumn93,
            this.dataGridViewTextBoxColumn94,
            this.dataGridViewTextBoxColumn95,
            this.dataGridViewTextBoxColumn96});
            this.dgvFlatSG1.DataSource = this.bindingSource1;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlatSG1.DefaultCellStyle = dataGridViewCellStyle63;
            this.dgvFlatSG1.Location = new System.Drawing.Point(3, 19);
            this.dgvFlatSG1.Name = "dgvFlatSG1";
            this.dgvFlatSG1.ReadOnly = true;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlatSG1.RowHeadersDefaultCellStyle = dataGridViewCellStyle64;
            this.dgvFlatSG1.RowHeadersWidth = 10;
            this.dgvFlatSG1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFlatSG1.RowTemplate.Height = 16;
            this.dgvFlatSG1.Size = new System.Drawing.Size(142, 467);
            this.dgvFlatSG1.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn91
            // 
            this.dataGridViewTextBoxColumn91.DataPropertyName = "CajaId";
            this.dataGridViewTextBoxColumn91.HeaderText = "#Caja";
            this.dataGridViewTextBoxColumn91.Name = "dataGridViewTextBoxColumn91";
            this.dataGridViewTextBoxColumn91.ReadOnly = true;
            this.dataGridViewTextBoxColumn91.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn91.Width = 40;
            // 
            // dataGridViewTextBoxColumn92
            // 
            this.dataGridViewTextBoxColumn92.DataPropertyName = "Talla";
            this.dataGridViewTextBoxColumn92.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn92.Name = "dataGridViewTextBoxColumn92";
            this.dataGridViewTextBoxColumn92.ReadOnly = true;
            this.dataGridViewTextBoxColumn92.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn92.Width = 45;
            // 
            // dataGridViewTextBoxColumn93
            // 
            this.dataGridViewTextBoxColumn93.DataPropertyName = "Prendas";
            this.dataGridViewTextBoxColumn93.HeaderText = "Cant";
            this.dataGridViewTextBoxColumn93.Name = "dataGridViewTextBoxColumn93";
            this.dataGridViewTextBoxColumn93.ReadOnly = true;
            this.dataGridViewTextBoxColumn93.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn93.Width = 35;
            // 
            // dataGridViewTextBoxColumn94
            // 
            this.dataGridViewTextBoxColumn94.DataPropertyName = "TipoCaja";
            this.dataGridViewTextBoxColumn94.HeaderText = "TipoCaja";
            this.dataGridViewTextBoxColumn94.Name = "dataGridViewTextBoxColumn94";
            this.dataGridViewTextBoxColumn94.ReadOnly = true;
            this.dataGridViewTextBoxColumn94.Visible = false;
            this.dataGridViewTextBoxColumn94.Width = 5;
            // 
            // dataGridViewTextBoxColumn95
            // 
            this.dataGridViewTextBoxColumn95.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn95.HeaderText = "Id";
            this.dataGridViewTextBoxColumn95.Name = "dataGridViewTextBoxColumn95";
            this.dataGridViewTextBoxColumn95.ReadOnly = true;
            this.dataGridViewTextBoxColumn95.Visible = false;
            this.dataGridViewTextBoxColumn95.Width = 5;
            // 
            // dataGridViewTextBoxColumn96
            // 
            this.dataGridViewTextBoxColumn96.DataPropertyName = "CuttingID";
            this.dataGridViewTextBoxColumn96.HeaderText = "CuttingID";
            this.dataGridViewTextBoxColumn96.Name = "dataGridViewTextBoxColumn96";
            this.dataGridViewTextBoxColumn96.ReadOnly = true;
            this.dataGridViewTextBoxColumn96.Visible = false;
            this.dataGridViewTextBoxColumn96.Width = 5;
            // 
            // lblFlatSG2
            // 
            this.lblFlatSG2.Location = new System.Drawing.Point(177, 0);
            this.lblFlatSG2.Name = "lblFlatSG2";
            this.lblFlatSG2.Size = new System.Drawing.Size(100, 16);
            this.lblFlatSG2.TabIndex = 20;
            this.lblFlatSG2.Text = "Flat #";
            this.lblFlatSG2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblFlatSG1
            // 
            this.lblFlatSG1.Location = new System.Drawing.Point(16, 0);
            this.lblFlatSG1.Name = "lblFlatSG1";
            this.lblFlatSG1.Size = new System.Drawing.Size(100, 16);
            this.lblFlatSG1.TabIndex = 19;
            this.lblFlatSG1.Text = "Flat #";
            this.lblFlatSG1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(552, 24);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
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
            // dgtbcFSG1CuttingId
            // 
            this.dgtbcFSG1CuttingId.Format = "";
            this.dgtbcFSG1CuttingId.FormatInfo = null;
            this.dgtbcFSG1CuttingId.HeaderText = "CorteId";
            this.dgtbcFSG1CuttingId.MappingName = "CuttingId";
            this.dgtbcFSG1CuttingId.ReadOnly = true;
            this.dgtbcFSG1CuttingId.Width = 0;
            // 
            // dgtbcFSG1Id
            // 
            this.dgtbcFSG1Id.Format = "";
            this.dgtbcFSG1Id.FormatInfo = null;
            this.dgtbcFSG1Id.HeaderText = "Id";
            this.dgtbcFSG1Id.MappingName = "Id";
            this.dgtbcFSG1Id.ReadOnly = true;
            this.dgtbcFSG1Id.Width = 0;
            // 
            // dgtbcFSG1TipoCaja
            // 
            this.dgtbcFSG1TipoCaja.Format = "";
            this.dgtbcFSG1TipoCaja.FormatInfo = null;
            this.dgtbcFSG1TipoCaja.HeaderText = "Tipo";
            this.dgtbcFSG1TipoCaja.MappingName = "TipoCaja";
            this.dgtbcFSG1TipoCaja.ReadOnly = true;
            this.dgtbcFSG1TipoCaja.Width = 0;
            // 
            // dgtbcFSG1Prendas
            // 
            this.dgtbcFSG1Prendas.Format = "";
            this.dgtbcFSG1Prendas.FormatInfo = null;
            this.dgtbcFSG1Prendas.HeaderText = "Cant";
            this.dgtbcFSG1Prendas.MappingName = "Prendas";
            this.dgtbcFSG1Prendas.Width = 30;
            // 
            // dgtbcFSG1Talla
            // 
            this.dgtbcFSG1Talla.Format = "";
            this.dgtbcFSG1Talla.FormatInfo = null;
            this.dgtbcFSG1Talla.HeaderText = "Talla";
            this.dgtbcFSG1Talla.MappingName = "Talla";
            this.dgtbcFSG1Talla.ReadOnly = true;
            this.dgtbcFSG1Talla.Width = 35;
            // 
            // dgtbcFSG1CajaId
            // 
            this.dgtbcFSG1CajaId.Format = "";
            this.dgtbcFSG1CajaId.FormatInfo = null;
            this.dgtbcFSG1CajaId.HeaderText = "#Caja";
            this.dgtbcFSG1CajaId.MappingName = "CajaId";
            this.dgtbcFSG1CajaId.ReadOnly = true;
            this.dgtbcFSG1CajaId.Width = 35;
            // 
            // dgtbcFSG2CuttingId
            // 
            this.dgtbcFSG2CuttingId.Format = "";
            this.dgtbcFSG2CuttingId.FormatInfo = null;
            this.dgtbcFSG2CuttingId.HeaderText = "CorteId";
            this.dgtbcFSG2CuttingId.MappingName = "CuttingId";
            this.dgtbcFSG2CuttingId.ReadOnly = true;
            this.dgtbcFSG2CuttingId.Width = 0;
            // 
            // dgtbcFSG2Id
            // 
            this.dgtbcFSG2Id.Format = "";
            this.dgtbcFSG2Id.FormatInfo = null;
            this.dgtbcFSG2Id.HeaderText = "Id";
            this.dgtbcFSG2Id.MappingName = "Id";
            this.dgtbcFSG2Id.ReadOnly = true;
            this.dgtbcFSG2Id.Width = 0;
            // 
            // dgtbcFSG2TipoCaja
            // 
            this.dgtbcFSG2TipoCaja.Format = "";
            this.dgtbcFSG2TipoCaja.FormatInfo = null;
            this.dgtbcFSG2TipoCaja.HeaderText = "Tipo";
            this.dgtbcFSG2TipoCaja.MappingName = "TipoCaja";
            this.dgtbcFSG2TipoCaja.ReadOnly = true;
            this.dgtbcFSG2TipoCaja.Width = 0;
            // 
            // dgtbcFSG2Prendas
            // 
            this.dgtbcFSG2Prendas.Format = "";
            this.dgtbcFSG2Prendas.FormatInfo = null;
            this.dgtbcFSG2Prendas.HeaderText = "Cant";
            this.dgtbcFSG2Prendas.MappingName = "Prendas";
            this.dgtbcFSG2Prendas.Width = 30;
            // 
            // dgtbcFSG2Talla
            // 
            this.dgtbcFSG2Talla.Format = "";
            this.dgtbcFSG2Talla.FormatInfo = null;
            this.dgtbcFSG2Talla.HeaderText = "Talla";
            this.dgtbcFSG2Talla.MappingName = "Talla";
            this.dgtbcFSG2Talla.ReadOnly = true;
            this.dgtbcFSG2Talla.Width = 35;
            // 
            // dgtbcFSG2CajaId
            // 
            this.dgtbcFSG2CajaId.Format = "";
            this.dgtbcFSG2CajaId.FormatInfo = null;
            this.dgtbcFSG2CajaId.HeaderText = "#Caja";
            this.dgtbcFSG2CajaId.MappingName = "CajaId";
            this.dgtbcFSG2CajaId.ReadOnly = true;
            this.dgtbcFSG2CajaId.Width = 35;
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
            // dgtbcFST1Id
            // 
            this.dgtbcFST1Id.Format = "";
            this.dgtbcFST1Id.FormatInfo = null;
            this.dgtbcFST1Id.HeaderText = "Id";
            this.dgtbcFST1Id.MappingName = "Id";
            this.dgtbcFST1Id.ReadOnly = true;
            this.dgtbcFST1Id.Width = 0;
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
            // dgtbcFST1Prendas
            // 
            this.dgtbcFST1Prendas.Format = "";
            this.dgtbcFST1Prendas.FormatInfo = null;
            this.dgtbcFST1Prendas.HeaderText = "Cant";
            this.dgtbcFST1Prendas.MappingName = "Prendas";
            this.dgtbcFST1Prendas.Width = 30;
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
            // dgtbcFST1CajaId
            // 
            this.dgtbcFST1CajaId.Format = "";
            this.dgtbcFST1CajaId.FormatInfo = null;
            this.dgtbcFST1CajaId.HeaderText = "#Caja";
            this.dgtbcFST1CajaId.MappingName = "CajaId";
            this.dgtbcFST1CajaId.ReadOnly = true;
            this.dgtbcFST1CajaId.Width = 35;
            // 
            // dgsFlatST1
            // 
            this.dgsFlatST1.DataGrid = null;
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
            // dgtbcF4CuttingId
            // 
            this.dgtbcF4CuttingId.Format = "";
            this.dgtbcF4CuttingId.FormatInfo = null;
            this.dgtbcF4CuttingId.HeaderText = "CorteId";
            this.dgtbcF4CuttingId.MappingName = "CuttingId";
            this.dgtbcF4CuttingId.ReadOnly = true;
            this.dgtbcF4CuttingId.Width = 0;
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
            // dgtbcF4TipoCaja
            // 
            this.dgtbcF4TipoCaja.Format = "";
            this.dgtbcF4TipoCaja.FormatInfo = null;
            this.dgtbcF4TipoCaja.HeaderText = "Tipo";
            this.dgtbcF4TipoCaja.MappingName = "TipoCaja";
            this.dgtbcF4TipoCaja.ReadOnly = true;
            this.dgtbcF4TipoCaja.Width = 0;
            // 
            // dgtbcF4Prendas
            // 
            this.dgtbcF4Prendas.Format = "";
            this.dgtbcF4Prendas.FormatInfo = null;
            this.dgtbcF4Prendas.HeaderText = "Cant";
            this.dgtbcF4Prendas.MappingName = "Prendas";
            this.dgtbcF4Prendas.Width = 30;
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
            // dgtbcF4CajaId
            // 
            this.dgtbcF4CajaId.Format = "";
            this.dgtbcF4CajaId.FormatInfo = null;
            this.dgtbcF4CajaId.HeaderText = "#Caja";
            this.dgtbcF4CajaId.MappingName = "CajaId";
            this.dgtbcF4CajaId.ReadOnly = true;
            this.dgtbcF4CajaId.Width = 35;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlatTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlat1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatS3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatS1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatSC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatSC1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatST2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatST1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatSG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlatSG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

                this.dgvFlat1.DataSource = dvmDetalle1;
                this.dgvFlat2.DataSource = dvmDetalle1;
                this.dgvFlat3.DataSource = dvmDetalle1;
                this.dgvFlat4.DataSource = dvmDetalle1;
                this.dgvFlat5.DataSource = dvmDetalle1;
                this.dgvFlat6.DataSource = dvmDetalle1;
                this.dgvFlat7.DataSource = dvmDetalle1;
                this.dgvFlatS1.DataSource = dvmDetalle1;
                this.dgvFlatS2.DataSource = dvmDetalle1;
                this.dgvFlatS3.DataSource = dvmDetalle1;
				this.dgvFlatSC1.DataSource = dvmDetalle1;
				this.dgvFlatSC2.DataSource = dvmDetalle1;
                this.dgvFlatST1.DataSource = dvmDetalle1;
                this.dgvFlatST2.DataSource = dvmDetalle1;
                this.dgvFlatSG1.DataSource = dvmDetalle1;
                this.dgvFlatSG2.DataSource = dvmDetalle1;
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
            //Garras
            DataViewManager dvmDetalleFlatSG1;
            DataViewManager dvmDetalleFlatSG2;
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
            //Garras
            DataSet dsDetalleFlatSG1 = new DataSet();
            DataSet dsDetalleFlatSG2 = new DataSet();
			#endregion

			#region Primeras
			//FLAT1
			dsDetalleFlat1 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"1","25","0");
			dvmDetalleFlat1 = dsDetalleFlat1.DefaultViewManager;
			dvmDetalleFlat1.DataSet.Tables[0].TableName="TABLEPLFLAT1";			
			//this.dgFlat1.DataSource = dvmDetalleFlat1.DataSet.Tables[0];
            this.dgvFlat1.DataSource = dvmDetalleFlat1.DataSet.Tables[0];
			ilFlatNumber=ilFlatNumber+1;
			//FLAT2
			ilSumaFilas = dsDetalleFlat1.Tables[0].Rows.Count;
			dsDetalleFlat2 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"1","25",ilSumaFilas.ToString());
			dvmDetalleFlat2 = dsDetalleFlat2.DefaultViewManager;
			dvmDetalleFlat2.DataSet.Tables[0].TableName="TABLEPLFLAT2";			
			//this.dgFlat2.DataSource = dvmDetalleFlat2.DataSet.Tables[0];
            this.dgvFlat2.DataSource = dvmDetalleFlat2.DataSet.Tables[0];
			ilFlatNumber=ilFlatNumber+1;
			//FLAT3
			ilSumaFilas = dsDetalleFlat1.Tables[0].Rows.Count + dsDetalleFlat2.Tables[0].Rows.Count;
			dsDetalleFlat3 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"1","10",ilSumaFilas.ToString());
			dvmDetalleFlat3 = dsDetalleFlat3.DefaultViewManager;
			dvmDetalleFlat3.DataSet.Tables[0].TableName="TABLEPLFLAT3";
			//this.dgFlat3.DataSource = dvmDetalleFlat3.DataSet.Tables[0];
            this.dgvFlat3.DataSource = dvmDetalleFlat3.DataSet.Tables[0];
			ilFlatNumber=ilFlatNumber+1;
			//FLAT4
			ilSumaFilas = dsDetalleFlat1.Tables[0].Rows.Count + dsDetalleFlat2.Tables[0].Rows.Count +dsDetalleFlat3.Tables[0].Rows.Count;
			dsDetalleFlat4 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"1","10",ilSumaFilas.ToString());
			dvmDetalleFlat4 = dsDetalleFlat4.DefaultViewManager;
			dvmDetalleFlat4.DataSet.Tables[0].TableName="TABLEPLFLAT4";
			//this.dgFlat4.DataSource = dvmDetalleFlat4.DataSet.Tables[0];
            this.dgvFlat4.DataSource = dvmDetalleFlat4.DataSet.Tables[0];
			ilFlatNumber=ilFlatNumber+1;
			//FLAT5
			ilSumaFilas = dsDetalleFlat1.Tables[0].Rows.Count + dsDetalleFlat2.Tables[0].Rows.Count +dsDetalleFlat3.Tables[0].Rows.Count+dsDetalleFlat4.Tables[0].Rows.Count;
			dsDetalleFlat5 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"1","25",ilSumaFilas.ToString());
			dvmDetalleFlat5 = dsDetalleFlat5.DefaultViewManager;
			dvmDetalleFlat5.DataSet.Tables[0].TableName="TABLEPLFLAT5";
			//this.dgFlat5.DataSource = dvmDetalleFlat5.DataSet.Tables[0];
            this.dgvFlat5.DataSource = dvmDetalleFlat5.DataSet.Tables[0];
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
					//this.dgFlat6.DataSource = dvmDetalleFlat6.DataSet.Tables[0];
                    this.dgvFlat6.DataSource = dvmDetalleFlat6.DataSet.Tables[0];
					this.lblFlatTE2.Text="Flat # "+ilFlatNumber.ToString();
					ilFlatNumber=ilFlatNumber+1;

					//FLAT7
					ilSumaFilas = dsDetalleFlat1.Tables[0].Rows.Count + dsDetalleFlat2.Tables[0].Rows.Count +dsDetalleFlat3.Tables[0].Rows.Count+dsDetalleFlat4.Tables[0].Rows.Count+dsDetalleFlat5.Tables[0].Rows.Count+dsDetalleFlat6.Tables[0].Rows.Count;
					dsDetalleFlat7 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"1","25",ilSumaFilas.ToString());
					if((dsDetalleFlat7.Tables[0].Rows.Count>0)&&(dsDetalleFlat6.Tables.Count>0))
					{
						dvmDetalleFlat7 = dsDetalleFlat7.DefaultViewManager;
						dvmDetalleFlat7.DataSet.Tables[0].TableName="TABLEPLFLAT7";
						//this.dgFlat7.DataSource = dvmDetalleFlat7.DataSet.Tables[0];
                        this.dgvFlat7.DataSource = dvmDetalleFlat7.DataSet.Tables[0];
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
				this.dgvFlatS1.DataSource = dvmDetalleFlatS1.DataSet.Tables[0];
				this.lblFlatS1.Text="Flat # "+ilFlatNumber.ToString();
				ilFlatNumber=ilFlatNumber+1;				
			

				//FLATSaldos2
				ilSumaFilas = Convert.ToInt32(dsDetalleFlatS1.Tables[0].Rows[dsDetalleFlatS1.Tables[0].Rows.Count-1][0].ToString());
				dsDetalleFlatS2 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"4","25",ilSumaFilas.ToString());
				if(dsDetalleFlatS2.Tables[0].Rows.Count>0)
				{
					dvmDetalleFlatS2 = dsDetalleFlatS2.DefaultViewManager;
					dvmDetalleFlatS2.DataSet.Tables[0].TableName="TABLEPLFLATS2";
					this.dgvFlatS2.DataSource = dvmDetalleFlatS2.DataSet.Tables[0];
					this.lblFlatS2.Text="Flat # "+ilFlatNumber.ToString();
					ilFlatNumber=ilFlatNumber+1;				
				

					//FLATSaldos3
					ilSumaFilas = Convert.ToInt32(dsDetalleFlatS2.Tables[0].Rows[dsDetalleFlatS1.Tables[0].Rows.Count-1][0].ToString());
					dsDetalleFlatS3 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"4","35",ilSumaFilas.ToString());
					if(dsDetalleFlatS3.Tables[0].Rows.Count>0)
					{
						dvmDetalleFlatS3 = dsDetalleFlatS3.DefaultViewManager;
						dvmDetalleFlatS3.DataSet.Tables[0].TableName="TABLEPLFLATS3";
						this.dgvFlatS3.DataSource = dvmDetalleFlatS3.DataSet.Tables[0];
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
				this.dgvFlatSC1.DataSource = dvmDetalleFlatSC1.DataSet.Tables[0];
				this.lblFlatSC1.Text="Flat # "+ilFlatNumber.ToString();
				ilFlatNumber=ilFlatNumber+1;

				//FLATSegundas2
				ilSumaFilas = Convert.ToInt32(dsDetalleFlatSC1.Tables[0].Rows[dsDetalleFlatSC1.Tables[0].Rows.Count-1][0].ToString());
				dsDetalleFlatSC2 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"4","25",ilSumaFilas.ToString());
				if(dsDetalleFlatSC2.Tables[0].Rows.Count>0)
				{
					dvmDetalleFlatSC2 = dsDetalleFlatSC2.DefaultViewManager;
					dvmDetalleFlatSC2.DataSet.Tables[0].TableName="TABLEPLFLATSC2";
					this.dgvFlatSC2.DataSource = dvmDetalleFlatSC2.DataSet.Tables[0];
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
				this.dgvFlatST1.DataSource = dvmDetalleFlatST1.DataSet.Tables[0];
				this.lblFlatST1.Text="Flat # "+ilFlatNumber.ToString();
				ilFlatNumber=ilFlatNumber+1;

				//FLATTerceras2
				ilSumaFilas = Convert.ToInt32(dsDetalleFlatST1.Tables[0].Rows[dsDetalleFlatST1.Tables[0].Rows.Count-1][0].ToString());
				dsDetalleFlatST2 = SistEti.lpQueries.LlenaPLCT(this.sgCorte,"3","25",ilSumaFilas.ToString());
				if(dsDetalleFlatST2.Tables[0].Rows.Count>0)
				{
					dvmDetalleFlatST2 = dsDetalleFlatST2.DefaultViewManager;
					dvmDetalleFlatST2.DataSet.Tables[0].TableName="TABLEPLFlatST2";
					this.dgvFlatST2.DataSource = dvmDetalleFlatST2.DataSet.Tables[0];
					this.lblFlatST2.Text="Flat # "+ilFlatNumber.ToString();
					ilFlatNumber=ilFlatNumber+1;
				}
			}
			#endregion

            #region Garras
            //FLATGarras1
            ilSumaFilas = 0;
            dsDetalleFlatSG1 = SistEti.lpQueries.LlenaPLCT(this.sgCorte, "5", "25", ilSumaFilas.ToString());
            if (dsDetalleFlatSG1.Tables[0].Rows.Count > 0)
            {
                dvmDetalleFlatSG1 = dsDetalleFlatSG1.DefaultViewManager;
                dvmDetalleFlatSG1.DataSet.Tables[0].TableName = "TABLEPLFlatSG1";
                this.dgvFlatSG1.DataSource = dvmDetalleFlatSG1.DataSet.Tables[0];
                this.lblFlatSG1.Text = "Flat # " + ilFlatNumber.ToString();
                ilFlatNumber = ilFlatNumber + 1;

                //FLATGarras2
                ilSumaFilas = Convert.ToInt32(dsDetalleFlatSG1.Tables[0].Rows[dsDetalleFlatSG1.Tables[0].Rows.Count - 1][0].ToString());
                dsDetalleFlatSG2 = SistEti.lpQueries.LlenaPLCT(this.sgCorte, "5", "25", ilSumaFilas.ToString());
                if (dsDetalleFlatSG2.Tables[0].Rows.Count > 0)
                {
                    dvmDetalleFlatSG2 = dsDetalleFlatST2.DefaultViewManager;
                    dvmDetalleFlatSG2.DataSet.Tables[0].TableName = "TABLEPLFlatSG2";
                    this.dgvFlatSG2.DataSource = dvmDetalleFlatSG2.DataSet.Tables[0];
                    this.lblFlatSG2.Text = "Flat # " + ilFlatNumber.ToString();
                    ilFlatNumber = ilFlatNumber + 1;
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

			
			if(((DataTable)dgvFlat1.DataSource).Rows.Count>=1)
			{
				#region exporta primeras 5 tarimas si tienen datos
                slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas, ilNumeroTarima, this.dgvFlat1) + "\n";
				ilNumeroTarima=ilNumeroTarima+1;
                if (((DataTable)dgvFlat2.DataSource).Rows.Count >= 1)
				{
                    slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas, ilNumeroTarima, this.dgvFlat2) + "\n";
					ilNumeroTarima=ilNumeroTarima+1;
                    if (((DataTable)dgvFlat3.DataSource).Rows.Count >= 1)
					{
                        slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas, ilNumeroTarima, this.dgvFlat3) + "\n";
						ilNumeroTarima=ilNumeroTarima+1;
                        if (((DataTable)dgvFlat4.DataSource).Rows.Count >= 1)
						{
                            slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas, ilNumeroTarima, this.dgvFlat4) + "\n";
							ilNumeroTarima=ilNumeroTarima+1;
                            if (((DataTable)dgvFlat5.DataSource).Rows.Count >= 1)
							{
                                slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas, ilNumeroTarima, this.dgvFlat5) + "\n";
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
					if(((DataTable)dgvFlat6.DataSource).Rows.Count>=1)
					{
						slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas,ilNumeroTarima,this.dgvFlat6)+"\n";
						ilNumeroTarima=ilNumeroTarima++;
						if(((DataTable)dgvFlat7.DataSource).Rows.Count>=1)
						{
							slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSolidas,ilNumeroTarima,this.dgvFlat7)+"\n";
							ilNumeroTarima=ilNumeroTarima++;
						}
					}
				}
				#endregion

				#region Exporta Saldos
				try
				{
					if(((DataTable)this.dgvFlatS1.DataSource).Rows.Count>=1)
					{
					
						slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSaldos,ilNumeroTarima,this.dgvFlatS1)+"\n";
						ilNumeroTarima=ilNumeroTarima+1;
						if(((DataTable)dgvFlatS2.DataSource).Rows.Count>=1)
						{
							slArchivoHTML = slArchivoHTML + GeneraReporteEmbarque(slCajaSaldos,ilNumeroTarima,this.dgvFlatS2)+"\n";
							ilNumeroTarima=ilNumeroTarima+1;
						}
					}
				}
				catch
				{}
				#endregion

				#region Exporta Segundas , Terceras y Garras
				try
				{
					if(((DataTable)this.dgvFlatSC1.DataSource).Rows.Count>=1)
						slArchivoHTML = slArchivoHTML + GeneraReporteEmbarqueSegTer(slCajaSegundas,ilNumeroTarima,this.dgvFlatSC1,this.dgvFlatSC2);
					if(((DataTable)this.dgvFlatST1.DataSource).Rows.Count>=1)
						slArchivoHTML = slArchivoHTML + GeneraReporteEmbarqueSegTer(slCajaTerceras,ilNumeroTarima,this.dgvFlatST1,this.dgvFlatST2);
                    if(((DataTable)this.dgvFlatSG1.DataSource).Rows.Count>=1)
                        slArchivoHTML = slArchivoHTML + GeneraReporteEmbarqueSegTer(slCajaGarras, ilNumeroTarima, this.dgvFlatSG1, this.dgvFlatSG2);
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
                case "5":
                    slFlatType = "Rags";
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
        private string GeneraReporteEmbarque(string slTipoCaja, int ilFlatNumber, DataGridView dgDetalleFlat)
        {
            string slCorte = this.tbxCorte.Text;
            string slEstilo = this.tbEstilo.Text;
            string slContrato = this.tbContrato.Text;
            string slColor = this.tbColor.Text;
            string slArchivoHTML = "";

            string slFlatType = "";
            string slFlatNumber = "";
            string slCasesFlat = "";
            string slDozensFlat = "";
            string slTalla = "";
            string slPairs = "";
            string slTotalPairs = "0";
            int ilRow = 0;
            int ilNoCajaCons = 0;
            bool blCreaArchivo = true;
            int ilCTotalCajas = 0;

            //DataSet dsDetalle = new DataSet();			
            //dsDetalle = SistEti.lpQueries.LlenaPLCT(this.sgCorte,slTipoCaja,"100%","0");

            switch (slTipoCaja)
            {
                case "1":
                    slFlatType = "";
                    break;
                case "2":
                    slFlatType = "Seconds";
                    break;
                case "3":
                    slFlatType = "Thirds";
                    break;
                case "4":
                    slFlatType = "";
                    break;
                case "5":
                    slFlatType = "Rags";
                    break;
            }


            blCreaArchivo = true;
            //while(blCreaArchivo)
            {
                #region AchivoHTML slArchivoHTML

                string slEncabezado1 = "";
                string slEncabezado2 = "";
                string slDetalle = "";
                string slFooter = "";


                switch (ilFlatNumber)
                {
                    case 1:
                        ilCTotalCajas = ilCTotalCajas + 25;
                        break;
                    case 2:
                        ilCTotalCajas = ilCTotalCajas + 25;
                        break;
                    case 3:
                        ilCTotalCajas = ilCTotalCajas + 10;
                        break;
                    case 4:
                        ilCTotalCajas = ilCTotalCajas + 10;
                        break;
                    case 5:
                        ilCTotalCajas = ilCTotalCajas + 25;
                        break;
                    case 6:
                        if (slTipoCaja == "1")
                            ilCTotalCajas = ilCTotalCajas + 10;
                        else
                            ilCTotalCajas = ilCTotalCajas + 25;

                        break;
                    case 7:
                        if (slTipoCaja == "1")
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
                if (ilCTotalCajas > rowCount)
                {
                    ilCTotalCajas = rowCount;
                }
                if (rowCount == 0)
                    blCreaArchivo = false;

                #region Detalle
                slDetalle = slDetalle + @"			
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
                int ilCaja = 0;
                slTotalPairs = "0";
                for (ilRow = ilNoCajaCons; ilRow < ilCTotalCajas/*dsDetalle.Tables[0].Rows.Count*/; ilRow++)
                {
                    ilCaja = ilCaja + 1;
                    slTalla = ((DataTable)dgDetalleFlat.DataSource).Rows[ilRow][1].ToString();
                    slPairs = ((DataTable)dgDetalleFlat.DataSource).Rows[ilRow][2].ToString();
                    slTotalPairs = Convert.ToString(Convert.ToInt64(slTotalPairs) + Convert.ToInt64(slPairs));
                    slDetalle = slDetalle + @"		
						<TR>				
							<TD style=""WIDTH: 90px""><P align=""center"">" + Convert.ToString(ilRow + 1) + @"</P></TD>
							<TD style=""WIDTH: 58px""><P align=""center"">" + slTalla + @"</P></TD>
							<TD><P align=""center"">" + slPairs + @"</P></TD>";

                    slDetalle = slDetalle + @"
						</TR>";
                }
                ilNoCajaCons = ilRow;
                slDetalle = slDetalle + @"
					<TR>						
						<TD style=""WIDTH: 90px"" align=""center"">TOTAL</TD>
						<TD style=""WIDTH: 58px"" align=""center"">" + ilCaja.ToString() + @"</TD>						
						<TD align=""center"">" + slTotalPairs + @"</TD>						
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
                slDozensFlat = Convert.ToString(Math.Round(Convert.ToDouble(slTotalPairs) / 12, 2));

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
				<TD><P align=""center""><STRONG>&nbsp;" + slFlatType + @"</STRONG></P></TD>
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
				<TD><P align=""center""><STRONG>" + ilFlatNumber.ToString() + @"</STRONG></P></TD>
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
				<TD><P align=""center""><STRONG>" + slCorte + @"</STRONG></P></TD>
				<TD style=""WIDTH:4%;""></TD>
				<TD>MFG. STYLE No.</TD>
				<TD><STRONG><P align=""center"">" + slEstilo + @"</P>	</STRONG></TD>
				<TD style=""WIDTH:3%;""></TD>
			</TR>			
			<TR><!--Fila 9-->
				<TD style=""WIDTH:3%;""></TD>
				<TD>INTERNAL No.</TD>
				<TD><P align=""center""><STRONG>" + slContrato + @"</STRONG></P></TD>
				<TD style=""WIDTH:4%;""></TD>
				<TD>COLOR</TD>
				<TD><STRONG><P align=""center"">" + slColor + @"</P>	</STRONG></TD>
				<TD style=""WIDTH:3%;""></TD>
			</TR>			
			<TR><!--Fila 10-->
				<TD style=""WIDTH:3%;""></TD>
				<TD>CASES ON FLAT</TD>
				<TD><P align=""center""><STRONG>" + slCasesFlat + @"</STRONG></P></TD>
				<TD style=""WIDTH:4%;""></TD>
				<TD>DOZENS ON FLAT</TD>
				<TD><P align=""center""><STRONG>" + slDozensFlat + @"</STRONG></P></TD>
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
                ilRow = ilRow - 1;
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

                ilFlatNumber = ilFlatNumber + 1;
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
        private string GeneraReporteEmbarqueSegTer(string slTipoCaja, int ilFlatNumber, DataGridView dgDetalleFlat1, DataGridView dgDetalleFlat2)
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
                case "5":
                    slFlatType = "Rags";
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

        private string GeneraReporteEmbarqueSegTer(string slTipoCaja, int ilFlatNumber, DataGrid dgDetalleFlat1, DataGrid dgDetalleFlat2)
        {
            string slCorte = this.tbxCorte.Text;
            string slEstilo = this.tbEstilo.Text;
            string slContrato = this.tbContrato.Text;
            string slColor = this.tbColor.Text;
            string slArchivoHTML = "";

            string slFlatType = "";
            string slFlatNumber = "";
            string slCasesFlat = "0";
            string slDozensFlat = "0";
            string slTalla = "";
            string slPairs = "0";
            string slTotalPairs = "0";
            int ilRow = 0;
            int ilNoCajaCons = 0;
            bool blCreaArchivo = true;
            int ilCTotalCajas = 0;

            //DataSet dsDetalle = new DataSet();			
            //dsDetalle = SistEti.lpQueries.LlenaPLCT(this.sgCorte,slTipoCaja,"100%","0");

            switch (slTipoCaja)
            {
                case "1":
                    slFlatType = "";
                    break;
                case "2":
                    slFlatType = "Seconds";
                    break;
                case "3":
                    slFlatType = "Thirds";
                    break;
                case "4":
                    slFlatType = "";
                    break;
                case "5":
                    slFlatType = "Rags";
                    break;
            }


            blCreaArchivo = true;


            #region AchivoHTML slArchivoHTML

            string slEncabezado1 = "";
            string slEncabezado2 = "";
            string slDetalle = "";
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

            slDetalle = slDetalle + @"			
			<TR><!--Fila 13-->
				<TD ></TD>
				<TD colspan =""5"" height =""730"" valign=top>
					";
            slDetalle = slDetalle + @"
						<TABLE border=""0"" valign =top>
							<TR>
								<TD >
									" + generaDetalleTarima(dgDetalleFlat1, 0, ref slCasesFlat, ref slDozensFlat) + @"	
								</TD>";
            try
            {
                if (((DataTable)dgDetalleFlat2.DataSource).Rows.Count >= 1)
                {
                    slDetalle = slDetalle + @"
								<TD>
									" + generaDetalleTarima(dgDetalleFlat2, ((DataTable)dgDetalleFlat1.DataSource).Rows.Count, ref slCasesFlat, ref slDozensFlat) + @"
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
                slDetalle = slDetalle + @"
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
                rowCount = rowCount + ((DataTable)dgDetalleFlat2.DataSource).Rows.Count;
            }
            catch
            {
            }
            //slCasesFlat = rowCount.ToString();
            slDozensFlat = Convert.ToString(Math.Round(Convert.ToDouble(slDozensFlat) / 12, 2));

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
				<TD><P align=""center""><STRONG>&nbsp;" + slFlatType + @"</STRONG></P></TD>
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
				<TD><P align=""center""><STRONG>" + ilFlatNumber.ToString() + @"</STRONG></P></TD>
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
				<TD><P align=""center""><STRONG>" + slCorte + @"</STRONG></P></TD>
				<TD style=""WIDTH:4%;""></TD>
				<TD>MFG. STYLE No.</TD>
				<TD><STRONG><P align=""center"">" + slEstilo + @"</P>	</STRONG></TD>
				<TD style=""WIDTH:3%;""></TD>
			</TR>			
			<TR><!--Fila 9-->
				<TD style=""WIDTH:3%;""></TD>
				<TD>INTERNAL No.</TD>
				<TD><P align=""center""><STRONG>" + slContrato + @"</STRONG></P></TD>
				<TD style=""WIDTH:4%;""></TD>
				<TD>COLOR</TD>
				<TD><STRONG><P align=""center"">" + slColor + @"</P>	</STRONG></TD>
				<TD style=""WIDTH:3%;""></TD>
			</TR>			
			<TR><!--Fila 10-->
				<TD style=""WIDTH:3%;""></TD>
				<TD>CASES ON FLAT</TD>
				<TD><P align=""center""><STRONG>" + slCasesFlat + @"</STRONG></P></TD>
				<TD style=""WIDTH:4%;""></TD>
				<TD>DOZENS ON FLAT</TD>
				<TD><P align=""center""><STRONG>" + slDozensFlat + @"</STRONG></P></TD>
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
            ilRow = ilRow - 1;
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

            ilFlatNumber = ilFlatNumber + 1;

            //		return ilFlatNumber;
            return slArchivoHTML;
        }

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

        private string generaDetalleTarima(DataGridView dgDetalleFlat, int ilNoCajaCons, ref string slCases, ref string slTotalPairs)
        {
            int rowCount = ((DataTable)dgDetalleFlat.DataSource).Rows.Count + ilNoCajaCons;
            int ilRow = 0;

            string slDetalle = "";
            string slTalla = "";
            string slPairs = "";

            slDetalle = slDetalle + @"
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
            int ilCaja = 0;

            ilCaja = 1;
            string slCajaID = "";
            for (ilRow = ilNoCajaCons; ilRow < rowCount/*dsDetalle.Tables[0].Rows.Count*/; ilRow++)
            {
                slCajaID = ((DataTable)dgDetalleFlat.DataSource).Rows[ilRow][0].ToString();
                slTalla = ((DataTable)dgDetalleFlat.DataSource).Rows[ilRow][1].ToString();
                slPairs = ((DataTable)dgDetalleFlat.DataSource).Rows[ilRow][2].ToString(); 
                slTotalPairs = Convert.ToString(Convert.ToInt64(slTotalPairs) + Convert.ToInt64(slPairs));
                slDetalle = slDetalle + @"		
						<TR>				
							<TD style=""WIDTH: 90px""><P align=""center"">" + Convert.ToString(ilCaja) + @"</P></TD>
							<TD style=""WIDTH: 58px""><P align=""center"">" + slTalla + @"</P></TD>
							<TD><P align=""center"">" + slPairs + @"</P></TD>
						</TR>";
                if (ilRow + 1 < rowCount)
                {
                    if (slCajaID != ((DataTable)dgDetalleFlat.DataSource).Rows[ilRow+1][0].ToString())
                    {
                        ilCaja = ilCaja + 1;
                        slDetalle = slDetalle + @"		
						<TR>				
							<TD>&nbsp;</TD>
							<TD>&nbsp;</TD>
							<TD>&nbsp;</TD>
						</TR>";
                    }
                }
            }
            ilNoCajaCons = ilRow;
            slDetalle = slDetalle + @"
					<TR>						
						<TD style=""WIDTH: 90px"" align=""center"">TOTAL</TD>
						<TD style=""WIDTH: 58px"" align=""center"">" + ilCaja.ToString() + @"</TD>						
						<TD align=""center"">" + slTotalPairs + @"</TD>						
					</TR>			
				</table>
				";
            slCases = Convert.ToString(Convert.ToInt32(slCases) + ilCaja);
            return slDetalle;
        }

	}
}
