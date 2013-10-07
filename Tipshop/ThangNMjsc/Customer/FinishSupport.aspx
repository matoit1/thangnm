<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FinishSupport.aspx.cs" Inherits="ThangNMjsc.Customer.FinishSupport" MasterPageFile="~/MasterPage/PublicCustomer.Master" %>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead_Customer" runat="server">
    <link href="../Css/calendar.css" rel="stylesheet" type="text/css"/>  
    <script src="../Scripts/calendar1.js" type="text/javascript"></script>  
    <script src="../Scripts/calendar2.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $(".startdate").datepicker({ dateFormat: "dd/mm/yy" }).val()
            $(".enddate").datepicker({ dateFormat: "dd/mm/yy" }).val()
        });
    </script>
</asp:Content>

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
        <center><asp:Label ID="Label8" runat="server" Text="Tất cả các Hỗ trợ của Khách hàng đã được xử lý" CssClass="tieude"></asp:Label><br /><br /></center>
        <cc1:GridViewExt ID="grvListSupport" runat="server" CssClass="mGrid" 
            AutoGenerateCheckBoxColumn="True" AutoGenerateColumns="False"
                FileTypeDownload="Excel" Width="100%" AllowPaging="True" PageSize="15" DataKeyNames="Supports_ID"
                classCheckedRow="" classHoverRow="" ColumnShowOnclick="" EnableModelValidation="True"
                WidthCheckBoxColumn="50" emptydatatext="Không có dữ liệu trả về."  
            onrowdatabound="grvListSupport_RowDataBound" onpageindexchanging="grvListSupport_PageIndexChanging">

            <alternatingrowstyle cssclass="GridAlternatingItem"></alternatingrowstyle>
            <columns>
                <asp:TemplateField HeaderText="Xem">
                    <ItemTemplate>
                        <asp:HyperLink ID="hpView" runat="server" class="GridItemlink">Xem</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gửi lại">
                    <ItemTemplate>
                        <asp:HyperLink ID="hpForward" runat="server" class="GridItemlink">Gửi lại</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Supports_Type" HeaderText="Tiêu đề hỗ trợ">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Products_Name" HeaderText="Tên Sản phẩm">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Staff_ID" HeaderText="Người trả lời">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Answers_DateTimeA" HeaderText="Ngày gửi" DataFormatString="{0:dd/MM/yyyy HH:mm}">
                    <ItemStyle CssClass="GridItemDate" />
                </asp:BoundField>
            </columns>
        </cc1:gridviewext>
    </div>
</asp:Content>
