using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecretLibrary.Model
{
    public class clsAuthersManager
    {
        public void Insert()
        {
            String strSQL = "INSERT INTO tblAuthers (FirstName, LastName) VALUES('Elnaz','Bayramzadeh')";
            clsDBMS objDBMS = new clsDBMS();
            objDBMS.ExecuteSQL(strSQL);
        }
    }
}