<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FreeLancers.UI.Account.Login" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <%--<h1><%: Title %>.</h1>--%>
    </hgroup>
    <section id="loginForm">
        <h2>Use a local account to log in.</h2>
        <asp:ModelErrorMessage ID="ModelErrorMessage1" runat="server" ModelStateKey="Login"
            CssClass="field-validation-error" SetFocusOnError="true" />
        <fieldset>
            <legend>Log in Form</legend>
            <ol>
                <li>
                    <asp:Label runat="server" AssociatedControlID="txtUserName">User name</asp:Label>
                    <asp:TextBox runat="server" ID="txtUserName" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUserName" CssClass="field-validation-error" ErrorMessage="The user name field is required." />
                </li>
                <li>
                    <asp:Label runat="server" AssociatedControlID="txtPassword">Password</asp:Label>
                    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" CssClass="field-validation-error" ErrorMessage="The password field is required." />
                </li>
                <li>
                    <asp:CheckBox runat="server" ID="cbRememberMe" />
                    <asp:Label runat="server" AssociatedControlID="cbRememberMe" CssClass="checkbox">Remember me?</asp:Label>
                </li>
            </ol>
            <asp:Button runat="server" ID="btnLogin" Text="Log in" OnClick="btnLogin_Click" />
        </fieldset>
        <p>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled" Text="Register" NavigateUrl="~/Account/Register.aspx"></asp:HyperLink>
            if you don't have an account.
        </p>
    </section>

    <section id="socialLoginForm">
        <h2>Use another service to log in.</h2>
        <uc:OpenAuthProviders runat="server" ID="OpenAuthLogin" />
    </section>
</asp:Content>
