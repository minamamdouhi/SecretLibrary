using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SecretLibrary.Model.Common;

namespace SecretLibrary.Model.DataAccess
{
    public class clsAuthersManager
    {
        public void Insert(clsAuthers objAuthers)
        {
            try
            {
                String strSQL = "INSERT INTO tblAuthers (FirstName, LastName) VALUES('" + objAuthers.FirstName + "','" + objAuthers.LastName + "')";
                clsDBMS objDBMS = new clsDBMS();
                objDBMS.ExecuteSQL(strSQL);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}