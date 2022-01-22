using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text;
using System.Diagnostics;

public partial class _Default : System.Web.UI.Page
{
    string mysqlConnection = "SERVER=localhost;DATABASE=web;UID=root;PWD=66761060.Ma";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            nameLbl.Text = getID.UserName;
        }
        catch
        {
            Response.Write("Please Login");
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
            try
            {
                if (FileUpload1.PostedFile.ContentType == "application/pdf")
                {
                        FileUpload1.SaveAs(("C:\\Users\\mehmet\\source\\repos\\WebSite1\\files\\") + FileUpload1.FileName);
                        Label1.Text = "File name: " +
                            FileUpload1.PostedFile.FileName +
                            "<br />File size: " +
                            FileUpload1.PostedFile.ContentLength +
                            "<br />File type: " +
                            FileUpload1.PostedFile.ContentType;

                    PdfInfo("C:\\Users\\mehmet\\source\\repos\\WebSite1\\files\\" + FileUpload1.FileName,out string why);
                   // Label1.Text = why+max_pdfID();
                    
                }
                else
                {
                    Label1.Text = "Choose a file.";
                }

            }
            catch (Exception ex)
            {
                Label1.Text = "Error " + ex.Message.ToString();
            }
        else
        {
            Label1.Text = " Please choose a file and save";
        }
    }


    public void PdfInfo(string file_path,out string why)
    {
        why = "";
        try
        {
            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader(file_path))
            {
                text.Append(PdfTextExtractor.GetTextFromPage(reader, 2));



            }
            string sayfa = text.ToString();
            string dersAdi;
            int index = 0;
            if (sayfa.Contains("BİTİRME PROJESİ"))
            {
                dersAdi = "BİTİRME PROJESİ";
                index = sayfa.IndexOf("BİTİRME PROJESİ");
                sayfa = sayfa.Remove(0, index + 15);
            }
            else
            {
                dersAdi = "ARAŞTIRMA PROBLEMLERİ";
                index = sayfa.IndexOf("ARAŞTIRMA PROBLEMLERİ");
                sayfa = sayfa.Remove(0, index + 20);
            }
            index = sayfa.IndexOf(".");
            if (sayfa.Remove(0, index - 5).IndexOf("\n") < 1)
            {
                sayfa = sayfa.Remove(0, index - 4);
            }
            else if (sayfa.Remove(0, index - 4).IndexOf("\n") < 1)
            {
                sayfa = sayfa.Remove(0, index - 3);
            }
            else if (sayfa.Remove(0, index - 3).IndexOf("\n") < 1)
            {
                sayfa = sayfa.Remove(0, index - 2);
            }
            string unvan;
            string danisman;
            string donem = "";
            string month;
            string baslik = "";
            string ozet = "";
            int year = 0;
            string ad;
            string soyad;
            string no;
            string ogrenimturu;
            List<string> unvanlar = new List<string>();
            List<string> jüriler = new List<string>();
            List<string> Ad = new List<string>();
            List<string> Soyad = new List<string>();
            List<string> No = new List<string>();
            List<string> Ogrenimturu = new List<string>();
            List<string> WordsList = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                unvan = sayfa.Substring(0, sayfa.IndexOf(".") + 1);
                sayfa = sayfa.Remove(0, sayfa.IndexOf(".") + 1).Trim();
                unvan += sayfa.Substring(0, sayfa.IndexOf(".") + 1);
                sayfa = sayfa.Remove(0, sayfa.IndexOf(".") + 1).Trim();
                if (sayfa.IndexOf("Üyesi") < 1)
                {
                    unvan += " Üyesi";
                    sayfa = sayfa.Remove(0, 5).Trim();
                }
                unvanlar.Add(unvan);
                index = sayfa.IndexOf("\n");
                jüriler.Add(sayfa.Substring(0, index));
                if (i == 0)
                {
                    danisman = sayfa.Substring(0, index);
                }
                sayfa = sayfa.Remove(0, index + 1);
                index = sayfa.IndexOf("\n");
                sayfa = sayfa.Remove(0, index + 1);
                index = sayfa.IndexOf("\n");
                sayfa = sayfa.Remove(0, index + 1);
            }
            sayfa = sayfa.Remove(0, sayfa.IndexOf(".") + 1);

            month = sayfa.Substring(0, sayfa.IndexOf("."));

            //Console.WriteLine(month);
            sayfa = sayfa.Remove(0, sayfa.IndexOf(".") + 1);

            if (month == "09" || month == "10" || month == "11" || month == "12" || month == "01" || month == "02")
            {
                if (month == "09" || month == "10" || month == "11" || month == "12")
                {
                    sayfa = sayfa.Remove(0, sayfa.IndexOf(".") + 1);
                    year = Convert.ToInt32(sayfa.Substring(0, 4));
                    donem = year + "-" + year + 1 + " Guz Donemi";
                }
                else
                {
                    sayfa = sayfa.Remove(0, sayfa.IndexOf(".") + 1);
                    year = Convert.ToInt32(sayfa.Substring(0, 4));
                    donem = year - 1 + "-" + year + " Guz Donemi";
                }


            }
            else if (month == "03" || month == "04" || month == "05" || month == "06" || month == "07")
            {
                sayfa = sayfa.Remove(0, sayfa.IndexOf(".") + 1);
                year = Convert.ToInt32(sayfa.Substring(0, 4));

                donem = year - 1 + "-" + year + " Bahar Donemi";

            }
            text.Clear();
            using (PdfReader reader = new PdfReader(file_path))
            {
                text.Append(PdfTextExtractor.GetTextFromPage(reader, 10));

            }
            sayfa = text.ToString();
            sayfa = sayfa.Trim();
            baslik = sayfa.Substring(0, sayfa.IndexOf("ÖZET"));

            baslik = baslik.Remove(baslik.IndexOf("\n"), 1);

            sayfa = sayfa.Remove(0, sayfa.IndexOf("ÖZET") + 6);
            ozet = sayfa.Substring(0, sayfa.IndexOf("Anahtar kelimeler"));
            sayfa = sayfa.Remove(0, sayfa.IndexOf(":") + 1);
            sayfa = sayfa.Substring(0, sayfa.IndexOf("."));
            sayfa = sayfa.Remove(sayfa.IndexOf("\n"), 1);



            string[] words = sayfa.Split(',');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
                WordsList.Add(words[i]);
            }

            text.Clear();
            using (PdfReader reader = new PdfReader(file_path))
            {
                text.Append(PdfTextExtractor.GetTextFromPage(reader, 4));

            }
            sayfa = text.ToString();
            sayfa = sayfa.Trim();

            while (!(sayfa.IndexOf("Adı Soyadı") == -1))
            {
                sayfa = sayfa.Remove(0, sayfa.IndexOf("No:") + 4);
                no = sayfa.Substring(0, 9);
                No.Add(no);
                sayfa = sayfa.Remove(0, sayfa.IndexOf("Soyadı:") + 8);
                ad = sayfa.Substring(0, sayfa.IndexOf("\n"));
                Ad.Add(ad);

            }


            for (int i = 0; i < No.Count; i++)
            {

                Ogrenimturu.Add(No[i].Substring(5, 1));

                Console.WriteLine(Ogrenimturu[i]);

            }

            using (var connection = new MySqlConnection(mysqlConnection))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("insert into pdf (pdf_filepath,lecture_name,sum,term,title,adviser_name,adviser_surname,adviser_title,jury1_name,jury1_surname,jury1_title," +
                        "jury2_name,jury2_surname,jury2_title,jury3_name, jury3_surname, jury3_title) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", connection);
                    command.Parameters.AddWithValue("@p1", file_path);
                    command.Parameters.AddWithValue("@p2", dersAdi);
                    command.Parameters.AddWithValue("@p3", ozet);
                    command.Parameters.AddWithValue("@p4", donem);
                    command.Parameters.AddWithValue("@p5", baslik);
                    command.Parameters.AddWithValue("@p6", jüriler[0]);
                    command.Parameters.AddWithValue("@p7", jüriler[0]);
                    command.Parameters.AddWithValue("@p8", unvanlar[0]);
                    command.Parameters.AddWithValue("@p9", jüriler[0]);
                    command.Parameters.AddWithValue("@p10", jüriler[0]);
                    command.Parameters.AddWithValue("@p11", unvanlar[0]);
                    command.Parameters.AddWithValue("@p12", jüriler[1]);
                    command.Parameters.AddWithValue("@p13", jüriler[1]);
                    command.Parameters.AddWithValue("@p14", unvanlar[1]);
                    command.Parameters.AddWithValue("@p15", jüriler[2]);
                    command.Parameters.AddWithValue("@p16", jüriler[2]);
                    command.Parameters.AddWithValue("@p17", unvanlar[2]);
                   // why = "Basarili"+max_pdfID();



                    command.ExecuteNonQuery();
                  

                }
                catch (Exception error)
                {
                    why = error.ToString();
                    throw;
                }
                for (int i = 0; i < No.Count; i++)
                {
                    
                          author_insert(No[i], Ad[i], Ogrenimturu[i]);
                          author_pdf_connection(No[i]);

                    
                    
                }
                for (int i = 0; i < WordsList.Count; i++)
                {
                    keyword_pdf_connection(WordsList[i]);
                }
                user_pdf_connection();

            }

            //Console.WriteLine(sayfa);
           // Console.ReadLine();

          


        }
        catch
        {

        }

       
    }
 public void author_insert(string No,string Ad, string Ogrenimturu)
    {
       
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("insert into author (author_number,author_name,author_surname,education_type) values (@p1,@p2,@p3,@p4)", connection);
                command.Parameters.AddWithValue("@p1", No );
                command.Parameters.AddWithValue("@p2", Ad);
                command.Parameters.AddWithValue("@p3", Ad);
                command.Parameters.AddWithValue("@p4", Ogrenimturu);

                command.ExecuteNonQuery();




            }

            catch (Exception)
            {

                throw;
            }
        }
    }

    public int  max_pdfID()
    
    {
        
        int id = 0;
        using (var connection = new MySqlConnection(mysqlConnection))
        {
            try
            {
               connection.Open();
                MySqlDataReader read;
                MySqlCommand command = new MySqlCommand("SELECT MAX(pdfID)  FROM pdf", connection);
                read = command.ExecuteReader();
                if (read.Read())
                {
                    id = read.GetInt32(0);
                    return id;





                }
                return id;
            }
            catch (Exception)
            {
                id = 0;

                return id;
                throw;
            }
        }


    }

    public void author_pdf_connection(string No)
    {

        using (var connection = new MySqlConnection(mysqlConnection))
        {

            try
            {
                connection.Open();
                MySqlCommand command2 = new MySqlCommand("insert into author_pdf_connection (author_number,pdfID) values (@p1,@p2)", connection);
                command2.Parameters.AddWithValue("@p1", No);
                command2.Parameters.AddWithValue("@p2", max_pdfID());
                Console.WriteLine(No);
                Label1.Text=No+" "+max_pdfID();
                Console.WriteLine(max_pdfID());


                command2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.ToString());
            }
        }
    }

    public void user_pdf_connection()
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {

            try
            {
                connection.Open();
                MySqlCommand command3 = new MySqlCommand("insert into user_pdf_connection (userID,pdfID) values (@p1,@p2)", connection);
                command3.Parameters.AddWithValue("@p1", getID.User_id);
                command3.Parameters.AddWithValue("@p2", max_pdfID());


                command3.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
        }
    }


    public void keyword_pdf_connection(string wordsList)
    {
        using (var connection = new MySqlConnection(mysqlConnection))
        {

            try
            {
                connection.Open();
                MySqlCommand command4 = new MySqlCommand("insert into keyword_pdf_connection (keyword,pdfID) values (@p1,@p2)", connection);
                command4.Parameters.AddWithValue("@p1", wordsList);
                command4.Parameters.AddWithValue("@p2", max_pdfID());


                command4.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}
