using System;
using System.Collections.Generic;
using System.Text;
using KokoDajMu.Classes;
using KokoDajMu.Interfaces;

namespace KokoDajMu.Classes
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public List<string> genres = new List<string>();
        public List<string> songs = new List<string>();

    }
}
