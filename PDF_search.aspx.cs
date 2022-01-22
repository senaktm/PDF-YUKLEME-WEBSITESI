using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class search_pdf : System.Web.UI.Page
{
    string mysqlConnection = "SERVER=localhost;DATABASE=web;UID=root;PWD=66761060.Ma";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();
                MySqlDataReader read;

                MySqlCommand command = new MySqlCommand("select pdf.title from pdf, author_pdf_connection where  author_pdf_connection.author_number = " + TextBox1.Text + " and pdf.pdfID = author_pdf_connection.pdfID", connection);
                read = command.ExecuteReader();
                GridView1.DataSource = read;
                GridView1.DataBind();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();
                MySqlDataReader read;

                MySqlCommand command = new MySqlCommand("select pdf.title from pdf, author_pdf_connection,author where pdf.pdfID=author_pdf_connection.pdfID AND author.author_name = " + TextBox2.Text + " and author.author_number = author_pdf_connection.author_number", connection);
                read = command.ExecuteReader();
                GridView1.DataSource = read;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();
                MySqlDataReader read;

                MySqlCommand command = new MySqlCommand("select title from pdf where lecture_name='"+TextBox3.Text+"'", connection);
                read = command.ExecuteReader();
                GridView1.DataSource = read;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }



    protected void Button4_Click(object sender, EventArgs e)
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();
                MySqlDataReader read;

                MySqlCommand command = new MySqlCommand("select pdf.title from pdf where pdf.title='" + TextBox4.Text + " '", connection);
                read = command.ExecuteReader();
                GridView1.DataSource = read;
                GridView1.DataBind();
            }
            catch (Exception )
            {
                throw;
            }

        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();
                MySqlDataReader read;

                MySqlCommand command = new MySqlCommand("(select title from pdf where pdfID IN (SELECT pdfID FROM keyword_pdf_connection WHERE keyword='"+TextBox5.Text+"'))", connection);
                read = command.ExecuteReader();
                GridView1.DataSource = read;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();
                MySqlDataReader read;

                MySqlCommand command = new MySqlCommand("select pdf.title from pdf where pdf.term='"+TextBox6.Text+"'", connection);
                read = command.ExecuteReader();
                GridView1.DataSource = read;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();
                MySqlDataReader read;

                MySqlCommand command = new MySqlCommand("select title from pdf where pdf.term='" + TextBox7.Text +"' AND lecture_name='"+ TextBox9.Text +"'"+
                   " AND pdfID IN(select pdfID from user_pdf_connection where userID IN(SELECT userID  from user where "
                 +"userName='" + TextBox8.Text + "'))" , connection);
                read = command.ExecuteReader();

                if (read!= null) {
                    GridView1.DataSource = read;
                    GridView1.DataBind();
                }
                else
                {
                    Label1.Text = "NULL CNM";
                }
               
           
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}