using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication4
{
    public partial class DisplayFootball : System.Web.UI.Page
    {
        static String cs = "Data Source=(LocalDb)\\LowZhongLeanSQL;Integrated Security=True";
        static SqlConnection con = new SqlConnection(cs);
        protected void Page_Load(object sender, EventArgs e)
        {    if (!IsPostBack)
            {

                LBLfootball.Text = "footballer.ToString()";
                if (Request.QueryString != null)
                {

                    String footballer = Request.QueryString["footballer"];
                    LBLfootball.Text = footballer;

                    con.Open();

                    String sqlRead = "SELECT * from Footballer WHERE Footballer=@Footballer";
                    SqlCommand sqlCommand = new SqlCommand(sqlRead, con);
                
                    sqlCommand.Parameters.AddWithValue("@Footballer", footballer);
               


                    SqlDataReader dr = sqlCommand.ExecuteReader();


                    String club = " ";
                    if (dr.HasRows) // Check if there are rows
                    {
                        while (dr.Read()) // Read each row
                        {

                             club = string.Format("{0}", dr["Club"]);
                            // Access data using dr[index] or dr["columnName"]
                            // Example: string username = dr["username"].ToString();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found.");
                    }
                   
                    con.Close();
                    LBLfootball.Text = footballer + " " + club;

                }


            }



        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            LBLfootball.Text = "footballer.ToString()";
            if (Request.QueryString != null)
            {

                String footballer = Request.QueryString["footballer"];
                LBLfootball.Text = "footballer.ToString();";

                SqlConnection con = new SqlConnection(cs);



            }

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);

            con.Open();
            String txtClub=TxtBoxFootballer.Text;

            String txtfootballer = "";
            //LBLfootball.Text = "footballer.ToString()";
            if (Request.QueryString != null)
            {

               txtfootballer = Request.QueryString["footballer"];
            
            }

              

            String sqlInsert = @"INSERT INTO Footballer(Club,Footballer) VALUES(@Club,@Footballer)";
            SqlCommand sqlCommand =new SqlCommand(sqlInsert, con);
            sqlCommand.Parameters.AddWithValue("@Club",txtClub.ToString());
            sqlCommand.Parameters.AddWithValue("@Footballer", txtfootballer);
            sqlCommand.ExecuteNonQuery();
            con.Close();    

        }
    }
}