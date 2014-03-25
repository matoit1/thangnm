<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Error_ListUC.ascx.cs" Inherits="DO_AN_TN.UserControl.Error_ListUC" %>
<script type="text/javascript">
    function CheckAll(chkTemp) {
        var grvTemp = document.getElementById("<%=grvListError.ClientID %>");
        for (i = 1; i < grvTemp.rows.length; i++) {
            grvTemp.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = chkTemp.checked;
        }
    }
</script>
<div>
    <table>
        <tr>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Tìm kiếm" onclick="btnSearch_Click" />
                <asp:Button ID="btnRefresh" runat="server" Text="Làm mới" onclick="btnRefresh_Click" />
                <asp:Button ID="btnAddNew" runat="server" Text="Thêm" onclick="btnAddNew_Click" />
                <asp:Button ID="btnDeleteList" runat="server" Text="Xóa" onclick="btnDeleteList_Click" />
                <asp:Button ID="btnExportExcel" runat="server" Text="Xuất ra Excel" onclick="btnExportExcel_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvListError" runat="server" CssClass="mGrid" 
                    AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                    FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="PK_lErrorID"
                    emptydatatext="Không có bản ghi nào."   PageSize="5" 
                    EnableModelValidation="True" onrowcommand="grvListError_RowCommand" 
                    onselectedindexchanged="grvListError_SelectedIndexChanged" 
                    onpageindexchanging="grvListError_PageIndexChanging" 
                    onrowdatabound="grvListError_RowDataBound"
                    AllowSorting="true" onsorting="grvListError_Sorting">
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
                                <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("PK_lErrorID")%>'>Chi tiết</asp:LinkButton>
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center"  />
                        </asp:TemplateField>
                        <asp:BoundField  DataField="PK_lErrorID"  HeaderText="Mã lỗi" SortExpression="FK_sMaLop">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField  DataField="sLink"  HeaderText="Đường dẫn lỗi" SortExpression="PK_sMaSV">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="sIP" HeaderText="Địa chỉ IP" SortExpression="sHoTenSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sBrowser" HeaderText="Trình duyệt" SortExpression="sTendangnhapSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iCodes" HeaderText="Mã lỗi" SortExpression="sMatkhauSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tTime" HeaderText="Thời gian báo lỗi" SortExpression="sEmailSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tTimeCheck" HeaderText="Thời gian kiểm tra" SortExpression="sDiachiSV">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iStatus" HeaderText="Trạng thái" SortExpression="sSdtSV">
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
</div>