using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Confirmation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // Retrives post back information for Bill to Address
            DropDownList ddlState = (DropDownList)PreviousPage.FindControl("ddlState");
            string selectedState = ddlState.SelectedValue;
            string firstName = ((TextBox)PreviousPage.FindControl("txtFirstName")).Text;
            string lastName = ((TextBox)PreviousPage.FindControl("txtLastName")).Text;
            string street = ((TextBox)PreviousPage.FindControl("txtStreet")).Text;
            string city = ((TextBox)PreviousPage.FindControl("txtCity")).Text;
            string zip = ((TextBox)PreviousPage.FindControl("txtZip")).Text;

            lblb2Results.Text = String.Format("{0} {1} {2} {3}, {4} {5}",
                firstName, lastName, street, city, selectedState, zip);

            
            
            
            //Retrives post back information for Ship To Address
            DropDownList ddlShipState = (DropDownList)PreviousPage.FindControl("ddlShipState");
            string selectedShipState = ddlShipState.SelectedValue;
            string shipFirstName = ((TextBox)PreviousPage.FindControl("txtShipFirstName")).Text;
            string shipLastName = ((TextBox)PreviousPage.FindControl("txtShipLastName")).Text;
            string shipStreet = ((TextBox)PreviousPage.FindControl("txtShipStreet")).Text;
            string shipCity = ((TextBox)PreviousPage.FindControl("txtShipCity")).Text;
            string shipZip = ((TextBox)PreviousPage.FindControl("txtShipZip")).Text;

            lbls2Results.Text = String.Format("{0} {1} {2} {3}, {4} {5}",
                shipFirstName, shipLastName, shipStreet, shipCity, selectedShipState, shipZip);
        }

        catch
        {

            lblb2Results.Text = "The original page must contain " +
                "First Name, Last Name, street, City, and Zip controls";

            lbls2Results.Text = "The original page must contain " +
                "First Name, Last Name, street, City, and Zip controls";
        }
    }
}