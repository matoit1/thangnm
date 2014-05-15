﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DiemThi_DetailUC.ascx.cs" Inherits="EHOU.UserControl.DiemThi_DetailUC" %>
<div>
    <table>
        <tr>
            <td></td>
            <td align="center" ><asp:Label ID="lblTitle" runat="server" Text="Điểm thi"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td align="center"><asp:Label ID="lblMsg" runat="server"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>Mã sinh viên: </td>
            <td><asp:DropDownList ID="ddlFK_sMaSV" runat="server" Width="405px" ontextchanged="ddlFK_sMaSV_TextChanged" AutoPostBack="true"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sMaSV" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Mã môn học: </td>
            <td><asp:DropDownList ID="ddlFK_sMaMonhoc" runat="server" Width="405px" ontextchanged="ddlFK_sMaMonhoc_TextChanged" AutoPostBack="true"></asp:DropDownList></td>
            <td><asp:Label ID="lblFK_sMaMonhoc" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Số lần học: </td>
            <td><asp:TextBox ID="txtPK_iSolanhoc" runat="server" Width="400px" ontextchanged="txtPK_iSolanhoc_TextChanged" AutoPostBack="true"></asp:TextBox></td>
            <td><asp:Label ID="lblPK_iSolanhoc" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Điểm chuyên cần: </td>
            <td><asp:TextBox ID="txtfDiemchuyencan" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblfDiemchuyencan" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Điểm giữa kỳ: </td>
            <td><asp:TextBox ID="txtfDiemgiuaky" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblfDiemgiuaky" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Điểm thi lần 1: </td>
            <td><asp:TextBox ID="txtfDiemthilan1" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblfDiemthilan1" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Điểm thi lần 2: </td>
            <td><asp:TextBox ID="txtfDiemthilan2" runat="server" Width="400px"></asp:TextBox></td>
            <td><asp:Label ID="lblfDiemthilan2" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Trạng thái: </td>
            <td><asp:DropDownList ID="ddliTrangThai" runat="server" Width="405px"></asp:DropDownList></td>
            <td><asp:Label ID="lbliTrangThai" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnInsert" runat="server" Text="Insert" 
                    onclick="btnInsert_Click" style="height: 26px" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" onclick="btnUpdate_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" onclick="btnDelete_Click" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" onclick="btnReset_Click" 
                    style="height: 26px" />
            </td>
            <td></td>
        </tr>
        
    </table>
</div>