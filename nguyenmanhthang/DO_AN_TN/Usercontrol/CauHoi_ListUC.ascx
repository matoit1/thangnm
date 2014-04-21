<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CauHoi_ListUC.ascx.cs" Inherits="DO_AN_TN.UserControl.CauHoi_ListUC" %>
<%@ Register src="Search/CauHoi_SearchUC.ascx" tagname="CauHoi_SearchUC" tagprefix="uc1" %>
<script type="text/javascript">
    function CheckAll(oCheckbox) {
        var GridView2 = document.getElementById("<%=grvListCauHoi.ClientID %>");
        for (i = 1; i < GridView2.rows.length; i++) {
            GridView2.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = oCheckbox.checked;
        }
    }
</script>
<div>
    <table>
        <tr>
            <td>
                <asp:HyperLink ID="hplSearch" runat="server" NavigateUrl="#" CssClass="topopup style_button" >Tìm kiếm</asp:HyperLink>
                <asp:Button ID="btnRefresh" runat="server" Text="Làm mới" onclick="btnRefresh_Click" />
                <asp:Button ID="btnAddNew" runat="server" Text="Thêm" onclick="btnAddNew_Click" />
                <asp:Button ID="btnDeleteList" runat="server" Text="Xóa" onclick="btnDeleteList_Click" />
                <asp:Button ID="btnExportExcel" runat="server" Text="Xuất ra Excel" onclick="btnExportExcel_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="pnlSearch" runat="server" Visible="true">
                        <asp:TextBox ID="txtTextSearch" runat="server"></asp:TextBox>
                        <asp:DropDownList ID="ddlTypeSearch" runat="server" ontextchanged="ddlTypeSearch_TextChanged">
                            <asp:ListItem Value="0">Tìm theo mã</asp:ListItem>
                            <asp:ListItem Value="1">Tìm theo tên</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" onclick="btnSearch_Click" />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvListCauHoi" runat="server" CssClass="mGrid" 
                    AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                                FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="PK_lCauhoi_ID"
                                emptydatatext="Không có bản ghi nào." 
                    EnableModelValidation="True" onrowcommand="grvListCauHoi_RowCommand" 
                    onselectedindexchanged="grvListCauHoi_SelectedIndexChanged" 
                    onpageindexchanging="grvListCauHoi_PageIndexChanging" 
                    onrowdatabound="grvListCauHoi_RowDataBound"  PageSize="5" 
                    AllowSorting="true" onsorting="grvListCauHoi_Sorting">
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
                                <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("PK_lCauhoi_ID")%>'>Chi tiết</asp:LinkButton>
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center"  />
                        </asp:TemplateField>
                        <asp:BoundField  DataField="FK_sMaGV"  HeaderText="Mã giáo viên" SortExpression="FK_sMaGV">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="PK_lCauhoi_ID" HeaderText="Mã câu hỏi" SortExpression="PK_lCauhoi_ID">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sCauhoi_Cauhoi" HeaderText="Câu hỏi" SortExpression="sCauhoi_Cauhoi">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sCauhoi_A" HeaderText="Đáp án A" SortExpression="sCauhoi_A">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sCauhoi_B" HeaderText="Đáp án B" SortExpression="sCauhoi_B">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sCauhoi_C" HeaderText="Đáp án C" SortExpression="sCauhoi_C">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sCauhoi_D" HeaderText="Đáp án D" SortExpression="sCauhoi_D">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iCauhoi_Dung" HeaderText="Câu hỏi đúng" SortExpression="iCauhoi_Dung">
                            <ItemStyle CssClass="GridItemCode" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sBoCauHoi" HeaderText="Bộ câu hỏi" SortExpression="sBoCauHoi">
                            <ItemStyle CssClass="GridItemCode" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tNgayTao" HeaderText="Ngày tạo" SortExpression="tNgayTao">
                            <ItemStyle CssClass="GridItemCode" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tNgayCapNhat" HeaderText="Ngày cập nhật" SortExpression="tNgayCapNhat">
                            <ItemStyle CssClass="GridItemCode" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iTrangThai" HeaderText="Trạng thái" SortExpression="iTrangThai">
                            <ItemStyle CssClass="GridItemCode" />
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
    <uc1:CauHoi_SearchUC ID="CauHoi_SearchUC1" runat="server"  OnSearch="Search_Click" />
</div>
