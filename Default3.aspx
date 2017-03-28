<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td><asp:Button ID="Button1" runat="server" Text="View Messages" onclick="Button1_Click" /></td>
                
            </tr>
            
        </table>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" Height="225px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="433px">
        
            </asp:GridView>
    </form>
</body>
</html>
