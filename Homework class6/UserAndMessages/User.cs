using System;
using System.Collections.Generic;
using System.Text;

namespace UserAndMessages
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string[] Mesages { get; set; }

        public User (int id, string username, string password, string[] mesages)
        {
            Id = id;
            Username = username;
            Password = password;
            Mesages = mesages;
        }

        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }

    }
}
