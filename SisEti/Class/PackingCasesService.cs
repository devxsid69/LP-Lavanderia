using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SisEti.Class
{
    public class PackingCasesService
    {
        public List<PackingCases> ObtenerPackinList(string idCorte, string sTipoCaja, string slCasesCant, string slNextCase)
        {
            List<PackingCases> listResult = new List<PackingCases>();
            DataSet dsDetalleFlat=SistEti.lpQueries.LlenaPLCT(idCorte, sTipoCaja, slCasesCant, slNextCase);

            foreach (DataRow item in dsDetalleFlat.Tables[0].Rows)
            {
                PackingCases entItem = new PackingCases() { 
                    CajaId = item["CajaID"].ToString(),
                    CuttingID = item["CuttingID"].ToString(),
                    Id = item["id"].ToString(),
                    Prendas = item["Prendas"].ToString(),
                    Talla = item["Talla"].ToString(),
                    TipoCaja = item["TipoCaja"].ToString()
                };
            }

            return listResult;
        }
    }
}
