<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Quiz.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Admin Page</title>
</head>
<body>
    <form id="form1" runat="server">
         <div class="jumbotron"  style="background-color:blueviolet;">
  <div class="container" style="color:white;">
  <center> <h1>Online Quiz...!!</h1></center>
  </div>
</div>

    <div style="margin-right:30%;margin-left:30%; font-family:sans-serif;font-size:22px;background-color:beige;">
        <div style="font-family:Arial;font-size:30px; color:burlywood;text-align:center;">
            Admin Login
        </div>
        <div style="margin-left:20%;margin-right:20%;">
        <span class="glyphicon glyphicon-user"></span>
        <asp:Label ID="Label1" runat="server" Text="Username">  </asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="text-primary"></asp:TextBox><br /><br />
            <span class="glyphicon glyphicon-lock"></span>
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="text-primary"></asp:TextBox><br />
            </div>
        <div style="margin-left:35%;margin-right:35%"><hr />
        <asp:Button ID="Button1" runat="server" Text="Login" Width="132px" CssClass="btn-primary active" OnClick="Button1_Click" /></div>
        <br />
    </div>
    </form>
</body>
</html>
