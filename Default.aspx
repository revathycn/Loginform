<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN FORM</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="PAGE">
        <div class="LOGIN">
            
    <table style="width: 100%;">
        <tr>
            <td style="padding: 18px">
                USER NAME;

            </td>
            <td >
                <asp:TextBox ID="TextBox1" runat="server" Width="158px"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td style="padding: 20px">
                PASSWORD;

            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="160px"></asp:TextBox></td>
          
        </tr>
        <tr>
            <td></td>
                    <td >
                 <asp:Button ID="Button1" runat="server"  Text="LOGIN" OnClick="Button1_Click" Height="33px" Width="132px" />
                 
            
                        <asp:Button ID="Button2" runat="server"  Text="CANCEL" Height="33px" OnClick="Button2_Click" Width="132px" />
                </td>
           
                </tr>
        <tr>

            <td >
               
                <asp:Label ID="Label1" runat="server" visible= "false" Text="Wrong Username or Password"></asp:Label>
                
                </td>

            <td >
               
                <asp:Label ID="Label2" runat="server" visible= "false" Text="Enter Username and Password"></asp:Label>
                
                </td>
            </tr>
            
       
    </table>
    </div>
    </div>
        </form>
</body>
</html>
