using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SistEti
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FSistEtiq : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mimOpcion1;
		private System.Windows.Forms.MenuItem mimOpcion2;
		private System.Windows.Forms.MenuItem mimOpcion3;
		private System.Windows.Forms.MenuItem mimOpcion5;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem5;
        private MenuItem menuItem9;
        private MenuItem miAcabados;
        private MenuItem miEstilos;
        private IContainer components;

		public FSistEtiq()
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mimOpcion1 = new System.Windows.Forms.MenuItem();
            this.mimOpcion5 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mimOpcion2 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mimOpcion3 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.miAcabados = new System.Windows.Forms.MenuItem();
            this.miEstilos = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mimOpcion1,
            this.menuItem9});
            // 
            // mimOpcion1
            // 
            this.mimOpcion1.Index = 0;
            this.mimOpcion1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mimOpcion5,
            this.menuItem1,
            this.menuItem4,
            this.menuItem6,
            this.mimOpcion3,
            this.menuItem3});
            this.mimOpcion1.Text = "Opciones";
            // 
            // mimOpcion5
            // 
            this.mimOpcion5.Index = 0;
            this.mimOpcion5.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.mimOpcion5.Text = "Capturar Cutting Ticket";
            this.mimOpcion5.Click += new System.EventHandler(this.mimOpcion5_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mimOpcion2,
            this.menuItem2});
            this.menuItem1.Text = "Leer Etiquetas";
            // 
            // mimOpcion2
            // 
            this.mimOpcion2.Index = 0;
            this.mimOpcion2.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.mimOpcion2.Text = "Primeras";
            this.mimOpcion2.Click += new System.EventHandler(this.mimOpcion2_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuItem2.Text = "Saldos, Segundas o Terceras";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.menuItem4.Text = "Packing List";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7,
            this.menuItem8,
            this.menuItem5});
            this.menuItem6.Text = "Imprimir";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlI;
            this.menuItem7.Text = "Imprimir por  No. de Etiqueta";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.menuItem8.Text = "Imprimir Etiqueta";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "Informacion Etiquetas";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click_1);
            // 
            // mimOpcion3
            // 
            this.mimOpcion3.Index = 4;
            this.mimOpcion3.Shortcut = System.Windows.Forms.Shortcut.CtrlI;
            this.mimOpcion3.Text = "Importar Cutting Ticket";
            this.mimOpcion3.Visible = false;
            this.mimOpcion3.Click += new System.EventHandler(this.mimOpcion3_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 5;
            this.menuItem3.Text = "Salir";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miAcabados,
            this.miEstilos});
            this.menuItem9.Text = "Catalogos";
            // 
            // miAcabados
            // 
            this.miAcabados.Index = 0;
            this.miAcabados.Text = "Acabados";
            this.miAcabados.Click += new System.EventHandler(this.miAcabados_Click);
            // 
            // miEstilos
            // 
            this.miEstilos.Index = 1;
            this.miEstilos.Text = "Estilos";
            this.miEstilos.Click += new System.EventHandler(this.miEstilos_Click);
            // 
            // FSistEtiq
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1112, 585);
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu1;
            this.Name = "FSistEtiq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FSistEtiq_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FSistEtiq());
		}

		private void FSistEtiq_Load(object sender, System.EventArgs e)
		{
		
		}

		private void mimOpcion2_Click(object sender, System.EventArgs e)
		{
			FLeerEtiq FLeerEtiqueta = new FLeerEtiq();
			FLeerEtiqueta.MdiParent = this;
			FLeerEtiqueta.Show();
	
		}

		private void mimOpcion3_Click(object sender, System.EventArgs e)
		{
			FImportaCT FImportar = new FImportaCT();
			FImportar.MdiParent = this;
			FImportar.Show();			
		}

		private void mimOpcion4_Click(object sender, System.EventArgs e)
		{
			
		}

		private void mimOpcion5_Click(object sender, System.EventArgs e)
		{
			FCapturaCT FCapturar = new FCapturaCT();
			FCapturar.MdiParent = this;
			FCapturar.Show();	
		
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			FLeerEtiqSST FLeerEtiquetaSST = new FLeerEtiqSST();
			FLeerEtiquetaSST.MdiParent = this;
			FLeerEtiquetaSST.Show();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			FPakingList FPList = new FPakingList();
			FPList.MdiParent = this;
			FPList.Show();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
				
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			FImprimeEtiqID FImprimirID = new FImprimeEtiqID();
			FImprimirID.MdiParent = this;
			FImprimirID.Show();	
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			FImprimeEtiq FImprimir = new FImprimeEtiq();
			FImprimir.MdiParent = this;
			FImprimir.Show();	
		}

		private void menuItem5_Click_1(object sender, System.EventArgs e)
		{
			FInfImpEtiq FInfoEtiq = new FInfImpEtiq();
			FInfoEtiq.MdiParent = this;
			FInfoEtiq.Show();	

		}

        private void miAcabados_Click(object sender, EventArgs e)
        {
            FAcabado FAcabado = new FAcabado();
            FAcabado.MdiParent = this;
            FAcabado.Show();
        }

        private void miEstilos_Click(object sender, EventArgs e)
        {
            FEstilo FEstilo = new FEstilo();
            FEstilo.MdiParent = this;
            FEstilo.Show();
        }

		
	}
}
