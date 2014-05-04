using System;
using System.Collections.Generic;
using System.Linq;
using FreeLancer.Services;
using FreeLancers.Service.Contracts;
using Microsoft.AspNet.Membership.OpenAuth;
using Microsoft.Web.WebPages.OAuth;

namespace FreeLancers.UI.Account
{
	public partial class Manage : System.Web.UI.Page
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

		protected string SuccessMessage
		{
			get;
			private set;
		}

		protected void Page_Load()
		{
			if (!IsPostBack)
			{
				lblEmail.Text = CurrentUser.Email;
				// Determine the sections to render
				var hasLocalPassword = UserService.HasPassword(CurrentUser);
				setPassword.Visible = !hasLocalPassword;
				changePassword.Visible = hasLocalPassword;

				// Render success message
				var message = Request.QueryString["m"];
				if (message != null)
				{
					// Strip the query string from action
					Form.Action = ResolveUrl("~/Account/Manage");

					SuccessMessage =
						message == "ChangePwdSuccess" ? "Your password has been changed."
						: message == "SetPwdSuccess" ? "Your password has been set."
						: String.Empty;
					successMessage.Visible = !String.IsNullOrEmpty(SuccessMessage);
				}
			}

		}

		protected void setPassword_Click(object sender, EventArgs e)
		{
			if (IsValid)
			{
				CurrentUser.Password = password.Text;
				UserService.Update(CurrentUser);
				if (true)
				{
					Response.Redirect("~/Account/Manage?m=SetPwdSuccess");
				}
				else
				{

					//ModelState.AddModelError("NewPassword", result.ErrorMessage);

				}
			}
		}


		protected void changePassword_Click(object sender, EventArgs e)
		{
			if (IsValid)
			{
				if (CurrentUser.Password == CurrentPassword.Text)
				{

					CurrentUser.Password = NewPassword.Text;
					UserService.Update(CurrentUser);
					if (true)
					{
						Response.Redirect("~/Account/Manage?m=ChangePwdSuccess");
					}
					else
					{

						//ModelState.AddModelError("NewPassword", result.ErrorMessage);

					}
				}
				else
				{
					ModelState.AddModelError("NewPassword", "you current password is incorrect");
				}
			}
		}


		protected static string ConvertToDisplayDateTime(DateTime? utcDateTime)
		{
			// You can change this method to convert the UTC date time into the desired display
			// offset and format. Here we're converting it to the server timezone and formatting
			// as a short date and a long time string, using the current thread culture.
			return utcDateTime.HasValue ? utcDateTime.Value.ToLocalTime().ToString("G") : "[never]";
		}
	}
}