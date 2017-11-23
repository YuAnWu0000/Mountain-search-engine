<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>台灣森呼吸</title>
    <link href = "image/000.jpg" rel="icon" />
</head>
   <body> 
    <form id="form1" runat="server">
    <div style="text-align: center">
        <br />
        <asp:TextBox ID="TextBox1" runat="server" style="text-align: left" ></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="search" OnClick="Button1_Click" style="text-align: right" />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/山.png" PostBackUrl  ="~/default.aspx" ImageAlign="Middle"/>
       
    </div>
    </form>
</body>
</html>
