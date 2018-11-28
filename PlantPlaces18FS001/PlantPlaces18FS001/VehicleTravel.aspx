<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehicleTravel.aspx.cs" Inherits="PlantPlaces18FS001.VehicleTravel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Mileage"></asp:Label>
            <asp:TextBox ID="TxtMiles" runat="server" ></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Find Vehicles" />
            <asp:Image ID="Image1" runat="server" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Number of Vehicles:"></asp:Label>
            <asp:Label ID="LblNumberOfVehicles" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
