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
        #region Properties

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

        #endregion

        #region Protected Methods

        protected void Page_Load(object sender, EventArgs e)
        {
            ReturnUrl = Request.QueryString["ReturnUrl"];
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            var result = UserService.Search(x => x.Email == txtEmail.Value);
            if (result == null || result.Count == 0)
            {
                UserContract user = new UserContract();
                user.Email = txtEmail.Value;
                user.Password = txtPassword.Value;
                user.RoleID = int.Parse(RBLRoles.SelectedValue);
                UserService.Add(user);
                //Redirect according to Role or according to querystring
            }
            else
            {
                ModelState.AddModelError("NewUser", "This Email is already registered");
            }
        }

        #endregion
    }
}