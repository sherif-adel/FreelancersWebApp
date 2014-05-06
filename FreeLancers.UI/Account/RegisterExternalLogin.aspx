<%@ Page Language="C#" Title="Register an external login" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterExternalLogin.aspx.cs" Inherits="FreeLancers.UI.Account.RegisterExternalLogin" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1>Your Authentication With <%: ProviderDisplayName %> is Complete</h1>
        <h2><%: ProviderUserName %>.</h2>
    </hgroup>

    
    <asp:ModelErrorMessage runat="server" ModelStateKey="Provider" CssClass="field-validation-error" />
    

    <asp:PlaceHolder runat="server" ID="userNameForm">
        <fieldset>
            <legend>Association Form</legend>
            <p>
                You've authenticated with <strong><%: ProviderDisplayName %></strong> as
                <strong><%: CurrentUser.Email %> </strong>.
            </p>
            <asp:Button runat="server" Text="Okay" ID="btnOk" OnClick="btnOk_Click" />
        </fieldset>
    </asp:PlaceHolder>
</asp:Content>
