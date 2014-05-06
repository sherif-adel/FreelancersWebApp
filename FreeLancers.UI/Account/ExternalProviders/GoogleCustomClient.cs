using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetOpenAuth.AspNet.Clients;
using DotNetOpenAuth.OpenId.Extensions.AttributeExchange;
using DotNetOpenAuth.OpenId.RelyingParty;

namespace FreeLancers.UI
{
	public class GoogleCustomClient : OpenIdClient
	{
		#region Constructors and Destructors

		public GoogleCustomClient()
			: base("google", WellKnownProviders.Google) { }

		#endregion

		#region Methods

		/// <summary>
		/// Gets the extra data obtained from the response message when authentication is successful.
		/// </summary>
		/// <param name="response">
		/// The response message. 
		/// </param>
		/// <returns>A dictionary of profile data; or null if no data is available.</returns>
		protected override Dictionary<string, string> GetExtraData(IAuthenticationResponse response)
		{
			FetchResponse fetchResponse = response.GetExtension<FetchResponse>();
			if (fetchResponse != null)
			{
				var extraData = new Dictionary<string, string>();
				extraData.Add("email", fetchResponse.GetAttributeValue(WellKnownAttributes.Contact.Email));
				extraData.Add("country", fetchResponse.GetAttributeValue(WellKnownAttributes.Contact.HomeAddress.Country));
				extraData.Add("firstname", fetchResponse.GetAttributeValue(WellKnownAttributes.Name.First));
				extraData.Add("lastname", fetchResponse.GetAttributeValue(WellKnownAttributes.Name.Last));

				return extraData;
			}

			return null;
		}

		/// <summary>
		/// Called just before the authentication request is sent to service provider.
		/// </summary>
		/// <param name="request">
		/// The request. 
		/// </param>
		protected override void OnBeforeSendingAuthenticationRequest(IAuthenticationRequest request)
		{
			// Attribute Exchange extensions
			var fetchRequest = new FetchRequest();
			fetchRequest.Attributes.AddRequired(WellKnownAttributes.Contact.Email);
			fetchRequest.Attributes.AddRequired(WellKnownAttributes.Contact.HomeAddress.Country);
			fetchRequest.Attributes.AddRequired(WellKnownAttributes.Name.First);
			fetchRequest.Attributes.AddRequired(WellKnownAttributes.Name.Last);

			request.AddExtension(fetchRequest);
		}

		#endregion
	}
}