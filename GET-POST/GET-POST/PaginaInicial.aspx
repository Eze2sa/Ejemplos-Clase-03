<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaInicial.aspx.cs" Inherits="GET_POST.PaginaInicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Prueba POST-GET</title>
</head>
<body>
    <form id="form1" action="PaginaDestino.aspx" method="get">
        <div>
            <input name="TextoGET" type="text" />
            <input name="BotonGET" type="submit" value="Petición por GET"/>
        </div>
        
    </form>
    <form id="form2" action="PaginaDestino.aspx" method="post">
        <div>
            <input name="TextoPOST" type="text" />
            <input name="BotonPOST" type="submit" value="Petición por POST"/>
        </div>
    </form>
</body>
</html>
