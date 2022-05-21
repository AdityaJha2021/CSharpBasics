using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClassExample
{
    public partial class PartialCustomer
    {
        public string PrintFullName()
        {
            return LastName + ", " + FirstName;
        }
        partial void PrintFirstName();
        

    }
}