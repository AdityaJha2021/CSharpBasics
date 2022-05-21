using System;
using System.Configuration;
using System.Data.SqlClient;

namespace PartialClassExample
{
    public partial class indexerExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            #region making indexer
            Company company = new Company();
            Response.Write("Total no. of Male Employee: " + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total no. of Female Employee: " + company["Female"]);
            Response.Write("<br/>");

            Response.Write("Employee Name with ID 2: " + company[2]+"<br/>");
            Response.Write("Employee Name with ID 3: " + company[3] + "<br/>");
            Response.Write("Employee Name with ID 5: " + company[5] + "<br/>");
            company[2] = "Employee 2 Name Changed";
            company[3] = "Employee 3 Name Changed";
            company[5] = "Employee 5 Name Changed";
            Response.Write("<br/>");
            Response.Write("Name of the employee after getting changed by indexer");
            Response.Write("<br/>");
            Response.Write("Employee Name with ID 2: " + company[2] + "<br/>");
            Response.Write("Employee Name with ID 3: " + company[3] + "<br/>");
            Response.Write("Employee Name with ID 5: " + company[5] + "<br/>");
            #endregion

            #region indexer in ADO.Net
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from emp", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Response.Write("ID = " + rdr[0].ToString() + " ");
                    Response.Write("Name = " + rdr["ename"].ToString() + " ");
                    Response.Write("<br/>");
                }
            }
            #endregion

            #region indexer in session state
            Session["session1"] = "First Session Object";
            Session["session2"] = "Second Session Object";

            Response.Write("Coming from First Session: " + Session[0].ToString());
            Response.Write("<br/>");
            Response.Write("Coming from Second Session: " + Session["session2"].ToString()); 
            #endregion
        }
    }
}