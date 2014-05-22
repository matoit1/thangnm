<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BaoCao_KetQua_KinhDoanh.aspx.cs" Inherits="HaBa.Report.BaoCao_KetQua_KinhDoanh" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnBaoCao" runat="server" Text="Báo Cáo" onclick="btnBaoCao_Click" />
        <asp:Panel ID="pnlSearch" runat="server" DefaultButton="btnTimKiem">
            <div style="width: 500px; margin: 0px auto 0px auto; border: 1px solid blue;">
                <table>
                    <tr>
                        <td>Tháng:</td>
                        <td>
                            <asp:DropDownList ID="ddlThang" runat="server">
                                <asp:ListItem Value="1">1</asp:ListItem>
                                <asp:ListItem Value="2">2</asp:ListItem>
                                <asp:ListItem Value="3">3</asp:ListItem>
                                <asp:ListItem Value="4">4</asp:ListItem>
                                <asp:ListItem Value="5">5</asp:ListItem>
                                <asp:ListItem Value="6">6</asp:ListItem>
                                <asp:ListItem Value="7">7</asp:ListItem>
                                <asp:ListItem Value="8">8</asp:ListItem>
                                <asp:ListItem Value="9">9</asp:ListItem>
                                <asp:ListItem Value="10">10</asp:ListItem>
                                <asp:ListItem Value="11">11</asp:ListItem>
                                <asp:ListItem Value="12">12</asp:ListItem>
                            </asp:DropDownList></td>
                        <td><asp:Label ID="lblThang" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Năm:</td>
                        <td><asp:TextBox ID="txtNam" runat="server" MaxLength="4" TabIndex="1"></asp:TextBox></td>
                        <td><asp:Label ID="lblNam" runat="server"></asp:Label></td>
                    </tr>
                     <tr>
                        <td>Trạng Thái:</td>
                        <td>
                            <asp:DropDownList ID="ddliTrangThai" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td><asp:Label ID="lbliTrangThai" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:Button ID="btnTimKiem" runat="server" Text="Tìm kiếm" onclick="btnTimKiem_Click" /></td>
                        <td></td>
                    </tr>
                </table>
            </div>
        </asp:Panel>
        <center><asp:Label ID="lblMsg" runat="server"></asp:Label></center>
        <asp:Panel ID="pnlReport" runat="server">
            <CR:CrystalReportViewer ID="crvKetQuaKinhDoanh" runat="server" ShowAllPageIds="True" AutoDataBind="true" />
        </asp:Panel>
    </div>
    </form>
</body>
</html>
