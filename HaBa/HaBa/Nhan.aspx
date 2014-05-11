<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nhan.aspx.cs" Inherits="HaBa.Nhan" %>
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
                <legend><asp:Label ID="lblPK_lProductID" runat="server" Text='<%# Eval("PK_lProductID") %>'></asp:Label> - <asp:Label ID="lblsName" runat="server" Text='<%# Eval("sName") %>'></asp:Label></legend>
                <asp:HyperLink ID="hplChiTietSanPham" runat="server" NavigateUrl='<%# Eval("PK_lProductID")%>' ImageUrl='<%# Eval("sName") %>'>
                
                    <div class="tableft">
                        <img src='<%# Eval("sLinkImage")%>' alt='<%# Eval("sName")%>' width="100px" height="100px" />
                    </div>
                    <div class="tabright">
                        <asp:Label ID="lblsDescription" runat="server" Text='<%# Eval("sDescription") %>'></asp:Label><br />
                        <asp:Label ID="lblsInfomation" runat="server" Text='<%# Eval("sInfomation") %>'></asp:Label><br />
                        <asp:Label ID="lblsOrigin" runat="server" Text='<%# Eval("sOrigin") %>'></asp:Label><br />
                        <asp:Label ID="lbllPrice" runat="server" Text='<%# Eval("lPrice") %>'></asp:Label><br />
                        <asp:Label ID="lblbStatus" runat="server" Text='<%#(Boolean)Eval("bStatus")==true?"Còn hàng":"Hết hàng"%>'></asp:Label><br />
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