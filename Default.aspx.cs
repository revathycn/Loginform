using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SURESH\Documents\data.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE UserName='" + TextBox1.Text + "' AND Password='" + TextBox2.Text + "'", con);
        DataTable dt = new DataTable(); //this is creating a virtual table  
        sda.Fill(dt);
        if (TextBox1.Text == "" || TextBox2.Text == "")
        {
            Label2.Visible = true;
        }
        else

        if (dt.Rows[0][0].ToString() == "1")
        {
            Response.Redirect("Default2.aspx");
        }
        else
        {
            Label1.Visible = true;
        }
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label2.Visible = false;
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox1.Focus();
        
    }

    
}