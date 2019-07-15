<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BitacoraExperimental.aspx.cs" Inherits="ProyectoServicios.BitacoraExperimental" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 87px;
            width: 257px;
        }
        .input-md {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <legend>Bitacora Experimental</legend> 
            <br />
            <br />

            <div class="form-group">
                <asp:DropDownList ID="ddlProyecto" runat="server" OnSelectedIndexChanged="ddlNombreProyecto_SelectedIndexChanged"></asp:DropDownList>
                <asp:Label ID="lblCod_Proyecto" runat="server" Text="Codigo de Proyecto"></asp:Label>
                <input id="txtCod_Proyecto" type="text" />
            </div>

            <br />

            <div class="col-md-4">
                <asp:Image ID="Firma" runat="server" Height="110px" />
                <asp:DropDownList ID="ddlNombreCompleto" runat="server" Height="16px" Width="101px"></asp:DropDownList>
                <asp:DropDownList ID="ddlFirma" runat="server" Height="16px" Width="104px"></asp:DropDownList>
            </div>
            <br />   
            </div>            
            <br />

            <table>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblNombre_Experimento" runat="server" Text="Nombre del Experimento:"></asp:Label>
                                    &nbsp;&nbsp;
                                    </td>
                                    <td>
                                        <div class="form-group">
                                            &nbsp;<asp:TextBox ID="txtNombre_Expe" class="form-control"  runat="server" Width="356px" ></asp:TextBox>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblFech" runat="server" Text="Fecha:"></asp:Label>
                                    </td>
                                    <td>
                                        <div class="form-group">
                                            <asp:TextBox ID="txtFechaa"  type="date" CssClass="form-control input-md" Width="356px" runat="server"></asp:TextBox>
                                        </div>
                                    </td>
                                </tr>
                            </table>



            <br />
            <div class="col-md-4">
                <asp:ImageButton ID="imgMuestra" runat="server" Height="98px" Width="103px" />
                <asp:Label ID="lblDetalle_Expe" runat="server" Text="Detalle Experimento: "></asp:Label>
                <textarea id="TextArea1"></textarea>
            </div>
            <br />
            <div class="col-md-4">
                <asp:Image ID="imgFirma1" runat="server" Height="113px" Width="130px" />
                <asp:DropDownList ID="ddlFirmaC" runat="server"></asp:DropDownList>
            </div>
            <br />
            <asp:Button ID="btnGuardar_Editar" runat="server" Text="Guardar" />

        </div>
    </form>
</body>
</html>
