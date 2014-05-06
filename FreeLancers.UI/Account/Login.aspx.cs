using FreeLancer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreeLancers.UI.Account
{
    public partial class Login : Page
    {
        private UserService _userService;

        public UserService UserService
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
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUserName.Text;
            string password = txtPassword.Text;

            var user = UserService.ValidateLogin(email, password);
            if (user != null)
            {
                Session["loggedUser"] = user;              
                //redirect according to role or return url 
            }
            else
            {
                ModelState.AddModelError("Login", "This Email is not registered");
            }

        }
    }
}