<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutProject.aspx.cs" Inherits="Hofstede_s_dimensions_analysier.AboutProject" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>О проекте</title>
    <style type="text/css">
    </style>
</head>
<body style="height: 787px">
    <form id="form1" runat="server">
    <div style="height: 775px">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Georgia" 
            Font-Size="X-Large" style="text-align: left" Text="О проекте"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" 
            Text="Тест, разработанный научной группой студентов факультета бизнес-информатики, предназначен для оценки культурных особенностей аудитории портала НИУ ВШЭ. Целью исследования является повышение удобства пользования сайта."></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" 
            Text="Тест состоит из 30 вопросов, каждый из которых подразумевает либо выбор нужного пункта, либо написания короткого ответа. Прохождение теста занимает не больше 10-15 минут."></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" BackColor="#FF9900" 
            Text="Приступить к тесту!" onclick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" 
            Text="В тесте применяются методы исследования культурных особенностей групп, разработанные Гертом Хофстеде. Герт Хофстеде -  нидерландский социолог, который провел исследования межкультурных особенностей респондентов из более чем 50 стран. На основании данных им были сформулированы следующие показатели:"></asp:Label>
        <br />
                       

        <br />
        <asp:Label ID="Label5" runat="server" Text="Дистанцированность от власти"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" 
            Text="Показывает, как сами люди оценивают степень неравенства в обществе, где они находятся"></asp:Label>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Индивидуализм vs Коллективизм"></asp:Label>
        <br />
        <asp:Label ID="Label8" runat="server" 
            Text="Отражает, к каким связям люди более склоны в конкретном обществе: к свободным отношения, где человек заботиться больше только о своем благосостояния и своих близких, или каждый с самого рождения принадлежит сильной сплоченной к группе, которую старается защищать в обмен поддержки со стороны членов этой группы"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Мужественность vs Женственность"></asp:Label>
        <br />
        <asp:Label ID="Label10" runat="server" 
            Text="Показатель, дифференцирующий типы групп по тому, какая роль в этой группе отводиться мужчине: роль напористого, жесткого, сосредоточенного на материальном успехе человека или роль хранители дома, семьи, ведущего домашнее хозяйство и поддерживающее порядок в доме. "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Отношение к неопределенности"></asp:Label>
        <br />
        <asp:Label ID="Label12" runat="server" 
            Text="Показатель, показывающий степень тревожности членов общества перед неопределенной, неизвестной, непредвиденной ситуацией."></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
