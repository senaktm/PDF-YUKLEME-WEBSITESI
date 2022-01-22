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

public partial class UserLogin : System.Web.UI.Page
{
  
    string mysqlConnection = "SERVER=localhost;DATABASE=web;UID=root;PWD=66761060.Ma";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void loginBtn_Click(object sender, EventArgs e)
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();
                MySqlDataReader read;
                MySqlCommand command = new MySqlCommand("SELECT userID FROM user WHERE userName='" + username_txt.Text + "' AND password='" + password_txt.Text + "'", connection);
                read = command.ExecuteReader();


            

                if (read.Read() )
                {
                    getID.User_id = read.GetInt32(0);
                    getID.UserName = username_txt.Text;
                    //Session["userName"] = read["userName"].ToString().ToUpper();
                    Response.Redirect("default.aspx");
                    



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
