<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="result.aspx.cs" Inherits="Quiz.result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Result</title>
</head>
<body>
    <div class="jumbotron"  style="background-color:blueviolet;">
  <div class="container" style="color:white;">
  <center> <h1>Online Quiz...!!</h1></center>
  </div>
   </div>
    <form id="form1" runat="server">
    <div style="background-color:azure;margin-left:25%;margin-right:25%; font-family:Verdana;font-size:25px;">
       <div style="background-color:antiquewhite;font-family:Algerian;font-size:30px;">
          <center> <asp:Label ID="Label3" runat="server" Text=""></asp:Label></center>
       </div>
         <div style="margin-left:10%;">
            <asp:Label ID="Label1" runat="server" Text="Score">   </asp:Label>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label><hr />
             <asp:Button ID="Button1" runat="server" Text="Back To Main Page" CssClass="btn-warning" OnClick="Button1_Click" />
        </div>
    
    </div>
    </form>
</body>
</html>
