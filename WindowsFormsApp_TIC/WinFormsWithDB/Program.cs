using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWithDB
{
    internal static class Program
    {
        public static SqlConnection conn;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WinFormsTestDB;Integrated Security=True";

            conn = new SqlConnection(connString);

            EnsureDatabaseExists(connString);
            EnsureCustomersTable(connString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void EnsureDatabaseExists(string connString)
        {
            var builder = new SqlConnectionStringBuilder(connString);
            string dbName = builder.InitialCatalog;

            // Connect to master DB
            builder.InitialCatalog = "master";
            using (SqlConnection conn = new SqlConnection(builder.ToString()))
            {
                conn.Open();
                string cmdText = $@"
            IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'{dbName}')
            BEGIN
                CREATE DATABASE [{dbName}]
            END";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.ExecuteNonQuery();
            }
        }


        private static void EnsureCustomersTable(string connString)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string createTableQuery = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Customers' and xtype='U')
                CREATE TABLE Customers (
                    Id INT PRIMARY KEY IDENTITY,
                    Name NVARCHAR(100),
                    Email NVARCHAR(100)
                )";
                SqlCommand cmd = new SqlCommand(createTableQuery, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
