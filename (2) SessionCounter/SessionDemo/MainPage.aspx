<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="SessionDemo.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblname" runat="server" Font-Size="X-Large" Text="Enter Name : "></asp:Label>
&nbsp;
            <asp:TextBox ID="txtname" runat="server" Font-Size="X-Large"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnsubmit" runat="server" Font-Size="X-Large" OnClick="btnsubmit_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>
