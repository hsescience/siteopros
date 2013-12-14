<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutProject.aspx.cs" Inherits="Hofstede_s_dimensions_analysier.AboutProject" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" class = "nobgimage">
<head runat="server">
    <title>О проекте</title>
    <meta charset = "utf-8" />
    <link href="Styles/style.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="font/font.css">
    <script type ="text/javascript" src = "Scripts/control.js"></script>

</head>
<body>
   <div class = "header">
        <div class = "header_content">
            <img src = "Styles/hselogo.png" class="header_content_logo" />
            <span class = "header_content_text">Примите участие</span>
        </div>
   </div>

   <div style = "clear:both;"></div>

   <div class = "wrap1">
        <div class = "wrap1_content">        
                  <div class = "wrap1_content_text">Это новый очень <br /><nobr> интересный проект НИУ ВШЭ</nobr>
                         <div class = "wrap1_content_button" onclick = "buttonaboutproject()">
                            <div class = "wrap1_content_button-text" onclick = "buttonaboutproject()">Пройти тест</div>
                         </div> 
                  </div>
                 <img src = "Styles/laptop.png" class = "wrap1_content_img-laptop" />
        </div>
   </div>

   <div style = "clear:both;"></div>

   <div class = "wrap2">
        <div class = "wrap2_content">
            <div class ="wrap2-content_left-colomn">
                <div class = "wrap2-content_left-colomn_text">Как это работает?</div>
                <img src = "Styles/houseimg.png" class = "wrap2-content_left-colomn_img"/>
            </div>
            <div class ="wrap2-content_right-colomn">
                <p>Тест, разработанный научной группой студентов факультета бизнес-информатики, предназначен для оценки культурных особенностей аудитории портала НИУ ВШЭ.</p>
                <p> Целью исследования является повышение удобства пользования сайта.</p>
                <p> Тест состоит из 30 вопросов, каждый из которых подразумевает либо выбор нужного пункта, либо написания короткого ответа. Прохождение теста занимает не больше 10-15 минут.</p>
            </div>
        </div>
   </div>

   <div style = "clear:both;"></div>

   <div class = "wrap3">
        <div class = "wrap3_content">
            <div class = "wrap3-content_left-colomn">
                <div class = "wrap3-content_left-colomn_item" style = "margin-top:30px;">
                    <img class = "wrap3-content_left-colomn_item-img" width=13 height=28 src="Styles/i1.png"/>
                    <div class = "wrap3-content_left-colomn_item-text">Текст, обосновывающий применение хофстедовых измерений вообще, а потом каждого в частности</div>
                </div>

                <div class = "wrap3-content_left-colomn_item">
                    <img class = "wrap3-content_left-colomn_item-img" width=23 height=22 style = "margin-left:-8px;" src="Styles/i2.png"/>
                    <div class = "wrap3-content_left-colomn_item-text">Текст, обосновывающий применение хофстедовых измерений вообще, а потом каждого в частности</div>
                </div>

                <div class = "wrap3-content_left-colomn_item">
                    <img class = "wrap3-content_left-colomn_item-img" width=25 height=25 style = "margin-left:-8px;" src="Styles/i3.png"/>
                    <div class = "wrap3-content_left-colomn_item-text">Текст, обосновывающий применение хофстедовых измерений вообще, а потом каждого в частности</div>
                </div>
            </div>
            <div class = "wrap3-content_right-colomn_img">
                <div class = "wrap3-content_right-colomn_img_opacity"></div>
                <div class ="wrap3-content_right-colomn_img-text">
                    <p>Культурные изменения</p>
                    <p>Герта Хофстеде</p>
                </div>
            </div>
        </div>
   </div>

   <div style = "clear:both;"></div>

   <div class = "footer">
        <div class = "footer_content">
            <div class="footer-content_where-text">&copyCopyright 2013 HSE</div>
            <div class="footer-content_about-text">About</div>
            <img src = "Styles/logo_fb.png" class= "footer-content_img-logo"/>
            <img src = "Styles/logo_tw.png" class= "footer-content_img-logo"/>
            <img src = "Styles/logo_vk.png" class= "footer-content_img-logo"/>
        </div>
   </div>
   
</body>

<form id="form1" runat="server" style = "height: 100%; width: 100%;">
     <asp:Button ID="Button1" style = "display:none;" runat="server" onclick="Button1_Click" />  
</form>
</html>
