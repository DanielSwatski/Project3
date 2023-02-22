using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3.Classes
{
    public class User
    {
        private string username;
        private string password;
        private string fullname;
        private string email;

        public User(String username, String password, String fullname, String email) {
            this.username = username;
            this.password = password;
            this.fullname = fullname;
            this.email = email;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Email { get => email; set => email = value; }

        public String ToString()
        {
            return "tostring in User";
        }

    }
}