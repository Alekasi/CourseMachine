using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using courseMachineUi.userReference;

namespace courseMachineUi.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AccountRegister_Click(object sender, EventArgs e)
        {
            string response = "";
            int error = 0;
            if (userEmail.Value == null || userEmail.Value.Length <= 0)
            {
                response += "<li>Email Null</li>";
                error++;
            }

            if (userPassword.Value == null || userPassword.Value.Length <= 0)
            {
                response += "<li>PassWord Null</li>";
                error++;

            }
            else if (passwordConfirm.Value == null || passwordConfirm.Value.Length <= 0)
            {
                response += "<li>PassWord(2) Null</li>";
                error++;
            }

            if (error <= 0)
            {
                IuserClient user = new IuserClient();
                register regUser = new register();
                regUser.name = "";
                regUser.firstname = "";
                regUser.lastname = "";
                regUser.email = userEmail.Value;
                regUser.password = userPassword.Value;

                string userId = user.userRegister(regUser);
                try
                {
                    Guid userGuid = new Guid(userId);
                    Session["userId"] = userGuid.ToString();
                    response += "<li>Account created succesfully</li>";
                }
                catch
                {
                    response += "<li>Error : " + userId + "</li>";
                }
            }
            createAccountLabel.InnerText = response;
        }
        
    }
}