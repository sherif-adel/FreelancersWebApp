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

			// Build the redirect url for OpenAuth verification
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
				Title = "External login failed";
				userNameForm.Visible = false;

				ModelState.AddModelError("Provider", String.Format("External login {0} failed.", ProviderDisplayName));

				// To view this error, enable page tracing in web.config (<system.web><trace enabled="true"/></system.web>) and visit ~/Trace.axd
				Trace.Warn("OpenAuth", String.Format("There was an error verifying authentication with {0})", ProviderDisplayName), authResult.Error);
				return;
			}
			// Store the provider details in ViewState
			ProviderName = authResult.Provider;
			ProviderUserId = authResult.ProviderUserId;
			ProviderUserName = authResult.UserName;

			var user = UserService.ValidateLogin(authResult.ExtraData["email"]);
			if (user == null)
			{
				user = new UserContract() { FirstName = authResult.ExtraData["firstname"], LastName = authResult.ExtraData["lastname"], Email = authResult.ExtraData["email"], RoleID = 2 };
				UserService.Add(user);
			}
			CurrentUser = user;

			// Strip the query string from action
			Form.Action = ResolveUrl(redirectUrl);

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