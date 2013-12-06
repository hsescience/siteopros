<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuestionAdder.aspx.cs" Inherits="Hofstede_s_dimensions_analysier.QuestionAdder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 559px">
    <form id="form1" runat="server">
    <div style="height: 549px">
    
        <asp:Label ID="Label1" runat="server" Text="Тип вопроса:"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Со слайдером</asp:ListItem>
            <asp:ListItem>С радиобаттоном</asp:ListItem>
            <asp:ListItem>С текстбоксом</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Описание способа ответа:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="87px" TextMode="MultiLine" 
            Width="626px"></asp:TextBox>
        <br />
        <br />
        Текст вопроса:<br />
        <asp:TextBox ID="TextBox2" runat="server" Height="87px" TextMode="MultiLine" 
            Width="626px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Ответы через //"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Height="24px" Width="621px"></asp:TextBox>
        <br />
        <br />
        Статус респондентов (0 - все):<br />
        <asp:TextBox ID="TextBox4" runat="server" Height="23px" Width="621px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Сохранить" />
    
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:hsesurveyConnectionString %>" 
        SelectCommand="SELECT * FROM [Question]"></asp:SqlDataSource>
    </form>
</body>
</html>
