using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlServerCe;
//using System.ComponentModel;
//using System.Collections;
//using System.Collections.Specialized;
//using System.ComponentModel;

namespace SDASisEti.Class
{
	/// <summary>
	/// Summary description for lpSDAQueries.
	/// </summary>
	public class lpSDAQueries
	{
		public static string strpCadenaConexionLectora = "Data Source=\\Program Files\\CapturaInventario\\tps.sdf";

		public lpSDAQueries()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		private static SqlConnection Conection()
		{
			SqlConnection odcConexion = new SqlConnection(strpCadenaConexionLectora);
			odcConexion.Open(); 
			return odcConexion;
		}
		
		private static DataSet LlenaDataSet(string sQuery)
		{
			DataSet dsUPCInf = new DataSet();
			SqlConnection odcConexion = Conection();
			SqlCommand odcSelect = new SqlCommand(sQuery,odcConexion);
			SqlDataAdapter odaAdapter = new SqlDataAdapter(odcSelect);
			odaAdapter.Fill(dsUPCInf);
			odcConexion.Close();
			return dsUPCInf;
		}		

		private static int EjecutaInsert(string sQuery)
		{
			int iResult=0;
			SqlConnection odcConexion = Conection();
			SqlCommand odcInsert = new SqlCommand(sQuery,odcConexion);
			//OleDbDataAdapter odaAdapter = new OleDbDataAdapter(odcSelect);
			iResult = odcInsert.ExecuteNonQuery();
			odcConexion.Close();
			return iResult;
		}

		#region public static                   DataSet generaDataSetConSelectQueryCE             (string straSelectQuery)
		public static DataSet generaDataSetConSelectQueryCE(string straSelectQuery)
		{
			DataSet dslQueryGeneral = new DataSet();
		
			SqlCeDataAdapter sqlCeDatAdalAdaptador = new SqlCeDataAdapter(straSelectQuery, strpCadenaConexionLectora);
			try
			{
				sqlCeDatAdalAdaptador.Fill(dslQueryGeneral);
			}
			catch //(Exception e)
			{
				return null;
			}

			return dslQueryGeneral;
		}
		#endregion
	}
}
