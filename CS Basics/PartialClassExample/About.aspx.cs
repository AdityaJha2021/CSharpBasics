using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialClassExample
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer c1 = new Customer();
            c1.FirstName = "Aditya";
            c1.LastName = "Prakash";

            string fullName = c1.PrintFullName();

            Response.Write("Full Name: " + fullName + "<br/>"+"Coming from customer<br/><br/>");

            PartialCustomer c2 = new PartialCustomer();
            c2.FirstName = "Harshita";
            c2.LastName = "Kumari";
            c2.PrintFullName();

            string fullName1 = c2.PrintFullName();
            Response.Write("Full Name: " + fullName1 + "<br/> Coming from Partial customer<br/><br/>");
        }
    }
}