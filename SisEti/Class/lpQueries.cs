using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

using SisEti.Entities;

namespace SistEti
{
	/// <summary>
	/// Summary description for lpQueries.
	/// </summary>
	/// 
	public class lpQueries
	{
		public static string obtenCadenaDeConexionTPS
		{
			get
			{
				return ConfigurationSettings.AppSettings["CadenaConexion"];
			}
		}
		//private const string sCadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = c:\BD LP ETAPA 2\BD - LP - Lavado y Confeccion.accdb";
		public lpQueries()
		{
			//
			// TODO: Add constructor logic here
			//
			
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

        private static int EjecutaInsertRegresaMaxID(string sQuery, string sIdField, string slTable)
        {
            int iResult = 0;
            OleDbConnection odcConexion = Conection();
            OleDbCommand odcInsert = new OleDbCommand(sQuery, odcConexion);
            //OleDbDataAdapter odaAdapter = new OleDbDataAdapter(odcSelect);
            iResult = odcInsert.ExecuteNonQuery();
            odcConexion.Close();
            if (iResult == 1)
            {
                DataSet dsMaxID = new DataSet();
                sQuery = String.Format("Select Max({0}) from {1}",sIdField,slTable);
                dsMaxID = LlenaDataSet(sQuery);
                iResult = Convert.ToInt32(dsMaxID.Tables[0].Rows[0][0].ToString());
            }
            return iResult;
        }

		#region Commented
//		private static int EjecutaInsert(string sQuery,OleDbTransaction odtTrans,OleDbConnection odcConexion)
//		{
//			int iResult=0;			
//			//OleDbConnection odcConexion = Conection();
//			OleDbCommand odcInsert = new OleDbCommand(sQuery,odcConexion,odtTrans);
//			//OleDbDataAdapter odaAdapter = new OleDbDataAdapter(odcSelect);
//			iResult = odcInsert.ExecuteNonQuery();
//			
//			return iResult;
//		}

//		private static int EjecutaInsertRegresaRegistro(string sQuery,OleDbTransaction odtTrans,OleDbConnection odcConexion)
//		{
//			int iResult=0;
//			OleDbCommand odcInsert = new OleDbCommand(sQuery,odcConexion,odtTrans);
//			iResult = odcInsert.ExecuteNonQuery();
//			
//			if(iResult==1)
//			{
//				DataSet dsUPCInf = new DataSet();
//				sQuery = "Select Max(id) from tbCuttingTicket";
//				dsUPCInf = LlenaDataSet(sQuery);
//				if(dsUPCInf.Tables[0].Rows[0][0].ToString()=="")
//				{
//					iResult = 1;
//				}
//				else
//				{
//					iResult = Convert.ToInt32(dsUPCInf.Tables[0].Rows[0][0].ToString());
//				}
//			}
//			
//			return iResult;
//		}

//		private static DataSet LlenaDataSet(string sQuery,OleDbTransaction odtTrans,OleDbConnection odcConexion)
//		{
//			DataSet dsUPCInf = new DataSet();			
//			OleDbCommand odcSelect = new OleDbCommand(sQuery,odcConexion,odtTrans);
//			OleDbDataAdapter odaAdapter = new OleDbDataAdapter(odcSelect);
//			odaAdapter.Fill(dsUPCInf);
//			odcConexion.Close();
//			return dsUPCInf;
//		}

//		public static int UpdateTallaCorte(int sCuttingID, string sTalla, int iPrendas,OleDbTransaction odtTrans,OleDbConnection odcConexion)
//		{
//			int iResult = 0;			
//			string sQuery = @"Update tbCuttingTicket SET "+sTalla+"= "+iPrendas.ToString()+" where id ="+sCuttingID.ToString()+";";
//			iResult = EjecutaInsert(sQuery,odtTrans,odcConexion);
//			return iResult;
//		}

//		public static int InsertaCorte(string sCorte, string sContrato, string sEstilo, string sColor,OleDbTransaction odtTrans,OleDbConnection odcConexion)
//		{
//			int iResult = 0;			
//			string sQuery = @"INSERT INTO tbCuttingTicket ( NoCorte, Contrato, Estilo, Color ) VALUES ("""+sCorte+@""","""+sContrato+@""", """+sEstilo+@""","""+sColor+@""");";
//			iResult = EjecutaInsertRegresaRegistro(sQuery,odtTrans,odcConexion);
//			return iResult;
//		}
		#endregion //Commented

		#region public static DataSet VerificaUPC(string sUPC,string sEstilo)
		public static DataSet VerificaUPC(string sUPC,string sEstilo)
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = "Select Estilo, Talla, UPC, Prendas From tbUPC where UPC = '"+sUPC+"' and Estilo ='"+sEstilo+"'";
			//OleDbConnection odcConexion = Conection();
			//OleDbCommand odcSelect = new OleDbCommand(sQuery,odcConexion);
			//OleDbDataAdapter odaAdapter = new OleDbDataAdapter(odcSelect);
			dsUPCInf = LlenaDataSet(sQuery);
			//"Select Estilo, Talla, UPC, Prendas From tbUPC where UPC = '"+sUPC+"'";
			return dsUPCInf;
		}
		#endregion //public static DataSet VerificaUPC(string sUPC,string sEstilo)

