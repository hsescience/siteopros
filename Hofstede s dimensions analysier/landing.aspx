<%--OUTDATED--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="landing.aspx.cs" Inherits="Hofstede_s_dimensions_analysier.landing" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="~/Styles/landing.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body background="img/1.png" style="color: #FFFFFF" bgcolor="#000000">
    <form id="form1" runat="server">
    <div>
    <h1 align="center">Let's improve the Internet!</h1>
    </div>
    <div><h2>
    Why?
    </h2>
    <p>Because the Internet is the dark place full of awful sites, which we have to use to find something we need.</p>
    <p><img src="img/awful2.jpg" /></p>
    </div>
    <div><h2>
    How?
    </h2>
    <p>By researching cultural differences and prefrences of Internet users all over the world and preparing recommendations for sites design assuming them.</p>
    <p>In the first step of investigation, cultural differnces are estimated acording to Geert Hofstede cultural dimensions:</p>
    <ul>
    <li>Power Distance (PDI)
<ul>
<li>This dimension expresses the degree to which the less powerful members of a society accept and expect that power is distributed unequally.
</li>
</ul>
</li>

<li>
Individualism versus collectivism (IDV)
<ul>
<li>
A society's position on this dimension is reflected in whether people’s self-image is defined in terms of “I” or “we”.
</li>
</ul>
</li>

<li>
Masculinity versus femininity (MAS)
<ul>
<li>
Masculine society at large is more competitive. Its opposite, feminine, stands for a preference for cooperation, modesty, caring for the weak and quality of life.
</li>
</ul>
</li>

<li>
Uncertainty avoidance (UAI)
<ul>
<li>
The uncertainty avoidance dimension expresses the degree to which the members of a society feel uncomfortable with uncertainty and ambiguity. 
</li>
</ul>
</li>

<li>
Long-term versus short-term orientation (LTO)
<ul>
<li>
The long-term orientation dimension can be interpreted as dealing with society’s search for virtue.
</li>
</ul>
</li>

<li>
Indulgence versus Restraint (IVR)
<ul>
<li>
Indulgence stands for a society that allows enjoying life and having fun. Restraint stands for a society that suppresses gratification of needs and regulates it by means of strict social norms.
</li>
</ul>
</li>
</ul>

    </div>
    <div><h2>
    Participate!
    </h2>
    <p>
        <asp:Button ID="Button1" runat="server" BackColor="Black" BorderColor="White" 
            BorderStyle="Double" ForeColor="White" Height="33px" onclick="Button1_Click1" 
            Text="Start" Width="121px" />
        </p></div>
    </form>
</body>
</html>
