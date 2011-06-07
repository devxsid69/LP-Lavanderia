<%@ Page language="c#" Codebehind="wseTipoLectura.aspx.cs" AutoEventWireup="false" Inherits="WASistEti.wseTipoLectura" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wseTipoLectura</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 288px; POSITION: absolute; TOP: 8px"
				bgColor="gainsboro">
				<TR>
					<TD noWrap align="left" width="86" bgColor="#3366cc">
						<asp:hyperlink id="Hyperlink1" runat="server" Font-Names="Arial Narrow" ForeColor="#C0C0FF" NavigateUrl="wseInicio.aspx"><<</asp:hyperlink></TD>
					<TD noWrap align="center" width="86" bgColor="#3366cc" colSpan="2">
						<asp:label id="Label1" runat="server" Font-Size="8pt" Font-Names="Arial" BackColor="Transparent"
							ForeColor="White" Font-Bold="True" Width="128px">Tipo de Lectura</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 139px; HEIGHT: 24px" align="right" width="139">
						<asp:label id="lblCorte" runat="server" Font-Size="8pt" Font-Names="Arial Narrow" ForeColor="DarkBlue"
							Font-Bold="True">No. Corte :</asp:label></TD>
					<TD style="WIDTH: 119px; HEIGHT: 24px" width="119">
						<asp:label id="lblNoCorte" runat="server" Font-Names="Verdana" Font-Bold="True"></asp:label></TD>
					<TD style="HEIGHT: 24px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 139px; HEIGHT: 39px" align="right" width="139" colSpan="3">
						<P align="center">
							<asp:RadioButton id="rbPrimeras" runat="server" Font-Size="8pt" Font-Names="Arial" ForeColor="DarkBlue"
								Font-Bold="True" Width="275px" Text="Primeras" GroupName="TIPO" AutoPostBack="True"></asp:RadioButton>
							<asp:RadioButton id="RadioButton1" runat="server" Font-Size="8pt" Font-Names="Arial" ForeColor="DarkBlue"
								Font-Bold="True" Width="278px" Text="Segundas" GroupName="TIPO" AutoPostBack="True"></asp:RadioButton>
							<asp:RadioButton id="RadioButton2" runat="server" Font-Size="8pt" Font-Names="Arial" ForeColor="DarkBlue"
								Font-Bold="True" Width="275px" Text="Terceras" GroupName="TIPO" AutoPostBack="True"></asp:RadioButton>
							<asp:RadioButton id="RadioButton3" runat="server" Font-Size="8pt" Font-Names="Arial" ForeColor="DarkBlue"
								Font-Bold="True" Width="275px" Text="Saldos" GroupName="TIPO" AutoPostBack="True"></asp:RadioButton></P>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 139px" align="right" width="139"></TD>
					<TD style="WIDTH: 119px; HEIGHT: 24px" width="119">
						<asp:button id="btnContinuar" runat="server" Font-Size="8pt" Font-Names="Arial Narrow" Text="Continuar ->>"
							Visible="False" CausesValidation="False"></asp:button></TD>
					<TD style="WIDTH: 280px"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
