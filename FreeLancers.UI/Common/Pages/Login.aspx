<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FreeLancers.UI.Users.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form runat="server">
		<table>
			<tr>
				<td>
					<asp:Label ID="lblEmail" Text="Email:" runat="server"></asp:Label>
				</td>
				<td>
					<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td>
					<asp:Label ID="lblPassword" Text="Password:" runat="server"></asp:Label>
				</td>
				<td>
					<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td>
					<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
				</td>
			</tr>
		</table>
	</form>
</body>
</html>
