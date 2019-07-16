<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BitacoraEx.aspx.cs" Inherits="BCientificas.BitacoraEx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .input-md {}
        .auto-style1 {
            width: 283px;
            height: 85px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Bitacora Experimental</h2>

            <div>
                <table>
                        <tr>
                            <td>
                                <asp:Label ID="lblNombreProyecto" runat="server" Text="Nombre del Proyecto:"></asp:Label>
                            &nbsp;&nbsp;
                                </td>
                            <td>
                                <div class="form-group">
                                    &nbsp;<asp:DropDownList ID="ddlProyectos" runat="server" Width="388px" Height="19px"></asp:DropDownList>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblCodigoProyecto" runat="server" Text="Codigo de Proyecto:"></asp:Label>
                            </td>
                            <td>
                                <div class="form-group">
                                    <asp:TextBox ID="txtCodigoProyecto" CssClass="form-control input-md" Width="388px" runat="server"></asp:TextBox>
                                </div>
                            </td>
                        </tr>
                </table>
            </div>

            <div class="col-md-4">
                <table>
                        <tr>
                            <td>
                                <div class="form-group">
                                    &nbsp;<asp:DropDownList ID="ddlNombreCompleto" runat="server" Width="216px" Height="19px"></asp:DropDownList>
                                </div>
                            </td>
                            <td>
                                <div class="form-group">
                                    &nbsp;<asp:DropDownList ID="ddlFirma" runat="server"  Width="216px" Height="19px"></asp:DropDownList>
                                </div>
                            </td>
                        </tr>
                </table>
            </div>
            <div>
                <asp:ImageButton ID="imgFirma" runat="server" Height="110px" />
            </div>

            <div>
                <table>
                        <tr>
                            <td>
                                <div class="form-group">
                                    &nbsp;<asp:Label ID="lblNombreExp" runat="server" Text="Nombre del Experimento:"></asp:Label>
                                </div>
                            </td>
                            <td>
                                <div class="form-group">
                                    &nbsp;<asp:TextBox ID="txtNombreExp" type="text" CssClass="form-control input-md" Width="198px" runat="server"></asp:TextBox>
                                </div>
                            </td>
                            <td>
                                <div class="form-group">
                                    &nbsp;<asp:Label ID="lblFecha" runat="server" Text="Fecha:"></asp:Label>
                                </div>
                            </td>
                            <td>
                                <div class="form-group">
                                    &nbsp;<asp:TextBox ID="txtFecha" type="Date" CssClass="form-control input-md" Width="108px" runat="server"></asp:TextBox>
                                </div>
                            </td>
                        </tr>
                </table>
            </div>

            <div>
                <table>
                        <tr>
                            <td>
                                <div class="form-group">
                                    &nbsp;<asp:ImageButton ID="imgMuestras" runat="server" Height="78px" Width="88px" />
                                </div>
                            </td>
                            <td>
                                <div class="form-group">
                                    &nbsp;<asp:Label ID="lblDetalleEx" runat="server" Text="Detalle de Experimento:"></asp:Label>
                                </div>
                            </td>
                        <tr>
                            <td>
                                <div class="form-group">
                                    &nbsp;<asp:Button ID="btnSubir" runat="server" Text="Subir" Width="78px" />
                                </div>
                            </td>
                            <td>
                                <div class="form-group">
                                    &nbsp;<textarea id="txaDetalleExp" class="auto-style1"></textarea>
                                </div>
                            </td>
                        </tr>
                            
                        </tr>
                </table>

                <div>
                <table>
                        <tr>
                            <td>
                                <div class="form-group">
                                    &nbsp;<asp:Image ID="imgFirmaa" runat="server" Height="54px" Width="89px" />
                                </div>
                            </td>
                            <td>
                                <div class="form-group">
                                    &nbsp;<asp:DropDownList ID="ddlFirmaTetigo" runat="server" Width="388px" Height="19px"></asp:DropDownList>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                                <asp:Button ID="btnGuardarBitacoraEx" runat="server" Text="Guardar" Width="83px" />
                            </td>
                        </tr>
                </table>
                    <br />
                    <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="Red" Font-Italic="True"></asp:Label>
            </div>
            </div>

        </div>
            
    </form>
</body>
</html>
