using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.Mobile;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.MobileControls;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using MWASistEti.Class;

namespace MWASistEti
{
	/// <summary>
	/// Summary description for inicio.
	/// </summary>
	public class inicio : System.Web.UI.MobileControls.MobilePage
	{
		protected System.Web.UI.MobileControls.Label lblCorte;
		protected System.Web.UI.MobileControls.TextBox tbCorte;
		protected System.Web.UI.MobileControls.Command btnBusca;
		protected System.Web.UI.WebControls.DataGrid dgResultado;
		protected System.Web.UI.MobileControls.Form Form1;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			int i= 1;
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
			this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
			this.dgResultado.ItemCreated += new System.Web.UI.WebControls.DataGridItemEventHandler(this.dgResultado_ItemCreated);
			this.dgResultado.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.dgResultado_ItemDataBound);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnBusca_Click(object sender, System.EventArgs e)
		{
			llenaDataGrid();
		}

		private void llenaDataGrid()
		{
			DataSet dsRes= new DataSet();
			dsRes = Class.WMAQueries.LlenaListaEtiqPorCorte(this.tbCorte.Text);
			this.dgResultado.DataSource = dsRes ;
			this.dgResultado.DataBind();

		}

		private void dgResultado_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			
			ListItemType listItemType = (ListItemType)e.Item.ItemType;
			if ((listItemType == ListItemType.Item) || (listItemType == ListItemType.AlternatingItem))
			{
				e.Item.Cells[7].Text = Convert.ToString((e.Item.ItemIndex+1));
			}

			if (listItemType == ListItemType.Header)
			{
				CheckBox cblSeleccionTodos = ((CheckBox)(e.Item.Cells[0].FindControl("CheckBoxSeleccionaTodos")));
				//cblSeleccionTodos.Attributes.Add("onclick","SelDeselecciona()");
		
			}
		}

		private void dgResultado_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			string slSelDeseccionaTodo="";

			ListItemType listItemType = (ListItemType)e.Item.ItemType;
			if (listItemType == ListItemType.Footer)
			{
				slSelDeseccionaTodo += 
					@"
				<script>
				function SelDeselecciona()
				{
					var valorDeChecado = false;

					if (Form1.DataGridResultadosBusqueda__ctl1_CheckBoxSeleccionaTodos.checked == false)
					{
						valorDeChecado = false;
					}
					else
					{
						valorDeChecado = true;
					}

				";

				for (int ilI = 0; ilI < this.dgResultado.Items.Count; ilI++)
				{
					CheckBox cblSeleccion = ((CheckBox)(this.dgResultado.Items[ilI].Cells[0].FindControl("CheckBoxSeleccion")));
					/*slSelDeseccionaTodo += 
						@"
					Form1."+cblSeleccion.ClientID+".checked = valorDeChecado;";*/
				}

				slSelDeseccionaTodo += 
					@"
				}
				</script>

				";
			//	this.estableceEtapaDePagina(EP.CodigoParaSeleccionarYDeseleccionarLosCheckBoxes.Valor, slSelDeseccionaTodo);
		
			}
		}
	}
}
