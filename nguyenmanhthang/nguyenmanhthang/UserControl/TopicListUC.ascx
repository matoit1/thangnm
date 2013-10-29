<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopicListUC.ascx.cs" Inherits="nguyenmanhthang.UserControl.ListTopicUC" %>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<table width="100%" align="center" cellpadding="2" cellspacing="0">
    <tr>
        <td align="center" colspan="2">
            <asp:Label ID="lblTitle" CssClass="TitleForm" runat="server" Text="Danh Sách Bài viết"></asp:Label><br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <cc1:GridViewExt ID="grvListTopic" runat="server" CssClass="mGrid" AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                FileTypeDownload="Excel" Width="100%" AllowPaging="True" PageSize="2" 
                datakeynames="Topic_ID" onrowcommand="grvListTopic_RowCommand" emptydatatext="Không có bản ghi nào."
                onrowdatabound="grvListTopic_RowDataBound" 
                onpageindexchanging="grvListTopic_PageIndexChanging">
                <AlternatingRowStyle CssClass="GridAlternatingItem"></AlternatingRowStyle>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("Topic_ID")%>'>Chi tiết</asp:LinkButton>
                         </ItemTemplate>
                      <ItemStyle HorizontalAlign="Center"  />
                    </asp:TemplateField>
                    <asp:BoundField  DataField="Topic_ID"  HeaderText="Mã Bài viết" >
                        <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                    </asp:BoundField>
                    <asp:BoundField DataField="Topic_Title" HeaderText="Tiêu đề">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Topic_Author" HeaderText="Tác giả">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Topic_LastUpdate" HeaderText="Ngày Cập nhật" dataformatstring="{0:dd/MM/yyyy HH:mm}">
                        <ItemStyle CssClass="GridItemCode" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Topic_Category" HeaderText="Nhóm Bài viết">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Topic_Tag" HeaderText="Thẻ">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Topic_Visit" HeaderText="Lượt xem">
                        <ItemStyle CssClass="GridItemNumber" />
                    </asp:BoundField>
                </Columns>
                <RowStyle CssClass="GridItem"></RowStyle>
                <HeaderStyle CssClass="GridHeader"></HeaderStyle>
                <FooterStyle CssClass="GridFooter"></FooterStyle>
            </cc1:GridViewExt>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblTitleBanGhi" CssClass="LabelBoldBlue" runat="server" Text="Tổng số bản ghi: "></asp:Label>
            <asp:Label ID="lblSo_BanGhi" CssClass="LabelBoldBlue" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:ImageButton ID="ibtnDelete" runat="server" ImageUrl="~/Images/Template/btnRemove.png" onclick="ibtnDelete_Click" CssClass="btnNewTopic" />
            <asp:ImageButton ID="ibtnAdd" runat="server" ImageUrl="~/Images/Template/btnNewTopic.png" onclick="ibtnAdd_Click" CssClass="btnNewTopic" />
            <asp:ImageButton ID="ibtnExportExcel" runat="server" ImageUrl="~/Images/Template/btnExport_Excel.gif" onclick="ibtnAdd_Click" CssClass="btnNewTopic" />
        </td>
    </tr>
</table>