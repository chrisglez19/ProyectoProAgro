<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProAgro.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Ingreso ProAgro</h1>
        </div>

        <div>
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server" placeholder="Ingresa Usuario"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblPass" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtPass" runat="server" placeholder="Ingresa Usuario"></asp:TextBox>
        </div>
        <div>
            <input type="button" id="btnIngresar"  value="Ingresar" />
        </div>
    </form>
</body>
</html>
