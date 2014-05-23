<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChonLop.aspx.cs" Inherits="EHOU.SinhVien.ChonLop" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" %>
<%@ Register src="../UserControl/CaHocUC.ascx" tagname="CaHocUC" tagprefix="uc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <asp:Panel ID="pnlLopHoc" runat="server">
        <fieldset class="divcahoc">
            <legend>Chọn lớp học muốn vào học !</legend>
            <asp:RadioButtonList ID="rbtnlListClass" runat="server" ontextchanged="rbtnlListClass_TextChanged" AutoPostBack="true">
            </asp:RadioButtonList>
        </fieldset>
    </asp:Panel>
    <asp:Panel ID="pnlBaiHoc" runat="server">
        <fieldset class="divcahoc">
            <legend>Chọn bài học muốn vào học !</legend>
            <asp:RadioButtonList ID="rbtnlListSubject" runat="server" ontextchanged="rbtnlListSubject_TextChanged" AutoPostBack="true">
            </asp:RadioButtonList>
        </fieldset>
    </asp:Panel>
</asp:Content>