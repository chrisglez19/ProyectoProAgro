<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProAgro.Login" %>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login ProAgro</title>
</head>
<body>
    <div align="center"  >
        <div id="formContent" style="margin-top: 100px">
            <div class="fadeIn first">
            <img src="https://www.proagroseguros.com.mx/images/logo-default-198x42.png" id="icon" alt="User Icon" />
            </div>
        <form runat="server">
            <div>
                 <asp:Label ID="lblRfc" class="control-label col-md-2" runat="server" Text="RFC"></asp:Label>
            </div>
            <div>
                 <asp:TextBox ID="txtRfc" runat="server" placeholder="Ingresa RFC" Width="300"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label1" class="control-label col-md-2" runat="server" Text="Contraseña"></asp:Label>
            </div>
            <div>
               <asp:TextBox ID="txtPass" type="password" runat="server"  placeholder="Ingresa Contraseña" Width="300"></asp:TextBox>
            </div>
            <div>
                <asp:Label class="text-danger" ID="lblError" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-success btn-sm" style="margin-top: 15px"  OnClick="btnIngresar_Click" />
            </div>
            
        </form>
        
     </div>
      </div>
</body>
</html>
