using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Membership.OpenAuth;
using Microsoft.Web.WebPages.OAuth;

namespace FreeLancers.UI
{
	internal static class AuthConfig
	{
		public static void RegisterOpenAuth()
		{
			OAuthWebSecurity.RegisterClient(new MicrosoftScopedClient("0000000044119886",
			"3bdr0qoxJLpfHRuBQuC4rZUmJ6wTrzSP",
			"wl.basic wl.emails"
			), "Microsoft", null);

			//OAuthWebSecurity.RegisterGoogleClient();
			OAuthWebSecurity.RegisterClient(new GoogleCustomClient(), "Google", null);

		}
	}
}