<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Finish.aspx.cs" Inherits="ThangNMjsc.Customer.Finish" MasterPageFile="~/MasterPage/PublicCustomer.Master"%>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Customer" runat="server">
    <div>
        <center><asp:Label ID="Label8" runat="server" Text="Tất cả các Hỗ trợ của Khách hàng" CssClass="tieude"></asp:Label><br /><br /></center>
        <cc1:GridViewExt ID="grvListSupportFinish" runat="server" CssClass="mGrid" 
            AutoGenerateCheckBoxColumn="True" AutoGenerateColumns="False"
                FileTypeDownload="Excel" Width="100%" AllowPaging="True" PageSize="15" DataKeyNames="Supports_ID"
                classCheckedRow="" classHoverRow="" ColumnShowOnclick="" EnableModelValidation="True"
                WidthCheckBoxColumn="50" emptydatatext="Không có dữ liệu trả về."  
            onrowdatabound="grvListSupportFinish_RowDataBound" onpageindexchanging="grvListSupportFinish_PageIndexChanging">

            <alternatingrowstyle cssclass="GridAlternatingItem"></alternatingrowstyle>
            <columns>
                <asp:TemplateField HeaderText="Xem">
                    <ItemTemplate>
                        <asp:HyperLink ID="hpView" runat="server" >Xem</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gửi lại">
                    <ItemTemplate>
                        <asp:HyperLink ID="hpForward" runat="server" >Gửi lại</asp:HyperLink>
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
                    <ItemStyle CssClass="GridItemCode" />
                </asp:BoundField>
            </columns>
        </cc1:gridviewext>
    </div>
</asp:Content>