using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.AspNet.Membership.OpenAuth;
using Microsoft.Web.WebPages.OAuth;

namespace FreeLancers.UI.Account
{
	public partial class OpenAuthProviders : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			if (IsPostBack)
			{
				var provider = Request.Form["provider"];
				if (provider == null)
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



		public string ReturnUrl { get; set; }



		public IEnumerable<Provider> GetProviderNames()
		{
			List<Provider> x = new List<Provider>();
			x.Add(new Provider("Microsoft", "Microsoft"));
			x.Add(new Provider("Google", "Google"));
			x.Add(new Provider("Twitter", "Twitter"));

			return x;
		}

	}

	public class Provider
	{
		public string ProviderDisplayName;
		public string ProviderName;
		public Provider(string ProviderDisplayName, string ProviderName)
		{
			this.ProviderDisplayName = ProviderDisplayName;
			this.ProviderName = ProviderName;
		}

	}
}