using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyKeeper
{
    public class StoredPasswordClass
    {
        public int _id;
        public string _service;
        public string _url;
        public string _password;
        public string _username;
        public string _email;



        public StoredPasswordClass() { }
        public StoredPasswordClass(int id, string service, string url, string password, string username, string email)
        {
            _id = id;  _service = service; _url = url;_password = password; _username = username;
            _email = email;

        }

    }
}
