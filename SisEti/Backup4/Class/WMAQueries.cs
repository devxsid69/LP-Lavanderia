using System;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace MWASistEti.Class
{
	/// <summary>
	/// Summary description for WMAQueries.
	/// </summary>
	public class WMAQueries
	{
		public WMAQueries()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static string obtenCadenaDeConexionTPS
		{
			get
			{
				return ConfigurationSettings.AppSettings["CadenaConexion"];
			}
		}	
	
		private static OleDbConnection Conection()
		{
			OleDbConnection odcConexion = new OleDbConnection(obtenCadenaDeConexionTPS);
			odcConexion.Open(); 
			return odcConexion;
		}
		
		private static DataSet LlenaDataSet(string sQuery)
		{
			DataSet dsUPCInf = new DataSet();
			OleDbConnection odcConexion = Conection();
			OleDbCommand odcSelect = new OleDbCommand(sQuery,odcConexion);
			OleDbDataAdapter odaAdapter = new OleDbDataAdapter(odcSelect);
			odaAdapter.Fill(dsUPCInf);
			odcConexion.Close();
			return dsUPCInf;
		}		

		private static int EjecutaInsert(string sQuery)
		{
			int iResult=0;
			OleDbConnection odcConexion = Conection();
			OleDbCommand odcInsert = new OleDbCommand(sQuery,odcConexion);
			//OleDbDataAdapter odaAdapter = new OleDbDataAdapter(odcSelect);
			iResult = odcInsert.ExecuteNonQuery();
			odcConexion.Close();
			return iResult;
		}

		
		public static DataSet LlenaListaEtiqPorCorte(string slCorte)
		{
			DataSet dsInf = new DataSet();
			string slQuery = @"SELECT tbCuttingTicket.NoCorte, tbTicketDet.EtiquetaId as Etiqueta,UPC, tipocaja , talla,prendas FROM tbTicketDet INNER JOIN (tbCuttingTicketDet 
INNER JOIN tbCuttingTicket ON tbCuttingTicketDet.cuttingID = tbCuttingTicket.Id) ON tbTicketDet.EtiquetaId = tbCuttingTicketDet.Id
WHERE tbCuttingTicket.NoCorte= """+slCorte+@"""";
			dsInf = LlenaDataSet(slQuery);
			return(dsInf);

		}
	}
	
}
