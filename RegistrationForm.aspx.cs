using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class RegistrationForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        {

            SqlConnection con = new SqlConnection(@"Data Source=SAHIL\SQLEXPRESS; Initial Catalog=Login; User ID=sa; Password=sa@123");

            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tbllogins values(@name,@pass,@city,@gender,@mail)", con);
                cmd.Parameters.AddWithValue("name", TextBox1.Text);
                cmd.Parameters.AddWithValue("pass", TextBox2.Text);
                cmd.Parameters.AddWithValue("city", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("gender", RadioButtonList1.SelectedValue);
                cmd.Parameters.AddWithValue("mail", TextBox4.Text);
                cmd.ExecuteNonQuery();

                TextBox1.Text = "";
                TextBox2.Text = "";
                DropDownList1.SelectedValue = "";
                RadioButtonList1.SelectedValue = "";
                TextBox4.Text = "";
                TextBox1.Focus();
                con.Close();
            }
        }
    }
}		
