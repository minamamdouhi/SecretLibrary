using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SecretLibrary
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection objSqlConnection;
            SqlCommand objSqlCommand;

            objSqlConnection = new SqlConnection();
            objSqlCommand = new SqlCommand();

            objSqlCommand.Connection = objSqlConnection;
            objSqlConnection.ConnectionString = "Data Source=192.168.1.13,1433;Initial Catalog=dbLibrary;User ID=sa;Password=metaldevil";

            String strSQL = "INSERT INTO tblMembers (FirstName, LastName, NationalID, FathersName, Gender, BirthDate, PhoneNo, Address, Email) VALUES ('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtNationalID.Text + "', '" + txtFathersName.Text + "', '" + txtGender.Text + "', '" + txtBirthDate.Text + "', '" + txtPhoneNo.Text + "', '" + txtAddress.Text + "', '" + txtEmail.Text + "')";

            objSqlCommand.CommandText = strSQL;

            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
        }
    }
}