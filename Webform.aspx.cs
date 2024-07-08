using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace test5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SampleDatabase.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

         //   disp_data();

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Table1 values('" + firstname.Text + "', '" + lastname.Text + "', '" + city.Text + "')";
            cmd.ExecuteNonQuery();
            firstname.Text = "";
            lastname.Text = "";
            city.Text = "";
            
          //  disp_data();
        }
     

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Table1 where firstname='" + firstname.Text + "'";
            cmd.ExecuteNonQuery();
            firstname.Text = "";
           // disp_data() ;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Table1 set firstname='"+firstname.Text+"',lastname='"+lastname.Text+"',city='"+city.Text+"' where id=" + Convert.ToInt32(id.Text) + "";
            cmd.ExecuteNonQuery();
            firstname.Text = "";
            lastname.Text = "";
            city.Text = "";
            id.Text = "";
           // disp_data();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        //You can use it as a function to keep track of data

        /*  public void disp_data()
       {
           SqlCommand cmd = con.CreateCommand();
           cmd.CommandType = CommandType.Text;
           cmd.CommandText = "select * from Table1";
           cmd.ExecuteNonQuery();
           DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(dt);
           GridView1.DataSource = dt;
           GridView1.DataBind();
       } */
    }
}