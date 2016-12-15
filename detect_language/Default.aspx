<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="detect_language.Default" Culture="auto:en-US" UICulture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            <asp:Label ID="Label4" runat="server" Text="<%$ Resources:Global, Message %>"></asp:Label>
        </h1>
      <asp:Label ID="Label1" runat="server" Text="Label" meta:resourceKey="Label1"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" meta:resourceKey="Button1"/>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label" meta:resourceKey="Label2"></asp:Label>



        <br />

         <asp:Label ID="Label3" runat="server" Text="Label" meta:resourceKey="Label3"></asp:Label>

    </div>
    </form>
</body>
</html>
