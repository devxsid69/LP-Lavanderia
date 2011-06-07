using System;
using System.Configuration;
using System.Runtime.InteropServices;
using System.IO;

namespace SistEti
{
	/// <summary>
	/// Summary description for lpUtils.
	/// </summary>
	public class lpUtils
	{
		//[DllImport("kernel32.dll")] internal static extern IntPtr CreateFile(string name, int desiredAccess, int shareMode, IntPtr securityAttributes,int creationDisposition, int dwFlagsAndAttributes, IntPtr templateFile);
		public lpUtils()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		#region private void private void imprime(string slCorte, string slContrato, string slEstilo, string slTalla, string slCant,string slUPC, string slColor)
		[DllImport("kernel32.dll")] internal static extern IntPtr CreateFile(string name, int desiredAccess, int shareMode, IntPtr securityAttributes,int creationDisposition, int dwFlagsAndAttributes, IntPtr templateFile);
		public static string Imprime(string slCorte, string slContrato, string slEstilo, string slTalla, string slCant,string slUPC, string slColor, string slTipoCaja,string slEtiquetaID)
		{
			char cr = (char)13;
			
			for( int ilCont=slEtiquetaID.Length;ilCont <7; ilCont++)
			{
				slEtiquetaID="0"+slEtiquetaID;
			}
			
			string mensaje="";

			string slUPCAlterno = GeneraSegUpc(slTalla);
			string slUPCEstiloAlterno = GeneraSegUpcEstilo(slTalla);
			String [] saCorte = new string[2]; 

			saCorte = slCorte.Split('-');
			slCorte = saCorte[1]+saCorte[0];

			string sCol =slColor.Substring(0,1);
			switch(sCol)
			{
				case "L":
					slColor="LTSW";
					break;
				case "D":
					slColor="DKSW";
					break;
				case "M":
					slColor="MEDSW";
					break;
                case "B":
                    slColor = "BLACK";
                    break;
				default:					
					break;
			}

			string slTipoImpresora = ConfigurationSettings.AppSettings["Impresora"];

			if(slTipoImpresora=="1")
			{
				
				
				if(( slTipoCaja == "1")||( slTipoCaja == "4"))
				{
					#region Etiqueta Solidas
					mensaje += "^XA"+ cr;
					mensaje += "^LH0,0"+ cr;
					mensaje += "^FO50,35^A0,,95,75^FDFLYNN^FS"+ cr;
					mensaje += "^FO500,35^A0,,45,65^FDPOS BIN STOCK^FS"+cr;
					mensaje += "^FO340,35^A0,,65,25^FD" + DateTime.Today.ToString("MM/yy") + "^FS" + cr;				
					mensaje += "^FO330,110^B3N,,120^FD" + slUPC + "^FS"+ cr;
					mensaje += "^FO95,140^A0,,65,45^FD" + slContrato  + "^FS"+ cr;
					mensaje += "^FO60,240^A0,,45,55^FD" + slEstilo + "^FS" + cr;				
					mensaje += "^FO100,280^A0,,65,45^FD" + slCorte + "^FS" + cr;
					mensaje += "^FO450,260^B3N,,90,N^FD" + slCorte + "^FS" + cr;
					mensaje += "^FO100,280^B3N,,90,N^FD" + slEtiquetaID + "^FS" + cr;	
					mensaje += "^FO120,425^A0,,60,30^FDPAIR^FS" + cr;
					mensaje += "^FO350,405^A0,,85,55^FD" + String.Format("{0:000}",slCant ) + "^FS" + cr;
					mensaje += "^FO630,385^B3N,,85,N^FD" + String.Format("{0:000}",slCant ) + "^FS" + cr;
					mensaje += "^FO50,505^A0,,60,30^FDS/" + slEstilo.Substring(7,3)  + "^FS" + cr;
					mensaje += "^FO220,505^A0,,60,30^FD" + slColor + "^FS" + cr;
					mensaje += "^FO530,505^A0,,60,30^FD  SZ " + slTalla + "^FS" + cr;
					mensaje += "^FO780,580^A0,,20,30^FDS^FS" + cr;
					mensaje += "^XZ" + cr;
					#endregion
				}
				else
				{
					#region Etiqueta Saldos, Segundas y Terceras
					string slTipoEtiqueta = "";
					
					switch(slTipoCaja )
					{
						case "2":
							slTipoEtiqueta = "IRREGULARS";							
							break;
						case "3":
							slTipoEtiqueta = "THIRDS";							
							break;
						case "4":
							slTipoEtiqueta = "POS BIN STOCK";
							break;
                        case "5":
                            slTipoEtiqueta = "RAGS";
                            break;
					}
					
					mensaje += "^XA"+ cr;
					mensaje += "^LH0,0"+ cr;
					mensaje += "^FO50,35^A0,,95,75^FDFLYNN^FS"+ cr;
					mensaje += "^FO500,35^A0,,45,65^FD"+slTipoEtiqueta+@"^FS"+cr;
					mensaje += "^FO340,35^A0,,65,25^FD" + DateTime.Today.ToString("MM/yy") + "^FS" + cr;				
					mensaje += "^FO330,95^B3N,,80^FD" + slUPC + "^FS"+ cr;
					mensaje += "^FO95,130^A0,,65,45^FD" + slContrato  + "^FS"+ cr;
					mensaje += "^FO25,220^A0,,40,55^FD" + slEstilo + "^FS" + cr;				
					mensaje += "^FO25,260^A0,,35,55^FD" + slUPCEstiloAlterno + "^FS" + cr;
					mensaje += "^FO330,215^B3N,,80^FD" + slUPCAlterno + "^FS"+ cr;
					mensaje += "^FO100,325^A0,,65,45^FD" + slCorte + "^FS" + cr;
					mensaje += "^FO450,325^B3N,,80,N^FD" + slCorte + "^FS" + cr;				
					mensaje += "^FO120,425^A0,,60,30^FDPAIR^FS" + cr;
					mensaje += "^FO350,415^A0,,85,55^FD" + String.Format("{0:000}",slCant ) + "^FS" + cr;
					mensaje += "^FO630,410^B3N,,80,N^FD" + String.Format("{0:000}",slCant ) + "^FS" + cr;
					mensaje += "^FO50,515^A0,,60,30^FDS/" + slEstilo.Substring(7,3)  + "^FS" + cr;
					mensaje += "^FO220,515^A0,,60,30^FD" + slColor + "^FS" + cr;
					mensaje += "^FO530,515^A0,,60,30^FD  SZ " + slTalla + "^FS" + cr;
					mensaje += "^FO780,580^A0,,20,30^FDS^FS" + cr;
					mensaje += "^XZ" + cr;
					#endregion
				}

			}
			else
			{
				if(( slTipoCaja == "1")||( slTipoCaja == "4"))
				{
					#region Etiqueta Solidas
					mensaje =@"
O
q815
S4
D"+ConfigurationSettings.AppSettings["Darkness"]+@"
ZB
JF

N
B422,103,0,3,2,4,109,N,"""+slUPC+@"""
A483,212,0,1,2,2,N,"""+slUPC +@"""
A24,34,0,2,4,5,N,""FLYNN""
A302,37,0,2,2,3,N,"""+DateTime.Today.ToString("MM/yy")+@"""
A444,37,0,2,2,3,N,""POS BIN STOCK""
A116,131,0,2,2,3,N,"""+slContrato+@"""
A67,242,0,2,2,2,N,"""+slEstilo +@"""
A116,286,0,2,2,3,N,"""+slCorte +@"""
B493,262,0,3,2,4,88,N,"""+slCorte+@"""
B116,340,0,3,2,4,40,N,"""+slEtiquetaID+@"""
A190,380,0,1,1,3,N,"""+slEtiquetaID +@"""
B534,387,0,3,2,4,90,N,"""+slCant+@"""
A596,529,0,2,2,3,N,"""+slTalla+@"""
A495,529,0,2,2,3,N,""SZ""
A71,406,0,2,2,3,N,""PAIR""
A359,390,0,2,3,4,N,"""+slCant +@"""
A63,526,0,2,2,3,N,""S/"+slEstilo.Substring(7,3)+@"""
A235,526,0,2,2,3,N,"""+slColor +@"""
P1
";
					#endregion
				}
				else
				{
					#region Etiqueta Saldos, Segundas y Terceras
					string slTipoEtiqueta = "";
					
					switch(slTipoCaja )
					{
						case "2":
							slTipoEtiqueta = "IRREGULARS";
							
							break;
						case "3":
							slTipoEtiqueta = "THIRDS";							
							break;
						case "4":
							slTipoEtiqueta = "POS BIN STOCK";
							break;
                        case "5":
                            slTipoEtiqueta = "RAGS";
                            break;
					}
					
					mensaje =@"
O
q815
S4
D"+ConfigurationSettings.AppSettings["Darkness"]+@"
ZB
JF

N
B424,108,0,3,2,4,73,N,"""+slUPC+@"""
A545,181,0,1,1,2,N,"""+slUPC +@"""
A31,23,0,2,4,5,N,""FLYNN""
A350,27,0,2,2,3,N,"""+DateTime.Today.ToString("MM/yy")+@"""
A500,27,0,2,2,3,N,"""+slTipoEtiqueta+@"""
A95,123,0,2,2,3,N,"""+slContrato+@"""
A45,220,0,2,2,2,N,"""+slEstilo+@"""
A89,305,0,2,2,3,N,"""+slCorte+@"""
B424,221,0,3,2,4,74,N,"""+slUPCAlterno+@"""
A545,295,0,1,1,2,N,"""+slUPCAlterno+@"""
B492,333,0,3,2,4,73,N,"""+slCorte+@"""
B116,360,0,3,2,4,40,N,"""+slEtiquetaID+@"""
A190,400,0,1,1,3,N,"""+slEtiquetaID +@"""
B527,430,0,3,2,4,73,N,"""+slCant+@"""
A596,529,0,2,2,3,N,"""+slTalla+@"""
A495,529,0,2,2,3,N,""SZ""
A70,454,0,2,2,3,N,""PAIR""
A108,260,0,2,1,2,N,"""+slUPCEstiloAlterno+@"""
A365,444,0,2,3,4,N,"""+slCant +@"""
A63,526,0,2,2,3,N,""S/"+slEstilo.Substring(7,3)+@"""
A235,526,0,2,2,3,N,"""+slColor +@"""
A384,238,0,2,1,1,N,""UPC""
P1
";
					#endregion
				}
			}
			

			//this.textBox1.Text = mensaje;
			return SendToLpt1(mensaje);

		}
		#endregion //private void imprime()

		#region public static void SendToLpt1(string message)
		public static string SendToLpt1(string message)
		{
			FileStream fs = null;
			IntPtr handle = CreateFile(
				"LPT1",
				(int) FileAccess.Write, 
				(int) FileShare.Read, 
				IntPtr.Zero, 
				(int) FileMode.Open, 
				0, 
				IntPtr.Zero);
			if (handle.ToInt32() != -1)
			{
				try
				{
					fs = new FileStream(handle, FileAccess.Write);
					byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
					fs.Write(msg, 0, msg.Length);
					fs.Close();
				}
				catch
				{
					return "No se ha encontrado la Impresora";
				}
			}
			else
			{
				return "No se puede abrir el puerto de Impresión";
			}
			return "";
		}
		#endregion //public static void SendToLpt1(string message)

		public static  string GeneraSegUpc(string slTalla)   
		{
			if(Convert.ToInt32(slTalla.Substring(0,2))<=44)
				return "000000000002";
			else
				return "000000000001";
		}

		public static  string GeneraSegUpcEstilo(string slTalla)
		{
			if(Convert.ToInt32(slTalla.Substring(0,2))<=44)
				return "J55-102000-00R";
			else
				return "J65-102000-00R";
		}

	}
}
