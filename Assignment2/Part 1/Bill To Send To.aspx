<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bill To Send To.aspx.cs" Inherits="Bill_To_Send_To" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 23px;
        }
        .style5
        {
            height: 7px;
        }
        .style8
        {
            height: 7px;
            width: 80px;
        }
        .style12
        {
            width: 507px;
        }
        .style31
        {
            height: 23px;
            width: 80px;
        }
        .style32
        {
            width: 80px;
        }
        .style33
        {
            height: 23px;
            width: 300px;
        }
        .style34
        {
            width: 300px;
        }
        .style35
        {
            width: 36px;
        }
        .style36
        {
            width: 96px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
    <!-- 
 ********************************************************************************************************************
                                                  Bill TO ADDRESSS
************************************************************************************************************************-->
     
    <div>
     <strong>Bill To Address</strong>
    
        <table  class="style1">
            <tr>
                <td class="style31">
                    <asp:Label ID="lblFirstName" runat="server" Text="First Name: "></asp:Label>
                </td>
                <td class="style33">
                    <asp:TextBox ID="txtFirstName" runat="server" Width="251px" 
                        style="margin-left: 0px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorBfname" ControlToValidate="txtFirstName" runat="server" ErrorMessage="First Name is required">*</asp:RequiredFieldValidator>
                </td>
                <td class="style31">
                    <asp:Label ID="lblLastName" runat="server" Text="Last Name: "></asp:Label>
                </td>
                <td class="style2" colspan="3">
                    <asp:TextBox ID="txtLastName" runat="server" style="margin-left: 0px" 
                        Width="250px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidatorBlname"  ControlToValidate="txtLastName" runat="server" ErrorMessage="Last Name is required">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style8">
                    <asp:Label ID="lblStreet" runat="server" Text="Street: "></asp:Label>
                </td>
                <td class="style5" colspan="5">
                    <asp:TextBox ID="txtStreet" runat="server" Width="686px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  ControlToValidate="txtStreet" runat="server" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style32">
                    <asp:Label ID="lblCity" runat="server" Text="City: "></asp:Label>
                </td>
                <td class="style34">
                    <asp:TextBox ID="txtCity" runat="server" Width="251px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"  ControlToValidate="txtCity" runat="server" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                    </td>
                <td class="style32">
                    <asp:Label ID="lblState" runat="server" Text="State: "></asp:Label>
                    
                </td>
                <td class="style36">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3"  ControlToValidate="ddlState" runat="server" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                    <asp:DropDownList ID="ddlState" runat="server" Width="96px" 
                       >
                        <asp:ListItem>Alabama</asp:ListItem>
                        <asp:ListItem Value="Alaska"/> <asp:ListItem Value="Arizona"/> <asp:ListItem Value="Arkansas"/> <asp:ListItem Value="California"/> <asp:ListItem Value="Colorado"/> <asp:ListItem Value="Connecticut"/> <asp:ListItem Value="D.C."/> <asp:ListItem Value="Delaware"/> <asp:ListItem Value="Florida"/> <asp:ListItem Value="Georgia"/> <asp:ListItem Value="Hawaii"/> <asp:ListItem Value="Idaho"/> <asp:ListItem Value="Illinois"/> <asp:ListItem Value="Indiana"/> <asp:ListItem Value="Iowa"/> <asp:ListItem Value="Kansas"/> <asp:ListItem Value="Kentucky"/> <asp:ListItem Value="Louisiana"/> <asp:ListItem Value="Maine"/> <asp:ListItem Value="Maryland"/> <asp:ListItem Value="Massachusetts"/> <asp:ListItem Value="Michigan"/> <asp:ListItem Value="Minnesota"/> <asp:ListItem Value="Mississippi"/> <asp:ListItem Value="Missouri"/> <asp:ListItem Value="Montana"/> <asp:ListItem Value="Nebraska"/> <asp:ListItem Value="Nevada"/> <asp:ListItem Value="New Hampshire"/> <asp:ListItem Value="New Jersey"/> <asp:ListItem Value="New Mexico"/> <asp:ListItem Value="New York"/> <asp:ListItem Value="North Carolina"/> <asp:ListItem Value="North Dakota"/> <asp:ListItem Value="Ohio"/> <asp:ListItem Value="Oklahoma"/> <asp:ListItem Value="Oregon"/> <asp:ListItem Value="Pennsylvania"/> <asp:ListItem Value="Rhode Island"/> <asp:ListItem Value="South Carolina"/> <asp:ListItem Value="South Dakota"/> <asp:ListItem Value="Tennessee"/> <asp:ListItem Value="Texas"/> <asp:ListItem Value="Utah"/> <asp:ListItem Value="Vermont"/> <asp:ListItem Value="Virginia"/> <asp:ListItem Value="Washington"/> <asp:ListItem Value="West Virginia"/> <asp:ListItem Value="Wisconsin"/> <asp:ListItem Value="Wyoming"/> 
                    </asp:DropDownList>
                    
                    </td>
                <td class="style35">
                    <asp:Label ID="lblZip" runat="server" Text="ZIP: "></asp:Label>
                    </td>
                <td class="style12">
                    <asp:TextBox ID="txtZip" runat="server" style="margin-left: 0px" Width="94px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4"   ControlToValidate="txtZip" runat="server" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                    </td>
            </tr>
        </table>
     </div>
 
 <!-- 
 ********************************************************************************************************************
                                                  SHIP TO ADDRESS
************************************************************************************************************************-->
     
    <hr />
     <div>
     <strong>Ship To Address</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox 
             ID="CheckBox1" runat="server" Text="Ship to same address" 
             oncheckedchanged="CheckBox1_CheckedChanged" AutoPostBack="True" />
    
        <table  class="style1">
            <tr>
                <td class="style31">
                    <asp:Label ID="lblShipFirstName" runat="server" Text="First Name: "></asp:Label>
                </td>
                <td class="style33">
                    <asp:TextBox ID="txtShipFirstName" runat="server" Width="251px" 
                        style="margin-left: 0px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5"   ControlToValidate="txtShipFirstName" runat="server" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                </td>
                <td class="style31">
                    <asp:Label ID="lblShipLastName" runat="server" Text="Last Name: "></asp:Label>
                </td>
                <td class="style2" colspan="3">
                    <asp:TextBox ID="txtShipLastName" runat="server" style="margin-left: 0px" 
                        Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6"   ControlToValidate="txtShipLastName" runat="server" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style8">
                    <asp:Label ID="lblShipStreet" runat="server" Text="Street: "></asp:Label>
                </td>
                <td class="style5" colspan="5">
                    <asp:TextBox ID="txtShipStreet" runat="server" Width="686px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7"   ControlToValidate="txtShipStreet" runat="server" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style32">
                    <asp:Label ID="lblShipCity" runat="server" Text="City: "></asp:Label>
                </td>
                <td class="style34">
                    <asp:TextBox ID="txtShipCity" runat="server" Width="251px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8"   ControlToValidate="txtShipCity" runat="server" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                    </td>
                <td class="style32">
                    <asp:Label ID="lblShipState" runat="server" Text="State: "></asp:Label>
                </td>
                <td class="style36">
                    <asp:DropDownList ID="ddlShipState" runat="server" Width="96px">
                        <asp:ListItem>Alabama</asp:ListItem>
                        <asp:ListItem Value="Alaska"/> <asp:ListItem Value="Arizona"/> <asp:ListItem Value="Arkansas"/> <asp:ListItem Value="California"/> <asp:ListItem Value="Colorado"/> <asp:ListItem Value="Connecticut"/> <asp:ListItem Value="D.C."/> <asp:ListItem Value="Delaware"/> <asp:ListItem Value="Florida"/> <asp:ListItem Value="Georgia"/> <asp:ListItem Value="Hawaii"/> <asp:ListItem Value="Idaho"/> <asp:ListItem Value="Illinois"/> <asp:ListItem Value="Indiana"/> <asp:ListItem Value="Iowa"/> <asp:ListItem Value="Kansas"/> <asp:ListItem Value="Kentucky"/> <asp:ListItem Value="Louisiana"/> <asp:ListItem Value="Maine"/> <asp:ListItem Value="Maryland"/> <asp:ListItem Value="Massachusetts"/> <asp:ListItem Value="Michigan"/> <asp:ListItem Value="Minnesota"/> <asp:ListItem Value="Mississippi"/> <asp:ListItem Value="Missouri"/> <asp:ListItem Value="Montana"/> <asp:ListItem Value="Nebraska"/> <asp:ListItem Value="Nevada"/> <asp:ListItem Value="New Hampshire"/> <asp:ListItem Value="New Jersey"/> <asp:ListItem Value="New Mexico"/> <asp:ListItem Value="New York"/> <asp:ListItem Value="North Carolina"/> <asp:ListItem Value="North Dakota"/> <asp:ListItem Value="Ohio"/> <asp:ListItem Value="Oklahoma"/> <asp:ListItem Value="Oregon"/> <asp:ListItem Value="Pennsylvania"/> <asp:ListItem Value="Rhode Island"/> <asp:ListItem Value="South Carolina"/> <asp:ListItem Value="South Dakota"/> <asp:ListItem Value="Tennessee"/> <asp:ListItem Value="Texas"/> <asp:ListItem Value="Utah"/> <asp:ListItem Value="Vermont"/> <asp:ListItem Value="Virginia"/> <asp:ListItem Value="Washington"/> <asp:ListItem Value="West Virginia"/> <asp:ListItem Value="Wisconsin"/> <asp:ListItem Value="Wyoming"/> 
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9"   ControlToValidate="ddlShipState" runat="server" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                    </td>
                <td class="style35">
                    <asp:Label ID="lblShipZip" runat="server" Text="ZIP: "></asp:Label>
                    </td>
                <td class="style12">
                    <asp:TextBox ID="txtShipZip" runat="server" style="margin-left: 0px" 
                        Width="94px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10"   ControlToValidate="txtShipZip" runat="server" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
                    </td>
            </tr>
        </table>
     </div>
    
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
        PostBackUrl="confirmation.aspx" />
    </form>
</body>
</html>