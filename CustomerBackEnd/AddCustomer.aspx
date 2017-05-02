<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCustomer.aspx.cs" Inherits="AddCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Add Customer<br />
        <br />
        Forename&nbsp;
        <asp:TextBox ID="txtForname" runat="server"></asp:TextBox>
        <br />
        <br />
        Surname&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
        <br />
        <br />
        Address&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <br />
        Town&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTown" runat="server"></asp:TextBox>
        <br />
        <br />
        Postcode&nbsp;&nbsp;
        <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
        <br />
        <br />
        DOB&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        <br />
        <br />
        Mobile&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAddCustomer" runat="server" Text="Add Customer" />
        <br />
    
    </div>
    </form>
</body>
</html>
