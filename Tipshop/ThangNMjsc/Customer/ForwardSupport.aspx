<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForwardSupport.aspx.cs" Inherits="ThangNMjsc.Customer.Forward" MasterPageFile="~/MasterPage/PublicCustomer.Master"%>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphMainContent_Customer" runat="server">
    <div>
        <div class="titleSupport"><br />
            <asp:Label ID="lblSupports_Type" runat="server" CssClass="type" Text=""></asp:Label><br />
            <asp:Label ID="lblSupports_ID" runat="server" CssClass="content" Text=""></asp:Label><br />
            <asp:Label ID="lblProducts_Name" runat="server" CssClass="content" Text=""></asp:Label><br />
        </div>
        <asp:Label ID="msg" runat="server" Text=""></asp:Label><br />
        <hr />
        <div  class="styleRepeater">
            <asp:Repeater ID="rpSupport" runat="server" 
                onitemdatabound="rpSupport_ItemDataBound">
                <ItemTemplate>
                    <div class="client">
                        <div class="avatar">
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("Accounts_LinkAvatar")%>' Width="100%"/>
                        </div>
                        <div class="content">
                            <span class="username"><asp:Label runat="server" Text='<%# Eval("Accounts_Username") %>' ID="Label7"></asp:Label>: </span>
                            <span class="chat"><asp:Label runat="server" Text='<%# Eval("Answers_Content") %>' ID="lblSupportID"></asp:Label></span><br />
                            <span class="datetime"><asp:Label ID="Label6" runat="server" Text="Ngày gửi: " ></asp:Label><asp:Label runat="server" Text='<%# Eval("Answers_DateTimeA") %>' ID="Label1"></asp:Label></span><br />
                        </div>
                    </div>
                    <div class="clear"></div><br />
                    <asp:Panel ID="pnAdmin" runat="server">
                        <div class="admin">
                            <div class="avatar">
                                <asp:Image ID="Image2" runat="server" ImageUrl='<%#Eval("AvatarStaff")%>' Width="100%"/>
                            </div>
                            <div class="content">
                                <span class="username"><asp:Label runat="server" Text='<%# Eval("Staff") %>' ID="lblStaff_Name"></asp:Label>: </span>
                                <span class="chat"><asp:Label runat="server" Text='<%# Eval("Answers_Question") %>' ID="Label5"></asp:Label></span><br />
                                <span class="datetime"><asp:Label ID="Label2" runat="server" Text="Ngày trả lời: " ></asp:Label><asp:Label runat="server" Text='<%# Eval("Answers_DateTimeB") %>' ID="Label4"></asp:Label></span><br />
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="clear"></div><hr />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <asp:Panel ID="panelForward" runat="server">
            <p>
                <asp:Label ID="Label5" runat="server" Text="Nội dung:"></asp:Label><br />
                <CKEditor:CKEditorControl ID="txtAnswers_Content" runat="server" CssClass="ck"></CKEditor:CKEditorControl>
                <asp:RequiredFieldValidator ControlToValidate="txtAnswers_Content" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bạn chưa nhập nội dung hỗ trợ"></asp:RequiredFieldValidator>
            </p>
            <center><asp:Button ID="btnForward" runat="server" Text="Gửi lại yêu cầu hỗ trợ" OnClick="btnForward_Click"/></center><br /><br />
        </asp:Panel>
    </div>
</asp:Content>
