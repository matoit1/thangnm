<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MonHoc_ListUC.ascx.cs" Inherits="DO_AN_TN.UserControl.MonHoc_ListUC" %>
<script type="text/javascript">
    function CheckAll(oCheckbox) {
        var GridView2 = document.getElementById("<%=grvListMonHoc.ClientID %>");
        for (i = 1; i < GridView2.rows.length; i++) {
            GridView2.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = oCheckbox.checked;
        }
    }
</script>
<table>
    <tr>
        <td>
            <asp:GridView ID="grvListMonHoc" runat="server" CssClass="mGrid" 
                AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                            FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="PK_sMaMonhoc"
                            emptydatatext="Không có bản ghi nào." 
                EnableModelValidation="True" onrowcommand="grvListMonHoc_RowCommand" 
                onselectedindexchanged="grvListMonHoc_SelectedIndexChanged" 
                onpageindexchanging="grvListMonHoc_PageIndexChanging" 
                onrowdatabound="grvListMonHoc_RowDataBound"  PageSize="5" 
                AllowSorting="true" onsorting="grvListMonHoc_Sorting">
                <AlternatingRowStyle CssClass="GridAlternatingItem"></AlternatingRowStyle>
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <input id="Checkbox2" type="checkbox" onclick="CheckAll(this)" runat="server" />
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="ItemCheckBox" runat="server" />
                        </ItemTemplate>
                   </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("PK_sMaMonhoc")%>'>Chi tiết</asp:LinkButton>
                            </ItemTemplate>
                        <ItemStyle Wrap="true" CssClass="GridItemLink" />
                    </asp:TemplateField>
                    <asp:BoundField  DataField="PK_sMaMonhoc"  HeaderText="Mã môn học" SortExpression="PK_sMaMonhoc">
                        <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                    </asp:BoundField>
                    <asp:BoundField DataField="sTenMonhoc" HeaderText="Tên môn học" SortExpression="sTenMonhoc">
                        <ItemStyle Wrap="true" CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="iSotrinh" HeaderText="Số trình" SortExpression="iSotrinh">
                        <ItemStyle Wrap="true" CssClass="GridItemNumber" />
                    </asp:BoundField>
                    <asp:BoundField DataField="iSotietday" HeaderText="Số tiết dạy" SortExpression="iSotietday">
                        <ItemStyle Wrap="true" CssClass="GridItemNumber" />
                    </asp:BoundField>
                    <asp:BoundField DataField="iTrangThai" HeaderText="Trạng thái" SortExpression="iTrangThai">
                        <ItemStyle Wrap="true" CssClass="GridItemNumber" />
                    </asp:BoundField>
                </Columns>
                <RowStyle CssClass="GridItem"></RowStyle>
                <HeaderStyle CssClass="GridHeader"></HeaderStyle>
                <FooterStyle CssClass="GridFooter"></FooterStyle>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td><asp:Label ID="lblTongSoBanGhi" runat="server"></asp:Label></td>
    </tr>
</table>