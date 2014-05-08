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

			OAuthWebSecurity.RegisterFacebookClient("692376860819843","dec6dc180939f4dc8b417da4fcd1321e");
			OAuthWebSecurity.RegisterClient(new GoogleCustomClient(), "Google", null);

		}
	}
}