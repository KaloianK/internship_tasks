using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;
using System.Linq;

namespace KokoDajMu.Classes
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Type { get; set; }
        public string DateOfBirth { get; set; }
        public List<string> genres = new List<string>();
        public List<string> albumNames = new List<string>();

        public User() { }

        public User(string username, string password, string type)
        {
            this.UserName = username;
            this.Password = password;
            this.Type = type;
        }
    }
}
