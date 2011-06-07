<%@ Page language="c#" Codebehind="wseInicio.aspx.cs" AutoEventWireup="false" Inherits="WASistEti.Inicio" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Buscar Corte</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
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
	<body MS_POSITIONING="GridLayout" onload="setFocus()">
		<form id="Form1" method="post" runat="server">
			<table bgColor="gainsboro" style="WIDTH: 224px">
				<TR>
					<TD align="center" bgColor="#3366cc" colSpan="3" noWrap>
						<asp:label id="Label1" runat="server" Font-Size="8pt" Font-Names="Arial" BackColor="Transparent"
							ForeColor="White" Font-Bold="True" Width="276px">Buscar Corte</asp:label></TD>
				</TR>
				<tr>
					<td style="WIDTH: 50px" noWrap>
						<asp:Label id="lblCortes" runat="server" Font-Size="7pt" ForeColor="DarkBlue" Font-Bold="True">No. Corte :</asp:Label></td>
					<td style="WIDTH: 138px" noWrap>
						<asp:TextBox id="tbCorte" runat="server" Font-Size="8pt"></asp:TextBox></td>
					<td noWrap>
						<asp:Button id="btnMostrar" runat="server" Text="Buscar" Font-Size="8pt"></asp:Button></td>
				</tr>
				<tr>
					<td colspan="3" noWrap>
						<asp:DataGrid id="dgCortes" runat="server" AutoGenerateColumns="False" Font-Names="Arial Narrow"
							Font-Size="7pt">
							<AlternatingItemStyle ForeColor="White" BackColor="#0066CC"></AlternatingItemStyle>
							<ItemStyle Font-Names="Arial Narrow" ForeColor="White" BackColor="#3399FF"></ItemStyle>
							<HeaderStyle Font-Names="Arial Narrow" Font-Bold="True" ForeColor="White" BackColor="#0000CC"></HeaderStyle>
							<Columns>
								<asp:ButtonColumn Text="Sel." ButtonType="PushButton" CommandName="Select"></asp:ButtonColumn>
								<asp:BoundColumn Visible="False" DataField="id" HeaderText="id"></asp:BoundColumn>
								<asp:BoundColumn DataField="NoCorte" HeaderText="CORTE"></asp:BoundColumn>
								<asp:BoundColumn DataField="Contrato" HeaderText="CONTR."></asp:BoundColumn>
								<asp:BoundColumn DataField="Estilo" HeaderText="ESTILO"></asp:BoundColumn>
								<asp:BoundColumn DataField="Color" HeaderText="COLOR"></asp:BoundColumn>
								<asp:TemplateColumn Visible="False">
									<ItemTemplate>
										<asp:Button id="btnBorrar" runat="server" Text="Borrar" CausesValidation="True" CommandName="borrar"></asp:Button>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:ButtonColumn Text="Borrar" ButtonType="PushButton" CommandName="Delete"></asp:ButtonColumn>
							</Columns>
							<PagerStyle NextPageText="Siguiente&amp;gt;" PrevPageText="&amp;lt;Anterior"></PagerStyle>
						</asp:DataGrid></td>
				</tr>
			</table>
			<INPUT class="textleft" id="hdnControlFocus" style="WIDTH: 20px" type="hidden" value="tbCorte"
				name="hdnControlFocus" runat="server">
		</form>
	</body>
</HTML>
