<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DiemThi_ListUC.ascx.cs" Inherits="DO_AN_TN.UserControl.DiemThi_ListUC" %>
<script type="text/javascript">
    function CheckAll(oCheckbox) {
        var GridView2 = document.getElementById("<%=grvListDiemThi.ClientID %>");
        for (i = 1; i < GridView2.rows.length; i++) {
            GridView2.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = oCheckbox.checked;
        }
    }
</script>
<table>
    <tr>
        <td>
            <asp:GridView ID="grvListDiemThi" runat="server" CssClass="mGrid" 
                AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                            FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="FK_sMaSV, FK_sMaMonhoc, PK_iSolanhoc"
                            emptydatatext="Không có bản ghi nào." 
                EnableModelValidation="True" onrowcommand="grvListDiemThi_RowCommand" 
                onselectedindexchanged="grvListDiemThi_SelectedIndexChanged" 
                onpageindexchanging="grvListDiemThi_PageIndexChanging" 
                onrowdatabound="grvListDiemThi_RowDataBound"  PageSize="5" 
                AllowSorting="true" onsorting="grvListDiemThi_Sorting">
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
                            <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("FK_sMaSV")%>'>Chi tiết</asp:LinkButton>
                            </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center"  />
                    </asp:TemplateField>
                    <asp:BoundField  DataField="FK_sMaSV"  HeaderText="Mã sinh viên" SortExpression="FK_sMaSV">
                        <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                    </asp:BoundField>
                    <asp:BoundField DataField="FK_sMaMonhoc" HeaderText="Mã môn học" SortExpression="FK_sMaMonhoc">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="PK_iSolanhoc" HeaderText="Số lần học" SortExpression="PK_iSolanhoc">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="fDiemchuyencan" HeaderText="Điểm chuyển cần" SortExpression="fDiemchuyencan">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="fDiemgiuaky" HeaderText="Điểm giữa kỳ" SortExpression="fDiemgiuaky">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="fDiemthilan1" HeaderText="Điểm thi lần 1" SortExpression="fDiemthilan1">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="fDiemthilan2" HeaderText="Điểm thi lần 2" SortExpression="fDiemthilan2">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="iTrangThai" HeaderText="Trạng thái" SortExpression="iTrangThai">
                        <ItemStyle CssClass="GridItemText" />
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