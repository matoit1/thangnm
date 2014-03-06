<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="nguyenmanhthang.Default" MasterPageFile="~/Common/Default.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="server">
    <meta property="fb:app_id" content="432781806807255"/>
    <link href="../../Css/Product/tab.css" rel="stylesheet" type="text/css"/>
    <script language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.0/jquery.min.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
    <div style="margin: 15px 15px 15px 15px;">
        <asp:Repeater ID="rpTopic" runat="server">
            <ItemTemplate>
                <div style="width: 700px; height: 250px; background-color:#CCCCFF;">
                    <div style="float:left; width: 250px; padding: 5px">
                        <asp:ImageButton ID="ibtnTopic_LinkImage" runat="server"  ImageUrl='<%#Eval("Topic_LinkImage")%>' width="240px" Height="240px" PostBackUrl='<%#"~/Topic.aspx?Topic_ID=" +Eval("Topic_ID")%>'/>
                    </div>
                    <div style="float:left; width: 425px; padding: 5px"">
                        <asp:HiddenField ID="hfTopic_ID" runat="server" Value='<%#Eval("Topic_ID")%>'></asp:HiddenField>
                        <asp:Label ID="lblTopic_Title" runat="server" Text='<%#Eval("Topic_Title")%>' Font-Bold="true" Font-Size="20px"></asp:Label><br />
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("Topic_Description")%>'></asp:Label>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/Bai-viet/" + Eval("Topic_ID") + "/" + Eval("link") + ".html"%>'> Xem thêm...</asp:HyperLink><br /><br />
                        <asp:Label ID="Label2" runat="server" Text='<%#"Chủ đề: "+Eval("Topic_Category")%>'></asp:Label><br />
                        <asp:Label ID="Label1" runat="server" Text='<%#"Tag: "+Eval("Topic_Tag")%>'></asp:Label><br />
                        <asp:Label ID="lblTopic_Visit" runat="server" Text='<%#"Số lượt xem: "+Eval("Topic_Visit")%>'></asp:Label><br />
                        <i><asp:Label ID="lblWebsite_LastUpdate" runat="server" Text='<%#"Cập nhật lần cuối: "+Eval("Topic_LastUpdate")%>'></asp:Label></i>
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
