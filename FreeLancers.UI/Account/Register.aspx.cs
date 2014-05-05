using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreeLancer.Services;
using FreeLancers.Service.Contracts;
using Microsoft.AspNet.Membership.OpenAuth;

namespace FreeLancers.UI.Account
{
	public partial class Register : Page
	{
		public string ReturnUrl;

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

		protected void Page_Load(object sender, EventArgs e)
		{
			ReturnUrl = Request.QueryString["ReturnUrl"];
		}

		protected void RegisterUser_CreatedUser(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(ReturnUrl))
			{
				ReturnUrl = "~/";
			}
			Response.Redirect(ReturnUrl);
		}

		protected void btnRegister_Click(object sender, EventArgs e)
		{           
			UserContract user = new UserContract();
            UserService.Search(x => x.Email == txtEmail.Text);
		}
	}
}