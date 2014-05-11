using FreeLancers.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreeLancers.UI
{
    public partial class Main : System.Web.UI.MasterPage
    {
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

        private void SetLoginHeader()
        {
            userPanel.Visible = true;
            if (!string.IsNullOrEmpty(CurrentUser.FirstName + CurrentUser.LastName))
            {
                lblUserName.InnerText = CurrentUser.FirstName + " " + CurrentUser.LastName;
            }
            else
            {
                lblUserName.InnerText = CurrentUser.Email;
            }
        }

        private void SetAnonymousHeader()
        {
            userPanel.Visible = false;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (CurrentUser == null)
                SetAnonymousHeader();
            else
                SetLoginHeader();
        }
    }
}