using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SisEti.Entities;

namespace SistEti
{
    public partial class FAcabado : System.Windows.Forms.Form
    {
        public Acabado entAcabado;
        
        public FAcabado()
        {
            InitializeComponent();
        }

        private void FAcabado_Load(object sender, EventArgs e)
        {
            entAcabado = new Acabado();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((tbxClave.Text != "") && (tbxEtiqueta.Text != "") && (tbxDescripcion.Text != ""))
            {
                bool bExisteAcabado = false;
                entAcabado.Number = int.Parse(tbxClave.Text);
                entAcabado.DescripcionEtiqueta = tbxEtiqueta.Text;
                entAcabado.Descripcion = tbxDescripcion.Text;
                if (entAcabado.IdAcabado == 0)
                    bExisteAcabado  = SistEti.lpQueries.VerificaExisteAcabado(entAcabado.Number);
                if (!bExisteAcabado)
                {
                    entAcabado.IdAcabado = SistEti.lpQueries.GuardaAcabado(entAcabado);
                    MessageBox.Show("La información se guardo correctamente.", "Informacion Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La clave de acabado ya existe.", "Informacion Existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }                
            }
            else
            {
                MessageBox.Show("Debe Ingresar toda la información.", "Informacion Requerida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FBuscarAcabado FBuscarAcabado = new FBuscarAcabado();
            FBuscarAcabado.ShowDialog(this);
            entAcabado = FBuscarAcabado.entAcabado;
            if (entAcabado.IdAcabado != 0)
            {
                this.tbxClave.Text = entAcabado.Number.ToString();
                this.tbxEtiqueta.Text = entAcabado.DescripcionEtiqueta.ToString();
                this.tbxDescripcion.Text = entAcabado.Descripcion;
            }
        }

        
    }
}
