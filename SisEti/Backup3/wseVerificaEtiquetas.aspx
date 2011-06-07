<%@ Page language="c#" Codebehind="wseVerificaEtiquetas.aspx.cs" AutoEventWireup="false" Inherits="WASistEti.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Verifica Etiquetas</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript">
		function setFocus()
			{
				try{
					eval("document.getElementById('"+ document.forms[0].hdnControlFocus.value +"').focus();");
					try{
						eval("document.getElementById('"+ document.forms[0].hdnControlFocus.value +"').select();");
					}catch(e){
					}
				}catch(e){
					document.forms[0].TextBoxUbicacionOrigen.focus();
					document.forms[0].TextBoxUbicacionOrigen.select();
				}
				document.forms[0].hdnControlFocus.value = "";
			}		
		</script>
	</HEAD>
	<body onload="setFocus()" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table style="WIDTH: 280px; HEIGHT: 262px">
				<tr>
					<td style="WIDTH: 86px; HEIGHT: 24px" align="right" width="86"><asp:label id="lblCorte" runat="server" Font-Size="8pt" Font-Names="Arial Narrow">No. Corte :</asp:label></td>
					<td style="WIDTH: 99px; HEIGHT: 24px" width="99"><asp:label id="lblNoCorte" runat="server" Font-Names="Verdana" Font-Bold="True"></asp:label></td>
					<td style="HEIGHT: 24px"></td>
				</tr>
				<tr>
					<td style="WIDTH: 86px" align="right" width="86"><asp:label id="lblEtiqueta" runat="server" Font-Size="8pt" Font-Names="Arial Narrow">Etiqueta : </asp:label></td>
					<td style="WIDTH: 99px; HEIGHT: 24px" width="99"><asp:textbox id="tbEtiqueta" runat="server" Font-Size="8pt" AutoPostBack="True" Width="102px"
							Font-Names="Arial Narrow"></asp:textbox></td>
					<td style="WIDTH: 280px"><asp:button id="btnValida" runat="server" Font-Size="8pt" Text="Validar" Font-Names="Arial Narrow"></asp:button></td>
				</tr>
				<TR>
					<TD style="WIDTH: 86px" align="right" width="86">
						<asp:CheckBox id="cbxGrid" runat="server" Font-Size="7pt" Font-Names="Arial Narrow" AutoPostBack="True"
							Text="Detalle"></asp:CheckBox></TD>
					<TD style="WIDTH: 99px; HEIGHT: 24px" width="99">
						<asp:CheckBox id="cbxReporte" runat="server" Font-Size="7pt" Font-Names="Arial Narrow" AutoPostBack="True"
							Text="Reporte"></asp:CheckBox></TD>
					<TD style="WIDTH: 280px">
						<asp:Button id="btnGeneraReporte" runat="server" Font-Size="8pt" Font-Names="Arial Narrow" Text="Reporte"
							Visible="False"></asp:Button></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 86px" align="center" width="86" colSpan="3">
						<asp:TextBox id="tbReport" runat="server" Font-Size="8pt" Font-Names="Arial Narrow" Width="276px"
							Visible="False" TextMode="MultiLine" ReadOnly="True" Height="90px"></asp:TextBox></TD>
				</TR>
				<tr>
					<td vAlign="top" align="left" width="100" colSpan="3"><asp:datagrid id="dgEtiquetas" runat="server" Font-Size="7pt" Font-Names="Arial Narrow" Width="280px"
							AutoGenerateColumns="False" Visible="False">
							<AlternatingItemStyle ForeColor="White" BackColor="#0066CC"></AlternatingItemStyle>
							<ItemStyle ForeColor="White" BackColor="#6699FF"></ItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#0000CC"></HeaderStyle>
							<Columns>
								<asp:BoundColumn Visible="False" DataField="Corte" HeaderText="No. Corte"></asp:BoundColumn>
								<asp:BoundColumn DataField="Etiqueta" HeaderText="No. Etiq."></asp:BoundColumn>
								<asp:BoundColumn DataField="upc" HeaderText="UPC"></asp:BoundColumn>
								<asp:BoundColumn DataField="color" HeaderText="COLOR"></asp:BoundColumn>
								<asp:BoundColumn DataField="Talla" HeaderText="TALLA"></asp:BoundColumn>
								<asp:BoundColumn DataField="PRENDAS" HeaderText="# PDS."></asp:BoundColumn>
								<asp:BoundColumn DataField="tipo caja" HeaderText="T. CAJA"></asp:BoundColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:CheckBox id=CheckBox1 runat="server" Checked='<%# Convert.ToBoolean(DataBinder.Eval(Container.DataItem, "Estado") )%>' Enabled="False">
										</asp:CheckBox>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn Visible="False" DataField="Existe" HeaderText="Existe"></asp:BoundColumn>
							</Columns>
						</asp:datagrid></td>
				</tr>
				<tr>
					<td style="WIDTH: 86px"></td>
					<td style="WIDTH: 99px">
						<asp:Button id="btnGuarda" runat="server" Font-Size="8pt" Font-Names="Arial Narrow" Text="Guardar"
							Visible="False"></asp:Button></td>
					<td></td>
				</tr>
				<tr>
					<td colspan="3"><asp:HyperLink id="Hyperlink1" runat="server" NavigateUrl="wseInicio.aspx" Font-Names="Arial Narrow"><< regresar</asp:HyperLink></td>
				</tr>
			</table>
			<INPUT class="textleft" id="hdnControlFocus" style="WIDTH: 20px" type="hidden" value="tbEtiqueta"
				name="hdnControlFocus" runat="server"> <INPUT class="textleft" id="hdnEstado" style="WIDTH: 20px" type="hidden" value="inicio"
				name="hdnControlFocus" runat="server">
		</form>
	</body>
</HTML>
