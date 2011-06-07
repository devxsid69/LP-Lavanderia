using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
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
	/// Summary description for wseLogin.
	/// </summary>
	public class wseLogin : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblUsuario;
		protected System.Web.UI.WebControls.Label lblContraseña;
		protected System.Web.UI.WebControls.Button btnEntrar;
		protected System.Web.UI.WebControls.TextBox tbCotraseña;
		protected System.Web.UI.WebControls.TextBox tbUsuario;
		protected System.Web.UI.WebControls.Label lblError;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.Label lblTitulo;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
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
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnEntrar_Click(object sender, System.EventArgs e)
		{
			string slUsuario = this.tbUsuario.Text;
			string slContraseña = this.tbCotraseña.Text;
			bool blUsuarioValido = true;
			if(slContraseña !=ConfigurationSettings.AppSettings["Contraseña"].ToString())
				blUsuarioValido=false;
			if(blUsuarioValido)
			{
				Session["Usuario"]=slUsuario;
				Response.Redirect("wseInicio.aspx");
			}
			else
			{
				this.lblError.Text="La contraseña ingresada es erronea.";

			}
			
		}
	}
}
