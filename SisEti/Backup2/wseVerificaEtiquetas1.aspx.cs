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
	public class wseVerificaEtiquetas1 : System.Web.UI.Page
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
		protected System.Web.UI.WebControls.Label lblEtiquetaAntc;
		protected System.Web.UI.WebControls.Label lblEtiquetaAnt;
		protected System.Web.UI.WebControls.Label lblResult;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label lblTotalLeidas;
		protected System.Web.UI.WebControls.Label lblTotalResta;
		protected System.Web.UI.WebControls.Label lblTotalCorte;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator1;
		protected System.Web.UI.WebControls.Button btnBorra;

	
		/*
		 * ESTADOS DE PAGINA
		 * 1 = Correcto
		 * 2 = No es Etiqueta
		 * 3 = 
		 * */
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if(!Page.IsPostBack)
			{
				
				this.lblNoCorte.Text = Request.Params["Corte"].ToString();
				DataSet dsDetalle = new DataSet();			
				dsDetalle = WAQueries.llenaDetalleEtiCorte(Request.Params["Corte"].ToString());				
				this.lblTotalCorte.Text = dsDetalle.Tables[0].Rows.Count.ToString();
				llenaGrid(dsDetalle);
				ArrayList ilArray = new ArrayList();
				Session["ilArray"]=ilArray;
				ArrayList ilArrayNoExiste = new ArrayList();
				
				dsDetalle = WAQueries.llenaDetalleEtiCorteId(Request.Params["CorteId"].ToString());
				string slNoExiste=dsDetalle.Tables[0].Rows[0][0].ToString();
				
				if(slNoExiste!="")
				{
					ilArrayNoExiste.AddRange(slNoExiste.Split(','));
				}
				Session["ilArrayNoExiste"]=ilArrayNoExiste;
				generaReporte();				
				//this.tbEtiqueta.Attributes.Add("onChange","evaluaTextBox('La informacion ingresada no es Valida?');");
				//hdnEstado.Value="1";

				
			}
			else
			{
				string slEtiq = this.lblEtiquetaAnt.Text;				
				
				for( int ilCont=slEtiq.Length;ilCont <7; ilCont++)
				{
					slEtiq="0"+slEtiq;
				}

				if(this.tbEtiqueta.Text==slEtiq)
				{
					this.lblMessage.Text = "La Etiqueta que estas leyendo acaba de ser ingresada.";
					this.lblMessage.Visible=true;
				}

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
			this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
			this.tbEtiqueta.TextChanged += new System.EventHandler(this.tbEtiqueta_TextChanged);
			this.cbxGrid.CheckedChanged += new System.EventHandler(this.cbxGrid_CheckedChanged);
			this.cbxReporte.CheckedChanged += new System.EventHandler(this.cbxReporte_CheckedChanged);
			this.btnBorra.Click += new System.EventHandler(this.btnBorra_Click);
			this.dgEtiquetas.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.dgEtiquetas_ItemDataBound);
			this.btnGeneraReporte.Click += new System.EventHandler(this.btnGeneraReporte_Click);
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

		#region Evalua Textbox Etiqueta Cuando Cambie
		private void tbEtiqueta_TextChanged(object sender, System.EventArgs e)
		{
				
			if(this.tbEtiqueta.Text.Length==7)
			{
				try
				{				
					string slEtiquetatb=Convert.ToInt32(this.tbEtiqueta.Text).ToString();
					if(this.tbEtiqueta.Text!="")
					{
				
						//ArrayList ilArray = new ArrayList();
						//ilArray = (ArrayList)Session["ilArray"];
						//ilArray.Add(this.tbEtiqueta.Text);
						//Session["ilArray"]=ilArray;
						ArrayList ilArrayNoExiste = new ArrayList();
						DataSet dsDetalle = new DataSet();
				
						//ilArray = (ArrayList)Session["ilArray"];
						ilArrayNoExiste = (ArrayList)Session["ilArrayNoExiste"];				
						dsDetalle=(DataSet)Session["dsDetalle"];

									
						bool blExiste = false;
					
						for(int ilData=0;ilData< dsDetalle.Tables[0].Rows.Count;ilData++)
						{
							string slEtiqueta = dsDetalle.Tables[0].Rows[ilData][1].ToString();
							if(slEtiqueta==slEtiquetatb)
							{
								int ilLect = Convert.ToInt32(dsDetalle.Tables[0].Rows[ilData][8]);
								ilLect=ilLect+1;
						
								dsDetalle.Tables[0].Rows[ilData][8]=(ilLect);
								dsDetalle.Tables[0].Rows[ilData][7]=(Convert.ToBoolean("true"));
								if(ilLect==1)
								{
									this.lblEtiquetaAnt.BackColor=Color.Green;
									this.lblResult.Text="Correcta";
									hdnEstado.Value="1";
								}
								if(ilLect>1)
								{
									this.lblEtiquetaAnt.BackColor=Color.Red;
									this.lblResult.Text="Repetida "+ilLect+" veces";
									hdnEstado.Value="2";
								}
						

								blExiste = true;
							}
						}
						if(blExiste==false)
						{
							ilArrayNoExiste.Add(slEtiquetatb);
							this.lblEtiquetaAnt.BackColor=Color.OrangeRed;
							this.lblResult.Text="No pertenece al Corte";
							hdnEstado.Value="3";
						}
						this.lblEtiquetaAnt.Text = slEtiquetatb;				
						Session["dsDetalle"]=dsDetalle;
						llenaGrid(dsDetalle);
				
						//ilArray.Clear();
						//Session["ilArray"]=ilArray;
						Session["ilArrayNoExiste"]=ilArrayNoExiste;


						//this.tbEtiqueta.Text="";
						//hdnEstado.Value="3";
						
						this.dgEtiquetas.Visible=false;
						this.cbxGrid.Checked=false;
						this.tbReport.Visible=false;
						this.cbxReporte.Checked=false;
						this.lblMessage.Visible=false;
						this.btnBorra.Enabled=true;

						this.lblTotalLeidas.Text = Convert.ToString(Convert.ToInt32(this.lblTotalLeidas.Text)+1);
						this.lblTotalResta.Text = Convert.ToString((Convert.ToInt32(this.lblTotalCorte.Text)-Convert.ToInt32(this.lblTotalLeidas.Text)));
						//this.tbEtiqueta.BackColor=Color.White;
					}
				}
				catch
				{
					this.lblMessage.Text="Informacion No Valida.";
					
					//this.tbEtiqueta.Text="";				
					//this.lblMessage.Visible=true;
					//this.tbEtiqueta.BackColor=Color.Red;
				}
			}
			else
			{
				//this.lblMessage.Visible=true;
				this.lblMessage.Text="Longitud No Valida.";
				//this.tbEtiqueta.BackColor=Color.Red;
				
			}
			
		}

		#endregion Evalua Textbox Etiqueta Cuando Cambie

		#region Datagrid ItemDataBound
		private void dgEtiquetas_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
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

		#endregion Datagrid ItemDataBound

		#region Commented
		private void btnValida_Click(object sender, System.EventArgs e)
		{				
			/*if((hdnEstado.Value=="1")||(hdnEstado.Value=="3"))
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
			this.btnGeneraReporte.Visible=true;*/
		}
		#endregion //commented

		#region Guardar
		private void btnGuarda_Click(object sender, System.EventArgs e)
		{
			DataSet dsDetalle = new DataSet();
			dsDetalle=(DataSet)Session["dsDetalle"];
			int ilResult = 0;
			for(int ilCont=0; ilCont < dsDetalle.Tables[0].Rows.Count; ilCont++)
			{
				string slEtiqueta=dsDetalle.Tables[0].Rows[ilCont][1].ToString();
				string slEstado=dsDetalle.Tables[0].Rows[ilCont][7].ToString();
				if(slEstado.ToLower()=="false")
					slEstado="0";
				else
					slEstado="1";
				string slExiste=dsDetalle.Tables[0].Rows[ilCont][8].ToString();
				ilResult = WAQueries.ActualizaInfoSTEXEtiqueta(slEtiqueta,slEstado,slExiste);			
			}
			ilResult = 0;
			ArrayList ilArrayNoExiste = new ArrayList();
			string slNoExiste="";
			ilArrayNoExiste = (ArrayList)Session["ilArrayNoExiste"];
			for(int ilCont=0; ilCont < ilArrayNoExiste.Count; ilCont++)
			{				
				if(slNoExiste!="")
					slNoExiste=slNoExiste+",";
				slNoExiste=slNoExiste+ilArrayNoExiste[ilCont].ToString();				
			}
			string slUsuarioRev=(string)Session["Usuario"];
			ilResult = WAQueries.ActualizaCorte(Request.Params["CorteID"].ToString(),slNoExiste,slUsuarioRev);			
		}

		#endregion //Guardar

		#region Boton REPORTE BORRADO
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
			slNoExiste ="ETIQUETAS QUE NO PERTENECEN AL CORTE :"+ilRegistros.ToString()+"\n"+slNoExiste;

			this.tbReport.Text=slCorrectos+slRepetidos+slNoExiste+slFaltantes;
			this.tbReport.Visible=true;
			this.cbxReporte.Checked=true;
		}

		#endregion Boton REPORTE BORRADO

		private void cbxGrid_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.cbxGrid.Checked==true)
				this.dgEtiquetas.Visible=true;
			else
				this.dgEtiquetas.Visible=false;

		}
	
		#region Reporte
		private void generaReporte()
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

			this.lblTotalLeidas.Text=ilRegistros.ToString();
			this.lblTotalResta.Text = Convert.ToString((Convert.ToInt32(this.lblTotalCorte.Text)-Convert.ToInt32(this.lblTotalLeidas.Text)));

			ilRegistros=0;
			//Repetidos > 1 
			int ilLectRepetida =0;
			for(int ilCont=0; ilCont < dsDetalle.Tables[0].Rows.Count; ilCont++)
			{
				if(Convert.ToInt32(dsDetalle.Tables[0].Rows[ilCont][8].ToString())>1)
				{
					ilRegistros=ilRegistros+1;
					ilLectRepetida=ilLectRepetida+Convert.ToInt32(dsDetalle.Tables[0].Rows[ilCont][8]);;
					slRepetidos=slRepetidos+dsDetalle.Tables[0].Rows[ilCont][1].ToString()+", "+dsDetalle.Tables[0].Rows[ilCont][8].ToString()+"\n";
				}
			}
			this.lblTotalLeidas.Text=Convert.ToString(ilLectRepetida+Convert.ToInt32(lblTotalLeidas.Text));
			this.lblTotalResta.Text = Convert.ToString((Convert.ToInt32(this.lblTotalCorte.Text)-Convert.ToInt32(this.lblTotalLeidas.Text)));
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
			slNoExiste ="ETIQUETAS QUE NO PERTENECEN AL CORTE :"+ilRegistros.ToString()+"\n"+slNoExiste;

			this.tbReport.Text=slCorrectos+slRepetidos+slNoExiste+slFaltantes;
			
			if(this.cbxReporte.Checked==true)
				this.tbReport.Visible=true;
			else
				this.tbReport.Visible=false;

		}

		#endregion //Reporte

		private void cbxReporte_CheckedChanged(object sender, System.EventArgs e)
		{
			generaReporte();
				
		}

		private void btnBorra_Click(object sender, System.EventArgs e)
		{
			switch(this.hdnEstado.Value)
			{
				case "1":
				//	break;
				case "2":
					DataSet dsDetalle = new DataSet();					
					dsDetalle=(DataSet)Session["dsDetalle"];

					for(int ilData=0;ilData< dsDetalle.Tables[0].Rows.Count;ilData++)
					{
						string slEtiqueta = dsDetalle.Tables[0].Rows[ilData][1].ToString();
						if(slEtiqueta==this.lblEtiquetaAnt.Text)
						{
							int ilLect = Convert.ToInt32(dsDetalle.Tables[0].Rows[ilData][8]);
							ilLect=ilLect-1;
						
							dsDetalle.Tables[0].Rows[ilData][8]=(ilLect);
							if(ilLect==0)
								dsDetalle.Tables[0].Rows[ilData][7]=(Convert.ToBoolean("false"));
							else
								dsDetalle.Tables[0].Rows[ilData][7]=(Convert.ToBoolean("true"));						
							
						}
					}
					Session["dsDetalle"]=dsDetalle;
					llenaGrid(dsDetalle);

					this.lblTotalLeidas.Text = Convert.ToString(Convert.ToInt32(this.lblTotalLeidas.Text)-1);
					this.lblTotalResta.Text = Convert.ToString((Convert.ToInt32(this.lblTotalCorte.Text)-Convert.ToInt32(this.lblTotalLeidas.Text)));

					this.lblEtiquetaAnt.Text="";
					this.lblResult.Text="";
					this.btnBorra.Enabled=false;
					
					break;				
				case "3":
					ArrayList ilArrayNoExiste = new ArrayList();					
					ilArrayNoExiste = (ArrayList)Session["ilArrayNoExiste"];
					if(ilArrayNoExiste.Count==0)
					{
						int ilIndex = ilArrayNoExiste.IndexOf(this.lblEtiquetaAnt.Text);
						ilArrayNoExiste.RemoveAt(ilIndex);
						Session["ilArrayNoExiste"]=ilArrayNoExiste;

						this.lblTotalLeidas.Text = Convert.ToString(Convert.ToInt32(this.lblTotalLeidas.Text)-1);
						this.lblTotalResta.Text = Convert.ToString((Convert.ToInt32(this.lblTotalCorte.Text)-Convert.ToInt32(this.lblTotalLeidas.Text)));

						this.lblEtiquetaAnt.Text="";
						this.lblResult.Text="";
						this.btnBorra.Enabled=false;
					}
					break;
				default:
					break;
			}
		}
	}
}
