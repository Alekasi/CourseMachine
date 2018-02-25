using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using courseMachineUi.userReference;

namespace courseMachineUi.Views.LogReg
{
    public partial class logReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userId"] != null)
            {
                //  Redirect
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            string email = loginEmail.ToString().Length <= 0 ? "" : loginEmail.ToString();
            string password = loginPassword.ToString().Length <= 0 ? "" : loginPassword.ToString();
            bool error = false;
            List<string> errors = new List<string>();
            errorContainer.InnerHtml = "";

            if (email.Length <= 0)
            {
                //  Show error
                error = true;
                errors.Add("Email must be provided");
            }
            else if (password.Length <= 0)
            {
                //  Show error
                error = true;
                errors.Add("Password must be provided");
            }

            if(error == true)
            {
                errorContainer.InnerHtml += "<ul>";
                foreach (string err in errors)
                {
                    errorContainer.InnerHtml += "<li>" + err + "</li>";
                }
                errorContainer.InnerHtml += "</ul>";
                return;
            }

            login log = new login();
            log.user = email;
            log.password = password;
            IuserClient client = new IuserClient();

            string response = client.userLogin(log);
            try
            {

                Session["userId"] = new Guid(response);
                //  Redirect to main page
                Server.Transfer("~/");
            }
            catch
            {
                //  Show error
            }
        }

        protected void loginLink_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Account/Login.aspx");
        }

        protected void registerLink_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Account/Register.aspx");
        }
    }
}