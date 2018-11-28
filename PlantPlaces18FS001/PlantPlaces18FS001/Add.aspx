<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="PlantPlaces18FS001.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Number:"></asp:Label>
            <asp:TextBox ID="Number1" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Number:"></asp:Label>
            <asp:TextBox ID="Number2" runat="server"></asp:TextBox>
            <asp:Button ID="BtnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" />
            <asp:Label ID="LblSum" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
