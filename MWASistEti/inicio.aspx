<%@ Page language="c#" Codebehind="inicio.aspx.cs" Inherits="MWASistEti.inicio" AutoEventWireup="false" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<HEAD>
	<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
	<meta name="CODE_LANGUAGE" content="C#">
	<meta name="vs_targetSchema" content="http://schemas.microsoft.com/Mobile/Page">
</HEAD>
<body Xmlns:mobile="http://schemas.microsoft.com/Mobile/WebForm">
	<mobile:Form id="Form1" runat="server" BackColor="#0075AA">
		<TABLE border="1">
			<TR>
				<TD width="100">
					<mobile:Label id="lblCorte" runat="server" Font-Bold="True" ForeColor="White" Alignment="Left">No. Corte</mobile:Label>
				</TD>
				<TD>
					<mobile:TextBox id="tbCorte" runat="server"></mobile:TextBox>
				</TD>
				<TD>
					<mobile:Command id="btnBusca" runat="server">Buscar...</mobile:Command>
				</TD>
			</TR>
		</TABLE>
	</mobile:Form>
	<asp:DataGrid id="dgResultado" BackColor="White" runat="server" ForeColor="Black">
		<HeaderStyle ForeColor="White" BackColor="#0000CC"></HeaderStyle>
		<Columns>
			<asp:ButtonColumn Text="Select" HeaderText="Selec." CommandName="Select"></asp:ButtonColumn>
			<asp:BoundColumn DataField="Etiqueta" HeaderText="Etiqueta"></asp:BoundColumn>
			<asp:BoundColumn DataField="UPC" HeaderText="UPC"></asp:BoundColumn>
			<asp:BoundColumn DataField="tipocaja" HeaderText="Tipo de Caja"></asp:BoundColumn>
			<asp:BoundColumn DataField="talla" HeaderText="TALLA"></asp:BoundColumn>
			<asp:BoundColumn DataField="Prendas" HeaderText="Prendas"></asp:BoundColumn>
		</Columns>
	</asp:DataGrid>
</body>
