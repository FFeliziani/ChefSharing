using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChefSharingFrontend
{
    public partial class ChefSharing : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Session["SESSION_ID"].ToString()))
            {
                Server.Transfer("~/Login.aspx");
            }
        }
    }
}