		#region public static DataSet VerificaTOTPrendasxCORTE(string sUPC,string sEstilo)
		public static DataSet VerificaTOTPrendasxCORTE(string sUPC,string sIDCorte,string sTipoCaja)
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = "Select IIF(SUM(PRENDAS) is null,0,SUM(PRENDAS)) From tbCuttingTicketDet where UPC = '"+sUPC+"' and CuttingID ="+sIDCorte+" and TipoCaja = "+sTipoCaja+" Group by CuttingID,UPC";
			//OleDbConnection odcConexion = Conection();
			//OleDbCommand odcSelect = new OleDbCommand(sQuery,odcConexion);
			//OleDbDataAdapter odaAdapter = new OleDbDataAdapter(odcSelect);
			dsUPCInf = LlenaDataSet(sQuery);
			//"Select Estilo, Talla, UPC, Prendas From tbUPC where UPC = '"+sUPC+"'";
			return dsUPCInf;
		}
		#endregion //public static DataSet VerificaUPC(string sUPC,string sEstilo)

		#region private static int EjecutaInsertRegresaRegistro(string sQuery)
		private static int EjecutaInsertRegresaRegistro(string sQuery)
		{
			int iResult=0;
			OleDbConnection odcConexion = Conection();
			OleDbCommand odcInsert = new OleDbCommand(sQuery,odcConexion);
			//OleDbDataAdapter odaAdapter = new OleDbDataAdapter(odcSelect);
			iResult = odcInsert.ExecuteNonQuery();
			odcConexion.Close();
			if(iResult==1)
			{
				DataSet dsUPCInf = new DataSet();
				sQuery = "Select Max(id) from tbCuttingTicket";
				dsUPCInf = LlenaDataSet(sQuery);
				iResult=Convert.ToInt32(dsUPCInf.Tables[0].Rows[0][0].ToString());
			}
			
			return iResult;
		}
		#endregion //private static int EjecutaInsertRegresaRegistro(string sQuery)
	
