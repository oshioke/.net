using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResultsPageEx1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            DropDownList ddlEvents = (DropDownList)PreviousPage.FindControl("ddlEvents");
            string selectedEvent = ddlEvents.SelectedValue;
            string firstName = ((TextBox)PreviousPage.FindControl("txtFirstName")).Text;
            string lastName = ((TextBox)PreviousPage.FindControl("txtLastName")).Text;
            string email = ((TextBox)PreviousPage.FindControl("txtEmail")).Text;
            lblResults.Text = String.Format("{0} {1} selected the event {2}",
                firstName, lastName, selectedEvent);
        }

        catch
        {
            lblResults.Text = "The originating page must contain " +
                "txtFirstName, txtLastName, txtEmail controls";
        }

    }
}