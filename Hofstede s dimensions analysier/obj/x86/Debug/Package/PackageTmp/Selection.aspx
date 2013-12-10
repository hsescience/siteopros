<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Selection.aspx.cs" Inherits="Hofstede_s_dimensions_analysier.Selection" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            height: 453px;
            width: 781px;
        }
    </style>
</head>
<body style="height: 463px; width: 329px">
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Button ID="DataResetButton" runat="server" Height="36px" 
        Text="Set data to default" Width="326px" onclick="DataResetButton_Click" />
    <asp:Image runat="server" id="arrow1" height="32" width="32" ImageUrl="img/arrow.png"/>
    <asp:Label 
        ID="Label10" runat="server" Font-Names="Gill Sans MT Condensed" Height="30px" 
        Text="Click to prepare data to choose."></asp:Label>
    <div style="width: 322px">
    <asp:Label ID="Label1" runat="server" Text="Waiting for data preparation..."></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Select country:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="23px" 
            style="margin-left: 29px; margin-top: 4px" Width="198px" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Image runat="server" id="arrow2" height="32" width="32" 
            ImageUrl="img/arrow.png" Visible="False"/>
        <asp:Label 
            ID="Label11" runat="server" Font-Names="Gill Sans MT Condensed" Height="30px" 
            Text="Select your country." Visible="False"></asp:Label>
        <div><asp:Label ID="Label3" runat="server" Text="or input marks for search:" 
                Visible="False"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="PDI"></asp:Label>
            <asp:TextBox ID="PDI_mark" runat="server" style="margin-left: 125px" 
                Width="163px" ReadOnly="True"></asp:TextBox>
            <div style="width: 324px">
                <asp:Label ID="Label5" runat="server" Text="IDV"></asp:Label>
                <asp:TextBox ID="IDV_mark" runat="server" style="margin-left: 123px" 
                    Width="163px" ReadOnly="True"></asp:TextBox>
                <div>
                    <asp:Label ID="Label6" runat="server" Text="MAS"></asp:Label>
                    <asp:TextBox ID="MAS_mark" runat="server" style="margin-left: 116px" 
                        Width="163px" ReadOnly="True"></asp:TextBox>
                    <div>
                        <asp:Label ID="Label7" runat="server" Text="UAI"></asp:Label>
                        <asp:TextBox ID="UAI_mark" runat="server" style="margin-left: 123px" 
                            Width="163px" ReadOnly="True"></asp:TextBox>
                        <div>
                            <asp:Label ID="Label8" runat="server" Text="LTO"></asp:Label>
                            <asp:TextBox ID="LTO_mark" runat="server" style="margin-left: 120px" 
                                Width="163px" ReadOnly="True"></asp:TextBox>
                            <div>
                                <asp:Label ID="Label9" runat="server" Text="IVR"></asp:Label>
                                <asp:TextBox ID="IVR_mark" runat="server" style="margin-left: 124px" 
                                    Width="163px" ReadOnly="True"></asp:TextBox>
                                <div style="height: 68px; width: 529px">
                                <asp:Button ID="Button2" runat="server" Height="57px" Text="Search" 
                                    Width="321px" onclick="Button2_Click" />
                                    <asp:Image runat="server" id="arrow3" height="32" width="32" 
                                        ImageUrl="img/arrow.png" Visible="False"/>
                                    <asp:Label 
                                        ID="Label12" runat="server" Font-Names="Gill Sans MT Condensed" Height="30px" 
                                        style="margin-bottom: 0px" Text="Click to continue." 
                                        Visible="False"></asp:Label>
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
