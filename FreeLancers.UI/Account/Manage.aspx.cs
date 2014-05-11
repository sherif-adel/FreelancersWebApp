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
        #region Properties
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

        public UserContract CurrentUser
        {
            get
            {
                if (Session["loggedUser"] != null)
                    return (UserContract)Session["loggedUser"];
                Session["loggedUser"] = UserService.GetById(2);
                return (UserContract)Session["loggedUser"];
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
        #endregion

        #region Protected Methods

        protected void Page_Load()
        {
            if (!IsPostBack)
            {
                SetPanelsVisablity();
                loadUserDetails();
            }

        }

        protected void setPassword_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    CurrentUser.Password = password.Value;
                    UserService.Update(CurrentUser);
                    SuccessMessage = "Password Added Successfully";
                    successMessage.Visible = !String.IsNullOrEmpty(SuccessMessage);
                    SetPanelsVisablity();
                }
                catch (Exception)
                {
                    ModelState.AddModelError("CurrentPassword", "Failed to Set Password");
                }
            }
        }

        protected void btnSaveDetails_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    CurrentUser.FirstName = txtFirstName.Text;
                    CurrentUser.LastName = txtLastName.Text;
                    CurrentUser.Mobile = int.Parse(txtMobile.Text);
                    UserService.Update(CurrentUser);
                    SuccessMessage = "Details Updated Successfully";
                    successMessage.Visible = !String.IsNullOrEmpty(SuccessMessage);
                }
                catch (Exception)
                {
                    ModelState.AddModelError("CurrentPassword", "Failed to update Details");
                    loadUserDetails();
                }
            }
        }

        protected void changePassword_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                if (CurrentUser.Password == txtCurrentPassword.Value)
                {

                    CurrentUser.Password = NewPassword.Value;
                    UserService.Update(CurrentUser);
                    SuccessMessage = "Password Updated Successfully";
                    successMessage.Visible = !String.IsNullOrEmpty(SuccessMessage);
                }
                else
                {
                    ModelState.AddModelError("CurrentPassword", "you current password is incorrect");
                }
            }
        }

        #endregion

        #region Private Methods

        private void SetPanelsVisablity()
        {
            var hasLocalPassword = UserService.HasPassword(CurrentUser);
            setPassword.Visible = !hasLocalPassword;
            changePassword.Visible = hasLocalPassword;
        }

        private void loadUserDetails()
        {
            lblEmail.Text = CurrentUser.Email;
            txtFirstName.Text = CurrentUser.FirstName;
            txtLastName.Text = CurrentUser.LastName;
            txtMobile.Text = CurrentUser.Mobile.HasValue ? CurrentUser.Mobile.Value.ToString() : string.Empty;
        }

        #endregion 

        protected static string ConvertToDisplayDateTime(DateTime? utcDateTime)
        {
            // You can change this method to convert the UTC date time into the desired display
            // offset and format. Here we're converting it to the server timezone and formatting
            // as a short date and a long time string, using the current thread culture.
            return utcDateTime.HasValue ? utcDateTime.Value.ToLocalTime().ToString("G") : "[never]";
        }
    }
}