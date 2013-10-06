<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PayMethod.aspx.cs" Inherits="ThangNMjsc.Admin.PayMethod" MasterPageFile="~/MasterPage/PublicAdmin.Master" %>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Admin" runat="server">
    <div>
        <center><asp:Label ID="Label8" runat="server" Text="Danh sách Nhân viên" CssClass="tieude"></asp:Label><br /><br />
        <asp:Label ID="Label13" runat="server" style="margin-left:50px"></asp:Label>
        </center>
        <cc1:GridViewExt ID="grvListPayMethod" runat="server" CssClass="mGrid" AutoGenerateCheckBoxColumn="True" AutoGenerateColumns="False"
                FileTypeDownload="Excel" Width="100%" AllowPaging="True" PageSize="15" DataKeyNames="Pay_ID"
                classCheckedRow="" classHoverRow="" ColumnShowOnclick="" EnableModelValidation="True"
                WidthCheckBoxColumn="50" emptydatatext="Không có dữ liệu trả về."  onrowdatabound="grvListPayMethod_RowDataBound" onpageindexchanging="grvListPayMethod_PageIndexChanging">

            <alternatingrowstyle cssclass="GridAlternatingItem"></alternatingrowstyle>
            <columns>
                <asp:TemplateField HeaderText="Xem">
                    <ItemTemplate>
                        <asp:HyperLink ID="hpView" runat="server" class="GridItemlink">Xem</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sửa">
                    <ItemTemplate>
                        <asp:HyperLink ID="hpEdit" runat="server" class="GridItemlink">Sửa</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Pay_ID" HeaderText="ID">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Pay_Name" HeaderText="Tên phương thức thanh toán">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
                <asp:BoundField DataField="Pay_Visible" HeaderText="Trạng thái kích hoạt">
                    <ItemStyle CssClass="GridItemText" />
                </asp:BoundField>
            </columns>
        </cc1:gridviewext>
        <br /><hr />
        <asp:Button ID="Delete" runat="server" Text="Xóa" onclick="btnDelete_Click" OnClientClick="return confirm('Bạn có muốn xóa những phương thức thanh toán đã chọn ko?');"/>
        <asp:Button ID="Button1" runat="server" Text="Thêm mới" PostBackUrl="~/Admin/Edit/EditPayMethod.aspx" />
    </div>
</asp:Content>
