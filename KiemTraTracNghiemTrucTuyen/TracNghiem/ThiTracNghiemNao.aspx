<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThiTracNghiemNao.aspx.cs" Inherits="TracNghiemTrucTuyen.ThiTracNghiemNao" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel runat="server">
        <ContentTemplate>
     <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label><br /><br />
        <asp:Repeater ID="rptLoadCauHoi" runat="server" 
            onitemcommand="rptLoadCauHoi_ItemCommand">
            <ItemTemplate>
                <asp:Label ID="lblIDCauhoi" runat="server" Text=' <%#Eval("CauhoiID")%>'></asp:Label>
                <asp:Label ID="lblCauhoi" runat="server" Text=' <%#Eval("tencauhoi")%>'></asp:Label><br /><br />
                <asp:RadioButton ID="rdoA" runat="server"  GroupName="NhomCH" /><asp:Label ID="lblA" runat="server" Text=' <%#"Câu A: " + Eval("daa")%>'></asp:Label><br />
                <asp:RadioButton ID="rdoB" runat="server" GroupName="NhomCH" /><asp:Label ID="lblB" runat="server" Text=' <%#"Câu B: " + Eval("dab")%>'></asp:Label><br />
                <asp:RadioButton ID="rdoC" runat="server" GroupName="NhomCH" /><asp:Label ID="lblC" runat="server" Text=' <%#"Câu C: " + Eval("dac")%>'></asp:Label><br />
                <asp:RadioButton ID="rdoD" runat="server" GroupName="NhomCH" /><asp:Label ID="lblD" runat="server" Text=' <%#"Câu D: " + Eval("dad")%>'></asp:Label><br />
                <asp:Label ID="lblKetqua" runat="server" ForeColor="Red"></asp:Label><br />
                <asp:Button Id="CheckIn" CommandName="check"  runat="server" Text="Kiểm tra" /><br />
                <hr /><br />
            </ItemTemplate>
        </asp:Repeater><br />
        </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