		#region public static int InsertaCaja(string sCuttingID, string sColor, string sTalla, string sCajaPedido,string sUPC, string CajaPrendas,string sTipoCaja)
		public static int InsertaCaja(string sCuttingID, string sColor, string sTalla, string sCajaPedido,string sUPC, string CajaPrendas,string sTipoCaja, string slCajaID)
		{
			int iResult = 0;
			//string sQuery = @"INSERT INTO tbCuttingTicketDet ( CuttingId, Color, Talla, CajaPedido, UPC, Prendas ) VALUES (1, ""Light SW"", ""44x30"", 24, ""754819077318"", 24);";
			//, (SELECT TOP 1 IIF(tbCuttingTicketDet.CajaID is null, 0,tbCuttingTicketDet.CajaID) FROM tbCuttingTicketDet where CuttingId = "+sCuttingID+@" ORDER BY tbCuttingTicketDet.cuttingID,tbCuttingTicketDet.CajaID DESC)
			string sQuery = @"INSERT INTO tbCuttingTicketDet ( CuttingId, Color, Talla, CajaPedido, UPC, Prendas ,TipoCaja,CajaID  ) VALUES ("+sCuttingID+@", """+sColor+@""", """+sTalla+@""","+sCajaPedido+@", """+sUPC+@""", "+CajaPrendas+@","+sTipoCaja+@","+slCajaID+@");";
			iResult = EjecutaInsert(sQuery);
			return iResult;
		}
		#endregion //public static int InsertaCaja(string sCuttingID, string sColor, string sTalla, string sCajaPedido,string sUPC, string CajaPrendas,string sTipoCaja)
		
		#region public static int InsertaCorte(string sCorte, string sContrato, string sEstilo, string sColor)
		public static int InsertaCorte(string sCorte, string sContrato, string sEstilo, string sColor, string slFecha)
		{
			int iResult = 0;			
			string sQuery = @"INSERT INTO tbCuttingTicket ( NoCorte, Contrato, Estilo, Color,Fecha ) VALUES ("""+sCorte+@""","""+sContrato+@""", """+sEstilo+@""","""+sColor+@""","""+slFecha+@""");";
			iResult = EjecutaInsertRegresaRegistro(sQuery);
			return iResult;
		}
		#endregion //public static int InsertaCorte(string sCorte, string sContrato, string sEstilo, string sColor)

        #region public static int InsertaInformacionEtiq(string sEtiquetaId,string sFecha, string sPCImp)
        public static int InsertaInformacionEtiq(string sEtiquetaId,string sFecha, string sPCImp)
		{
			int iResult = 0;
			
			string sQuery = @"INSERT INTO tbTicketDet ( EtiquetaId, ContadorImp, FechaImp, UltFechaImp,PCImp ) VALUES ("+sEtiquetaId+@",1,"""+sFecha+@""","""+sFecha+@""","""+sPCImp+@""");";
			iResult = EjecutaInsertRegresaRegistro(sQuery);
			return iResult;
        }
        #endregion

        #region public static int ActualizaCorte(string sCorte, string sContrato, string sEstilo, string sColor)
        public static int ActualizaCorte(string slIdCorte, string sCorte, string sContrato, string sEstilo, string sColor, string slFecha)
		{
			int iResult = 0;			
			
			string sQuery = @"Update tbCuttingTicket set NoCorte = """+sCorte+@""", Contrato = """+sContrato+@""" , Estilo = """+sEstilo+@""", Color = """+sColor+@""",Fecha="""+slFecha+@""" where id ="+slIdCorte;
			iResult = EjecutaInsertRegresaRegistro(sQuery);
			return iResult;
		}
		#endregion //public static int InsertaCorte(string sCorte, string sContrato, string sEstilo, string sColor)

		#region public static int BorraCorte(int ilCuttingId)
		public static int BorraCorte(int ilCuttingId)
		{
			int iResult = 0;			
			string sQuery = "Delete From tbCuttingTicket where id = "+ilCuttingId.ToString();
			iResult = EjecutaInsertRegresaRegistro(sQuery);
			return iResult;
		}
		#endregion //public static int BorraCorte(int ilCuttingId)

		#region public static int UpdateTallaCorte(int sCuttingID, string sTalla, int iPrendas)
		public static int UpdateTallaCorte(string sCuttingID, string sTalla, int iPrendas)
		{
			int iResult = 0;			
			string sQuery = @"Update tbCuttingTicket SET "+sTalla+"= "+iPrendas.ToString()+" where id ="+sCuttingID+";";
			iResult = EjecutaInsert(sQuery);
			return iResult;
		}
		#endregion //public static int UpdateTallaCorte(int sCuttingID, string sTalla, int iPrendas)

		#region public static DataSet LlenaDetCT(string sCorteID)
		public static DataSet LlenaDetCT(string sCorteID)
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = @"Select CuttingId, Color,Talla, CajaPedido, UPC, Prendas, IIF(CajaID is null, 0 ,CajaID) AS CajaID, Id as Etiqueta From tbCuttingTicketDet Where CuttingID ="+sCorteID+" order by CajaID desc";
			dsUPCInf = LlenaDataSet(sQuery);			
			return dsUPCInf;
		}
		#endregion //public static DataSet LlenaDetCT(string sCorteID)

		#region public static DataSet LlenaDetCTUPCIMP(string sCorteID)
		public static DataSet LlenaDetCTUPCIMP(string sCorteID)
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = @"Select UPC, TALLA, PRENDAS,IDETIQ From vtCuttingTicketUPC Where id ="+sCorteID;
			dsUPCInf = LlenaDataSet(sQuery);			
			return dsUPCInf;
		}
		#endregion //public static DataSet LlenaDetCTUPCIMP(string sCorteID, string sEstilo)

		#region public static DataSet LlenaCTporID(string idCorte)
		public static DataSet LlenaCTporID(string idCorte)
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = @"Select NoCorte, Contrato, Estilo, Color, IIF((SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1
WHERE tbCuttingTicket.[id]=cInt(tbCT1.[CuttingID]) GROUP BY tbCT1.CuttingID) is null,0,(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1
WHERE tbCuttingTicket.[id]=cInt(tbCT1.[CuttingID]) GROUP BY tbCT1.CuttingID)) AS [SUMAPRENDAS] from tbCuttingTicket where id="+idCorte;			
			dsUPCInf = LlenaDataSet(sQuery);			
			return dsUPCInf;
		}
		#endregion //public static DataSet LlenaCTporID(string idCorte)

		#region public static DataSet LlenaEtiquetaporID(string idEtiqueta)
		public static DataSet LlenaEtiquetaporID(string idEtiqueta)
		{
			DataSet dsEtiqInf = new DataSet();
			string sQuery = @"SELECT tbCuttingTicket.NoCorte, tbCuttingTicket.Contrato, tbCuttingTicket.Estilo, tbCuttingTicket.Color, tbCuttingTicketDet.UPC, 
tbCuttingTicketDet.Prendas, tbCuttingTicketDet.Talla, tbCuttingTicketDet.TipoCaja,tbCuttingTicketDet.cuttingID
FROM tbCuttingTicket INNER JOIN tbCuttingTicketDet ON tbCuttingTicket.Id = tbCuttingTicketDet.cuttingID
WHERE tbCuttingTicketDet.ID ="+idEtiqueta+@"";
			dsEtiqInf = LlenaDataSet(sQuery);			
			return dsEtiqInf;

		}
		#endregion public static DataSet LlenaEtiquetaporID(string idEtiqueta)

		#region public static DataSet obtenInfoEtiq(string sIdEtiq)
		public static DataSet obtenInfoEtiq(string sIdEtiq)
		{
			DataSet dsInfEtiq = new DataSet();
			string sQuery = @"Select id,ContadorImp,ultFechaImp,PCImp From tbTicketDet where EtiquetaId = "+sIdEtiq;
			
			dsInfEtiq = LlenaDataSet(sQuery);			
			return dsInfEtiq;
		}
		#endregion public static DataSet obtenInfoEtiq(string sIdEtiq)

		#region public static DataSet LlenaListaCT(string sCorte)
		public static DataSet LlenaListaCT(string sCorte)
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = @"Select id, NoCorte, Contrato, Estilo, Color From tbCuttingTicket where NoCorte like ""%"+sCorte+@"%"" order by id desc";
			//OleDbConnection odcConexion = Conection();
			//OleDbCommand odcSelect = new OleDbCommand(sQuery,odcConexion);
			//OleDbDataAdapter odaAdapter = new OleDbDataAdapter(odcSelect);
			dsUPCInf = LlenaDataSet(sQuery);
			//"Select Estilo, Talla, UPC, Prendas From tbUPC where UPC = '"+sUPC+"'";
			return dsUPCInf;
		}
		#endregion //public static DataSet LlenaListaCT(string sCorte)

		#region public static DataSet LlenaInfEtiq(string sCorte, string sEtiqueta)
		public static DataSet LlenaInfEtiq(string sCorte, string sEtiqueta)
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = @"Select CORTE, ETIQUETA, UPC, COLOR, TALLA, 
			PRENDAS, [TIPO CAJA],[PRIMERA IMP],[ULTIMA IMP] From vtTicketInformacion ";

			if(sCorte!="")
			{
				sQuery = sQuery + @"where  CORTE = """+sCorte;			
				if(sEtiqueta!="")
				{
					sQuery = sQuery + @" or ETIQUETA = "+sEtiqueta+@" order by CORTE desc";
				}
			}
			else
			{
				if(sEtiqueta!="")
				{
					sQuery = sQuery + @" Where  ETIQUETA = "+sEtiqueta+@" order by CORTE desc";
				}
			}
			
