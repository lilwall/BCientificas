<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BitacoraExperimental.aspx.cs" Inherits="ProyectoServicios.BitacoraExperimental" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlProyecto" runat="server" OnSelectedIndexChanged="ddlNombreProyecto_SelectedIndexChanged"></asp:DropDownList>
            <asp:Label ID="lblCod_Proyecto" runat="server" Text="Codigo de Proyecto"></asp:Label>
            <input id="txtCod_Proyecto" type="text" />
            
            <br />
            <br />
            <asp:Image ID="Firma" runat="server" Height="110px" />
            <asp:DropDownList ID="ddlNombreCompleto" runat="server" Height="16px" Width="101px"></asp:DropDownList>
            <asp:DropDownList ID="ddlFirma" runat="server" Height="16px" Width="104px"></asp:DropDownList>

            <br />
            <br />

            <asp:Label ID="lblNombre_Expe" runat="server" Text="Nombre del Experimento"></asp:Label>
            <input id="txtNombre_Expe" type="text" />

            <br />
            <br />
            <asp:Label ID="lblFecha" runat="server" Text="Fecha:   "></asp:Label>
            <input id="txtFecha" type="date" />

            <br />
            <br />

            <asp:ImageButton ID="imgMuestra" runat="server" Height="98px" Width="103px" />
            <asp:Label ID="lblDetalle_Expe" runat="server" Text="Detalle Experimento: "></asp:Label>
            <textarea id="TextArea1" cols="20" rows="2"></textarea>
            <br />
            <br />

            <asp:Image ID="imgFirma1" runat="server" Height="113px" Width="130px" />
            <asp:DropDownList ID="ddlFirmaC" runat="server"></asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnGuardar_Editar" runat="server" Text="Guardar" />

        </div>
    </form>
</body>
</html>
