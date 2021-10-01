<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Geograficos.aspx.cs" Inherits="ProAgro.Geograficos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mapa/Georeferencias</title>
</head>
<body>
    <div runat="server">
         <dl class="dl-horizontal">
            <dt> <asp:Label ID="lblLatitudK" runat="server" Text="Latitud:"></asp:Label></dt>
            <dd>  <asp:Label ID="lblLatitudV" runat="server"></asp:Label></dd>
       
            <dt><asp:Label ID="lblLongitudK" runat="server" Text="Longitud:"></asp:Label></dt>
            <dd><asp:Label ID="lblLongitudV" runat="server" Text=""></asp:Label></dd>
        </dl>
    </div>
</body>
</html>
