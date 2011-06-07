<%@ Page language="c#" Codebehind="wseVerificaEtiquetas1.aspx.cs" AutoEventWireup="false" Inherits="WASistEti.wseVerificaEtiquetas1" %>
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
	//	function evaluaTextBox(mensaje){
		//alert(mensaje);
	//	document.Form1.hdnEstado.value
	//	if(document.Form1.hdnEstado.value=="2")
	//	alert(mensaje);
	//	}	
		</script>
</HEAD>
	<body onload="setFocus()" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table style="WIDTH: 288px" bgColor="gainsboro">
				<TR>
					<TD noWrap align="left" width="86" bgColor="#3366cc">
						<asp:hyperlink id="Hyperlink1" runat="server" ForeColor="#C0C0FF" Font-Names="Arial Narrow" NavigateUrl="wseInicio.aspx"><<</asp:hyperlink></TD>
					<TD noWrap align="center" width="86" bgColor="#3366cc" colSpan="2">
						<asp:label id="Label1" runat="server" BackColor="Transparent" ForeColor="White" Width="128px"
							Font-Bold="True" Font-Size="8pt" Font-Names="Arial">Lectura de Etiquetas</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 139px; HEIGHT: 24px" align="right" width="139">
						<asp:label id="lblCorte" runat="server" ForeColor="DarkBlue" Font-Bold="True" Font-Size="8pt"
							Font-Names="Arial Narrow">No. Corte :</asp:label></TD>
					<td style="WIDTH: 119px; HEIGHT: 24px" width="119"><asp:label id="lblNoCorte" runat="server" Font-Bold="True" Font-Names="Verdana"></asp:label></td>
					<td style="HEIGHT: 24px"><asp:button id="btnGuarda" runat="server" Font-Size="8pt" Font-Names="Arial Narrow" Text="Guardar"
							CausesValidation="False"></asp:button></td>
				</TR>
  <TR>
    <TD style="WIDTH: 139px" align=center width=139 colSpan=3><asp:label id="lblMessage" runat="server" ForeColor="#C00000" Font-Size="8pt" Font-Names="Arial Narrow"
							Visible="False" Width="274px"></asp:label></TD></TR>
				<tr>
					<td style="WIDTH: 139px" align="right" width="139"><asp:label id="lblEtiqueta" runat="server" ForeColor="DarkBlue" Font-Bold="True" Font-Size="8pt"
							Font-Names="Arial Narrow">Etiqueta : </asp:label></td>
					<td style="WIDTH: 119px; HEIGHT: 24px" width="119"><asp:textbox id="tbEtiqueta" tabIndex="2" runat="server" Width="102px" Font-Size="8pt" Font-Names="Arial Narrow"></asp:textbox></td>
					<td style="WIDTH: 280px"><asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbEtiqueta"></asp:requiredfieldvalidator><asp:regularexpressionvalidator id="RegularExpressionValidator1" runat="server" Font-Size="8pt" Font-Names="Arial Narrow"
							ErrorMessage="ddddddd(7)" ControlToValidate="tbEtiqueta" ValidationExpression="\d\d\d\d\d\d\d"></asp:regularexpressionvalidator></td>
				</tr>
				<TR>
					<TD style="WIDTH: 139px" align="right" width="139"><asp:label id="lblEtiquetaAntc" runat="server" ForeColor="DarkBlue" Font-Bold="True" Font-Size="8pt"
							Font-Names="Arial Narrow">Etiqueta Ant : </asp:label></TD>
					<TD style="WIDTH: 119px; HEIGHT: 24px" align="center" width="119"><asp:label id="lblEtiquetaAnt" runat="server" BackColor="Green" ForeColor="White" Font-Bold="True"
							Font-Size="8pt" Font-Names="Arial"></asp:label></TD>
					<TD style="WIDTH: 280px"><asp:label id="lblResult" runat="server" ForeColor="DarkBlue" Font-Bold="True" Font-Size="8pt"
							Font-Names="Arial"></asp:label></TD>
				</TR>
				<TR>
					<TD align="center" width="139"></TD>
					<TD align="center" width="139" colSpan="2">T (<asp:label id="lblTotalCorte" runat="server" ForeColor="DarkBlue" Font-Bold="True" Font-Size="8pt"
							Font-Names="Arial"></asp:label>)&nbsp;- L (<asp:label id="lblTotalLeidas" runat="server" ForeColor="DarkBlue" Font-Bold="True" Font-Size="8pt"
							Font-Names="Arial"></asp:label>)&nbsp;= R (<asp:label id="lblTotalResta" runat="server" ForeColor="DarkBlue" Font-Bold="True" Font-Size="8pt"
							Font-Names="Arial"></asp:label>)</TD>
				</TR>
			</table>
			<table style="WIDTH: 288px" bgColor="gainsboro">
				<TR>
					<TD style="WIDTH: 139px" align="right" width="139"><asp:checkbox id="cbxGrid" runat="server" ForeColor="DarkBlue" Font-Bold="True" Font-Size="8pt"
							Font-Names="Arial Narrow" AutoPostBack="True" Text="Detalle"></asp:checkbox></TD>
					<TD style="WIDTH: 119px; HEIGHT: 24px" width="119"><asp:checkbox id="cbxReporte" runat="server" ForeColor="DarkBlue" Font-Bold="True" Font-Size="8pt"
							Font-Names="Arial Narrow" AutoPostBack="True" Text="Reporte"></asp:checkbox></TD>
					<TD style="WIDTH: 280px"><asp:button id="btnBorra" runat="server" Width="56px" Font-Size="8pt" Font-Names="Arial Narrow"
							Text="Borrar Ult." CausesValidation="False"></asp:button></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 86px" align="center" width="86" colSpan="3"><asp:textbox id="tbReport" runat="server" Width="276px" Font-Size="8pt" Font-Names="Arial Narrow"
							Visible="False" Height="90px" ReadOnly="True" TextMode="MultiLine"></asp:textbox></TD>
				</TR>
				<tr>
					<td vAlign="top" align="left" width="100" colSpan="3"><asp:datagrid id="dgEtiquetas" runat="server" Width="280px" Font-Size="7pt" Font-Names="Arial Narrow"
							Visible="False" AutoGenerateColumns="False">
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
					<td style="WIDTH: 139px"></td>
					<td style="WIDTH: 119px"><asp:button id="btnGeneraReporte" runat="server" Font-Size="8pt" Font-Names="Arial Narrow" Visible="False"
							Text="Reporte" DESIGNTIMEDRAGDROP="98"></asp:button></td>
					<TD></TD>
				</tr>
				<TR>
					<TD colSpan="3"></TD>
				</TR>
			</table>
			<INPUT class="textleft" id="hdnControlFocus" style="WIDTH: 20px" type="hidden" value="tbEtiqueta"
				name="hdnControlFocus" runat="server"> <INPUT class="textleft" id="hdnEstado" style="WIDTH: 20px" type="hidden" value="inicio"
				name="hdnEstado" runat="server">
		</form>
	</body>
</HTML>
