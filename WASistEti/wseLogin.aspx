<%@ Page language="c#" Codebehind="wseLogin.aspx.cs" AutoEventWireup="false" Inherits="WASistEti.wseLogin" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>REVISION DE EMBARQUE</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 112px; POSITION: absolute; TOP: 8px; HEIGHT: 99px"
				bgColor="gainsboro">
				<TR>
					<TD noWrap align="center" width="1" bgColor="#3366cc" colSpan="3">
						<asp:label id="lblTitulo" runat="server" Font-Size="8pt" Font-Names="Arial" BackColor="Transparent"
							ForeColor="White" Font-Bold="True" Width="276px">Entrar / Login</asp:label></TD>
				</TR>
				<TR>
					<TD noWrap width="38" style="WIDTH: 38px">
						<asp:Label id="lblUsuario" runat="server" Font-Size="7pt" ForeColor="DarkBlue" Font-Bold="True">Usuario :</asp:Label></TD>
					<TD noWrap width="80" style="WIDTH: 80px">
						<asp:TextBox id="tbUsuario" runat="server" Width="114px" Font-Size="8pt" Font-Names="Arial Narrow"></asp:TextBox></TD>
					<TD noWrap width="30">
						<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Font-Names="Arial Narrow" ErrorMessage="*"
							ControlToValidate="tbUsuario"></asp:RequiredFieldValidator></TD>
				</TR>
				<TR>
					<TD noWrap width="38" style="WIDTH: 38px">
						<asp:Label id="lblContraseña" runat="server" Font-Size="7pt" ForeColor="DarkBlue" Font-Bold="True">Contraseña :</asp:Label></TD>
					<TD noWrap width="80" style="WIDTH: 80px">
						<asp:TextBox id="tbCotraseña" runat="server" Width="113px" TextMode="Password" Font-Size="8pt"
							Font-Names="Arial Narrow"></asp:TextBox></TD>
					<TD noWrap width="30">
						<asp:Button id="btnEntrar" runat="server" Font-Size="8pt" Text="entrar"></asp:Button></TD>
				</TR>
				<TR>
					<TD noWrap width="1" colSpan="3" align="center">
						<asp:Label id="lblError" runat="server" Font-Size="8pt" Font-Names="Arial Narrow" ForeColor="Red"
							Width="272px"></asp:Label></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
