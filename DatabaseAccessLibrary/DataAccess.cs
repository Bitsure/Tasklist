using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using System.Linq;

namespace DatabaseAccessLibrary
{
    public class DataAccess
    {
        private string ConnectionName { get; set; } = "Database";
        private readonly IConfiguration conf;

        public DataAccess(IConfiguration config)
        {
            this.conf = config;
        }

        //Get all users
        public List<T> GetData<T, U>(string sql, U parameters)
        {
            string connectionString = conf.GetConnectionString(ConnectionName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.Query<T>(sql, parameters).ToList();
            }
        }

        public void AddUser(string sql, UserData user)
        {
            string connectionString = conf.GetConnectionString(ConnectionName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(sql, user);
            }
        }

        public void AddTask(string sql, TaskData task)
        {
            string connectionString = conf.GetConnectionString(ConnectionName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(sql, task);
            }
        }

        public void RemoveTask(string sql, int id)
        {
            string connectionString = conf.GetConnectionString(ConnectionName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(sql, new { id});
            }
        }

        public bool CheckUsername<U>(string sql, U parameters)
        {
            string connectionString = conf.GetConnectionString(ConnectionName);
            Console.WriteLine("Executing Request of Checking...");
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                return connection.ExecuteScalar<bool>(sql, parameters);
            }
        }
    }
}
