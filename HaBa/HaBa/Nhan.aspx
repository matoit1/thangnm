<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nhan.aspx.cs" Inherits="HaBa.Nhan" MasterPageFile="~/ShareInterface/ProductSI.Master" %>
<%@ Register src="UserControl/AdvancedSearchUC.ascx" tagname="AdvancedSearchUC" tagprefix="uc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <style type="text/css">
        .result
        {
            margin: 0px auto 0px auto;
            width: 1024px;
        }
        
        .style1
        {
            height: 165px
        }
        .style1 a
        {
            text-decoration: none;
        }
        .tableft
        {
            float: left;
            width: 300px;
            padding: 5px;
        }
        .tabright
        {
            float: right;
            width: 650px;
        }
    </style>
<div class="clear"></div>
<div class="result">
    <h1><asp:Label ID="lblTitle" runat="server"></asp:Label></h1>
    <asp:Panel ID="pnlSearch" runat="server" DefaultButton="btnSearch">
        <asp:TextBox ID="txtKeyWord" runat="server" Width="500px" Height="30px"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Width="90px" Height="37px" Text="Tìm kiếm" onclick="btnSearch_Click" />
        <asp:LinkButton ID="lbtnAdvancedSearch" runat="server" onclick="lbtnAdvancedSearch_Click">Tìm kiếm nâng cao</asp:LinkButton>
    </asp:Panel>
    <uc1:AdvancedSearchUC ID="AdvancedSearchUC1" runat="server" Visible="false"/>
    <h4><i><asp:Label ID="lblMsg" runat="server"></asp:Label></i></h4>
    <asp:Repeater ID="rptResultSearch" runat="server" onitemdatabound="rptResultSearch_ItemDataBound">
        <ItemTemplate>
            <fieldset class="style1">
                <legend><asp:Label ID="lblPK_sSanPhamID" runat="server" Text='<%# Eval("PK_sSanPhamID") %>'></asp:Label> - <asp:Label ID="lblsTenSanPham" runat="server" Text='<%# Eval("sTenSanPham") %>'></asp:Label></legend>
                <asp:HyperLink ID="hplChiTietSanPham" runat="server" NavigateUrl='<%#"../SanPham.aspx?PK_sSanPhamID="+Eval("PK_sSanPhamID")%>'>
                
                    <div class="tableft">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("sLinkImage")%>' AlternateText='<%# Eval("sTenSanPham")%>' Width="100px" Height="100px" />
                        <%--<img src='<%# Eval("sLinkImage")%>' alt='<%# Eval("sTenSanPham")%>' width="100px" height="100px" />--%>
                    </div>
                    <div class="tabright">
                        <asp:Label ID="lblsMoTa" runat="server" Text='<%# Eval("sMoTa") %>'></asp:Label><br />
                        <%--<asp:Label ID="lblsInfomation" runat="server" Text='<%# Eval("sInfomation") %>'></asp:Label><br />--%>
                        <asp:Label ID="lblsXuatXu" runat="server" Text='<%# Eval("sXuatXu") %>'></asp:Label><br />
                        <asp:Label ID="lbllGiaBan" runat="server" Text='<%# Eval("lGiaBan") %>'></asp:Label><br />
                        <asp:Label ID="lbliTrangThai" runat="server" Text='<%# Eval("iTrangThai")%>'></asp:Label><br />
                    </div>
                </asp:HyperLink>
            </fieldset>
            <br /><br />
        </ItemTemplate>
    </asp:Repeater>
    <br />
    
    <br />
</div>
</asp:Content>