<%--ACTUAL LANDING PAGE--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="landing_v2.aspx.cs" Inherits="Hofstede_s_dimensions_analysier.landing_v2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Styles/landing.css" rel="stylesheet" type="text/css" />
    <title>LITI Start Page</title>

<%--    ======Скрипт для убирания описаний под спойлер=======--%>
    <script type="text/javascript">
        function fade(obj, s, opa) {
            if (s == 1) {
                var op = opa + 5;
                if (op <= 100) {
                    var ob = document.getElementById(obj);
                    if (ob.style.display != "block") {
                        ob.style.display = "block";
                    }
                    ob.style.opacity = (op / 100);
                    if (op < 100) {
                        setTimeout("fade(\"" + obj + "\",1," + op + ")", 20);
                    }
                }
            }
            else {
                var op = opa - 5;
                var ob = document.getElementById(obj);
                if (op > 0) {

                    ob.style.opacity = (op / 100);
                    setTimeout("fade(\"" + obj + "\",0," + op + ")", 20);
                }
                else {
                    ob.style.display = "none";
                }
            }
        } 
    </script>
       <%-- ==================================================--%>

</head>
<body background="img/1.png" style="color: #FFFFFF" bgcolor="#000000">
    <form id="form1" runat="server">
    <div>
        <h1 align="center">
            Let's improve the Internet!</h1>
    </div>
    <div>
        <h2>
            Why?
        </h2>
        <p>
            Because the Internet is the dark place full of awful sites, which we have to use
            to find something we need.</p>
        <p>
            <img src="img/awful2.jpg" alt="the dark place" /></p>
    </div>
    <div>
        <h2>
            How?
        </h2>
        <p>
            By researching cultural differences and prefrences of Internet users all over the
            world and preparing recommendations for sites design assuming them.</p>
        <p>
            In the first step of investigation, cultural differnces are estimated acording to
            Geert Hofstede cultural dimensions:</p>
        <ul>
            <li>
                <h3>
                    Power Distance (PDI)</h3>
                <p onclick="fade('PDI_spoiler',1,0); return false" style="color: #999999">
                    (show description)</p>
                <ul id="PDI_spoiler" style="display: none;">
                    <li>
                        <p>
                            This dimension expresses the degree to which the less powerful members of a society
                            accept and expect that power is distributed unequally.</p>
                        <img src="img/22.png" alt="PDI" align="top" />
                        <p onclick="fade('PDI_spoiler',0,100); return false" style="color: #999999">
                            (hide description)</p>
                    </li>
                </ul>
            </li>
            <li>
                <h3>
                    Individualism versus collectivism (IDV)</h3>
                <p onclick="fade('IDV_spoiler',1,0); return false" style="color: #999999">
                    (show description)</p>
                <ul id="IDV_spoiler" style="display: none;">
                    <li>
                        <p>
                            A society's position on this dimension is reflected in whether people’s self-image
                            is defined in terms of “I” or “we”.</p>
                        <img src="img/23.png" alt="IDV" />
                        <p onclick="fade('IDV_spoiler',0,100); return false" style="color: #999999">
                            (hide description)</p>
                    </li>
                </ul>
            </li>
            <li>
                <h3>
                    Masculinity versus femininity (MAS)</h3>
                <p onclick="fade('MAS_spoiler',1,0); return false" style="color: #999999">
                    (show description)</p>
                <ul id="MAS_spoiler" style="display: none;">
                    <li>Masculine society at large is more competitive. Its opposite, feminine, stands for
                        a preference for cooperation, modesty, caring for the weak and quality of life.
                        <p onclick="fade('MAS_spoiler',0,100); return false" style="color: #999999">
                            (hide description)</p>
                    </li>
                </ul>
            </li>
            <li>
                <h3>
                    Uncertainty avoidance (UAI)</h3>
                <p onclick="fade('UAI_spoiler',1,0); return false" style="color: #999999">
                    (show description)</p>
                <ul id="UAI_spoiler" style="display: none;">
                    <li>
                        <p>
                            The uncertainty avoidance dimension expresses the degree to which the members of
                            a society feel uncomfortable with uncertainty and ambiguity.</p>
                        <img src="img/24.png" alt="UAI" />
                        <p onclick="fade('UAI_spoiler',0,100); return false" style="color: #999999">
                            (hide description)</p>
                    </li>
                </ul>
            </li>
            <li>
                <h3>
                    Long-term versus short-term orientation (LTO)</h3>
                <p onclick="fade('LTO_spoiler',1,0); return false" style="color: #999999">
                    (show description)</p>
                <ul id="LTO_spoiler" style="display: none;">
                    <li>
                        <p>
                            The long-term orientation dimension can be interpreted as dealing with society’s
                            search for virtue.</p>
                        <img src="img/25.png" alt="LTO" />
                        <p onclick="fade('LTO_spoiler',0,100); return false" style="color: #999999">
                            (hide description)</p>
                    </li>
                </ul>
            </li>
            <li>
                <h3>
                    Indulgence versus Restraint (IVR)</h3>
                <p onclick="fade('IVR_spoiler',1,0); return false" style="color: #999999">
                    (show description)</p>
                <ul id="IVR_spoiler" style="display: none;">
                    <li>
                        <p>
                            Indulgence stands for a society that allows enjoying life and having fun. Restraint
                            stands for a society that suppresses gratification of needs and regulates it by
                            means of strict social norms.</p>
                        <img src="img/26.png" alt="IVR" />
                        <p onclick="fade('IVR_spoiler',0,100); return false" style="color: #999999">
                            (hide description)</p>
                    </li>
                </ul>
            </li>
        </ul>
    </div>
    <div>
        <h2>
            Participate!
        </h2>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="Black" BorderColor="White" BorderStyle="Double"
                ForeColor="White" Height="33px" OnClick="Button1_Click1" Text="Start" Width="121px" />
        </p>
    </div>
    </form>
</body>
</html>
