<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DO_AN_TN.Default" EnableEventValidation="false" MasterPageFile="~/Share_Interface/Home_SI.Master" %>
<asp:Content ID="cContent" runat="server" ContentPlaceHolderID="cphBody">
    <div style="margin: 5px 5px 5px 5px;">
        <asp:Repeater ID="rpTopic" runat="server">
            <ItemTemplate>
                <div style="width: 700px; height: 210px;">
                    <div style="float:left; width: 210px; height: 210px; padding: 2px">
                        <asp:ImageButton ID="ibtnTopic_LinkImage" runat="server"  ImageUrl='<%#Eval("sLinkAnh")%>' width="200px" Height="200px" PostBackUrl='<%#"~/Topic.aspx?PK_lMaBaiViet=" +Eval("PK_lMaBaiViet")%>'/>
                    </div>
                    <div style="float:left; width: 425px; height: 210px; padding: 5px"">
                        <asp:HiddenField ID="hfTopic_ID" runat="server" Value='<%#Eval("PK_lMaBaiViet")%>'></asp:HiddenField>
                        <asp:Label ID="lblTopic_Title" runat="server" Text='<%#Eval("sTieuDe")%>' Font-Bold="true" Font-Size="20px"></asp:Label><br />
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("sMoTa")%>'></asp:Label>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/Topic.aspx?PK_lMaBaiViet=" + Eval("PK_lMaBaiViet")%>'> Xem thêm...</asp:HyperLink><br /><br />
                        <asp:Label ID="Label2" runat="server" Text='<%#"Tác giả: "+Eval("FK_sMaGV")%>'></asp:Label><br />
                        <asp:Label ID="Label1" runat="server" Text='<%#"Tag: "+Eval("sTag")%>'></asp:Label><br />
                        <asp:Label ID="lblTopic_Visit" runat="server" Text='<%#"Số lượt xem: "+Eval("iLuotXem")%>'></asp:Label><br />
                        <i><asp:Label ID="lblWebsite_LastUpdate" runat="server" Text='<%#"Cập nhật lần cuối: "+Eval("tNgayCapNhat")%>'></asp:Label></i>
                    </div>
                </div><hr /><br />
            </ItemTemplate>
        </asp:Repeater>
        <div style="overflow: hidden;">
        <asp:Repeater ID="rptPages" runat="server" onitemcommand="rptPages_ItemCommand">
            <ItemTemplate>
                <asp:Button ID="btnPage" runat="server" Text="<%# Container.DataItem %>" CommandName="Page" CommandArgument="<%# Container.DataItem %>" />
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </div>
</asp:Content>
