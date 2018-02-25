using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace courseMachineUi.Views.Config.course
{
    public partial class courseView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CourseHidden.Visible = false;
            if(Request.QueryString["courseId"] == null)
            {

            }
            try
            {
                Guid courseId = new Guid(Request.QueryString["courseId"]);
            }
            catch
            {
                Response.Redirect("http://localhost:63103/");
            }
            

        }
    }
}