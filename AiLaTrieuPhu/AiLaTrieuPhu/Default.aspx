<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AiLaTrieuPhu._Default" MasterPageFile="~/Public.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
            <div style="margin: 15px 15px 15px 15px; width: 700px; height: 500px">
                <div style="height: 80px; background-color: Navy; width: 500px; float: left"><br />
                    <asp:Button ID="btnMoney" runat="server" Text="0" />
                    <asp:Button ID="btnStop" runat="server" Text="Stop" OnClientClick="return confirm('Bạn có chắc chắn muốn dừng cuộc chơi ko?');"/>
                    <asp:Button ID="btn50_50" runat="server" Text="50:50" OnClientClick="return confirm('Bạn có chắc chắn muốn sử dụng sự trợ giúp 50:50 ko?');"/>
                    <asp:Button ID="btnLoocker" runat="server" Text="Loocker" OnClientClick="return confirm('Bạn có chắc chắn muốn sử dụng sự trợ giúp hỏi ý kiến khán giả ko?');"/>
                    <asp:Button ID="btnPhone" runat="server" Text="Phone" OnClientClick="return confirm('Bạn có chắc chắn muốn sử dụng sự trợ giúp gọi điện cho người nổi tiếng ko?');"/>
                    <asp:Button ID="btnMove" runat="server" Text="Move" OnClientClick="return confirm('Bạn có chắc chắn muốn sử dụng sự trợ giúp đổi câu hỏi ko?');"/>
                </div>
                <div style="height: 80px; background-color: Navy; width: 200px; float: left"><br />
                    <asp:Button ID="btnLoading" runat="server" Text="Loading..." />
                </div>
                <asp:ScriptManager ID="ScriptManager1Demo" runat="server">
                </asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1Demo" runat="server">
                <ContentTemplate>
                <div style="padding: 5px 5px 5px 5px ;margin:10px 2px 2px 2px; width: 500px; height: 400px; background-color:rgb(210, 213, 253); float: left">
                 <h1><br><asp:Label ID="lblSTT" runat="server" Text="Label"></asp:Label></h1><br />
                    <asp:Label ID="lblMsg" runat="server" ></asp:Label><br />
                    <asp:Repeater ID="rpCauhoi" runat="server" onitemcommand="rpCauhoi_ItemCommand">
                        <ItemTemplate>
                                    #<asp:Label ID="Label1" runat="server" Text='<%#Eval("Cauhoi_ID")+": "%>' Font-Bold="true" Font-Size="20px"></asp:Label>
                                    <asp:Label ID="lblCauhoi_cauhoi" runat="server" Text='<%#Eval("Cauhoi_cauhoi")%>' Font-Bold="true" Font-Size="20px"></asp:Label><br />
                                    <span> A: </span><asp:Button ID="btnA" runat="server" Text='<%#Eval("Cauhoi_A")%>' CommandName="A"/>
                                    <span> B: </span><asp:Button ID="btnB" runat="server" Text='<%#Eval("Cauhoi_B")%>' CommandName="B"/><br />
                                    <span> C: </span><asp:Button ID="btnC" runat="server" Text='<%#Eval("Cauhoi_C")%>' CommandName="C"/>
                                    <span> D: </span><asp:Button ID="btnD" runat="server" Text='<%#Eval("Cauhoi_D")%>' CommandName="D"/>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                </ContentTemplate>
                </asp:UpdatePanel>
                <div style="margin:10px 2px 2px 2px; width: 180px; height: 400px; background-color: White; float: left">
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/avatar.png" width= "180px"/>
                </div>
            </div>

</asp:Content>