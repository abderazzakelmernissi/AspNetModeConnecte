using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {

            for(int i =1;i<=10;i++)
            ListBox1.Items.Add(i.ToString());
        }
    }
    protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ListBox2.Items.Add(ListBox1.SelectedValue);
        ListBox1.Items.Remove(ListBox1.SelectedValue);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Add(ListBox2.SelectedValue);
        ListBox2.Items.Remove(ListBox2.SelectedValue);
    }
}