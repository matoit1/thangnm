<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TracNghiemUC.ascx.cs" Inherits="DO_AN_TN.UserControl.TracNghiemUC" %>
<div>
<asp:ScriptManager ID="smQuestion" runat="server"></asp:ScriptManager>
    <center><h1>AI LÀ TRIỆU PHÚ</h1>
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    </center><br />
    <asp:UpdatePanel ID="upTime" runat="server">
        <ContentTemplate>
            <asp:Timer ID="tThoiGianTraLoiCauHoi" runat="server" ontick="tThoiGianTraLoiCauHoi_Tick"></asp:Timer>
            <asp:Button ID="btnTime" runat="server" BackColor="Blue" />
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:ListView ID="lvQuestion" runat="server">            
<%--        <LayoutTemplate>
            <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
        </LayoutTemplate>--%>
        <ItemTemplate>               
            <div class="style">
                <p> <asp:Label ID="questionID" runat="server" text='<%# Eval("PK_lCauhoi_ID")%>' Font-Bold="true" ></asp:Label>: <b><%# Eval("sCauhoi_Cauhoi")%></b></p>
                <p>
                    <asp:RadioButton ID="rbtnsCauhoi_A" runat="server" GroupName="gnQuestion" /> <%# Eval("sCauhoi_A")%>
                    <asp:RadioButton ID="rbtnsCauhoi_B" runat="server" GroupName="gnQuestion" /> <%# Eval("sCauhoi_B")%>
                    <asp:RadioButton ID="rbtnsCauhoi_C" runat="server" GroupName="gnQuestion" /> <%# Eval("sCauhoi_C")%>
                    <asp:RadioButton ID="rbtnsCauhoi_D" runat="server" GroupName="gnQuestion" /> <%# Eval("sCauhoi_D")%>
                </p>
                <asp:Label ID="lblResuilt" runat="server" Font-Size="Large" ></asp:Label>
                <hr /><hr /><br />
            </div>
        </ItemTemplate>
    </asp:ListView>
    <asp:Button ID="Submit" runat="server" Text="Chấm điểm" onclick="Submit_Click" />
</div>