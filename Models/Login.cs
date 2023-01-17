using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeyp.Models
{
    public class Login
    {
        public string Website { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Login()
        {

        }

        public Login(string website, string username, string password)
        {
            Website = website;
            Username = username;
            Password = password;
        }

        //sample list of logins
        public static List<Login> GetLogins()
        {
            return new List<Login>
            {
               new Login("Test 1", "fdsfjkdsl", "dsfsdf"),
               new Login("Customer 2", "dsfjdsj", "fdsfds"),
               new Login("Brian", "sdfsdfsd", "dsfdsfds")
            };
        }

        public string ToString()
        {
            return Website + " " + Username + " " + Password;
        }

        public string SaveLogins()
        {
            return Website + "," + Username + "," + Password;
        }

    }
}
