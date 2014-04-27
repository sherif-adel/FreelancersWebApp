using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreeLancer.Services;
using FreeLancers.Service.Contracts;
using FreeLancers.UI.Utility;

namespace FreeLancers.UI.Users
{
	public partial class Login : System.Web.UI.Page
	{
		private IUserService _userService;

		IUserService UserService
		{
			get
			{
				if (_userService == null)
					_userService = new UserService();
				return _userService;
			}
		}

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			string email = txtEmail.Text;
			string password = txtPassword.Text;
			UserContract user = UserService.ValidateLogin(email, password);
			if (user != null)
			{
				Session[Constants.UserSessionKey] = user;
				//redirect
			}
			else
			{

			}
		}
	}
}