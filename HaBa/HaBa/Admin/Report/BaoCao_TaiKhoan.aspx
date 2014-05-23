<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BaoCao_TaiKhoan.aspx.cs" Inherits="HaBa.Admin.Report.BaoCao_TaiKhoan" MasterPageFile="~/ShareInterface/ReportSI.Master"%>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <div>
        <asp:Button ID="btnBaoCao" runat="server" Text="Ẩn Tìm kiếm" onclick="btnBaoCao_Click" />
        <asp:Panel ID="pnlSearch" runat="server" DefaultButton="btnTimKiem">
            <div style="width: 500px; margin: 0px auto 0px auto; border: 1px solid blue;">
                <table>
                    <tr>
                        <td>Quyền Hạn:</td>
                        <td>
                            <asp:DropDownList ID="ddliQuyenHan" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td><asp:Label ID="lbliQuyenHan" runat="server"></asp:Label></td>
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
            <CR:CrystalReportViewer ID="crvTaiKhoan" runat="server" ShowAllPageIds="True" AutoDataBind="true" />
        </asp:Panel>
    </div>
</asp:Content>
