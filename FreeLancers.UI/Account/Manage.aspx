<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="FreeLancers.UI.Account.Manage" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
    </hgroup>

    <section id="passwordForm">
        <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
            <p class="message-success"><%: SuccessMessage %></p>
        </asp:PlaceHolder>

        <p>You're logged in as <strong>
            <asp:Label ID="lblEmail" runat="server"></asp:Label></strong>.</p>

        <asp:PlaceHolder runat="server" ID="setPassword" Visible="false">
            <p>
                You do not have a local password for this site. Add a local
                password so you can log in without an external login.
            </p>
            <fieldset>
                <legend>Set Password Form</legend>
                <ol>
                    <li>
                        <asp:Label runat="server" AssociatedControlID="password">Password</asp:Label>
                        <asp:TextBox runat="server" ID="password" TextMode="Password" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="password"
                            CssClass="field-validation-error" ErrorMessage="The password field is required."
                            Display="Dynamic" ValidationGroup="SetPassword" />

                        <asp:ModelErrorMessage runat="server" ModelStateKey="NewPassword" AssociatedControlID="password"
                            CssClass="field-validation-error" SetFocusOnError="true" />

                    </li>
                    <li>
                        <asp:Label runat="server" AssociatedControlID="confirmPassword">Confirm password</asp:Label>
                        <asp:TextBox runat="server" ID="confirmPassword" TextMode="Password" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="confirmPassword"
                            CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The confirm password field is required."
                            ValidationGroup="SetPassword" />
                        <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="confirmPassword"
                            CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The password and confirmation password do not match."
                            ValidationGroup="SetPassword" />
                    </li>
                </ol>
                <asp:Button runat="server" Text="Set Password" ValidationGroup="SetPassword" OnClick="setPassword_Click" />
            </fieldset>
        </asp:PlaceHolder>

        <asp:PlaceHolder runat="server" ID="manageDetails"> 
            <h3>Manage your Details</h3>
            <fieldset>
                <legend>Set Password Form</legend>
                <ol>
                    <li>
                        <asp:Label ID="lblFirstName" runat="server" AssociatedControlID="txtFirstName" Text="First Name"></asp:Label>
                        <asp:TextBox runat="server" ID="txtFirstName" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName"
                            CssClass="field-validation-error" ErrorMessage="The password field is required."
                            Display="Dynamic" ValidationGroup="ManageDetails" />

                    </li>
                    <li>
                        <asp:Label ID="lblLastName" runat="server" AssociatedControlID="txtLastName" Text="Last Name"></asp:Label>
                        <asp:TextBox runat="server" ID="txtLastName" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName"
                            CssClass="field-validation-error" ErrorMessage="The password field is required."
                            Display="Dynamic" ValidationGroup="ManageDetails" />
                    </li>
                     <li>
                        <asp:Label ID="lblMobileNo" runat="server" AssociatedControlID="txtMobile" Text="Mobile Number"></asp:Label>
                        <asp:TextBox runat="server" ID="txtMobile" TextMode="Number" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtMobile"
                            CssClass="field-validation-error" ErrorMessage="The password field is required."
                            Display="Dynamic" ValidationGroup="ManageDetails" />
                    </li>
                </ol>
                <asp:Button ID="btnSaveDetails" runat="server" Text="Save Details" ValidationGroup="SetPassword" OnClick="btnSaveDetails_Click" />
            </fieldset>
        </asp:PlaceHolder>

        <asp:PlaceHolder runat="server" ID="changePassword" Visible="false">
            <h3>Change password</h3>
            <fieldset class="changePassword">
                <legend>Change password details</legend>
                <asp:ModelErrorMessage ID="ModelErrorMessage1" runat="server" ModelStateKey="NewPassword" AssociatedControlID="password"
                    CssClass="field-validation-error" SetFocusOnError="true" />
                <ol>
                    <li>
                        <asp:Label runat="server" ID="CurrentPasswordLabel" AssociatedControlID="txtCurrentPassword">Current password</asp:Label>
                        <asp:TextBox runat="server" ID="txtCurrentPassword" CssClass="passwordEntry" TextMode="Password" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCurrentPassword"
                            CssClass="field-validation-error" ErrorMessage="The current password field is required."
                            ValidationGroup="ChangePassword" />

                         <asp:ModelErrorMessage ID="ModelErrorMessage2" runat="server" ModelStateKey="CurrentPassword" AssociatedControlID="txtCurrentPassword"
                            CssClass="field-validation-error" SetFocusOnError="true" />
                    </li>
                    <li>
                        <asp:Label runat="server" ID="NewPasswordLabel" AssociatedControlID="NewPassword">New password</asp:Label>
                        <asp:TextBox runat="server" ID="NewPassword" CssClass="passwordEntry" TextMode="Password" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="NewPassword"
                            CssClass="field-validation-error" ErrorMessage="The new password is required."
                            ValidationGroup="ChangePassword" />
                    </li>
                    <li>
                        <asp:Label runat="server" ID="ConfirmNewPasswordLabel" AssociatedControlID="ConfirmNewPassword">Confirm new password</asp:Label>
                        <asp:TextBox runat="server" ID="ConfirmNewPassword" CssClass="passwordEntry" TextMode="Password" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmNewPassword"
                            CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Confirm new password is required."
                            ValidationGroup="ChangePassword" />
                        <asp:CompareValidator runat="server" ControlToCompare="NewPassword" ControlToValidate="ConfirmNewPassword"
                            CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The new password and confirmation password do not match."
                            ValidationGroup="ChangePassword" />
                    </li>
                </ol>
                <asp:Button runat="server" Text="Change password" ValidationGroup="ChangePassword" OnClick="changePassword_Click" />
            </fieldset>
        </asp:PlaceHolder>
    </section>

</asp:Content>
