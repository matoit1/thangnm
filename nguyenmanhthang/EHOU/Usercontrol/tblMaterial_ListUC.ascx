<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tblMaterial_ListUC.ascx.cs" Inherits="EHOU.Usercontrol.tblMaterial_ListUC" %>
<script type="text/javascript">
    function CheckAll(chkTemp) {
        var grvTemp = document.getElementById("<%=grvListBaiViet.ClientID %>");
        for (i = 1; i < grvTemp.rows.length; i++) {
            grvTemp.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = chkTemp.checked;
        }
    }
</script>
<div>
    <table>
        <tr>
            <td>
                <%--<asp:HyperLink ID="hplSearch" runat="server" NavigateUrl="#" CssClass="topopup style_button" >Tìm kiếm</asp:HyperLink>--%>
                <asp:Button ID="btnRefresh" runat="server" Text="Làm mới" onclick="btnRefresh_Click" />
                <asp:Button ID="btnAddNew" runat="server" Text="Thêm" onclick="btnAddNew_Click" />
                <%--<asp:Button ID="btnDeleteList" runat="server" Text="Xóa" onclick="btnDeleteList_Click" />
                <asp:Button ID="btnExportExcel" runat="server" Text="Xuất ra Excel" onclick="btnExportExcel_Click" />--%>
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
                <asp:GridView ID="grvListBaiViet" runat="server" CssClass="mGrid" 
                    AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                    FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="PK_lMaterial"
                    emptydatatext="Không có bản ghi nào."   PageSize="10" 
                    EnableModelValidation="True" onrowcommand="grvListBaiViet_RowCommand" 
                    onpageindexchanging="grvListBaiViet_PageIndexChanging" 
                    AllowSorting="true" onsorting="grvListBaiViet_Sorting">
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
                                <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("PK_lMaterial")%>'>Chi tiết</asp:LinkButton>
                                </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center"  />
                        </asp:TemplateField>
                        <asp:BoundField  DataField="PK_lMaterial"  HeaderText="Mã học liệu" SortExpression="PK_lMaterial">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField  DataField="FK_sSubject"  HeaderText="Môn học" SortExpression="FK_sSubject">
                            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
                        </asp:BoundField>
                        <asp:BoundField DataField="FK_sUsername" HeaderText="Người đăng" SortExpression="FK_sUsername">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sDescription" HeaderText="Mô tả" SortExpression="sDescription">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sLinkDownload" HeaderText="Link download" SortExpression="sLinkDownload">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tLastUpdate" HeaderText="Ngày cập nhật" SortExpression="tLastUpdate">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iSize" HeaderText="Kích thước" SortExpression="iSize">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iType" HeaderText="Loại file" SortExpression="iType">
                            <ItemStyle CssClass="GridItemText" />
                        </asp:BoundField>
                        <asp:BoundField DataField="iStatus" HeaderText="Trạng thái" SortExpression="iStatus">
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
    <%--<uc1:BaiViet_SearchUC ID="BaiViet_SearchUC1" runat="server" OnSearch="Search_Click" />--%>
