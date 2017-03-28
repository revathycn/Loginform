using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SURESH\Documents\data.mdf;Integrated Security=True;Connect Timeout=30");
        con.Open();
        SqlDataAdapter SDA = new SqlDataAdapter("select * from main1", con);
        DataSet DATA = new DataSet();
        SDA.Fill(DATA);
        GridView1.DataSource = DATA;
        GridView1.DataBind();
        con.Close();
    }
}