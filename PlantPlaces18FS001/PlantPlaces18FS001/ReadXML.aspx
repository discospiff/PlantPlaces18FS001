<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadXML.aspx.cs" Inherits="PlantPlaces18FS001.ReadXML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Submit your Plant XML"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Submit" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="XML Validation:"></asp:Label>
            <asp:Label ID="LblXMLValidation" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
