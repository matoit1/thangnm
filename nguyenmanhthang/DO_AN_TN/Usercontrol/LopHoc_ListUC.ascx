<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LopHoc_ListUC.ascx.cs" Inherits="DO_AN_TN.UserControl.LopHoc_ListUC" %>
<script type="text/javascript">
    function CheckAll(oCheckbox) {
        var GridView2 = document.getElementById("<%=grvListLopHoc.ClientID %>");
        for (i = 1; i < GridView2.rows.length; i++) {
            GridView2.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = oCheckbox.checked;
        }
    }
</script>
<table>
    <tr>
        <td>
            <asp:GridView ID="grvListLopHoc" runat="server" CssClass="mGrid" 
                AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                            FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="PK_sMalop"
                            emptydatatext="Không có bản ghi nào." 
                EnableModelValidation="True" onrowcommand="grvListLopHoc_RowCommand" 
                onselectedindexchanged="grvListLopHoc_SelectedIndexChanged" 
                onpageindexchanging="grvListLopHoc_PageIndexChanging" 
                onrowdatabound="grvListLopHoc_RowDataBound"  PageSize="5" 
                AllowSorting="true" onsorting="grvListLopHoc_Sorting">
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
                            <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("PK_sMalop")%>'>Chi tiết</asp:LinkButton>
                            </ItemTemplate>
                        <ItemStyle HorizontalAlign="Center"  />
                    </asp:TemplateField>
                    <asp:BoundField  DataField="PK_sMalop"  HeaderText="Mã lớp học" SortExpression="PK_sMalop">
                        <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                    </asp:BoundField>
                    <asp:BoundField DataField="sTenlop" HeaderText="Tên lớp học" SortExpression="sTenlop">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="iNamvaotruong" HeaderText="Năm vào trường" SortExpression="iNamvaotruong">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="iSiso" HeaderText="Sĩ số" SortExpression="iSiso">
                        <ItemStyle CssClass="GridItemText" />
                    </asp:BoundField>
                    <asp:BoundField DataField="iSoNamDaoTao" HeaderText="Số năm đào tạo" SortExpression="iSoNamDaoTao">
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