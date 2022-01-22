using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_insert : System.Web.UI.Page
{
    string mysqlConnection = "SERVER=localhost;DATABASE=web;UID=root;PWD=66761060.Ma";
    protected void Page_Load(object sender, EventArgs e)
    {
        showInfo();
    }




    public void showInfo()
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();
                MySqlDataReader read;

                MySqlCommand komut = new MySqlCommand("select * from user  ", connection);
                read = komut.ExecuteReader();
                GridView1.DataSource = read;
                GridView1.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    protected void addBtn_Click(object sender, EventArgs e)
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO user (userName,password) VALUES (@p1,@p2)", connection);
                command.Parameters.AddWithValue("@p1", username_txt.Text);
                command.Parameters.AddWithValue("@p2", password_txt.Text);
                command.ExecuteNonQuery();
                showInfo();


            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    protected void deleteBtn_Click(object sender, EventArgs e)
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("DELETE FROM user WHERE userID = '" + userID_txt.Text + "'", connection);
        
                command.ExecuteNonQuery();
                showInfo();


            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    protected void updateBtn_Click(object sender, EventArgs e)
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE user SET userName = '" + username_txt.Text + "', password= '" + password_txt.Text + "' WHERE userID ='" + userID_txt.Text + "'", connection);

                command.ExecuteNonQuery();
                showInfo();


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}