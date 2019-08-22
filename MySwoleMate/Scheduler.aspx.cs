using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySwoleMate
{
    public partial class Scheduler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AppointmentList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // empty for now, to get the page to display
        }
    }
}