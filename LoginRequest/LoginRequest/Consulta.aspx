<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="LoginRequest.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mi Página</title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
            <table width="100%" id ="MiTabla" runat ="server" >
                    <tr> 
                        <td>
                            <asp:Label ID="lblUsuario" runat="server" Text="Usuario: "></asp:Label> 
                        </td>
                        <td > 
                            <asp:TextBox ID="txtUsuario" runat="server" Width="250px" Height="30px" Font-Size="Larger"></asp:TextBox>
                        </td>
                        <td> 
                            <asp:Label ID="UltimoAcceso" Text="Ultimo Acceso: " runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtUltimoAcceso" runat="server" Width="250px" Height="30px" Font-Size="Larger"></asp:TextBox>
                        </td>
                    </tr>
            </table>
        </div>
    </form>
</body>
</html>
