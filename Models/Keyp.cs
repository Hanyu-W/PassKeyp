using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeyp.Models
{
    public class Keyp
    {
        public string Filename { get; set; }

        public string Password { get; set; }

        public Keyp(string filename, string password)
        {
            Filename = filename;
            Password = password;
        }
    }
}
