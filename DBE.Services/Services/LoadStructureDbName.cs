//using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBE.Services.Services
{
    public class LoadStructureDbName
    {
        public static string ConnectionString = "Server=DESKTOP-A7G87UL\\SQLEXPRESS;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True";
        public List<string> LoadDatabases()
        {
            List<string> DbsName = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb');";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string dbName = reader["name"].ToString();
                        DbsName.Add(dbName);
                    }
                    connection.Close();
                    return DbsName.ToList();
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    throw new Exception("Error loading databases: " + ex.Message);
                }
            }
        }
        public List<string> LoadTableByDbName(string DbName)
        {
            List<string> Items = new List<string>();
            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = '{DbName}';";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string tableName = reader["name"].ToString();
                        Items.Add(tableName);
                    }
                    connection.Close();
                    return Items;
                }catch(Exception ex)
                {
                    throw new Exception("");
                }
            }
        }
    }
}
