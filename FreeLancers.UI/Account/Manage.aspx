<%@ Page Title="Manage Account" Language="C#" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="FreeLancers.UI.Account.Manage" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:content contentplaceholderid="MainContent" runat="server">
    <hgroup class="title">
        <%--<h1><%: Title %>.</h1>--%>
    </hgroup>

    <section id="passwordForm">
        <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
            <p class="message-success"><%: SuccessMessage %></p>
        </asp:PlaceHolder>

        <h2>You're logged in as <strong>
            <asp:Label ID="lblEmail" runat="server"></asp:Label></strong>
        </h2>
        <br />
        <asp:PlaceHolder runat="server" ID="setPassword" Visible="false">
            <fieldset>
                <legend>Set Local Password</legend>
                <div class="alert alert-warning">
                    You do not have a local password for this site. Add a local
                password so you can log in without an external login.
                </div>

                <div class="input-icon">
                    <i class="fa fa-lock"></i>
                    <input id="password" class="form-control placeholder-no-fix" type="password" autocomplete="off" placeholder="Password" name="password" runat="server" />
                </div>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="password"
                    CssClass="field-validation-error" ErrorMessage="The password field is required."
                    Display="Dynamic" ValidationGroup="SetPassword" />

                <asp:ModelErrorMessage runat="server" ModelStateKey="NewPassword" AssociatedControlID="password"
                    CssClass="field-validation-error" SetFocusOnError="true" />

                <div class="input-icon">
                    <i class="fa fa-lock"></i>
                    <input id="confirmPassword" class="form-control placeholder-no-fix" type="password" autocomplete="off" placeholder="Password" name="confirmPassword" runat="server" />
                </div>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="confirmPassword"
                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The confirm password field is required."
                    ValidationGroup="SetPassword" />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="confirmPassword"
                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The password and confirmation password do not match."
                    ValidationGroup="SetPassword" />
                <br />
                <asp:Button runat="server" Text="Set Password" ValidationGroup="SetPassword" OnClick="setPassword_Click" class="btn green pull-right" />
            </fieldset>
        </asp:PlaceHolder>
        <br />
        <asp:PlaceHolder runat="server" ID="manageDetails">
            <fieldset>
                <legend>Manage your Details</legend>
                <div class="panel panel-default">
                    <!-- Default panel contents -->
                    <div class="panel-heading">Account Details</div>

                    <table class="table">
                        <tr>
                            <td>
                                <asp:Label ID="lblFirstName" runat="server" AssociatedControlID="txtFirstName" Text="First Name:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtFullName" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName"
                                    CssClass="field-validation-error" ErrorMessage="The password field is required."
                                    Display="Dynamic" ValidationGroup="ManageDetails" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblMobileNo" runat="server" AssociatedControlID="txtMobile" Text="Mobile Number:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="txtMobile" TextMode="Number" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtMobile"
                                    CssClass="field-validation-error" ErrorMessage="The password field is required."
                                    Display="Dynamic" ValidationGroup="ManageDetails" />
                            </td>
                        </tr>
                    </table>
                </div>
                <asp:Button ID="btnSaveDetails" runat="server" Text="Save Details" ValidationGroup="ManageDetails" OnClick="btnSaveDetails_Click" class="btn green pull-right" />
            </fieldset>
        </asp:PlaceHolder>
        <br />
        <asp:PlaceHolder runat="server" ID="changePassword" Visible="false">
            <fieldset class="changePassword">
                <legend>Change Password</legend>
                <asp:ModelErrorMessage ID="ModelErrorMessage1" runat="server" ModelStateKey="NewPassword" AssociatedControlID="password"
                    CssClass="field-validation-error" SetFocusOnError="true" />

                <div>
                    <div class="input-icon">
                        <i class="fa fa-lock"></i>
                        <input id="txtCurrentPassword" class="form-control placeholder-no-fix" type="password" autocomplete="off" placeholder="Current Password" name="password" runat="server" />
                    </div>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCurrentPassword"
                        CssClass="field-validation-error" ErrorMessage="The current password field is required."
                        ValidationGroup="ChangePassword" />
                </div>
                <div>
                    <div>
                    <asp:ModelErrorMessage ID="ModelErrorMessage2" runat="server" ModelStateKey="CurrentPassword" AssociatedControlID="txtCurrentPassword"
                        CssClass="field-validation-error" SetFocusOnError="true" />
                    </div>
                    <div class="input-icon">
                        <i class="fa fa-lock"></i>
                        <input id="NewPassword" class="form-control placeholder-no-fix" type="password" autocomplete="off" placeholder="New Password" name="password" runat="server" />
                    </div>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="NewPassword"
                        CssClass="field-validation-error" ErrorMessage="The new password is required."
                        ValidationGroup="ChangePassword" />
                </div>
                <div>
                    <div class="input-icon">
                        <i class="fa fa-lock"></i>
                        <input id="ConfirmNewPassword" class="form-control placeholder-no-fix" type="password" autocomplete="off" placeholder="New Password Confirmation" name="password" runat="server" />
                    </div>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmNewPassword"
                        CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Confirm new password is required."
                        ValidationGroup="ChangePassword" />
                    <asp:CompareValidator runat="server" ControlToCompare="NewPassword" ControlToValidate="ConfirmNewPassword"
                        CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The new password and confirmation password do not match."
                        ValidationGroup="ChangePassword" />
                </div>
                <br />
                <asp:Button runat="server" Text="Change password" ValidationGroup="ChangePassword" OnClick="changePassword_Click" class="btn green pull-right" />
            </fieldset>
        </asp:PlaceHolder>
    </section>

    <script src="../Scripts/jquery-2.1.0.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            setActiveTab();
        });

        function setActiveTab() {
            var tab = $("#account");
            tab.addClass('active');
            tab.children("a").append("<span class='selected'></span>");
        }
    </script>

</asp:content>


