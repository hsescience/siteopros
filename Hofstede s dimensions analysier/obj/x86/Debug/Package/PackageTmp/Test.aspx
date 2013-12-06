<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Hofstede_s_dimensions_analysier.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 336px">
    <form id="form1" runat="server">
    <div style="height: 351px">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Georgia" 
            Font-Size="X-Large" style="text-align: left" 
            Text="Тестирование. Вопрос XX из YY"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="51px" TextMode="MultiLine" 
            Width="984px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="50px" 
            ontextchanged="TextBox2_TextChanged" Width="844px"></asp:TextBox>
    
        <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="132px">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>

        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="112px" 
            Width="194px">
            <asp:ListItem>Вариант ответа 1</asp:ListItem>
            <asp:ListItem>Вариант ответа 2</asp:ListItem>
            <asp:ListItem>Вариант ответа 3</asp:ListItem>
            <asp:ListItem>Вариант ответа 4</asp:ListItem>
            <asp:ListItem>Вариант ответа 5</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="Button1" runat="server" Text="Продолжить" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:hsesurveyConnectionString %>" 
            SelectCommand="SELECT * FROM [Question]"></asp:SqlDataSource>
        <br />
        </div>
    </form>
</body>
</html>
