<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThongTinCaNhan.aspx.cs" Inherits="EHOU.GiangVien.ThongTinCaNhan" MasterPageFile="~/Share_Interface/GiangVien_SI.Master" %>

<%@ Register src="../UserControl/GiangVien_DetailUC.ascx" tagname="GiangVien_DetailUC" tagprefix="uc1" %>

<%@ Register src="../Usercontrol/tblAccount_DetailUC.ascx" tagname="tblAccount_DetailUC" tagprefix="uc2" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div>
    
        <uc2:tblAccount_DetailUC ID="tblAccount_DetailUC1" runat="server" />
    
    </div>
</asp:Content>
