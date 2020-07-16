using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecretLibrary.Model.Common
{
    public class clsBooks
    {
        private String _ID;
        private String _Name;
        public String Auther;
        public String publisher;
        public String ISBN;
        public String Translator;
        public String Category;
        public String Language;

        public String ID
        {
            set
            {
                String str
            }
            get
            {

            }
        }
        public String Name
        {
            set
            {
                String strName = value.ToString();

                if ((strName == "") || (strName.Length == 0) || (strName == null))
                {
                    throw new Exception("Last name cannot be empty.");
                }
                else if (strName.Length >= 100)
                {
                    throw new Exception("Last name cannot greater than 100 characters");
                }
                _Name = strName;
            }
            get
            {
                return _Name;
            }
        } 

    }
}