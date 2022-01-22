
using System;
using MySql.Data.MySqlClient;
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

public partial class AdminLogin : System.Web.UI.Page
{
    string mysqlConnection = "SERVER=localhost;DATABASE=web;UID=root;PWD=66761060.Ma";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void admin_btn_Click(object sender, EventArgs e)
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();
                MySqlDataReader read;
                MySqlCommand command = new MySqlCommand("SELECT * FROM admin WHERE adminName='" + username_txt.Text + "' AND password='" + password_txt.Text + "'", connection);
                read = command.ExecuteReader();
                if (read.Read())
                {
                    Session["adminName"] = read["adminName"].ToString().ToUpper();
                    Response.Redirect("default2.aspx");




                }
                else
                {
                    Response.Write("Invalid username or password");
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
        }
}