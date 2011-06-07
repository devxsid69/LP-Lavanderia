using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;



namespace WASistEti
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblCorte;
		protected System.Web.UI.WebControls.TextBox tbEtiqueta;
		protected System.Web.UI.WebControls.Label lblEtiqueta;
		protected System.Web.UI.WebControls.Label lblNoCorte;
		protected System.Web.UI.HtmlControls.HtmlInputHidden hdnControlFocus;
		protected System.Web.UI.WebControls.DataGrid dgEtiquetas;
		protected System.Web.UI.HtmlControls.HtmlInputHidden hdnEstado;
		protected System.Web.UI.WebControls.HyperLink Hyperlink1;
		protected System.Web.UI.WebControls.Button btnGeneraReporte;
		protected System.Web.UI.WebControls.Button btnGuarda;
		protected System.Web.UI.WebControls.TextBox tbReport;
		protected System.Web.UI.WebControls.CheckBox cbxGrid;
		protected System.Web.UI.WebControls.CheckBox cbxReporte;
		protected System.Web.UI.WebControls.Button btnValida;

	
		/*
		 * ESTADOS DE PAGINA
		 * 1 = INICIO
		 * 2 = VALIDADA
		 * 3 = CON CAMBIOS
		 * */
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if(!Page.IsPostBack)
			{
				
				this.lblNoCorte.Text = Request.Params["Corte"].ToString();
				DataSet dsDetalle = new DataSet();			
				dsDetalle = WAQueries.llenaDetalleEtiCorte(Request.Params["Corte"].ToString());				
				llenaGrid(dsDetalle);
				ArrayList ilArray = new ArrayList();
				Session["ilArray"]=ilArray;
				ArrayList ilArrayNoExiste = new ArrayList();
				Session["ilArrayNoExiste"]=ilArrayNoExiste;

				
			}
			else
			{
				
			}
			hdnControlFocus.Value= this.tbEtiqueta.ClientID;
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.tbEtiqueta.TextChanged += new System.EventHandler(this.tbEtiqueta_TextChanged);
			this.btnValida.Click += new System.EventHandler(this.btnValida_Click);
			this.dgEtiquetas.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.dgEtiquetas_ItemDataBound);
			this.btnGeneraReporte.Click += new System.EventHandler(this.btnGeneraReporte_Click);
			this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
			this.cbxGrid.CheckedChanged += new System.EventHandler(this.cbxGrid_CheckedChanged);
			this.cbxReporte.CheckedChanged += new System.EventHandler(this.cbxReporte_CheckedChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnBuscar_Click(object sender, System.EventArgs e)
		{
			
		}

		private void llenaGrid(DataSet dsDetalle)
		{
			
			//DataSet dsDetalle = new DataSet();			
			//dsDetalle = WAQueries.llenaDetalleEtiCorte(Request.Params["Corte"].ToString());
			
			this.dgEtiquetas.DataSource = dsDetalle;
			this.dgEtiquetas.DataBind();
			Session["dsDetalle"]=dsDetalle;


		}

		private void tbEtiqueta_TextChanged(object sender, System.EventArgs e)
		{
			if(this.tbEtiqueta.Text!="")
			{
				ArrayList ilArray = new ArrayList();
				ilArray = (ArrayList)Session["ilArray"];
				ilArray.Add(this.tbEtiqueta.Text);
				Session["ilArray"]=ilArray;
				this.tbEtiqueta.Text="";
				hdnEstado.Value="3";
				this.btnGuarda.Visible=false;
				this.btnGeneraReporte.Visible=false;
			}
		}

		private void dgEtiquetas_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if((hdnEstado.Value=="2")||(hdnEstado.Value=="3"))
			{
				if(e.Item.ItemIndex!=-1)
				{
					string slTExt = e.Item.Cells[8].Text;
					if(Convert.ToInt32(e.Item.Cells[8].Text)>1)
					{
						e.Item.Cells[7].BackColor= Color.Red;
					}
					if(Convert.ToInt32(e.Item.Cells[8].Text)==0)
					{
						e.Item.Cells[7].BackColor= Color.Yellow;
					}
					if(Convert.ToInt32(e.Item.Cells[8].Text)==1)
					{
						e.Item.Cells[7].BackColor= Color.Green;
					}
				}
			}
		}

		private void btnValida_Click(object sender, System.EventArgs e)
		{				
			if((hdnEstado.Value=="1")||(hdnEstado.Value=="3"))
			{
				ArrayList ilArray = new ArrayList();
				ArrayList ilArrayNoExiste = new ArrayList();
				DataSet dsDetalle = new DataSet();
				
				ilArray = (ArrayList)Session["ilArray"];
				ilArrayNoExiste = (ArrayList)Session["ilArrayNoExiste"];				
				dsDetalle=(DataSet)Session["dsDetalle"];

				for(int ilCont =0; ilCont<ilArray.Count;ilCont++)
				{
					string slEtiquetaArray = (String)ilArray[ilCont];
					bool blExiste = false;
					
					for(int ilData=0;ilData< dsDetalle.Tables[0].Rows.Count;ilData++)
					{
						string slEtiqueta = dsDetalle.Tables[0].Rows[ilData][1].ToString();
						if(slEtiqueta==slEtiquetaArray)
						{
							int ilLect = Convert.ToInt32(dsDetalle.Tables[0].Rows[ilData][8]);
							ilLect=ilLect+1;
							dsDetalle.Tables[0].Rows[ilData][8]=(ilLect);
							dsDetalle.Tables[0].Rows[ilData][7]=(Convert.ToBoolean("true"));
							blExiste = true;
						}
					}
					if(blExiste==false)
					ilArrayNoExiste.Add(slEtiquetaArray);
					Session["dsDetalle"]=dsDetalle;
					llenaGrid(dsDetalle);
				}
				ilArray.Clear();
				Session["ilArray"]=ilArray;
				Session["ilArrayNoExiste"]=ilArrayNoExiste;
				hdnEstado.Value="2";
			}
			this.dgEtiquetas.Visible=true;
			this.cbxGrid.Checked=true;
			this.btnGuarda.Visible=true;
			this.btnGeneraReporte.Visible=true;
		}

		private void btnGuarda_Click(object sender, System.EventArgs e)
		{
		
		}

		private void btnGeneraReporte_Click(object sender, System.EventArgs e)
		{
			ArrayList ilArrayNoExiste = new ArrayList();
			ilArrayNoExiste = (ArrayList)Session["ilArrayNoExiste"];
			DataSet dsDetalle = new DataSet();
			dsDetalle=(DataSet)Session["dsDetalle"];
			
			string slCorrectos = "";
			string slRepetidos = "";
			string slFaltantes = "";
			string slNoExiste = "";
			int ilRegistros = 0;

			//Correctos 1
			for(int ilCont=0; ilCont < dsDetalle.Tables[0].Rows.Count; ilCont++)
			{
				if(dsDetalle.Tables[0].Rows[ilCont][8].ToString()=="1")
				{
					ilRegistros=ilRegistros+1;
					slCorrectos=slCorrectos+dsDetalle.Tables[0].Rows[ilCont][1].ToString()+"\n";
				}
				
			}
			slCorrectos ="ETIQUETAS CORRECTAS :"+ilRegistros.ToString()+"\n"+slCorrectos;
			ilRegistros=0;
			//Repetidos > 1 
			for(int ilCont=0; ilCont < dsDetalle.Tables[0].Rows.Count; ilCont++)
			{
				if(Convert.ToInt32(dsDetalle.Tables[0].Rows[ilCont][8].ToString())>1)
				{
					ilRegistros=ilRegistros+1;
					slRepetidos=slRepetidos+dsDetalle.Tables[0].Rows[ilCont][1].ToString()+", "+dsDetalle.Tables[0].Rows[ilCont][8].ToString()+"\n";
				}
			}
			slRepetidos ="ETIQUETAS REPETIDAS :"+ilRegistros.ToString()+"\n"+slRepetidos;
			ilRegistros=0;
			//Faltantes 0
			for(int ilCont=0; ilCont < dsDetalle.Tables[0].Rows.Count; ilCont++)
			{
				if(dsDetalle.Tables[0].Rows[ilCont][8].ToString()=="0")
				{
					ilRegistros=ilRegistros+1;
					slFaltantes=slFaltantes+dsDetalle.Tables[0].Rows[ilCont][1].ToString()+"\n";
				}
			}
			slFaltantes ="ETIQUETAS FALTANTES :"+ilRegistros.ToString()+"\n"+slFaltantes;
			ilRegistros=0;
			//NoPertenecen al Corte
			for(int ilCont=0; ilCont < ilArrayNoExiste.Count; ilCont++)
			{
				ilRegistros=ilRegistros+1;
				slNoExiste=slNoExiste+ilArrayNoExiste[ilCont].ToString()+"\n";				
			}
			slNoExiste ="ETIQUETAS INEXISTENTES EN CORTE :"+ilRegistros.ToString()+"\n"+slNoExiste;

			this.tbReport.Text=slCorrectos+slRepetidos+slFaltantes+slNoExiste;
			this.tbReport.Visible=true;
			this.cbxReporte.Checked=true;
		}

		private void cbxGrid_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.cbxGrid.Checked==true)
				this.dgEtiquetas.Visible=true;
			else
				this.dgEtiquetas.Visible=false;

		}

		private void cbxReporte_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.cbxReporte.Checked==true)
				this.tbReport.Visible=true;
			else
				this.tbReport.Visible=false;
		
		}
	}
}
