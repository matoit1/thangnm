<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestCalendar.aspx.cs" Inherits="ThangNMjsc.Test.TestCalendar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Css/calendar.css" rel="stylesheet" type="text/css"/>  
    <script src="../Scripts/calendar1.js" type="text/javascript"></script>  
    <script src="../Scripts/calendar2.js" type="text/javascript"></script> 
    <script type="text/javascript">
        $(function () {
            $("#startdate").datepicker({ dateFormat: "dd/mm/yy" }).val()
            $("#enddate").datepicker({ dateFormat: "dd/mm/yy" }).val()
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Start Date: <input type="text" id="startdate" size="30"/>    
        End Date: <input type="text" id="enddate" size="30"/>
    </div>
    </form>
</body>
</html>
