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
	/// Summary description for wseTipoLectura.
	/// </summary>
	public class wseTipoLectura : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblNoCorte;
		protected System.Web.UI.WebControls.Label lblCorte;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.HyperLink Hyperlink1;
		protected System.Web.UI.WebControls.RadioButton RadioButton1;
		protected System.Web.UI.WebControls.RadioButton RadioButton2;
		protected System.Web.UI.WebControls.RadioButton RadioButton3;
		protected System.Web.UI.WebControls.Button btnContinuar;
		protected System.Web.UI.WebControls.RadioButton rbPrimeras;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			this.lblNoCorte.Text = Request.Params["Corte"].ToString();
			Session["CorteID"] = Request.Params["CorteID"].ToString();
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
			this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
			this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
			this.RadioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
			this.rbPrimeras.CheckedChanged += new System.EventHandler(this.rbPrimeras_CheckedChanged);
			this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnContinuar_Click(object sender, System.EventArgs e)
		{
			
			
		}

		private void rbPrimeras_CheckedChanged(object sender, System.EventArgs e)
		{
			Response.Redirect("wseVerificaEtiquetas1.aspx?Corte="+lblNoCorte.Text+"&CorteID="+Session["CorteID"]+"&TipoLect=1");
		}

		private void RadioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			Response.Redirect("wseVerificaEtiquetas1.aspx?Corte="+lblNoCorte.Text+"&CorteID="+Session["CorteID"]+"&TipoLect=2");
		}

		private void RadioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			Response.Redirect("wseVerificaEtiquetas1.aspx?Corte="+lblNoCorte.Text+"&CorteID="+Session["CorteID"]+"&TipoLect=3");
		}

		private void RadioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			Response.Redirect("wseVerificaEtiquetas1.aspx?Corte="+lblNoCorte.Text+"&CorteID="+Session["CorteID"]+"&TipoLect=4");
		}
	}
}
