<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GiangVien.aspx.cs" Inherits="EHOU.QuanTri.GiangVien" MasterPageFile="~/Share_Interface/QuanTri_SI.Master" EnableEventValidation="false"%>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register src="../UserControl/GiangVien_DetailUC.ascx" tagname="GiangVien_DetailUC" tagprefix="uc1" %>
<%@ Register src="../UserControl/GiangVien_ListUC.ascx" tagname="GiangVien_ListUC" tagprefix="uc2" %>
<%@ Register src="../UserControl/BaiViet_ListUC.ascx" tagname="BaiViet_ListUC" tagprefix="uc3" %>
<%@ Register src="../UserControl/CauHoi_ListUC.ascx" tagname="CauHoi_ListUC" tagprefix="uc4" %>
<%@ Register src="../UserControl/LichDayVaHoc_ListUC.ascx" tagname="LichDayVaHoc_ListUC" tagprefix="uc5" %>
<%@ Register src="../UserControl/LopHoc_ListUC.ascx" tagname="LopHoc_ListUC" tagprefix="uc6" %>
<%@ Register src="../UserControl/MonHoc_ListUC.ascx" tagname="MonHoc_ListUC" tagprefix="uc7" %>
<%@ Register src="../UserControl/PhanCongCongTac_ListUC.ascx" tagname="PhanCongCongTac_ListUC" tagprefix="uc8" %>


<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <asp:ScriptManager ID="smrMain" runat="server"></asp:ScriptManager>
    <div>
        <asp:MultiView ID="mtvMain" runat="server" ActiveViewIndex="0">
            <asp:View ID="vList" runat="server">
                <uc2:GiangVien_ListUC ID="GiangVien_ListUC1" runat="server" OnViewDetail="ViewDetail_Click" />
            </asp:View>
            <asp:View ID="vDetail" runat="server">
                <asp:LinkButton ID="lbtnBack" runat="server" onclick="lbtnBack_Click">Quay lại danh sách</asp:LinkButton><br /><br />
                <cc1:TabContainer ID="tcrMain" runat="server" ActiveTabIndex="0">
                    <cc1:TabPanel ID="tplThongTinChung" runat="server" HeaderText="Thông tin chung">
                        <ContentTemplate>
                            <uc1:GiangVien_DetailUC ID="GiangVien_DetailUC1" runat="server" />
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="tplMonHoc" runat="server" HeaderText="Môn học">
                        <ContentTemplate>
                            <uc7:MonHoc_ListUC ID="MonHoc_ListUC1" runat="server" />
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="tplLopHoc" runat="server" HeaderText="Lớp học">
                        <ContentTemplate>
                            <uc6:LopHoc_ListUC ID="LopHoc_ListUC1" runat="server" />
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="tplCauHoi" runat="server" HeaderText="Câu hỏi">
                        <ContentTemplate>
                            <uc4:CauHoi_ListUC ID="CauHoi_ListUC1" runat="server" />
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="tplBaiViet" runat="server" HeaderText="Bài viết">
                        <ContentTemplate>
                            <uc3:BaiViet_ListUC ID="BaiViet_ListUC1" runat="server" />
                        </ContentTemplate>
                    </cc1:TabPanel>
                    <cc1:TabPanel ID="tplPhanCongCongTac" runat="server" HeaderText="Phân công công tác">
                        <ContentTemplate>
                            <asp:MultiView ID="mtvMainPCCT" runat="server" ActiveViewIndex="0">
                                <asp:View ID="vListPCCT" runat="server">
                                    <uc8:PhanCongCongTac_ListUC ID="PhanCongCongTac_ListUC1" runat="server" />
                                </asp:View>
                                <asp:View ID="vDetailPCCT" runat="server">
                                    <uc5:LichDayVaHoc_ListUC ID="LichDayVaHoc_ListUC1" runat="server" />
                                </asp:View>
                            </asp:MultiView>
                        </ContentTemplate>
                    </cc1:TabPanel>
                </cc1:TabContainer>
            </asp:View>
        </asp:MultiView>
    </div>
</asp:Content>