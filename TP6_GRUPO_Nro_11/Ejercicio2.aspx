<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TP6_GRUPO_Nro_11.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 31px;
        }
        .auto-style3 {
            width: 49px;
        }
        .auto-style4 {
            height: 31px;
            width: 49px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInicio" runat="server" Font-Bold="True" Font-Size="20pt" Text="Inicio"></asp:Label>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:HyperLink ID="HlSeleccionarProductos" runat="server" NavigateUrl="~/SeleccionarProductos.aspx">Seleccionar Productos</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbEliminarProductos" runat="server" PostBackUrl="~/EliminarProductos.aspx">Eliminar Productos seleccionados</asp:LinkButton>
                &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:HyperLink ID="hlMostrarProductos" runat="server" NavigateUrl="~/Mostrarproductos.aspx">Mostrar Productos</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
