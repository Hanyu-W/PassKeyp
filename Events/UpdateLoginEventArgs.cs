using PassKeyp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeyp.Events
{
    public class UpdateLoginEventArgs : EventArgs
    {
        //ArrayList of the logins
        private List<Login> logins = new List<Login>();

        public UpdateLoginEventArgs(List<Login> c)
        {
            logins = c;
        }

        public List<Login> GetLogins
        {
            get
            {
                return logins;
            }
        }

    }
}
