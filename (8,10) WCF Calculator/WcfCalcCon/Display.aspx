<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="WcfCalcCon.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter no 1:&nbsp;
            <asp:TextBox ID="txtno1" runat="server" Font-Size="Large" Width="150px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter no 2:&nbsp;
            <asp:TextBox ID="txtno2" runat="server" Font-Size="Large" Width="150px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Button ID="btnadd" runat="server" Font-Size="Large" OnClick="btnadd_Click" Text="ADD" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnsubtract" runat="server" Font-Size="Large" OnClick="btnsubtract_Click" Text="SUBTRACT" Width="111px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnmultiply" runat="server" Font-Size="Large" OnClick="btnmultiply_Click" Text="MULTIPLY" Width="102px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btndiv" runat="server" Font-Size="Large" OnClick="btndiv_Click" Text="DIVIDE" Width="71px" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Result:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblresult" runat="server" Font-Size="Large"></asp:Label>
        </div>
    </form>
</body>
</html>
