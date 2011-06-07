using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace SistEti
{
	/// <summary>
	/// Summary description for FImprimeEtiqID.
	/// </summary>
	public class FImprimeEtiqID : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Button btAceptar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox gbCorte;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TextBox tbEtiquetaID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btPrevisualizar;
		private System.Windows.Forms.Label lblTallaT;
		private System.Windows.Forms.Label lblUPCT;
		private System.Windows.Forms.Label lblTalla;
		private System.Windows.Forms.Label lblUPC;
		private System.Windows.Forms.Label lblCorte;
		private System.Windows.Forms.Label lblCorteT;
		private System.Windows.Forms.Label lblEstilo;
		private System.Windows.Forms.Label lblEstiloT;
		private System.Windows.Forms.Label lblContrato;
		private System.Windows.Forms.Label lblContratoT;
		private System.Windows.Forms.Label lblColor;
		private System.Windows.Forms.Label lblColorT;
		private System.Windows.Forms.Label lblPrendas;
		private System.Windows.Forms.Label lblPrendasT;
		private System.Windows.Forms.GroupBox gbxBoxType;
		private System.Windows.Forms.RadioButton rbnBoxType4;
		private System.Windows.Forms.RadioButton rbnBoxType3;
		private System.Windows.Forms.RadioButton rbnBoxType2;
		private System.Windows.Forms.RadioButton rbnBoxType1;
		private System.Windows.Forms.Button btImprime;
		private string sgTipoCaja ="1";
		private string sgCorteId="";
        private RadioButton rbnBoxType5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FImprimeEtiqID()
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCorte = new System.Windows.Forms.GroupBox();
            this.btImprime = new System.Windows.Forms.Button();
            this.gbxBoxType = new System.Windows.Forms.GroupBox();
            this.rbnBoxType4 = new System.Windows.Forms.RadioButton();
            this.rbnBoxType3 = new System.Windows.Forms.RadioButton();
            this.rbnBoxType2 = new System.Windows.Forms.RadioButton();
            this.rbnBoxType1 = new System.Windows.Forms.RadioButton();
            this.lblPrendasT = new System.Windows.Forms.Label();
            this.lblPrendas = new System.Windows.Forms.Label();
            this.lblColorT = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblContratoT = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.lblEstiloT = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblCorteT = new System.Windows.Forms.Label();
            this.lblCorte = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblUPC = new System.Windows.Forms.Label();
            this.lblTallaT = new System.Windows.Forms.Label();
            this.lblUPCT = new System.Windows.Forms.Label();
            this.btPrevisualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEtiquetaID = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.rbnBoxType5 = new System.Windows.Forms.RadioButton();
            this.gbCorte.SuspendLayout();
            this.gbxBoxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(80, 8);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 30;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(184, 8);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 32;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Contraseña:";
            // 
            // gbCorte
            // 
            this.gbCorte.Controls.Add(this.btImprime);
            this.gbCorte.Controls.Add(this.gbxBoxType);
            this.gbCorte.Controls.Add(this.lblPrendasT);
            this.gbCorte.Controls.Add(this.lblPrendas);
            this.gbCorte.Controls.Add(this.lblColorT);
            this.gbCorte.Controls.Add(this.lblColor);
            this.gbCorte.Controls.Add(this.lblContratoT);
            this.gbCorte.Controls.Add(this.lblContrato);
            this.gbCorte.Controls.Add(this.lblEstiloT);
            this.gbCorte.Controls.Add(this.lblEstilo);
            this.gbCorte.Controls.Add(this.lblCorteT);
            this.gbCorte.Controls.Add(this.lblCorte);
            this.gbCorte.Controls.Add(this.lblTalla);
            this.gbCorte.Controls.Add(this.lblUPC);
            this.gbCorte.Controls.Add(this.lblTallaT);
            this.gbCorte.Controls.Add(this.lblUPCT);
            this.gbCorte.Controls.Add(this.btPrevisualizar);
            this.gbCorte.Controls.Add(this.label1);
            this.gbCorte.Controls.Add(this.tbEtiquetaID);
            this.gbCorte.Location = new System.Drawing.Point(16, 40);
            this.gbCorte.Name = "gbCorte";
            this.gbCorte.Size = new System.Drawing.Size(592, 368);
            this.gbCorte.TabIndex = 33;
            this.gbCorte.TabStop = false;
            this.gbCorte.Visible = false;
            // 
            // btImprime
            // 
            this.btImprime.Location = new System.Drawing.Point(504, 328);
            this.btImprime.Name = "btImprime";
            this.btImprime.Size = new System.Drawing.Size(75, 23);
            this.btImprime.TabIndex = 54;
            this.btImprime.Text = "Imprimir";
            this.btImprime.Visible = false;
            this.btImprime.Click += new System.EventHandler(this.btImprime_Click);
            // 
            // gbxBoxType
            // 
            this.gbxBoxType.Controls.Add(this.rbnBoxType5);
            this.gbxBoxType.Controls.Add(this.rbnBoxType4);
            this.gbxBoxType.Controls.Add(this.rbnBoxType3);
            this.gbxBoxType.Controls.Add(this.rbnBoxType2);
            this.gbxBoxType.Controls.Add(this.rbnBoxType1);
            this.gbxBoxType.Location = new System.Drawing.Point(16, 312);
            this.gbxBoxType.Name = "gbxBoxType";
            this.gbxBoxType.Size = new System.Drawing.Size(435, 48);
            this.gbxBoxType.TabIndex = 53;
            this.gbxBoxType.TabStop = false;
            this.gbxBoxType.Text = "Tipo de Etiqueta";
            // 
            // rbnBoxType4
            // 
            this.rbnBoxType4.Location = new System.Drawing.Point(280, 16);
            this.rbnBoxType4.Name = "rbnBoxType4";
            this.rbnBoxType4.Size = new System.Drawing.Size(80, 24);
            this.rbnBoxType4.TabIndex = 3;
            this.rbnBoxType4.Text = "Saldos";
            // 
            // rbnBoxType3
            // 
            this.rbnBoxType3.Location = new System.Drawing.Point(192, 16);
            this.rbnBoxType3.Name = "rbnBoxType3";
            this.rbnBoxType3.Size = new System.Drawing.Size(80, 24);
            this.rbnBoxType3.TabIndex = 2;
            this.rbnBoxType3.Text = "Terceras";
            // 
            // rbnBoxType2
            // 
            this.rbnBoxType2.Location = new System.Drawing.Point(104, 16);
            this.rbnBoxType2.Name = "rbnBoxType2";
            this.rbnBoxType2.Size = new System.Drawing.Size(80, 24);
            this.rbnBoxType2.TabIndex = 1;
            this.rbnBoxType2.Text = "Segundas";
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
            // 
            // lblPrendasT
            // 
            this.lblPrendasT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrendasT.Location = new System.Drawing.Point(104, 272);
            this.lblPrendasT.Name = "lblPrendasT";
            this.lblPrendasT.Size = new System.Drawing.Size(176, 23);
            this.lblPrendasT.TabIndex = 52;
            this.lblPrendasT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrendas
            // 
            this.lblPrendas.Location = new System.Drawing.Point(24, 272);
            this.lblPrendas.Name = "lblPrendas";
            this.lblPrendas.Size = new System.Drawing.Size(64, 23);
            this.lblPrendas.TabIndex = 51;
            this.lblPrendas.Text = "PRENDAS";
            this.lblPrendas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorT
            // 
            this.lblColorT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblColorT.Location = new System.Drawing.Point(104, 176);
            this.lblColorT.Name = "lblColorT";
            this.lblColorT.Size = new System.Drawing.Size(176, 23);
            this.lblColorT.TabIndex = 50;
            this.lblColorT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(40, 176);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(48, 24);
            this.lblColor.TabIndex = 49;
            this.lblColor.Text = "COLOR";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContratoT
            // 
            this.lblContratoT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblContratoT.Location = new System.Drawing.Point(104, 144);
            this.lblContratoT.Name = "lblContratoT";
            this.lblContratoT.Size = new System.Drawing.Size(176, 23);
            this.lblContratoT.TabIndex = 48;
            this.lblContratoT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContrato
            // 
            this.lblContrato.Location = new System.Drawing.Point(16, 144);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(72, 23);
            this.lblContrato.TabIndex = 47;
            this.lblContrato.Text = "CONTRATO";
            this.lblContrato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstiloT
            // 
            this.lblEstiloT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEstiloT.Location = new System.Drawing.Point(104, 112);
            this.lblEstiloT.Name = "lblEstiloT";
            this.lblEstiloT.Size = new System.Drawing.Size(176, 23);
            this.lblEstiloT.TabIndex = 46;
            this.lblEstiloT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstilo
            // 
            this.lblEstilo.Location = new System.Drawing.Point(40, 112);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(48, 23);
            this.lblEstilo.TabIndex = 45;
            this.lblEstilo.Text = "ESTILO";
            this.lblEstilo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorteT
            // 
            this.lblCorteT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCorteT.Location = new System.Drawing.Point(104, 80);
            this.lblCorteT.Name = "lblCorteT";
            this.lblCorteT.Size = new System.Drawing.Size(176, 23);
            this.lblCorteT.TabIndex = 44;
            this.lblCorteT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorte
            // 
            this.lblCorte.Location = new System.Drawing.Point(40, 80);
            this.lblCorte.Name = "lblCorte";
            this.lblCorte.Size = new System.Drawing.Size(48, 23);
            this.lblCorte.TabIndex = 43;
            this.lblCorte.Text = "CORTE";
            this.lblCorte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTalla
            // 
            this.lblTalla.Location = new System.Drawing.Point(48, 240);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(40, 24);
            this.lblTalla.TabIndex = 42;
            this.lblTalla.Text = "TALLA";
            this.lblTalla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUPC
            // 
            this.lblUPC.Location = new System.Drawing.Point(48, 208);
            this.lblUPC.Name = "lblUPC";
            this.lblUPC.Size = new System.Drawing.Size(40, 24);
            this.lblUPC.TabIndex = 41;
            this.lblUPC.Text = "UPC";
            this.lblUPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTallaT
            // 
            this.lblTallaT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTallaT.Location = new System.Drawing.Point(104, 240);
            this.lblTallaT.Name = "lblTallaT";
            this.lblTallaT.Size = new System.Drawing.Size(176, 23);
            this.lblTallaT.TabIndex = 40;
            this.lblTallaT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUPCT
            // 
            this.lblUPCT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblUPCT.Location = new System.Drawing.Point(104, 208);
            this.lblUPCT.Name = "lblUPCT";
            this.lblUPCT.Size = new System.Drawing.Size(176, 23);
            this.lblUPCT.TabIndex = 39;
            this.lblUPCT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btPrevisualizar
            // 
            this.btPrevisualizar.Location = new System.Drawing.Point(192, 16);
            this.btPrevisualizar.Name = "btPrevisualizar";
            this.btPrevisualizar.Size = new System.Drawing.Size(88, 23);
            this.btPrevisualizar.TabIndex = 2;
            this.btPrevisualizar.Text = "Previsualizar";
            this.btPrevisualizar.Click += new System.EventHandler(this.btPrevisualizar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etiqueta ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEtiquetaID
            // 
            this.tbEtiquetaID.Location = new System.Drawing.Point(80, 16);
            this.tbEtiquetaID.Name = "tbEtiquetaID";
            this.tbEtiquetaID.Size = new System.Drawing.Size(100, 20);
            this.tbEtiquetaID.TabIndex = 0;
            this.tbEtiquetaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtiquetaID_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(528, 416);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // rbnBoxType5
            // 
            this.rbnBoxType5.Location = new System.Drawing.Point(349, 16);
            this.rbnBoxType5.Name = "rbnBoxType5";
            this.rbnBoxType5.Size = new System.Drawing.Size(80, 24);
            this.rbnBoxType5.TabIndex = 4;
            this.rbnBoxType5.Text = "Garras";
            // 
            // FImprimeEtiqID
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(634, 448);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbCorte);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FImprimeEtiqID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FImprimeEtiqID";
            this.gbCorte.ResumeLayout(false);
            this.gbCorte.PerformLayout();
            this.gbxBoxType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void btAceptar_Click(object sender, System.EventArgs e)
		{
			if(this.tbPassword.Text==ConfigurationSettings.AppSettings["PasswordETN"])
			{
				gbCorte.Visible = true;
				this.tbEtiquetaID.Focus();
			}
			else
			{
				MessageBox.Show("Contraseña Incorrecta, intente Nuevamente.", "Contraseña Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		private void btnCancelar_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void CargaInfEtiq()
		{
			try
			{
			
				if(this.tbEtiquetaID.Text!="")
				{
					DataSet dsDetalle = new DataSet();			
					dsDetalle = SistEti.lpQueries.LlenaEtiquetaporID(this.tbEtiquetaID.Text);	
					if((dsDetalle.Tables.Count>0)&&(dsDetalle.Tables[0].Rows.Count>0))
					{
						this.lblCorteT.Text = dsDetalle.Tables[0].Rows[0][0].ToString();
						this.lblContratoT.Text = dsDetalle.Tables[0].Rows[0][1].ToString();
						this.lblEstiloT.Text = dsDetalle.Tables[0].Rows[0][2].ToString();
						this.lblColorT.Text = dsDetalle.Tables[0].Rows[0][3].ToString();
						this.lblUPCT.Text = dsDetalle.Tables[0].Rows[0][4].ToString();					
						this.lblPrendasT.Text = dsDetalle.Tables[0].Rows[0][5].ToString();
						this.lblTallaT.Text = dsDetalle.Tables[0].Rows[0][6].ToString();
						this.sgCorteId = dsDetalle.Tables[0].Rows[0][8].ToString();
			
						#region Evalua Tipo de Etiqueta (Primeras, Segundas, Terceras, Saldos)
						switch(dsDetalle.Tables[0].Rows[0][7].ToString())
						{
							case "1" :
								this.rbnBoxType1.Checked=true;
								this.rbnBoxType1.Enabled=true;
								this.rbnBoxType2.Enabled=false;
								this.rbnBoxType3.Enabled=false;
								this.rbnBoxType4.Enabled=false;
                                this.rbnBoxType5.Enabled = false;
								sgTipoCaja="1";
								break;
							case "2" :
								this.rbnBoxType2.Checked=true;
								this.rbnBoxType1.Enabled=false;
								this.rbnBoxType2.Enabled=true;
								this.rbnBoxType3.Enabled=false;
								this.rbnBoxType4.Enabled=false;
                                this.rbnBoxType5.Enabled = false;
								sgTipoCaja="2";
								break;
							case "3" :
								this.rbnBoxType3.Checked=true;
								this.rbnBoxType1.Enabled=false;
								this.rbnBoxType2.Enabled=false;
								this.rbnBoxType3.Enabled=true;
								this.rbnBoxType4.Enabled=false;
                                this.rbnBoxType5.Enabled = false;
								sgTipoCaja="3";
								break;
							case "4" :
								this.rbnBoxType4.Checked=true;
								this.rbnBoxType1.Enabled=false;
								this.rbnBoxType2.Enabled=false;
								this.rbnBoxType3.Enabled=false;
								this.rbnBoxType4.Enabled=true;
                                this.rbnBoxType5.Enabled = false;
								sgTipoCaja="4";
								break;
                            case "5":
                                this.rbnBoxType5.Checked = true;
                                this.rbnBoxType1.Enabled = false;
                                this.rbnBoxType2.Enabled = false;
                                this.rbnBoxType3.Enabled = false;
                                this.rbnBoxType4.Enabled = false;
                                this.rbnBoxType5.Enabled = true;
                                sgTipoCaja = "5";
                                break;
						}
						#endregion

						this.btImprime.Visible=true;

					}
					else
					{
						this.lblCorteT.Text = "";
						this.lblContratoT.Text = "";
						this.lblEstiloT.Text = "";
						this.lblColorT.Text = "";
						this.lblUPCT.Text = "";
						this.lblTallaT.Text = "";
						this.lblPrendasT.Text = "";
						MessageBox.Show("El No. de Etiqueta No Existe.", "Informacion Invalida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
						this.tbEtiquetaID.Text="";
						this.tbEtiquetaID.Focus();
					}
				}
			}
			catch
			{
				MessageBox.Show("Ingrese un No. de Etiqueta valida.", "Informacion Invalida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				this.tbEtiquetaID.Text="";
				this.tbEtiquetaID.Focus();
			}
		}


		private void btPrevisualizar_Click(object sender, System.EventArgs e)
		{
			CargaInfEtiq();						
		}

		private void btImprime_Click(object sender, System.EventArgs e)
		{
			string slMessage = "";
			slMessage = SistEti.lpUtils.Imprime(this.lblCorteT.Text,this.lblContratoT.Text,this.lblEstiloT.Text,this.lblTallaT.Text,this.lblPrendasT.Text,this.lblUPCT.Text,this.lblColorT.Text,sgTipoCaja,this.tbEtiquetaID.Text);

			actualizaInfEitq();
			
			if(slMessage!="")
				MessageBox.Show(slMessage, "ERROR DE IMPRESION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
		}

		private void actualizaInfEitq()
		{
			int ilContImp=1;
			int ilResult =0;
			DataSet dsInfoEtiq = new DataSet();
			dsInfoEtiq = SistEti.lpQueries.obtenInfoEtiq(this.tbEtiquetaID.Text);
			
			string slFecha = DateTime.Now.ToString();
			if((dsInfoEtiq.Tables.Count>0)&&(dsInfoEtiq.Tables[0].Rows.Count>0))
			{
				ilContImp = Convert.ToInt32(dsInfoEtiq.Tables[0].Rows[0][1].ToString());
				ilContImp++;
				ilResult = SistEti.lpQueries.ActualizaEtiqInfo(this.tbEtiquetaID.Text,ilContImp.ToString(),slFecha);
			}
			else
			{
				
					string slEtiquetaId = SistEti.lpQueries.traeEtiquetaId(this.lblUPCT.Text,this.sgCorteId);
					if(slEtiquetaId!="0")
					{						
						int iResultEtiq = SistEti.lpQueries.InsertaInformacionEtiq(this.tbEtiquetaID.Text,slFecha,ConfigurationSettings.AppSettings["NomPC"]);
					}				
			}

		}

		private void tbEtiquetaID_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)Keys.Return)
			{	
				CargaInfEtiq();
				this.btImprime.Focus();
			}
		}
	}
}
