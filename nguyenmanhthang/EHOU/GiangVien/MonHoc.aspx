<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MonHoc.aspx.cs" Inherits="EHOU.GiangVien.MonHoc" MasterPageFile="~/Share_Interface/GiangVien_SI.Master" EnableEventValidation="false"%>
<%@ Register src="../UserControl/tblSubject_ListUC.ascx" tagname="tblSubject_ListUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/tblSubject_DetailUC.ascx" tagname="tblSubject_DetailUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
        <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
            <asp:View ID="vList" runat="server">
                <uc1:tblSubject_ListUC ID="tblSubject_ListUC1" runat="server" OnViewDetail="ViewDetail_Click"/>
            </asp:View>
            <asp:View ID="vDetail" runat="server">
                <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton><br /><br />
                <uc2:tblSubject_DetailUC ID="tblSubject_DetailUC1" runat="server" />
            </asp:View>
        </asp:MultiView>
    </div>
</asp:Content>
