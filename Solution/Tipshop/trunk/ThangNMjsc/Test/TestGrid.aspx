<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestGrid.aspx.cs" Inherits="ThangNMjsc.Admin.TestGrid"
    MasterPageFile="~/MasterPage/PublicAdmin.Master" %>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div>
        <center>
            <asp:Label ID="Label8" runat="server" Text="Các Hỗ trợ mới từ Khách hàng" CssClass="tieude"></asp:Label><br />
            <br />
        </center>
         <cc1:GridViewExt ID="grvListNewSupport" runat="server" CssClass="GridLayout" AutoGenerateCheckBoxColumn="True" AutoGenerateColumns="False"
                            FileTypeDownload="Excel" Width="100%" AllowPaging="True" PageSize="20" DataKeyNames="Supports_ID"
                            classCheckedRow="" classHoverRow="" ColumnShowOnclick="" EnableModelValidation="True"
                            WidthCheckBoxColumn="50" emptydatatext="Không có dữ liệu thỏa mãn điều kiện tìm kiếm."  onrowdatabound="grvListNewSupport_RowDataBound1">

            <alternatingrowstyle cssclass="GridAlternatingItem"></alternatingrowstyle>
            <columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ID="hpReply" runat="server" >Trả lời</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Customer_ID" HeaderText="Mã Khách hàng">
                    <ItemStyle CssClass="GridItemNumber" />
                </asp:BoundField>
                <asp:BoundField DataField="Product_ID" HeaderText="Mã Sản phẩm">
                    <ItemStyle CssClass="GridItemNumber" />
                </asp:BoundField>
                <asp:BoundField DataField="Supports_Type" HeaderText="Tiêu đề">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Answers_DateTimeA" HeaderText="Ngày gửi" DataFormatString="{0:dd/MM/yyyy HH:mm}">
                    <ItemStyle CssClass="GridItemCode" />
                </asp:BoundField>
            </columns>
        </cc1:gridviewext>
        <asp:Button ID="Delete" runat="server" Text="Xóa" onclick="Delete_Click" />
        <%--        <asp:GridView ID="grvListNewSupport" runat="server" CssClass="mGrid" AutoGenerateColumns="False"
            Width="100%" AllowPaging="True" PageSize="15" 
            DataKeyNames="Answers_ID" EmptyDataText="Không có dữ liệu thỏa mãn điều kiện tìm kiếm."
            OnRowCommand="grvListNewSupport_RowCommand" 
            onrowdatabound="grvListNewSupport_RowDataBound" 
      
            onpageindexchanging="grvListNewSupport_PageIndexChanging">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ID="hpReply" runat="server" >Trả lời</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:ButtonField CommandName="cmdDelete" HeaderText="" Text="Xóa">
                    <ItemStyle HorizontalAlign="Center" Width="90px" Wrap="true" />
                </asp:ButtonField>
                <asp:BoundField DataField="Customer_ID" HeaderText="Mã Khách hàng">
                    <ItemStyle CssClass="GridItemNumber" />
                </asp:BoundField>
                <asp:BoundField DataField="Product_ID" HeaderText="Mã Sản phẩm">
                    <ItemStyle CssClass="GridItemNumber" />
                </asp:BoundField>
                <asp:BoundField DataField="Supports_Type" HeaderText="Tiêu đề">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Answers_DateTimeA" HeaderText="Ngày gửi" DataFormatString="{0:dd/MM/yyyy HH:mm}">
                    <ItemStyle CssClass="GridItemCode" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>--%>
        <%--        <table>
            <tr>
                <th width="8%">Trả lời</th>
                <th width="5%">Xóa</th>
                <th width="15%" align="center">Mã Khách hàng</th>
                <th width="15%" align="center">Mã Sản phẩm</th>
                <th width="50%" align="center">Tiêu đề</th>
                <th width="15%" align="center">Ngày gửi</th>
            </tr>
            <asp:Repeater ID="rpNewSupport" runat="server">
                <ItemTemplate>
                    <tr>
                        <td width="8%" class="buttom"><a href="Edit/ReplyNewSupport.aspx?Supports_ID=<%# Eval("Supports_ID")%>&Answers_ID=<%# Eval("Answers_ID")%>">Trả lời</a></td>
                        <td width="5%" class="buttom"><asp:LinkButton ID="Delete" runat="server" OnClick="Delete_Click" OnClientClick ="javascript: return confirm('Bạn chắc chắn muốn xóa toàn bộ Hỗ trợ này không?')">Xóa</asp:LinkButton></td>
                        <td width="15%" align="center"><asp:Label  ID="Label2" Text='<%# Eval("Customer_ID") %>' runat="server"/></td>
                        <td width="15%" align="center"><asp:Label  ID="Label4" Text='<%# Eval("Product_ID") %>' runat="server"/></td>
                        <td width="50%" align="center"><asp:Label  ID="Label5" Text='<%# Eval("Supports_Type") %>' runat="server"/></td>
                        <td width="15%" align="center"><asp:Label  ID="Label3" Text='<%# Eval("Answers_DateTimeA") %>' runat="server"/></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>--%>
    </div>
</asp:Content>
