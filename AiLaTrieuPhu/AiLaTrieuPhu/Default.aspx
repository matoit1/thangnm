<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AiLaTrieuPhu._Default" MasterPageFile="~/Public.Master" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" runat="server">
<asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                    </asp:ToolkitScriptManager>
    
        
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
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Button ID="btnCountDown" runat="server" Text="30" />
                            <asp:Timer ID="timerCountDown" runat="server" Interval="1000" OnTick="timerCountDown_Tick"></asp:Timer>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <div style="padding: 5px 5px 5px 5px ;margin:10px 2px 2px 2px; width: 500px; height: 400px; background-color:rgb(210, 213, 253); float: left">
                  rgb(210, 213, 253): Với mức thưởng trị giá 200.000 VNĐ</h1><br /><br />
                    <span> Berlin là thủ đô của quốc gia nào</span><br /><br /><br />
                    <span> A: </span><asp:Button ID="btnA" runat="server" Text="Đức" OnClientClick="return confirm('Bạn có chắc chắn chọn đáp án A ko?');" />
                    <span> B: </span><asp:Button ID="btnB" runat="server" Text="Mỹ" OnClientClick="return confirm('Bạn có chắc chắn chọn đáp án B ko?');" /><br />
                    <span> C: </span><asp:Button ID="btnC" runat="server" Text="Anh" OnClientClick="return confirm('Bạn có chắc chắn chọn đáp án C ko?');" />
                    <span> D: </span><asp:Button ID="btnD" runat="server" Text="Pháp" OnClientClick="return confirm('Bạn có chắc chắn chọn đáp án D ko?');" />
                </div>
                <div style="margin:10px 2px 2px 2px; width: 180px; height: 400px; background-color: White; float: left">
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="avata.png" width= "180px"/>
                </div>            </div>

</asp:Content>