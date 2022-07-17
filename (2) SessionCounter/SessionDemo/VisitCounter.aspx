<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisitCounter.aspx.cs" Inherits="SessionDemo.VisitCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblvisit" runat="server" Font-Size="X-Large"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnincrement" runat="server" Font-Size="X-Large" OnClick="btnincrement_Click" Text="Increment" />
        </div>
    </form>
</body>
</html>
