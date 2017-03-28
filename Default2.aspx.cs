using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        string body = "From" + "revathy1619@gmail.com" + "\n";
        //  body += "subject" + txtmsg.Text + "\n";
        body += "Message" + TextBox3.Text + "\n";
        var smtp = new System.Net.Mail.SmtpClient();
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("revathy1619@gmail.com", "h@rsh1619");
            smtp.Timeout = 20000;
        }
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SURESH\Documents\data.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into main1 (Message) values ('" + TextBox3.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }


        smtp.Send("revathy1619@gmail.com", TextBox2.Text, TextBox1.Text, TextBox3.Text);
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

   

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
       
        Response.Redirect("Default3.aspx");
    }
}