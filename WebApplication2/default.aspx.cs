using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == "七星山")
            {
                Button1.PostBackUrl = "七星山.aspx";
            }
           
            else if (TextBox1.Text == "拉拉山")
            {
                Button1.PostBackUrl = "拉拉山.aspx";
            }
            else if (TextBox1.Text == "加利山")
            {
                Button1.PostBackUrl = "加利山.aspx";
            }
            else if (TextBox1.Text == "雪山")
            {
                Button1.PostBackUrl = "雪山.aspx";
            }
            else if (TextBox1.Text == "合歡山")
            {
                Button1.PostBackUrl = "合歡山.aspx";
            }
            else if (TextBox1.Text == "奇萊山")
            {
                Button1.PostBackUrl = "奇萊山.aspx";
            }
            else if (TextBox1.Text == "秀姑巒山")
            {
                Button1.PostBackUrl = "秀姑巒山.aspx";
            }
            else if (TextBox1.Text == "玉山")
            {
                Button1.PostBackUrl = "玉山.aspx";
            }
            else if (TextBox1.Text == "玉穗山")
            {
                Button1.PostBackUrl = "玉穗山.aspx";
            }
            else if (TextBox1.Text == "塔關山")
            {
                Button1.PostBackUrl = "塔關山.aspx";
            }
            else if (TextBox1.Text == "關山")
            {
                Button1.PostBackUrl = "關山.aspx";
            }
            else
            {
                Button1.PostBackUrl = "false.aspx";
            }
        }
    }
}