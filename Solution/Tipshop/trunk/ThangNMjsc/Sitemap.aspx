<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sitemap.aspx.cs" Inherits="ThangNMjsc.Sitemap" MasterPageFile="~/MasterPage/PublicProduct.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="cphMainContent_Product" runat="server">
    <div>
        <asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows" ShowLines="True">
            <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
            <Nodes>
                <asp:TreeNode NavigateUrl="~/Default.aspx" Text="Trang chủ" Value="Trang chủ">
                    <asp:TreeNode NavigateUrl="~/Info/Terms.aspx" Text="Điều khoản" 
                        Value="Điều khoản"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/Info/Link.aspx" Text="Liên kết Website" 
                        Value="Liên kết Website"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/Sitemap.aspx" Text="Bản đồ Website" 
                        Value="Bản đồ Website"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/Info/ThangNMjsc.aspx" Text="Giới thiệu" 
                    Value="Giới thiệu"></asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/Product/Default.aspx" Text="Sản phẩm" 
                    Value="Sản phẩm">
                    <asp:TreeNode Text="Thời trang Bé trai" Value="Thời trang Bé trai">
                    </asp:TreeNode>
                    <asp:TreeNode Text="Thời trang Bé gái" Value="Thời trang Bé gái"></asp:TreeNode>
                    <asp:TreeNode Text="Giày dép và Phụ kiện" Value="Giày dép và Phụ kiện">
                    </asp:TreeNode>
                    <asp:TreeNode Text="Mỹ phẩm" Value="Mỹ phẩm">
                        <asp:TreeNode Text="Mỹ phẩm Trẻ em" Value="Mỹ phẩm Trẻ em"></asp:TreeNode>
                        <asp:TreeNode Text="Mỹ phẩm dành cho Nam" Value="Mỹ phẩm dành cho Nam">
                        </asp:TreeNode>
                        <asp:TreeNode Text="Mỹ phẩm dành cho Nữ" Value="Mỹ phẩm dành cho Nữ">
                        </asp:TreeNode>
                    </asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/Info/Ship.aspx" Text="Ship hàng" Value="Ship hàng">
                </asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/Info/Contact.aspx" Text="Liên hệ" Value="Liên hệ">
                </asp:TreeNode>
            </Nodes>
            <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" 
                HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" 
                HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
    </div>
</asp:Content>
