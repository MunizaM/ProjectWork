using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCardDetails : System.Web.UI.Page
{
    protected void btnAddDetails(object sender, EventArgs e)
    {
        //store -1 into the the session object to indicate this is a new record
        Session["PaymentNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnPayment.aspx");
    }
}