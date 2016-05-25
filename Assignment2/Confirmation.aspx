<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Confirmation.aspx.cs" Inherits="Confirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Thank You For Your Order!</p>
<p>Your order information is as follows:</p>
        <br />
        <p><strong>Bill To Address</strong></p>
        <asp:Label ID="lblb2Results" runat="server" Text="Results: "></asp:Label>
        
        <hr />
   
        <p><strong>Ship To Address</strong></p>
        <asp:Label ID="lbls2Results" runat="server" Text="Results: "></asp:Label>
    </div>
    
    
    </form>
</body>
</html>
