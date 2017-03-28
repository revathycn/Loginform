
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            height: 95px;
        }
        .auto-style2 {
            height: 27px;
        }
        .auto-style3 {
            left: -2px;
            top: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style3">
    <div class="PAGE">
   <div class="Login">
    <h1>Contact form 
    </h1>
       <table style="width: 100%;" >
           <tr>
               <td class="auto-style2">Name</td>
               <td class="auto-style2">
                   <asp:TextBox ID="TextBox1" runat="server" Width="369px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox></td>
              <td class="auto-style2"></td>
           </tr>
           <tr>
               <td>Email</td>
               <td>
                   <asp:TextBox ID="TextBox2" runat="server" Width="369px"></asp:TextBox></td>
               <td></td>
           </tr>
           <tr>
               <td class="auto-style1">Message</td>
               <td class="auto-style1">
                   <asp:TextBox ID="TextBox3" runat="server" Height="85px" Width="369px"></asp:TextBox></td>
               <td class="auto-style1"></td>
           </tr>
           <tr>
               <td></td>
               <td>

           
                   <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1" Width="99px" />
                   
               </td>
               


           </tr>
       </table>
       <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Click Here</asp:LinkButton>
    </div>
</div>
    </form>
</body>
</html>
