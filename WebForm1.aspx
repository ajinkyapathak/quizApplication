<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Quiz.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButton ID="RadioButton1" GroupName="abc" runat="server" />
        <asp:RadioButton ID="RadioButton2" runat="server" />

        <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server"></asp:RadioButtonList>
    </div>

    </form>
</body>
</html>
