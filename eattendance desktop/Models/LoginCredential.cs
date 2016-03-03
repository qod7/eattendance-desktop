using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eattendance_desktop.Models
{
    class LoginCredential
    {
        private String _username;
        private String _hash;
        private String _token;

        public LoginCredential(String username, String hash, String token)
        {
            this._username = username;
            this._hash = hash;
            this._token = token;
        }

        public String username
        {
            get { return _username; }
            set { _username = value; }
        }

        public String hash
        {
            get { return _hash; }
            set { _hash = value; }
        }

        public String token
        {
            get { return _token; }
            set { _token = value; }
        }
    }
}
