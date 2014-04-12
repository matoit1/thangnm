<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LichHoc.aspx.cs" Inherits="DO_AN_TN.SinhVien.LichHoc" MasterPageFile="~/Share_Interface/SinhVien_SI.Master" EnableEventValidation="false" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register src="../UserControl/LichDayVaHoc_ListUC.ascx" tagname="LichDayVaHoc_ListUC" tagprefix="uc1" %>

<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
<asp:ScriptManager ID="smrMain" runat="server"></asp:ScriptManager>
    <fieldset style="width: 1000px;">
    <legend>Lớp học của tôi</legend>
        <cc1:TabContainer ID="tcrMain" runat="server" ActiveTabIndex="0">
            <cc1:TabPanel ID="tplMonDangHoc" runat="server" HeaderText="Các môn đang học">
                <ContentTemplate>
                    <uc1:LichDayVaHoc_ListUC ID="LichDayVaHoc_ListUC1" runat="server" OnViewDetail="ViewDetail_Click"/>
                
</ContentTemplate>
            

</cc1:TabPanel>
            <cc1:TabPanel ID="tplMonDaHoc" runat="server" HeaderText="Các môn đã học">
                <ContentTemplate>
                    <uc1:LichDayVaHoc_ListUC ID="LichDayVaHoc_ListUC2" runat="server"/>
                
</ContentTemplate>
            

</cc1:TabPanel>
        </cc1:TabContainer>
    </fieldset>
</asp:Content>