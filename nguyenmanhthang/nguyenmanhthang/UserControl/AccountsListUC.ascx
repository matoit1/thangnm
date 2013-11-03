<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountsListUC.ascx.cs" Inherits="nguyenmanhthang.UserControl.AccountsListUC" %>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<table width="100%" align="center" cellpadding="2" cellspacing="0">
    <tr>
        <td align="center" colspan="2">
            <asp:Label ID="lblTitle" CssClass="TitleForm" runat="server" Text="Danh Sách Tài khoản"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <cc1:GridViewExt ID="grvListAccounts" runat="server" CssClass="mGrid" AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                FileTypeDownload="Excel" Width="100%" AllowPaging="True" PageSize="1" datakeynames="Accounts_ID" onrowcommand="grvListAccounts_RowCommand"
                emptydatatext="Không có bản ghi nào." onpageindexchanging="grvListAccounts_PageIndexChanging">
                <AlternatingRowStyle CssClass="GridAlternatingItem"></AlternatingRowStyle>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("Accounts_ID")%>'>Chi tiết</asp:LinkButton>
                         </ItemTemplate>
                      <ItemStyle HorizontalAlign="Center"  />
                    </asp:TemplateField>
                    <asp:BoundField  DataField="Accounts_ID"  HeaderText="Mã" >
                        <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                    </asp:BoundField>
                    <asp:BoundField DataField="Accounts_Username" HeaderText="Tên đăng nhập">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Accounts_Email" HeaderText="Email">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Accounts_FullName" HeaderText="Họ và tên" >
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Accounts_DateOfBirth" HeaderText="Ngày sinh" dataformatstring="{0:dd/MM/yyyy HH:mm}">
                        <ItemStyle CssClass="GridItemCode" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Accounts_Permission" HeaderText="Quyền">
                        <ItemStyle CssClass="GridItemNumber" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Accounts_Like" HeaderText="Like">
                        <ItemStyle CssClass="GridItemNumber" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Accounts_RegisterDate" HeaderText="Ngày đăng ký" dataformatstring="{0:dd/MM/yyyy HH:mm}">
                        <ItemStyle CssClass="GridItemCode" />
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
</table>