			dsUPCInf = LlenaDataSet(sQuery);
			//"Select Estilo, Talla, UPC, Prendas From tbUPC where UPC = '"+sUPC+"'";
			return dsUPCInf;
		}
		#endregion //public static DataSet LlenaListaCT(string sCorte)

		#region public static int ActualizaCorte(string sCorte, string sContrato, string sEstilo, string sColor)
		public static int ActualizaEtiqInfo(string sEtiqId, string sContImp,string slFecha)
		{
			int iResult = 0;			
			
			string sQuery = @"Update tbTicketDet set ContadorImp = "+sContImp+@", ultFechaImp = """+slFecha+@""" where EtiquetaId ="+sEtiqId;
			iResult = EjecutaInsertRegresaRegistro(sQuery);
			return iResult;
		}
		#endregion

		#region public static DataSet LlenaTallaCT(string idCorte)
		public static DataSet LlenaTallaCT(string idCorte)
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = @"
SELECT ""x29"" as [W\L] ,tbCuttingTicket.[30x29] as 30 , tbCuttingTicket.[32x29] as 32 , tbCuttingTicket.[33x29] as 33 , tbCuttingTicket.[34x29] as 34 , tbCuttingTicket.[36x29] as 36 , tbCuttingTicket.[38x29] as 38, tbCuttingTicket.[40x29] as 40,  tbCuttingTicket.[42x29] as 42, tbCuttingTicket.[44x29] as 44, tbCuttingTicket.[46x29] as 46, tbCuttingTicket.[48x29] as 48,tbCuttingTicket.[50x29] as 50 FROM tbCuttingTicket WHERE ID ="+idCorte.ToString()+@"
UNION ALL
SELECT ""x30"" as [W\L],tbCuttingTicket.[30x30], tbCuttingTicket.[32x30], tbCuttingTicket.[33x30], tbCuttingTicket.[34x30], tbCuttingTicket.[36x30], tbCuttingTicket.[38x30], tbCuttingTicket.[40x30],  tbCuttingTicket.[42x30], tbCuttingTicket.[44x30], tbCuttingTicket.[46x30], tbCuttingTicket.[48x30], tbCuttingTicket.[50x30] FROM tbCuttingTicket WHERE ID ="+idCorte.ToString()+@"
UNION ALL
SELECT ""x32"" as [W\L],tbCuttingTicket.[30x32], tbCuttingTicket.[32x32], tbCuttingTicket.[33x32], tbCuttingTicket.[34x32], tbCuttingTicket.[36x32], tbCuttingTicket.[38x32], tbCuttingTicket.[40x32],  tbCuttingTicket.[42x32], tbCuttingTicket.[44x32], tbCuttingTicket.[46x32], tbCuttingTicket.[48x32], tbCuttingTicket.[50x32] FROM tbCuttingTicket WHERE ID ="+idCorte.ToString()+@"
UNION ALL
SELECT ""x34"" as [W\L],tbCuttingTicket.[30x34], tbCuttingTicket.[32x34], tbCuttingTicket.[33x34], tbCuttingTicket.[34x34], tbCuttingTicket.[36x34], tbCuttingTicket.[38x34], tbCuttingTicket.[40x34],  tbCuttingTicket.[42x34], tbCuttingTicket.[44x34], tbCuttingTicket.[46x34] as 46, tbCuttingTicket.[48x34] as 48,tbCuttingTicket.[50x34] as 50 FROM tbCuttingTicket WHERE ID ="+idCorte.ToString()+@"";
			
			dsUPCInf = LlenaDataSet(sQuery);
			
			return dsUPCInf;
		}
		#endregion//public static DataSet LlenaTallaCT(string idCorte)

		#region public static DataSet LlenaTallaCTCapt(string idCorte)
		public static DataSet LlenaTallaCTCapt(string sidCorte)
		{
			DataSet dsUPCInf = new DataSet();
			#region Query
			string sQuery =@"select [W/L],[30],[32],[33],[34],[36],[38],[40],[42],[44],[46],[48],[50] from tbSumaCapturas where CuttingID = "+sidCorte;
//			string sQuery =@"
//SELECT
//IIF((SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 WHERE  tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""30x29"" 
//GROUP BY tbCT1.Talla) is null,0,(
//SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 WHERE  tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""30x29"" 
//GROUP BY tbCT1.Talla)) AS [30x29],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""32x29"" GROUP BY tbCT1.Talla) AS [32x29],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""33x29"" GROUP BY tbCT1.Talla) AS [33x29],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""34x29"" GROUP BY tbCT1.Talla) AS [34x29],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""36x29"" GROUP BY tbCT1.Talla) AS [36x29],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""38x29"" GROUP BY tbCT1.Talla) AS [38x29],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""40x29"" GROUP BY tbCT1.Talla) AS [40x29],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""42x29"" GROUP BY tbCT1.Talla) AS [42x29],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""44x29"" GROUP BY tbCT1.Talla) AS [44x29]
//FROM tbCuttingTicketDet AS tbCTM 
//WHERE ((([tbCTM].[CuttingID])="""+sidCorte+@""")) GROUP BY tbCTM.[CuttingID] 
//union ALL 
//SELECT 
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE  tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""30x30"" GROUP BY tbCT1.Talla) AS [30x30],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""32x30"" GROUP BY tbCT1.Talla) AS [32x30],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""33x30"" GROUP BY tbCT1.Talla) AS [33x30],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""34x30"" GROUP BY tbCT1.Talla) AS [34x30],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""36x30"" GROUP BY tbCT1.Talla) AS [36x30],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""38x30"" GROUP BY tbCT1.Talla) AS [38x30],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""40x30"" GROUP BY tbCT1.Talla) AS [40x30],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""42x30"" GROUP BY tbCT1.Talla) AS [42x30],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""44x30"" GROUP BY tbCT1.Talla) AS [44x30]
//FROM tbCuttingTicketDet AS tbCTM 
//WHERE ((([tbCTM].[CuttingID])="""+sidCorte+@""")) GROUP BY tbCTM.[CuttingID] 
//UNION ALL 
//SELECT 
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE  tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""30x32"" GROUP BY tbCT1.Talla) AS [30x32],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""32x32"" GROUP BY tbCT1.Talla) AS [32x32],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""33x32"" GROUP BY tbCT1.Talla) AS [33x32],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""34x32"" GROUP BY tbCT1.Talla) AS [34x32],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""36x32"" GROUP BY tbCT1.Talla) AS [36x32],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""38x32"" GROUP BY tbCT1.Talla) AS [38x32],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""40x32"" GROUP BY tbCT1.Talla) AS [40x32],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""42x32"" GROUP BY tbCT1.Talla) AS [42x32],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""44x32"" GROUP BY tbCT1.Talla) AS [44x32]
//FROM tbCuttingTicketDet AS tbCTM 
//WHERE ((([tbCTM].[CuttingID])="""+sidCorte+@""")) GROUP BY tbCTM.[CuttingID] 
//UNION ALL 
//SELECT 
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE  tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""30x34"" GROUP BY tbCT1.Talla) AS [30x34],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""32x34"" GROUP BY tbCT1.Talla) AS [32x34],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""33x34"" GROUP BY tbCT1.Talla) AS [33x34],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""34x34"" GROUP BY tbCT1.Talla) AS [34x34],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""36x34"" GROUP BY tbCT1.Talla) AS [36x34],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""38x34"" GROUP BY tbCT1.Talla) AS [38x34],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""40x34"" GROUP BY tbCT1.Talla) AS [40x34],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""42x34"" GROUP BY tbCT1.Talla) AS [42x34],
//(SELECT Sum(tbCT1.prendas) AS TotPrendas FROM tbCuttingTicketDet as tbCT1 
//WHERE tbCTM.[CuttingID]=tbCT1.[CuttingID] and tbCT1.Talla = ""44x34"" GROUP BY tbCT1.Talla) AS [44x34]
//FROM tbCuttingTicketDet AS tbCTM 
//WHERE ((([tbCTM].[CuttingID])="""+sidCorte+@"""))GROUP BY tbCTM.[CuttingID];";
			#endregion//QUERY
			dsUPCInf = LlenaDataSet(sQuery);
			
			return dsUPCInf;
		}
		#endregion//public static DataSet LlenaTallaCTCapt(string sidCorte)

		#region public static DataSet LlenaTallaCTCaptPrim(string idCorte)
		public static DataSet LlenaTallaCTCaptPrim(string sidCorte)
		{
			DataSet dsUPCInf = new DataSet();

			string sQuery =@"select [W/L],[30],[32],[33],[34],[36],[38],[40],[42],[44],[46],[48],[50] from tbSumaCapturasPrimeras where CuttingID = "+sidCorte;
			dsUPCInf = LlenaDataSet(sQuery);
			
			return dsUPCInf;
		}
		#endregion//public static DataSet LlenaTallaCTCaptPrim(string sidCorte)

		#region public static DataSet LlenaTallaCTCaptSegTerc(string idCorte)
		public static DataSet LlenaTallaCTCaptSegTerc(string sidCorte)
		{
			DataSet dsUPCInf = new DataSet();
			
			string sQuery =@"select [W/L],[30],[32],[33],[34],[36],[38],[40],[42],[44],[46],[48],[50] from tbSumaCapturasSegTerc where CuttingID = "+sidCorte;
			dsUPCInf = LlenaDataSet(sQuery);
			
			return dsUPCInf;
		}
		#endregion//public static DataSet LlenaTallaCTCaptSegTerc(string sidCorte)

		#region public static DataSet RevisaTalla(string sTalla, string idCorte)		
		public static DataSet RevisaTalla(string sTalla, string idCorte)
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = @"
SELECT ["+sTalla+@"] FROM tbCuttingTicket WHERE ID ="+idCorte.ToString()+@"";
			
			dsUPCInf = LlenaDataSet(sQuery);
			
			return dsUPCInf;
		}
		#endregion //public static DataSet RevisaTalla(string sTalla, string idCorte)

		#region public static DataSet traeCantPrendas(string sUPC, string sCorteID)
		public static DataSet traeCantPrendas(string sUPC, string sCorteID)
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = @"select SUM(prendas) from tbCuttingTicketDet where CuttingID = "+sCorteID+@" and UPC = """+sUPC+@"""";
			
			dsUPCInf = LlenaDataSet(sQuery);
			
			return dsUPCInf;
		}
		#endregion public static DataSet traeCantPrendas(string sUPC, string sCorteID)

		#region public static string traeEtiquetaId(string sUPC, string sCorteID)
		public static string traeEtiquetaId(string sUPC, string sCorteID)
		{
			string  slEtiqID="0";
			DataSet dsEtiID = new DataSet();
			string sQuery = @"SELECT Max(ID) AS EtiqID FROM tbCuttingTicketDet WHERE (((tbCuttingTicketDet.[CuttingID])="+sCorteID+@") AND ((tbCuttingTicketDet.[UPC])="""+sUPC+@"""))";
			dsEtiID = LlenaDataSet(sQuery);

			if((dsEtiID.Tables.Count>0)&&(dsEtiID.Tables[0].Rows.Count>0))
			{
				slEtiqID = dsEtiID.Tables[0].Rows[0][0].ToString();
			}
			return slEtiqID;
		}
		#endregion public static string traeEtiquetaId(string sUPC, string sCorteID)
		
		#region public static DataSet LlenaDetUPC(string sCorteID)
		public static DataSet LlenaDetUPC(string sCorteID)
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = @"Select * From tbUPC Where UPC LIKE ""%"+sCorteID+@"%""";
			dsUPCInf = LlenaDataSet(sQuery);			
			return dsUPCInf;
		}
		#endregion //public static DataSet LlenaDetCT(string sCorteID)

		#region public static DataSet LlenaMatrizCaptCT()
		public static DataSet LlenaMatrizCaptCT()
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = @"Select * From vtGeneraMatriz";
			dsUPCInf = LlenaDataSet(sQuery);			
			return dsUPCInf;
		}
		#endregion //public static DataSet LlenaMatrizCaptCT()

		#region public static DataSet LlenaEstilos()
		public static DataSet LlenaEstilos()
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = @"Select * From tbEstilos WHERE ACTIVO = 1 order by Estilo";
			dsUPCInf = LlenaDataSet(sQuery);			
			return dsUPCInf;
		}
		#endregion //public static DataSet LlenaEstilos()		

		#region public static DataSet LlenaPLCT(string idCorte)
		public static DataSet LlenaPLCT(string idCorte, string sTipoCaja,string slCasesCant, string slNextCase)
		{
			DataSet dsUPCInf = new DataSet();
			string sQuery = @" Select TOP "+slCasesCant+@" CajaId, Talla, Prendas,TipoCaja,id,CuttingId from vtPackingList where CuttingId ="+idCorte.ToString()+@" and TipoCaja = "+sTipoCaja +@" and CajaId > "+slNextCase;
			
			dsUPCInf = LlenaDataSet(sQuery);
			
			return dsUPCInf;
		}
		#endregion//public static DataSet LlenaTallaCT(string idCorte)

		#region public static DataSet RegresaConsecutivoCaja(string idCorte)
		public static string RegresaConsecutivoCaja(string idCorte)
		{
			string slCajaID = "0";
			DataSet dsUPCInf = new DataSet();
			string sQuery = @" SELECT TOP 1  tbCuttingTicketDet.CajaID AS CAJAID
FROM tbCuttingTicketDet
WHERE (((tbCuttingTicketDet.[CuttingId])="+idCorte.ToString()+@"))
and CAJAID is not null
ORDER BY tbCuttingTicketDet.cuttingID, tbCuttingTicketDet.CajaID DESC";
			
			dsUPCInf = LlenaDataSet(sQuery);
			if((dsUPCInf.Tables.Count>0)&&(dsUPCInf.Tables[0].Rows.Count>0))
			{
				slCajaID = dsUPCInf.Tables[0].Rows[0][0].ToString();
			}
			
			return slCajaID;
		}
		#endregion//public static DataSet LlenaTallaCT(string idCorte)

		#region public static bool VerificaExistenciaCorte(string slNoCorte)
		public static bool VerificaExistenciaCorte(string slNoCorte)
		{
			bool ilExiste = false;
			DataSet dsUPCInf = new DataSet();
			string sQuery = @" Select  NoCorte from tbCuttingTicket where NoCorte ="""+slNoCorte+@"""";;			
			dsUPCInf = LlenaDataSet(sQuery);
			if((dsUPCInf.Tables.Count>0)&&(dsUPCInf.Tables[0].Rows.Count>0))
			{
				ilExiste = true;
			}
			
			return ilExiste	;
		}
		#endregion//public static bool VerificaExistenciaCorte(string slNoCorte)

		#region public static DataSet LlenaListaPL(string slCorte, string slTipoCaja)
		public static DataSet LlenaListaPL(string slCorte, string slTipoCaja)
		{
			DataSet dsListaPL = new DataSet();
			string slQuery ="";
//			if(slTipoCaja=="2")
//				slQuery = @"SELECT tbCuttingTicketDet.cuttingID, tbCuttingTicketDet.TipoCaja, tbCuttingTicketDet.CajaID, tbCuttingTicketDet.Talla, tbCuttingTicketDet.Prendas
//FROM tbCuttingTicketDet WHERE tbCuttingTicketDet.cuttingID ="+slCorte+@" AND (tbCuttingTicketDet.TipoCaja = 2 OR tbCuttingTicketDet.TipoCaja) = 3 order by tbCuttingTicketDet.CajaID;
//";
//			else
			//tbCuttingTicketDet.cuttingID, tbCuttingTicketDet.TipoCaja, 
			slQuery = @"SELECT tbCuttingTicketDet.CajaID as CajaNo, tbCuttingTicketDet.Talla, tbCuttingTicketDet.Prendas
FROM tbCuttingTicketDet WHERE tbCuttingTicketDet.cuttingID ="+slCorte+@" AND tbCuttingTicketDet.TipoCaja = "+slTipoCaja+@" order by tbCuttingTicketDet.CajaID;
";
			dsListaPL = LlenaDataSet(slQuery);			
			return(dsListaPL);

		}
		#endregion

		public static DataSet LlenaListaEtiqPorCorte(string slCorte)
		{
			DataSet dsInf = new DataSet();
			string slQuery = @"SELECT tbCuttingTicket.NoCorte, tbTicketDet.EtiquetaId, tbTicketDet.ContadorImp, tbTicketDet.FechaImp, tbTicketDet.UltFechaImp, tbTicketDet.PCImp
FROM tbTicketDet INNER JOIN (tbCuttingTicketDet 
INNER JOIN tbCuttingTicket ON tbCuttingTicketDet.cuttingID = tbCuttingTicket.Id) ON tbTicketDet.EtiquetaId = tbCuttingTicketDet.Id
WHERE tbCuttingTicket.NoCorte= """+slCorte+@"""";
			dsInf = LlenaDataSet(slQuery);
			return(dsInf);

		}

        public static DataSet ObtenAcabadoBusqueda(string slAcabado)
        {
            List<Acabado> resultList = new List<Acabado>();
            DataSet dsAcabado = new DataSet();
            string sQuery = @"SELECT tbAcabados.IdAcabado as ID, tbAcabados.AcabadoClave AS Clave, tbAcabados.EtiquetaDescripcion as Etiqueta, tbAcabados.Descripcion as Descripcion
FROM tbAcabados where tbAcabados.AcabadoClave like ""%" + slAcabado + @"%"" order by IdAcabado asc;";
            dsAcabado = LlenaDataSet(sQuery);

            //foreach (DataRow itemRow in dsAcabado.Tables[0].Rows)
            //{ 
            //    Acabado entAcabado = new Acabado()
            //    {
            //        IdAcabado = int.Parse(itemRow["ID"].ToString()),
            //        Number = int.Parse(itemRow["Clave"].ToString()),
            //        DescripcionEtiqueta = itemRow["Etiqueta"].ToString(),
            //        Descripcion = itemRow["Descripcion"].ToString()                    
            //    };
            //    resultList.Add(entAcabado);
            //}

            return dsAcabado;
        }

        public static int GuardaAcabado(Acabado entAcabado)
        {
            int iResult = 0;
            string sQuery = "";
            if (entAcabado.IdAcabado == 0)
            {
                sQuery = @"
    INSERT INTO tbAcabados
        (         
         AcabadoClave, 
         EtiquetaDescripcion,
         Descripcion
        )
        VALUES
        (
        {0},
        ""{1}"",
        ""{2}""
        );";
                sQuery = String.Format(sQuery, entAcabado.Number, entAcabado.DescripcionEtiqueta, entAcabado.Descripcion);
                iResult = EjecutaInsertRegresaMaxID(sQuery, "IdAcabado", "tbAcabados");
            }
            else
            {
                sQuery = @"UPDATE tbAcabados SET 
         AcabadoClave = {0}, 
         EtiquetaDescripcion = ""{1}"",
         Descripcion= ""{2}""
        where IdAcabado = {3}
        ";
                sQuery = String.Format(sQuery, entAcabado.Number, entAcabado.DescripcionEtiqueta, entAcabado.Descripcion,entAcabado.IdAcabado);
                iResult = EjecutaInsert(sQuery);
                iResult = entAcabado.IdAcabado;
            }

            return iResult;
        }

        public static bool VerificaExisteAcabado(int iClave)
        {
            DataSet dsAcabado = new DataSet();
            string sQuery = @"SELECT tbAcabados.IdAcabado as ID, tbAcabados.AcabadoClave AS Clave, tbAcabados.EtiquetaDescripcion as Etiqueta, tbAcabados.Descripcion as Descripcion
FROM tbAcabados where tbAcabados.AcabadoClave = {0}";
            sQuery = String.Format(sQuery, iClave);
            dsAcabado = LlenaDataSet(sQuery);
            if (dsAcabado.Tables.Count > 0)
            {
                if (dsAcabado.Tables[0].Rows.Count > 0)
                    return true;
            }

            return false;
        }

        public static DataSet ObtenEstiloBusqueda(string slEstilo)
        {
            DataSet dsEstilo = new DataSet();
            string sQuery = @"SELECT tbEstilos.Id, tbEstilos.ESTILO, tbEstilos.ACTIVO
FROM tbEstilos WHERE tbEstilos.ESTILO like ""{0}"";";
            sQuery = String.Format(sQuery, slEstilo);
            dsEstilo = LlenaDataSet(sQuery);
            return dsEstilo;
        }

        public static int GuardaEstilo(Estilo entEstilo)
        {
            int ilResult = 0;
            string sQuery = "";
            if (entEstilo.IdEstilo == 0)
            {
                sQuery = @"
                INSERT INTO tbEstilos
                (ESTILO,
                ACTIVO)
                VALUES
                (""{0}"",{1})
                ;";
                sQuery = String.Format(sQuery, entEstilo.EstiloCodigo);
                ilResult = EjecutaInsertRegresaMaxID(sQuery, "Id", "tbEstilos");
            }
            return ilResult;
        }
	}
}
