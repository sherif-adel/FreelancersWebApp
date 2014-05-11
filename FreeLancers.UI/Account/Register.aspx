<%@ Page Title="Register" Language="C#" MasterPageFile="~/Account/AccountMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FreeLancers.UI.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <hgroup class="title">
        <%--<h1><%: Title %>.</h1>
        <h2>Use the form below to create a new account.</h2>--%>
    </hgroup>


    <fieldset>
        <legend>Registration Form</legend>

        <div class="alert alert-warning">
            Passwords are required to be a minimum of 6 characters in length.
        </div>

        <div>
            <asp:ModelErrorMessage ID="ModelErrorMessage1" runat="server" ModelStateKey="NewUser"
                CssClass="field-validation-error" SetFocusOnError="true" />
        </div>

        <div>
            <asp:Label ID="lblRole" runat="server" AssociatedControlID="RBLRoles">Select Role:</asp:Label>
            <asp:RadioButtonList ID="RBLRoles" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True" Value="2" Text="User"></asp:ListItem>
                <asp:ListItem Value="3" Text="Freelancer"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RBLRoles"
                CssClass="field-validation-error" ErrorMessage="The email address field is required." />
        </div>

        <div class="input-icon">
            <i class="fa fa-user"></i>
            <input id="txtEmail" class="form-control placeholder-no-fix" type="text" autocomplete="off" placeholder="email" name="email" runat="server" />
        </div>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail"
            CssClass="field-validation-error" ErrorMessage="The email address field is required." />
        <div class="input-icon">
            <i class="fa fa-lock"></i>
            <input id="txtPassword" class="form-control placeholder-no-fix" type="password" autocomplete="off" placeholder="Password" name="password" runat="server" />
        </div>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
            CssClass="field-validation-error" ErrorMessage="The password field is required." />

        <div class="input-icon">
            <i class="fa fa-lock"></i>
            <input id="txtConfirmPassword" class="form-control placeholder-no-fix" type="password" autocomplete="off" placeholder="Password" name="password" runat="server" />
        </div>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtConfirmPassword"
            CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The confirm password field is required." />
        <asp:CompareValidator runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword"
            CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
        <br />
        <asp:Button runat="server" Text="Register" ID="btnRegister" OnClick="btnRegister_Click" class="btn blue pull-right" />
    </fieldset>
</asp:Content>
