using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KeyKeeper
{
    public class LoginClass
    {
        public int _id;
        public string _username;
        public string _password;

        public LoginClass() { }
        public LoginClass(int id, string username, string password)
        {
            _id = id; _username = username; _password = password;
        }
    }
}
