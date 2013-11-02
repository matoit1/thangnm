<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CommentListUC.ascx.cs" Inherits="nguyenmanhthang.UserControl.CommentListUC" %>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<table width="100%" align="center" cellpadding="2" cellspacing="0">
    <tr>
        <td align="center" colspan="2">
            <asp:Label ID="lblTitle" CssClass="TitleForm" runat="server" Text="Danh sách Bình luận"></asp:Label><br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <cc1:GridViewExt ID="grvCommentList" runat="server" CssClass="mGrid" AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                FileTypeDownload="Excel" Width="100%" AllowPaging="True" PageSize="1" 
                datakeynames="Comment_ID" onrowcommand="grvCommentList_RowCommand" emptydatatext="Không có bản ghi nào."
                onrowdatabound="grvCommentList_RowDataBound" 
                onpageindexchanging="grvCommentList_PageIndexChanging">
                <AlternatingRowStyle CssClass="GridAlternatingItem"></AlternatingRowStyle>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("Comment_ID")%>'>Chi tiết</asp:LinkButton>
                            </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center"  />
                    </asp:TemplateField>
                    <asp:BoundField  DataField="Comment_ID"  HeaderText="ID" >
                        <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                    </asp:BoundField>
                    <asp:BoundField DataField="Comment_Name" HeaderText="Người viết">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Comment_Email" HeaderText="Email">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Comment_Website" HeaderText="Website">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Comment_Content" HeaderText="Nội dung">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Comment_Status" HeaderText="TT">
                        <ItemStyle CssClass="GridItemNumber" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Comment_LastUpdate" HeaderText="Ngày viết">
                        <ItemStyle CssClass="GridItemCode" />
                    </asp:BoundField>
                </Columns>
                <RowStyle CssClass="GridItem"></RowStyle>
                <HeaderStyle CssClass="GridHeader"></HeaderStyle>
                <FooterStyle CssClass="GridFooter"></FooterStyle>
            </cc1:GridViewExt>
            <asp:Label ID="lblTongSo_BanGhi" CssClass="LabelBoldBlue" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:ImageButton ID="ibtnDelete" runat="server" ImageUrl="~/Images/Template/btnRemove.png" onclick="ibtnDelete_Click" CssClass="btnNewTopic" />
            <asp:ImageButton ID="ibtnAdd" runat="server" ImageUrl="~/Images/Template/btnNewTopic.png" onclick="ibtnAdd_Click" CssClass="btnNewTopic" />
            <asp:ImageButton ID="ibtnExportExcel" runat="server" ImageUrl="~/Images/Template/btnExport_Excel.png" CssClass="btnNewTopic" onclick="ibtnExportExcel_Click" />
        </td>
    </tr>
</table>