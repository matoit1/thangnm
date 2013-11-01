<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestEvent.aspx.cs" Inherits="nguyenmanhthang.UserControl.TestEvent" %>
<%@ Register Assembly="FCAP.Controls" Namespace="FCAP.Controls" TagPrefix="cc1" %>
<%@ Register src="EventUserControl.ascx" tagname="EventUserControl" tagprefix="uc1" %>

<%@ Register src="DetailTopicUC.ascx" tagname="DetailTopicUC" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:EventUserControl ID="EventUserControl1" runat="server" OnPageTitleUpdated="MyEventUserControl_PageTitleUpdated"/>
        <br />
        <cc1:CodeAndList ID="calMa_LH" runat="server" cssclass="ComboBox" width="400px">
        </cc1:CodeAndList>
        
        <br />
        <cc1:intergertextbox runat="server" ID="txtSo_HD" runat="server" Width="400px"></cc1:intergertextbox>
        <uc2:DetailTopicUC ID="DetailTopicUC1" runat="server" />
    </div>
    <asp:updatepanel runat="server" id="UpdatePanel1">
<contenttemplate>
<radu:radupload runat="server" id="RadUpload1" />
<asp:button runat="server" id="Button1" text="Postback" />
</contenttemplate>
<triggers>
<asp:postbacktrigger controlid="Button1" />
</triggers>
</asp:updatepanel>

    </form>
</body>
</html>
