using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using courseMachineUi.parentService;
using courseMachineUi.ChildReference;

namespace courseMachineUi
{
    public partial class config : System.Web.UI.Page
    {
        /*
         Setting up
             */
        private string userId;
        private string courseId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userId"] == null)
            {
                //  Redirect
            }
            userId = Session["userId"].ToString();
            courseId = Request.QueryString["course"];
            if(courseId == null | courseId.Length <= 0)
            {
                // Redirect
            }

            title.Text = courseId;
        }

        protected void createParent(object sender, EventArgs e)
        {
            string parent = parentName.Value;
            if(parent.Length <= 3)
            {
                // Error Msg
            }
            IparentClient create = new IparentClient();
            string response = create.createString(parent, userId, courseId);
            Guid parentId = new Guid();
            try
            {
                parentId = new Guid(response);
            }
            catch
            {
                // Display Error
            }

        }
    }
}