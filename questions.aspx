<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="questions.aspx.cs" Inherits="Quiz.questions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title>Quiz</title>
</head>
<body>
  <div class="jumbotron"  style="background-color:blueviolet;">
  <div class="container" style="color:white;">
  <center> <h1>Online Quiz...!!</h1></center>
  </div>
   </div>
    <form id="form1" runat="server">
        <div>
<asp:ScriptManager ID= "SM1" runat="server"></asp:ScriptManager>
<asp:Timer ID="timer1" runat="server" 
Interval="1000" OnTick="timer1_tick"></asp:Timer>
</div>
<div>
<asp:UpdatePanel id="updPnl" 
runat="server" UpdateMode="Conditional">
<ContentTemplate>
    <div style="font-family:Arial;font-size:24px;color:aqua;">
<asp:Label ID="lblTimer" runat="server"></asp:Label></div>
</ContentTemplate>
<Triggers>
<asp:AsyncPostBackTrigger ControlID="timer1" EventName ="tick" />
</Triggers>
</asp:UpdatePanel>
</div>
    <div style="margin-top:10%;margin-left:5%;background-color:bisque;font-family:sans-serif;font-size:25px;">
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label><hr />
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-6">
       A. <asp:RadioButton ID="RadioButton1" GroupName="a" runat="server" /></div>
        <div class="col-sm-6">
        B. <asp:RadioButton ID="RadioButton2" GroupName="a" runat="server" /></div></div></div>
        <hr />
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-6">
       C. <asp:RadioButton ID="RadioButton3" GroupName="a" runat="server" /></div>
       <div class="col-sm-6">
       D. <asp:RadioButton ID="RadioButton4" GroupName="a" runat="server" /></div></div></div>
        <hr />
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-3">
        <asp:Button ID="Button1" runat="server" Text="Previous" OnClick="Button1_Click" CssClass="btn-primary active" />
       </div>
        <div class="col-sm-3">
         <asp:Button ID="Button2" runat="server" Text="Submit" CssClass="btn-danger active" OnClick="Button2_Click" />
        </div>
        <div class="col-sm-3">
            <asp:Button ID="Button3" runat="server" Text="Next" OnClick="Button3_Click" CssClass="btn-success active" />
        </div>
        <div class="col-sm-3">
            <asp:Button ID="Button4" runat="server" Text="Submit Answer" OnClick="Button4_Click" CssClass="btn-success active" />
        </div>
          </div>
       </div>
        <hr /><hr />
        </div>
    </form>
</body>
</html>
