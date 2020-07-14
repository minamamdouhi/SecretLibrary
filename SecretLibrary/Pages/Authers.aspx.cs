using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SecretLibrary.Model.Common;
using SecretLibrary.Model.DataAccess;

namespace SecretLibrary.Pages
{
    public partial class Authers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                clsAuthersManager objAuthersManager = new clsAuthersManager();
                clsAuthers objAuthers = new clsAuthers();
                objAuthers.FirstName = txtFirstName.Text;
                objAuthers.LastName = txtLastName.Text;
                objAuthersManager.Insert(objAuthers);
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }
    }
}