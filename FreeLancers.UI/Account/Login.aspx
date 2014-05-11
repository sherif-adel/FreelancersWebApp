<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Account/AccountMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FreeLancers.UI.Account.Login" EnableViewState="true"%>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <%--<h1><%: Title %>.</h1>--%>
    </hgroup>
    <section id="loginForm">
        <asp:ModelErrorMessage ID="ModelErrorMessage1" runat="server" ModelStateKey="Login"
            CssClass="field-validation-error" SetFocusOnError="true" />
        <fieldset>
            <legend>Log in</legend>

            <div class="input-icon">
                <i class="fa fa-user"></i>
                <input id="txtUserName" class="form-control placeholder-no-fix" type="text" autocomplete="off" placeholder="email" name="email" runat="server" />
            </div>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUserName" CssClass="field-validation-error" ErrorMessage="The user name field is required." />

            <div class="input-icon">
                <i class="fa fa-lock"></i>
                <input id="txtPassword" class="form-control placeholder-no-fix" type="password" autocomplete="off" placeholder="Password" name="password" runat="server" />
            </div>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" CssClass="field-validation-error" ErrorMessage="The password field is required." />

            <asp:CheckBox runat="server" ID="cbRememberMe" Text="Remember Me ?" CssClass="checkbox" />

            <asp:Button runat="server" ID="btnLogin" Text="Log in" OnClick="btnLogin_Click" class="btn green pull-right"></asp:Button>
        </fieldset>
        <br />
        <p>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled" Text="Register" Font-Bold="true" Font-Underline="true" NavigateUrl="~/Account/Register.aspx"></asp:HyperLink>
            if you don't have an account.
        </p>
    </section>

    <section id="socialLoginForm">
        <uc:OpenAuthProviders runat="server" ID="OpenAuthLogin" />
    </section>
</asp:Content>
