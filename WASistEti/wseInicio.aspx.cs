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
	/// Summary description for Inicio.
	/// </summary>
	public class Inicio : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button btnMostrar;
		protected System.Web.UI.WebControls.TextBox tbCorte;
		protected System.Web.UI.WebControls.DataGrid dgCortes;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.HtmlControls.HtmlInputHidden hdnControlFocus;
		protected System.Web.UI.WebControls.Label lblCortes;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if(!Page.IsPostBack)
			{
				//LlenaDataGrid();
				
			}
			hdnControlFocus.Value= this.tbCorte.ClientID;
		}

		private void LlenaDataGrid()
		{
			DataViewManager dvmDetalle;
			DataSet dsDetalle = new DataSet();
			dsDetalle.Clear();
			dsDetalle = WAQueries.LlenaListaCT(this.tbCorte.Text);
			dvmDetalle = dsDetalle.DefaultViewManager;
			this.dgCortes.DataSource = dsDetalle;
			this.dgCortes.DataBind();
			hdnControlFocus.Value= this.tbCorte.ClientID;
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
			this.tbCorte.TextChanged += new System.EventHandler(this.tbCorte_TextChanged);
			this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
			this.dgCortes.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgCortes_DeleteCommand);
			this.dgCortes.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.dgCortes_ItemDataBound_1);
			this.dgCortes.SelectedIndexChanged += new System.EventHandler(this.dgCortes_SelectedIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnMostrar_Click(object sender, System.EventArgs e)
		{
			LlenaDataGrid();
		}

		private void dgCortes_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			/*ListItemType listItemType =  (ListItemType)e.Item.ItemType;
			if ((listItemType == ListItemType.Item) || (listItemType == ListItemType.AlternatingItem))
			{
				string link = "<a href ='#' class='lateral' onclick = 'regresaValor(\""+ e.Item.Cells[0].Text+"\",\""+e.Item.Cells[0].Text+"\")'>Agregar</a>";
			}*/
		}

		private void dgCortes_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string slCorte = this.dgCortes.SelectedItem.Cells[2].Text;
			string slCorteID = this.dgCortes.SelectedItem.Cells[1].Text;
			Response.Redirect("wseTipoLectura.aspx?Corte="+slCorte+"&CorteID="+slCorteID);
		
		}

		private void dgCortes_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			if(e.CommandName.Equals("delete"))
				if((e.Item.ItemType == ListItemType.Item)||(e.Item.ItemType == ListItemType.AlternatingItem))
				{
					e.Item.Attributes.Add("onclick","return confirm('estas seguro de borrar la informacion de este corte?');");
				}
		}

		private void dgCortes_ItemDataBound_1(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if(e.Item.ItemIndex!=-1)
				e.Item.Cells[7].Attributes.Add("onclick","return confirm('¿Estas seguro de borrar la informacion de este corte?');");
//			ButtonColumn btn = (ButtonColumn).FindControl("Delete");
			
//			if(btn != null)
			{
//				btn.Attributes.Add("onclick","return confirm('¿Estas seguro de borrar la informacion de este corte?');");
			}
			
		}

		private void dgCortes_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			string slUsuario="";
			string slCorte = e.Item.Cells[2].Text;//this.dgCortes.SelectedItem.Cells[2].Text;		
			int ilResult = WAQueries.InicializaInfoSTEXEtiqueta(slCorte);
			if(ilResult!=-1)
				ilResult = WAQueries.ActualizaCorte(e.Item.Cells[1].Text,"",slUsuario);
			if(ilResult!=-1)
                Page.RegisterStartupScript("MessageBox","<SCRIPT>alert('La informacion del Corte se ha borrado correctamente.');</SCRIPT>");
			if(ilResult==-1)
                Page.RegisterStartupScript("MessageBox","<SCRIPT>alert('ERROR: La informacion del Corte no fue borrada.');</SCRIPT>");
		}

		private void tbCorte_TextChanged(object sender, System.EventArgs e)
		{
			LlenaDataGrid();
		}

		
	}
}
