using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ponomarev_N
{
    public static class connectionLink
    {
        public static string connectionString = @"Data Source=DESKTOP-FKVQ8KB\SQLEXPRESS;Initial Catalog=Ponomarev_N;Integrated Security=True";
    }
    class DataBase
    {
        // Ссылка на подключение
        string connectionString = connectionLink.connectionString;
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        SqlCommand cmd;
        DataSet dataSet;


        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }


        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

        public void GetList(string tableName, DataGridView dataGridView)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {tableName}", sqlConnection);
            dataSet = new DataSet();
            openConnection();
            sqlDataAdapter.Fill(dataSet, tableName);
            dataGridView.DataSource = dataSet.Tables[$"{tableName}"];
            closeConnection();
        }
        public void GetListAdapter(string query,string tableName,DataGridView dataGridView)
        {
            sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            dataSet = new DataSet();
            openConnection();
            sqlDataAdapter.Fill(dataSet, tableName);
            dataGridView.DataSource = dataSet.Tables[tableName];
            closeConnection();
        }
    }
   

}