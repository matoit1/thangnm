<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SinhVien_ListUC.ascx.cs" Inherits="DO_AN_TN.UserControl.SinhVien_ListUC" %>
<script type="text/javascript">
    function CheckAll(oCheckbox){
        var GridView2 = document.getElementById("<%=grvList.ClientID %>");
        for(i = 1;i < GridView2.rows.length; i++){
            GridView2.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = oCheckbox.checked;
        }
    }
</script>
<asp:Label ID="lblMsg" runat="server"></asp:Label><br />
<table>
    <tr>
        <td>Mã</td>
        <td><asp:TextBox ID="txtMa" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Tên</td>
        <td><asp:TextBox ID="txtTen" runat="server"></asp:TextBox></td>
    </tr>
    
    <tr>
        <td>Email</td>
        <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>Họ tên</td>
        <td><asp:TextBox ID="txtHoten" runat="server"></asp:TextBox></td>
    </tr>
</table>
<asp:GridView ID="grvList" runat="server" CssClass="mGrid" 
    AutoGenerateColumns="False" AutoGenerateCheckBoxColumn="True" 
                FileTypeDownload="Excel" Width="100%" AllowPaging="True" datakeynames="Accounts_ID"
                emptydatatext="Không có bản ghi nào." 
    EnableModelValidation="True" onrowcommand="grvList_RowCommand" 
    onrowdatabound="grvList_RowDataBound" 
    onselectedindexchanged="grvList_SelectedIndexChanged" >
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
                <asp:LinkButton ID="cmdDetail" runat="server" CommandName="cmdView" Width="90px" CommandArgument='<%#Eval("Accounts_ID")%>'>Chi tiết</asp:LinkButton>
                </ItemTemplate>
            <ItemStyle HorizontalAlign="Center"  />
        </asp:TemplateField>
        <asp:BoundField  DataField="Accounts_ID"  HeaderText="Mã" >
            <ItemStyle Wrap="true" CssClass="GridItemNumber"/>
        </asp:BoundField>
        <asp:BoundField DataField="Accounts_Username" HeaderText="Tên đăng nhập">
            <ItemStyle CssClass="GridItemText" />
        </asp:BoundField>
        <asp:BoundField DataField="Accounts_Email" HeaderText="Email">
            <ItemStyle CssClass="GridItemText" />
        </asp:BoundField>
        <asp:BoundField DataField="Accounts_FullName" HeaderText="Họ và tên" >
            <ItemStyle CssClass="GridItemText" />
        </asp:BoundField>
        <asp:BoundField DataField="Accounts_DateOfBirth" HeaderText="Ngày sinh" dataformatstring="{0:dd/MM/yyyy HH:mm}">
            <ItemStyle CssClass="GridItemCode" />
        </asp:BoundField>
        <asp:BoundField DataField="Accounts_Permission" HeaderText="Quyền">
            <ItemStyle CssClass="GridItemNumber" />
        </asp:BoundField>
        <asp:BoundField DataField="Accounts_Like" HeaderText="Like">
            <ItemStyle CssClass="GridItemNumber" />
        </asp:BoundField>
        <asp:BoundField DataField="Accounts_RegisterDate" HeaderText="Ngày đăng ký" dataformatstring="{0:dd/MM/yyyy HH:mm}">
            <ItemStyle CssClass="GridItemCode" />
        </asp:BoundField>
    </Columns>
    <RowStyle CssClass="GridItem"></RowStyle>
    <HeaderStyle CssClass="GridHeader"></HeaderStyle>
    <FooterStyle CssClass="GridFooter"></FooterStyle>
</asp:GridView>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataKeyNames="Accounts_ID" DataSourceID="SqlDataSource1" 
    EnableModelValidation="True">
    <Columns>
        <asp:BoundField DataField="Accounts_ID" HeaderText="Accounts_ID" 
            InsertVisible="False" ReadOnly="True" SortExpression="Accounts_ID" />
        <asp:BoundField DataField="Accounts_Username" HeaderText="Accounts_Username" 
            SortExpression="Accounts_Username" />
        <asp:BoundField DataField="Accounts_Password" HeaderText="Accounts_Password" 
            SortExpression="Accounts_Password" />
        <asp:BoundField DataField="Accounts_Email" HeaderText="Accounts_Email" 
            SortExpression="Accounts_Email" />
        <asp:BoundField DataField="Accounts_FullName" HeaderText="Accounts_FullName" 
            SortExpression="Accounts_FullName" />
        <asp:BoundField DataField="Accounts_Address" HeaderText="Accounts_Address" 
            SortExpression="Accounts_Address" />
        <asp:BoundField DataField="Accounts_DateOfBirth" 
            HeaderText="Accounts_DateOfBirth" SortExpression="Accounts_DateOfBirth" />
        <asp:BoundField DataField="Accounts_PhoneNumber" 
            HeaderText="Accounts_PhoneNumber" SortExpression="Accounts_PhoneNumber" />
        <asp:BoundField DataField="Accounts_Permission" 
            HeaderText="Accounts_Permission" SortExpression="Accounts_Permission" />
        <asp:BoundField DataField="Accounts_LinkAvatar" 
            HeaderText="Accounts_LinkAvatar" SortExpression="Accounts_LinkAvatar" />
        <asp:BoundField DataField="Accounts_Signature" HeaderText="Accounts_Signature" 
            SortExpression="Accounts_Signature" />
        <asp:BoundField DataField="Accounts_Like" HeaderText="Accounts_Like" 
            SortExpression="Accounts_Like" />
        <asp:CheckBoxField DataField="Accounts_Notification" 
            HeaderText="Accounts_Notification" SortExpression="Accounts_Notification" />
        <asp:CheckBoxField DataField="Accounts_Status" HeaderText="Accounts_Status" 
            SortExpression="Accounts_Status" />
        <asp:BoundField DataField="Accounts_RegisterDate" 
            HeaderText="Accounts_RegisterDate" SortExpression="Accounts_RegisterDate" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:connect %>" 
    SelectCommand="SELECT * FROM [Accounts]"></asp:SqlDataSource>

