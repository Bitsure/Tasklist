using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseAccessLibrary
{
    public class UserHandler
    {
        private DataAccess _db;

        public UserHandler(DataAccess db)
        {
            this._db = db;
        }

        public UserData GetUser(string Username)
        {
            return _db.GetData<UserData, dynamic>($"select * from Users where Username = @Username", new {Username }).First(); //Tutaj występuje problem
        }

        public void InsertUser(UserData user)
        {
            string sql = @"insert into dbo.Users (Username, Password, EmailAddress)
                            values (@Username, @Password, @EmailAddress)";
            _db.AddUser(sql, user);
        }

        public bool DoesUserExists(string Username)
        {
            string sql = @"select count(1) from Users where Username=@Username";
            return _db.CheckUsername(sql, new { Username});
        }

        public bool MatchUsernameAndPassword(string Username, string Password)
        {
            string sql = $"select * from Users where Username = @Username and Password = @Password";

            return _db.CheckUsername(sql, new { Username, Password });
        }
    }
}
