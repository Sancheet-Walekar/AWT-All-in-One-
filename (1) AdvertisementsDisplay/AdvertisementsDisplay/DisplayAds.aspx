<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayAds.aspx.cs" Inherits="AdvertisementsDisplay.DisplayAds" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="adrAdvertisements" runat="server" AdvertisementFile="~/Ads.xml" Height="200px" Target="_blank" Width="200px" />
        </div>
    </form>
</body>
</html>
