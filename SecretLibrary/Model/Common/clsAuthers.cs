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

                if ((strFirstName == "") || (strFirstName.Length == 0) || (strFirstName == null))
                {
                    throw new Exception("First name cannot be empty.");
                }
                else if (strFirstName.Length >= 50)
                {
                    throw new Exception("First name cannot greater than 50 characters");
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

                if ((strLastName == "") || (strLastName.Length == 0) || (strLastName == null))
                {
                    throw new Exception("Last name cannot be empty.");
                }
                else if (strLastName.Length >= 50)
                {
                    throw new Exception("Last name cannot greater than 50 characters");
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