<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WaittingOrders.aspx.cs" Inherits="ThangNMjsc.Customer.WaittingOrders" MasterPageFile="~/MasterPage/PublicCustomer.Master"%>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Customer" runat="server">
    <div class="search">
        <center>
            <asp:TextBox ID="txtSupports_Type" runat="server" CssClass="textboxmain"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" onclick="btnSearch_Click" />
            <asp:LinkButton ID="btnShowSearchAdvanced" runat="server" OnClick="btnShowSearchAdvanced_Click">Tìm kiếm nâng cao</asp:LinkButton>
        </center>
        <asp:Panel ID="PanelSearchAdvanced" runat="server" Visible="false">
            <div class="left">
                <p><asp:Label ID="Label1" runat="server" Text="Tìm theo tên khách hàng: "></asp:Label>
                <asp:TextBox ID="txtAccounts_FullName" runat="server" CssClass="textbox"  TabIndex="1"></asp:TextBox></p>
                <p><asp:Label ID="Label4" runat="server" Text="Tìm theo nội dung hỗ trợ: "></asp:Label>
                <asp:TextBox ID="txtAnswers_Content" runat="server" CssClass="textbox" TabIndex="3"></asp:TextBox></p>
                <p><asp:Label ID="Label6" runat="server" Text="Tìm theo ngày hỗ trợ từ: "></asp:Label>
                <asp:TextBox ID="txtAnswers_DateTimeA1" runat="server" class="startdate" Width="146px" style="float: right;"></asp:TextBox></p>
            </div>
            <div class="right">
                <p><asp:Label ID="Label2" runat="server" Text="Tìm theo tên sản phẩm: "></asp:Label>
                <asp:TextBox ID="txtProducts_Name" runat="server" CssClass="textbox" TabIndex="2"></asp:TextBox></p>
                <p><asp:Label ID="Label5" runat="server" Text="Tìm theo nội dung trả lời: "></asp:Label>
                <asp:TextBox ID="txtAnswers_Question" runat="server" CssClass="textbox" TabIndex="4"></asp:TextBox></p>
                <p><asp:Label ID="Label7" runat="server" Text="đến ngày:"></asp:Label>
                <asp:TextBox ID="txtAnswers_DateTimeA2" runat="server" class="enddate" Width="146px" style="float: right;"></asp:TextBox></p>
            </div>
        </asp:Panel>
    </div>
    <div>
        <center><asp:Label ID="Label8" runat="server" Text="Tất cả các Hóa đơn đang chờ xử lý" CssClass="tieude"></asp:Label><br /><br />
        <asp:Label ID="Label13" runat="server" style="margin-left:50px"></asp:Label>
        </center>
        <cc1:gridviewext id="grvListOrder" runat="server" cssclass="mGrid" autogeneratecheckboxcolumn="True"
            autogeneratecolumns="False" filetypedownload="Excel" width="100%" allowpaging="True"
            pagesize="15" datakeynames="Orders_ID" classcheckedrow="" classhoverrow=""
            columnshowonclick="" enablemodelvalidation="True" widthcheckboxcolumn="50" emptydatatext="Không có dữ liệu trả về."
            onrowdatabound="grvListOrder_RowDataBound" onpageindexchanging="grvListOrder_PageIndexChanging">
            <alternatingrowstyle cssclass="GridAlternatingItem"></alternatingrowstyle>
            <columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ID="hpView" runat="server" class="GridItemlink">Xem</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Orders_ID" HeaderText="Mã hóa đơn">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Pay_Name" HeaderText="Phương thức thanh toán">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Accounts_FullName" HeaderText="Người đặt mua">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Pay_FullName" HeaderText="Người nhận hàng">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Pay_PhoneNumber" HeaderText="Số điện thoại người nhận">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Pay_DateOfStart" HeaderText="Ngày mua" DataFormatString="{0:dd/MM/yyyy HH:mm}">
                    <ItemStyle CssClass="GridItemDate" />
                </asp:BoundField>
            </columns>
        </cc1:gridviewext>
        <center><asp:Button ID="btnDelete" runat="server" Text="Xóa" OnClick="btnDelete_Click" OnClientClick="return confirm('Bạn có muốn xóa những toàn bộ chi tiết hỗ trợ đã chọn ko?');" /></center>
    </div>
</asp:Content>