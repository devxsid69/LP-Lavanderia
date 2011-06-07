using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SisEti.Entities;

namespace SistEti
{
    public partial class FBuscarAcabado : Form
    {
        public Acabado entAcabado;
        public FBuscarAcabado()
        {
            InitializeComponent();
        }

        private void FBuscarAcabado_Load(object sender, EventArgs e)
        {
            entAcabado = new Acabado();
            LlenaDetalle("");
        }

        private void LlenaDetalle(string sAcabado)
        {
            DataViewManager dvmAcabado = new DataViewManager();
            DataSet dsAcabado = new DataSet();
            dsAcabado.Clear();
            dsAcabado = SistEti.lpQueries.ObtenAcabadoBusqueda(sAcabado);
            dvmAcabado = dsAcabado.DefaultViewManager;

            dgvAcabados.DataSource = dvmAcabado.DataSet.Tables[0];
            dgvAcabados.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAcabados_MouseUp(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo info = this.dgvAcabados.HitTest(e.X, e.Y);

            switch (info.Type)
            { 
                case DataGridViewHitTestType.Cell:
                    
                    entAcabado.IdAcabado = int.Parse(this.dgvAcabados.Rows[info.RowIndex].Cells[0].Value.ToString());
                    entAcabado.Number = int.Parse(this.dgvAcabados.Rows[info.RowIndex].Cells[1].Value.ToString());
                    entAcabado.DescripcionEtiqueta = this.dgvAcabados.Rows[info.RowIndex].Cells[2].Value.ToString();
                    entAcabado.Descripcion = this.dgvAcabados.Rows[info.RowIndex].Cells[3].Value.ToString();
                    this.Close();
                    break;
            }
        }
    }
}
