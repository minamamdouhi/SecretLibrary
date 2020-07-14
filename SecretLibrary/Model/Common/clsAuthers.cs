using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecretLibrary.Model.Common
{
    public class clsAuthers
    {
        public String ID;
        private String _FirstName;
        private String _LastName;

        public String FirstName
        {
            set
            {
                String strFirstName = value.ToString();

                if (strFirstName == "")
                {
                    throw new Exception("First name cannot be empty.");
                }
                else
                {
                    _FirstName = strFirstName;
                }
            }
            get
            {
                return _FirstName;
            }
        }

        public String LastName
        {
            set
            {
                String strLastName = value.ToString();

                if (strLastName == "")
                {
                    throw new Exception("Last name cannot be empty.");
                }
                else
                {
                    _LastName = strLastName;
                }
            }
            get
            {
                return _LastName;
            }
        }
    }
}