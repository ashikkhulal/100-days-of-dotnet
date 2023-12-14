using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormApp
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Session["BackButtonClicked"] = "Yes";
            if (Session["URLStack"] != null)
            {
                Stack<string> urlStack = (Stack<string>)Session["URLStack"];
                if(urlStack.Count > 0)
                {
                    string lastVisitedURL = urlStack.Pop();
                    Response.Redirect(lastVisitedURL);
                }
                else
                {
                    LblMessage.Text = "There are no pages in history!";
                }
                
            }
        }
    }
}