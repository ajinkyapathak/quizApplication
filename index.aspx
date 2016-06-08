<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Quiz.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Online Quiz</title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 400px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron"  style="background-color:blueviolet;">
  <div class="container" style="color:white;">
  <center> <h1>Online Quiz...!!</h1></center>
      <p align="center" style="color:antiquewhite">This website will provide you questions regarding various domains to improve your skills</p>
  </div>
</div>
        <div style="margin-left:30%; margin-right:30%; background-color:azure; font-family:Verdana; font-size:25px;" class="auto-style1">
            <div style="margin-left:20%;margin-right:20%;">
                <span class="glyphicon glyphicon-user"></span>
        <asp:Label ID="Label1" runat="server" Text="Enter Name">   </asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="active"></asp:TextBox><br />
                </div><hr />
            <asp:Button ID="Button1" runat="server" Text="Start Quiz" CssClass="btn-danger active" style="margin-left: 30%; margin-right:30%;" Width="221px" OnClick="Button1_Click" /><br /><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Admin Login" CssClass="btn-default active" OnClick="Button2_Click" style="margin-left: 30%;margin-right:30%;" Width="252px" />
        </div>

    </form>
</body>
</html>
