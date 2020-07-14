using System;

namespace Model
{
    public class clsDBMS
    {
        SqlConnection objSqlConnection;
        SqlCommand objSqlCommand;

        public clsDBMS()
        {
            objSqlConnection = new SqlConnection();
            objSqlCommand = new SqlCommand();

            objSqlCommand.Connection = objSqlConnection;
            objSqlConnection.ConnectionString = "Server = 192.168.1.13; Database = dbLibrary; User Id = sa; Password = metaldevil;";
        }

        public void ExecuteSQL(String strSQL)
        {
            objSqlCommand.CommandText = strSQL;

            objSqlConnection.Open();
            objSqlCommand.ExecuteNonQuery();
            objSqlConnection.Close();
        }

        public DataTable ExecuteSelectSQL(String strSQL)
        {
            objSqlCommand.CommandText = strSQL;

            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(objSqlCommand);
            DataTable objDataTable = new DataTable();

            objSqlDataAdapter.Fill(objDataTable);

            return objDataTable;
        }
    }
}