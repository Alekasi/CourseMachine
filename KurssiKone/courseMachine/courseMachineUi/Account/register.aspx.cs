using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using courseMachineUi.userReference;

namespace courseMachineUi.Account
{
    public partial class emailConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void registerButton_Click(object sender, EventArgs e)
        {
            var email = registerEmail.ToString();
            var password = registerPassword.ToString();
            var rePassword = registerRePassword.ToString();
            List<string> errors = new List<string>();
            bool error = false;
            errorContainer.InnerHtml = "";

            if (email.Length <= 0)
            {
                //  Show null error
                error = true;
                errors.Add("Email cannot be null");
            }

            if (password.Length < 8)
            {
                //  Show null error
                error = true;
                errors.Add("Password must be atleast 8 characters");
            }

            if (!password.All(char.IsDigit))
            {
                //  Password needs to contain digit
                error = true;
                errors.Add("Password must contain digit");
            }

            if (!password.All(c => char.IsUpper(c)))
            {
                //  Password needs to contain uppercase
                error = true;
                errors.Add("Password must contain uppercase");
            }

            if (rePassword.Length <= 0)
            {
                //  Show null error
                error = true;
                errors.Add("Password cannot be left null");
            }

            if (password != rePassword)
            {
                //  Show passwords dont match
                error = true;
                errors.Add("Passwords need to macth");
            }
            if (error == true)
            {
                errorContainer.InnerHtml += "<ul>";
                foreach (string err in errors)
                {
                    errorContainer.InnerHtml += "<li>" + err + "</li>";
                }
                errorContainer.InnerHtml += "</ul>";
                return;
            }

            register reg = new register();
            IuserClient user = new IuserClient();
            string response = user.userRegister(reg);
            try
            {
                Guid userId = new Guid(response);
            }
            catch
            {
                //  Show error
            }

            //  Redirect to "Check your email page"
            Server.Transfer("~/Account/register.aspx");
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