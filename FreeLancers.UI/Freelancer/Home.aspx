<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FreeLancers.UI.Freelancer.Home" %>

<%@ Register Src="~/Freelancer/ManageProfile.ascx" TagPrefix="uc1" TagName="ManageProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:ManageProfile runat="server" id="ManageProfile" />
    </div>
    </form>
</body>
</html>
