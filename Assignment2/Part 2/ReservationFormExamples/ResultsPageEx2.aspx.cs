using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResultsPageEx2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            RegistrationInfo ri = PreviousPage.RegistrationInfo;

            lblResults.Text = String.Format(" {0} {1} selected the event {2}",
                ri.FirstName, ri.LastName, ri.SelectedEvent);

        }

        catch
        {
            lblResults.Text = "The originating page must contain " +
                "txtFirstName, txtLastName, txtEmail controls";
        }

    }
}