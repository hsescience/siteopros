<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recomendations_form.aspx.cs" Inherits="Hofstede_s_dimensions_analysier.Recomendations_form" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 649px; width: 935px">
    
        <div>
            <asp:Label ID="Label1" runat="server" 
                Text="Read description of common sites of your region and vote, is it true? Please, provide feedback, what's wrong in decription and how those sites should be changed to be more convenient (note, that feedback may be sent only once)."></asp:Label>
            <div style="height: 93px">
                <asp:Label ID="Label2" runat="server" 
                    
                    Text="metaphors (typical images (simulacrums, not pictures) used in the design of the sites):"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Height="72px" Width="782px" 
                    TextMode="MultiLine" ReadOnly="True" Font-Names="Georgia"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="44px" 
                    ImageUrl="~/img/like.png" onclick="ImageButton1_Click" style="margin-top: 0px" 
                    Width="55px" />
                <asp:ImageButton ID="ImageButton2" runat="server" Height="44px" 
                    ImageUrl="~/img/dislike.jpg" onclick="ImageButton2_Click" 
                    style="margin-top: 0px" Width="55px" />
                <div style="height: 93px">
                    <asp:Label ID="Label3" runat="server" 
                        Text="mental models ( flows of thought from the real life, the use of which is stimulated when using the site):"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" Height="72px" Width="781px" 
                        TextMode="MultiLine" ReadOnly="True" Font-Names="Georgia"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton3" runat="server" Height="44px" 
                        ImageUrl="~/img/like.png" onclick="ImageButton3_Click" style="margin-top: 0px" 
                        Width="55px" />
                    <asp:ImageButton ID="ImageButton4" runat="server" Height="44px" 
                        ImageUrl="~/img/dislike.jpg" onclick="ImageButton4_Click" 
                        style="margin-top: 0px" Width="55px" />
                <div style="height: 93px">
                    <asp:Label ID="Label4" runat="server" 
                        Text="navigation (features of transition within the web pages and between them):"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" Height="72px" Width="781px" 
                        TextMode="MultiLine" ReadOnly="True" Font-Names="Georgia"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton5" runat="server" Height="44px" 
                        ImageUrl="~/img/like.png" onclick="ImageButton5_Click" style="margin-top: 0px" 
                        Width="55px" />
                    <asp:ImageButton ID="ImageButton6" runat="server" Height="44px" 
                        ImageUrl="~/img/dislike.jpg" onclick="ImageButton6_Click" 
                        style="margin-top: 0px" Width="55px" />
                <div style="height: 93px">
                    <asp:Label ID="Label5" runat="server" 
                        Text="interaction (specific of user 's interaction with the interface):"></asp:Label>
                    <asp:TextBox ID="TextBox4" runat="server" Height="72px" Width="781px" 
                        TextMode="MultiLine" ReadOnly="True" Font-Names="Georgia"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton7" runat="server" Height="44px" 
                        ImageUrl="~/img/like.png" onclick="ImageButton7_Click" style="margin-top: 0px" 
                        Width="55px" />
                    <asp:ImageButton ID="ImageButton8" runat="server" Height="44px" 
                        ImageUrl="~/img/dislike.jpg" onclick="ImageButton8_Click" 
                        style="margin-top: 0px" Width="55px" />
                <div style="height: 93px">
                    <asp:Label ID="Label6" runat="server" 
                        
                        Text="appearence (features of the visual design: colors, shapes, elements location, using videos and other multimedia, etc.):"></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server" Height="72px" Width="781px" 
                        TextMode="MultiLine" ReadOnly="True" Font-Names="Georgia"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton9" runat="server" Height="44px" 
                        ImageUrl="~/img/like.png" onclick="ImageButton9_Click" style="margin-top: 0px" 
                        Width="55px" />
                    <asp:ImageButton ID="ImageButton10" runat="server" Height="44px" 
                        ImageUrl="~/img/dislike.jpg" onclick="ImageButton10_Click" 
                        style="margin-top: 0px" Width="55px" />
                <div style="height: 93px">
                    <asp:Label ID="Label7" runat="server" Text="Feedback:"></asp:Label>
                    <div>
                    <asp:TextBox ID="TextBox6" runat="server" Height="72px" Width="781px" 
                        TextMode="MultiLine" Font-Names="Georgia"></asp:TextBox>
                        <div>
                <asp:Button ID="Button12" runat="server" Text="Send" Height="25px" Width="104px" 
                                onclick="Button12_Click" />
                        </div>
                    </div>
                </div>
                </div>
                </div>
                </div>
                </div>
            </div>
        </div>
    
    </div>
    </form>
</body>
</html>
