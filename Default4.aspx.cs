﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default4 : System.Web.UI.Page
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
            cmd.CommandText = "select * from stagaire";
            cn.Open();
            d = cmd.ExecuteReader();

            while (d.Read())
            {
                ListBox1.Items.Add(d[0].ToString() + " " + d[1].ToString() + " " + d[2].ToString() + " " + d[3].ToString());
            }

            d.Close();
            cn.Close();
        }
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from stagaire where NumI=" + (int.Parse(ListBox1.SelectedIndex.ToString())+1) ;
        cn.Open();
        d = cmd.ExecuteReader();
        if (d.Read()) {
            TextBox1.Text = d[0].ToString();
            TextBox2.Text = d[1].ToString();
            TextBox3.Text = d[2].ToString();
            TextBox4.Text = d[3].ToString();
        }
        d.Close();
        cn.Close();
    }
}