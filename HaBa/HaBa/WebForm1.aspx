<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HaBa.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater ID="rptRoot" runat="server" OnItemDataBound="rpListParentProduct_ItemDataBound">
        <ItemTemplate>
            <li><asp:HyperLink ID="hplPK_iNhomSanPhamID" runat="server" NavigateUrl='<%#"~/Group.aspx?Products_ID="+Eval("PK_iNhomSanPhamID")%>'><%#Eval("sTenNhom")%></asp:HyperLink>
                <asp:Repeater ID="rptiNhomCon" runat="server">
                    <HeaderTemplate><ul></HeaderTemplate>
                    <ItemTemplate>
                        <li><asp:HyperLink ID="hpliNhomCon" runat="server" NavigateUrl='<%#"~/Group.aspx?PK_iNhomSanPhamID="+Eval("PK_iNhomSanPhamID")+"&iNhomCon="+Eval("iNhomCon")%>'><%#Eval("sTenNhom")%></asp:HyperLink></li>
                    </ItemTemplate>
                    <FooterTemplate></ul></FooterTemplate>
                </asp:Repeater>
            </li>
            <asp:HiddenField ID="hrfPK_iNhomSanPhamID" runat="server" Value='<%#Eval("PK_iNhomSanPhamID")%>' />
        </ItemTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>
