<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KhaoSatChatLuong.aspx.cs" Inherits="TracNghiemTrucTuyen.KhaoSatChatLuong" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="lvQuestion" runat="server">            
            <LayoutTemplate>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
            </LayoutTemplate>
            <ItemTemplate>               
                <div class="style">
                    <p> <asp:Label ID="questionID" runat="server" text='<%# Eval("Cauhoi_ID")%>' Font-Bold="true" ></asp:Label>: <b><%# Eval("Cauhoi_cauhoi")%></b></p>
                    <p>
                        <asp:RadioButton ID="ansA" runat="server" GroupName="num1" /> <%# Eval("Cauhoi_A")%>
                        <asp:RadioButton ID="ansB" runat="server" GroupName="num1" /> <%# Eval("Cauhoi_B")%>
                        <asp:RadioButton ID="ansC" runat="server" GroupName="num1" /> <%# Eval("Cauhoi_C")%>
                        <asp:RadioButton ID="ansD" runat="server" GroupName="num1" /> <%# Eval("Cauhoi_D")%>
                    </p>
                    <asp:Label ID="lblResuilt" runat="server" Font-Size="Large" ></asp:Label>
                    <hr /><hr /><br />
                </div>
            </ItemTemplate>
        </asp:ListView>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="submit" runat="server" Text="Check" onclick="submit_Click" />    
    </div>
    </form>
</body>
</html>
