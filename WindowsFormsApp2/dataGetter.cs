using System.Data;
using System.Data.SqlClient;

namespace ProjLucri
{
    class DataGetter
    {
        private SqlConnection connection;

        public DataGetter(string serverIP, string serverPort, string userName, string password)
        {
            connection = new SqlConnection("Data Source=" + serverIP + "," + serverPort + "; Database=TestDB;Persist Security Info=True; User ID=" + userName + "; Password=" + password);
        }
        public DataTable GetData(string statement)
        {
            DataTable dataStore = new DataTable();
            SqlCommand sqlStatement = new SqlCommand(statement, connection);
            SqlDataAdapter dataGrabber = new SqlDataAdapter(sqlStatement);

            connection.Open();
            dataGrabber.Fill(dataStore);
            connection.Close();

            return dataStore;
        }
    }
}
