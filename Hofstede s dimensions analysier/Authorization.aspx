<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Authorization.aspx.cs" Inherits="Hofstede_s_dimensions_analysier.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset = "utf-8" />
    <title>Добро пожаловать, пройдите опрос</title>
    <link href="Styles/style.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="font/font.css">
    <link type="text/css" rel="stylesheet" href="Styles/jquery.jscrollpane.css"/>

    <script type="text/javascript" src = "Scripts/control.js"></script>
	<script type="text/javascript" src = "Scripts/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="Scripts/jquery.mousewheel.js"></script>
	<script type="text/javascript" src="Scripts/jquery.jscrollpane.js"></script>

   
</head>
<body>
    <div id = "content_auto">
    <form id="form1" runat="server">
    <div style="height: 412px">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Georgia" 
            Font-Size="X-Large" style="text-align: left" Text="Представьтесь, пожалуйста!"></asp:Label>
        <br />
        <br />
        <span style="font-size:11.0pt;line-height:107%;
font-family:&quot;Georgia&quot;,&quot;serif&quot;;mso-fareast-font-family:Calibri;mso-fareast-theme-font:
minor-latin;mso-bidi-font-family:&quot;Times New Roman&quot;;mso-bidi-theme-font:minor-bidi;
mso-ansi-language:RU;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">Статус 
        относительно НИУ ВШЭ:</span><br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Абитуриент</asp:ListItem>
            <asp:ListItem>Студент</asp:ListItem>
            <asp:ListItem>Преподаватель</asp:ListItem>
            <asp:ListItem>Сотрудник</asp:ListItem>
            <asp:ListItem>Родитель абитуриента </asp:ListItem>
            <asp:ListItem>Родитель студента </asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <span style="font-size:11.0pt;line-height:107%;
font-family:&quot;Georgia&quot;,&quot;serif&quot;;mso-fareast-font-family:Calibri;mso-fareast-theme-font:
minor-latin;mso-bidi-font-family:&quot;Times New Roman&quot;;mso-bidi-theme-font:minor-bidi;
mso-ansi-language:RU;mso-fareast-language:EN-US;mso-bidi-language:AR-SA">Филиал:</span><br />
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>НИУ ВШЭ в Москве</asp:ListItem>
            <asp:ListItem>НИУ ВШЭ в Санкт-Петербурге</asp:ListItem>
            <asp:ListItem>НИУ ВШЭ в Нижнем Новгороде</asp:ListItem>
            <asp:ListItem>НИУ ВШЭ в Перми</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Факультет:"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList4" runat="server">
            <asp:ListItem>БИ</asp:ListItem>
            <asp:ListItem>Эконом</asp:ListItem>
            <asp:ListItem>ГМУ</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Родная страна:"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList5" runat="server">
            <asp:ListItem>РФ</asp:ListItem>
            <asp:ListItem>США</asp:ListItem>
            <asp:ListItem>Norge</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Страна проживания:"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList6" runat="server">
            <asp:ListItem>РФ</asp:ListItem>
            <asp:ListItem>США</asp:ListItem>
            <asp:ListItem>Norge</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" 
            Text="Я согласен на обработку моих данных." />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Продолжить" />
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:hsesurveyConnectionString %>" 
            SelectCommand="SELECT * FROM [Respondent]"></asp:SqlDataSource>
    
    </div>
    </form>
    </div>
</body>
</html>
