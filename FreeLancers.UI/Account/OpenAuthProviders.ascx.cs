using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.AspNet.Membership.OpenAuth;
using Microsoft.Web.WebPages.OAuth;

namespace FreeLancers.UI.Account
{
    public partial class OpenAuthProviders : System.Web.UI.UserControl
    {
        public string ReturnUrl
        {
            get { return (string)ViewState["ReturnUrl"] ?? String.Empty; }
            set { ViewState["ReturnUrl"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string provider;
            if (!String.IsNullOrEmpty(Request.QueryString["provider"]))
            {
                provider = Request.QueryString["provider"];
            }
            else
            {
                return;
            }

            var redirectUrl = "~/Account/RegisterExternalLogin";
            if (!String.IsNullOrEmpty(ReturnUrl))
            {
                var resolvedReturnUrl = ResolveUrl(ReturnUrl);
                redirectUrl += "?ReturnUrl=" + HttpUtility.UrlEncode(resolvedReturnUrl);
            }

            OAuthWebSecurity.RequestAuthentication(provider, redirectUrl);
        }
    }
}