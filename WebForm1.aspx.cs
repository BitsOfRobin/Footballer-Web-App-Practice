using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        String cs = "Data Source=(LocalDb)\\LowZhongLeanSQL;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (!IsPostBack)
            {
                List<String> footballerList = new List<String>();
                footballerList.Add("Saka");
                footballerList.Add("Ronaldo");
                footballerList.Add("Martinellli");
                footballerList.Add("Leandro Trossard");
                footballerList.Add("Jesus");
                footballerList.Add("Odegaard");
                DDLFootball.Items.Clear();
                DDLFootball.DataSource = footballerList;
                DDLFootball.DataBind();



            }
 


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           





        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            String footballer = DDLFootball.SelectedValue;
            if (footballer != null)
            {

                Response.Redirect("DisplayFootball.aspx?footballer=" + footballer);


            }




        }
    }
}