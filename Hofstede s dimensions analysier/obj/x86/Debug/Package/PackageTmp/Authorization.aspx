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
        <form id="auto" name = "auto" runat=server action = "">
            <div  id = "fio">Представтесь, пожалуйста</div>
            <div style = "clear:both; margin-top:50px;"></div>

        
            <div class = "colon">
					<div class = "leftcolon">Ваш статус относительно НИУ ВШЭ</div>
					<input type = "hidden" name = "status" id = "status" value = ""/>
					<div class = "rightcolon">
						<div class = "buttoninput">
							<div class = "liststatus">
								<div class = "listitem" onclick = "statitemclick(0);">Абитуриент НИУ ВШЭ</div>
								<div class = "listitem" onclick = "statitemclick(1);">Студент НИУ ВШЭ</div>
								<div class = "listitem" onclick = "statitemclick(2);">Преподаватель НИУ ВШЭ</div>
								<div class = "listitem" onclick = "statitemclick(3);">Сотрудник НИУ ВШЭ</div>
								<div class = "listitem" onclick = "statitemclick(4);">Родитель абитуриента НИУ ВШЭ</div>
								<div class = "listitem" onclick = "statitemclick(5);">Родитель студента НИУ ВШЭ</div>
							</div>
							<div class = "buttoninputtext" id = "statustext"  onclick = "statusonclick();">Выбирите свой статус</div>
							<img class = "littlebutton" id = "lbstatus" onclick = "statusonclick();" src = "Styles/littlebutton.png"/>
						</div>
					</div>
				</div>
				<div style = "clear:both; margin-top:30px;"></div>

                <div class = "colon">
					<div class = "leftcolon">Филиал</div>
					<input type = "hidden" name = "filial" id = "filial" value = ""/>
					<div class = "rightcolon">
						<div class = "buttoninput">
							<div class = "listfilial">
								<div class = "listitem" onclick = "filialitemclick(0);">Москва</div>
								<div class = "listitem" onclick = "filialitemclick(1);">МИЭМ</div>
								<div class = "listitem" onclick = "filialitemclick(2);">Нижний Новгород</div>
								<div class = "listitem" onclick = "filialitemclick(3);">Пермь</div>
								<div class = "listitem" onclick = "filialitemclick(4);">Санкт-Петербург</div>
							</div>
							<div class = "buttoninputtext" id = "filialtext"  onclick = "filialonclick();">Выбирите свой филиал</div>
							<img class = "littlebutton" id = "lbfilial" onclick = "filialonclick();" src = "Styles/littlebutton.png"/>
						</div>
					</div>
				</div>

				<div style = "clear:both; margin-top:30px;"></div>
                 <div class = "colon">
					<div class = "leftcolon">Факультет</div>
					<input type = "hidden" name = "faculty" id = "faculty" value = ""/>
					<div class = "rightcolon">
						<div class = "buttoninputfac">
							<div id = "listfaculty">
								
							</div>
							<div class = "buttoninputtext" id = "facultytext"  onclick = "facultyonclick();">Выбирите свой факультет</div>
							<img class = "littlebutton" id = "lbfaculty" onclick = "facultyonclick();" src = "Styles/littlebutton.png"/>
						</div>
						
					</div>
				</div>

				<div style = "clear:both; margin-top:30px;"></div>
                
                <div class = "colon">
					<div class = "leftcolon">Родная страна</div>
					<input type = "hidden" name = "countrybr" id = "countrybr" value = ""/>
					<div class = "rightcolon">
						<div class = "buttoninput">
							<div id = "listcountrybr">
								
							</div>
							<div class = "buttoninputtext" id = "countrybrtext"  onclick = "countrybronclick();">Выбирите свою родную страну</div>
							<img class = "littlebutton" id = "lbcountrybr" onclick = "countrybronclick();" src = "Styles/littlebutton.png"/>
						</div>
					</div>
				</div>

				<div style = "clear:both; margin-top:30px;"></div>

                <div class = "colon">
					<div class = "leftcolon">Страна проживания</div>
					<input type = "hidden" name = "countryliv" id = "countryliv" value = ""/>
					<div class = "rightcolon">
						<div class = "buttoninput">
							<div id = "listcountryliv">
								
							</div>
							<div class = "buttoninputtext" id = "countrylivtext"  onclick = "countrylivonclick();">Выбирите свою страну проживания</div>
							<img class = "littlebutton"  id = "lbcountryliv" onclick = "countrylivonclick();" src = "Styles/littlebutton.png"/>
						</div>
					</div>
				</div>

				<div id = "podvergdenie">
					<img src="Styles/vykl.png" id = "submitpodtv" onclick = "buttonpodv();">
					<div id = "textpodtvergd" onclick = "buttonpodv();">Да, я согласен(на) на обработку и хранение моих данных</div>
				</div>
				<div style = "clear: both;"></div>
				<div id = "submitbutton" onclick = "submitclick();">
					<div id = "submitbuttontext">Войти</div>
				</div>
      
        <asp:Button ID="Button1" runat="server" style = "visibility:hidden;" onclick="Button1_Click" 
            Text="Продолжить" />
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:hsesurveyConnectionString %>" 
            SelectCommand="SELECT * FROM [Respondent]"></asp:SqlDataSource>
    
    
        </form>
    </div>
</body>
    <script type="text/javascript">addcountriees();</script>
</html>
