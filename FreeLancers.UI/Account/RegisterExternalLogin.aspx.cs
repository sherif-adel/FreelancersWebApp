using System;
using System.Web;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using FreeLancer.Services;
using FreeLancers.Service.Contracts;
using Microsoft.AspNet.Membership.OpenAuth;
using Microsoft.Web.WebPages.OAuth;

namespace FreeLancers.UI.Account
{
    public partial class RegisterExternalLogin : System.Web.UI.Page
    {

        private UserService _userService;

        protected UserService UserService
        {
            get
            {
                if (_userService == null)
                    _userService = new UserService();
                return _userService;
            }
        }

        protected UserContract CurrentUser
        {
            get
            {
                if (Session["loggedUser"] != null)
                    return (UserContract)Session["loggedUser"];
                return null;
            }
            set
            {
                Session["loggedUser"] = value;
            }
        }

        protected string ProviderName
        {
            get { return (string)ViewState["ProviderName"] ?? String.Empty; }
            private set { ViewState["ProviderName"] = value; }
        }

        protected string ProviderDisplayName
        {
            get { return (string)ViewState["ProviderDisplayName"] ?? String.Empty; }
            private set { ViewState["ProviderDisplayName"] = value; }
        }

        protected string ProviderUserId
        {
            get { return (string)ViewState["ProviderUserId"] ?? String.Empty; }
            private set { ViewState["ProviderUserId"] = value; }
        }

        protected string ProviderUserName
        {
            get { return (string)ViewState["ProviderUserName"] ?? String.Empty; }
            private set { ViewState["ProviderUserName"] = value; }
        }

        protected void Page_Load()
        {
            if (!IsPostBack)
            {
                ProcessProviderResult();
            }
        }


        private void ProcessProviderResult()
        {
            var redirectUrl = "~/Account/RegisterExternalLogin";
            var returnUrl = Request.QueryString["ReturnUrl"];
            if (!String.IsNullOrEmpty(returnUrl))
            {
                redirectUrl += "?ReturnUrl=" + HttpUtility.UrlEncode(returnUrl);
            }
            // Verify the OpenAuth payload
            var authResult = OAuthWebSecurity.VerifyAuthentication(redirectUrl);
            ProviderDisplayName = authResult.Provider;

            if (!authResult.IsSuccessful)
            {
                HandeFailedLogin();
                return;
            }

            // Store the provider details in ViewState
            ProviderName = authResult.Provider;
            ProviderUserId = authResult.ProviderUserId;
            ProviderUserName = authResult.UserName;
            string email;
            string name;
            int roleId = 2;

            try
            {
                if (ProviderName.ToLower() == "facebook")
                {
                    email = authResult.ExtraData["username"];
                    name = authResult.ExtraData["name"];
                }
                else
                {
                    email = authResult.ExtraData["email"];
                    name = authResult.ExtraData["firstname"] + authResult.ExtraData["lastname"];
                }

                CurrentUser = AuthenticateUser(email, name, roleId);
            }
            catch (Exception)
            {
                HandeFailedLogin();
                return;
            }


        }

        private UserContract AuthenticateUser(string email, string name, int roleId)
        {
            UserContract user = UserService.ValidateLogin(email);
            if (user == null)
            {
                user = new UserContract() { FullName = name, Email = email, RoleID = roleId };
                UserService.Add(user);
            }
            return user;
        }

        private void HandeFailedLogin()
        {
            Title = "External login failed";
            userNameForm.Visible = false;

            ModelState.AddModelError("Provider", String.Format("External login {0} failed.", ProviderDisplayName));

        }

        private void RedirectToReturnUrl()
        {
            var returnUrl = Request.QueryString["ReturnUrl"];
            if (!String.IsNullOrEmpty(returnUrl) && OpenAuth.IsLocalUrl(returnUrl))
            {
                Response.Redirect(returnUrl);
            }
            else
            {
                Response.Redirect("~/");
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            RedirectToReturnUrl();
        }
    }
}