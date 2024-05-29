using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aisapp
{
    public class UserSessionService
    {
        private string _userEmail;

        public string UserEmail
        {
            get => _userEmail;
            set => _userEmail = value;
        }

        public bool IsUserLoggedIn => !string.IsNullOrEmpty(_userEmail);
    }
}