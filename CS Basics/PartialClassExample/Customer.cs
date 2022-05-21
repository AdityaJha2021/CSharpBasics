using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClassExample
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName { get => _lastName; set => _lastName = value; }

        public string PrintFullName()
        {
            return LastName + ", " + FirstName;
        }
    }
}