using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTHR
{
    internal class Daftar
    {
        private string _newUsername;
        private string _newPassword;

        public string NewUsername
        {
            get { return _newUsername; }
            set { _newUsername = value; }
        }

        public string NewPassword
        {
            get { return _newPassword; }
            set { _newPassword = value; }
        }
    }
}
