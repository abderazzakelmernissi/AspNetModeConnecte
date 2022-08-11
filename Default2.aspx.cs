using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{

    SqlConnection cn = new SqlConnection("Data Source=USER6EB4;Initial Catalog=TpAsp1;Integrated Security=True");
    SqlCommand cmd = new SqlCommand();
    SqlDataReader d;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from stagaire";
            cn.Open();
            d = cmd.ExecuteReader();


            if (d.Read())
            {
                TextBox1.Text = d[0].ToString();
                TextBox2.Text = d[1].ToString();
                TextBox3.Text = d[2].ToString();
                TextBox4.Text = d[3].ToString();
            }
            cn.Close();
            d.Close();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select top 1 * from stagaire order by NumI DESC";
        cn.Open();
        d = cmd.ExecuteReader();

        if (d.Read())
        {

            TextBox1.Text = d[0].ToString();
            TextBox2.Text = d[1].ToString();
            TextBox3.Text = d[2].ToString();
            TextBox4.Text = d[3].ToString();
        }
        cn.Close();
        d.Close();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select top 1 * from stagaire";
        cn.Open();
        d = cmd.ExecuteReader();
        if (d.Read())
        {
            TextBox1.Text = d[0].ToString();
            TextBox2.Text = d[1].ToString();
            TextBox3.Text = d[2].ToString();
            TextBox4.Text = d[3].ToString();
        }
        cn.Close();
        d.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stagaire where NumI=" + (int.Parse(TextBox1.Text) - 1);
            cn.Open();
            d = cmd.ExecuteReader();
            if (d.Read())
            {
                TextBox1.Text = d[0].ToString();
                TextBox2.Text = d[1].ToString();
                TextBox3.Text = d[2].ToString();
                TextBox4.Text = d[3].ToString();
            }
            cn.Close();
            d.Close();
        }
        catch { }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from stagaire where NumI=" + (int.Parse(TextBox1.Text) + 1);
            cn.Open();
            d = cmd.ExecuteReader();

            if (d.Read())
            {
                TextBox1.Text = d[0].ToString();
                TextBox2.Text = d[1].ToString();
                TextBox3.Text = d[2].ToString();
                TextBox4.Text = d[3].ToString();
            }
            cn.Close();
            d.Close();
        }
        catch { }
    }
}