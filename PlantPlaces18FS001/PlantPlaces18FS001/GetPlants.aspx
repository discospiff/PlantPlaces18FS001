<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetPlants.aspx.cs" Inherits="PlantPlaces18FS001.GetPlants" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnReadJSON" runat="server" OnClick="BtnReadJSON_Click" Text="Read JSON" />
        </div>
        <asp:Label ID="LblJSONCount" runat="server" Text="JSON Count"></asp:Label>
    </form>
</body>
</html>
