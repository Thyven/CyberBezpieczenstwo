using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBezpieczenstwo.Data
{
    public class UserData
    {
        public int userID;
        public string username;
        public string password;
        public DateTime passwordExpireDate;
        public string role;
        public List<string> oldPasswords;
        public string OneTimePassYN;
        public double? OneTimePassRes;

        public override string ToString()
        {
            return userID + " " + username + " " + role;
        }
    }
}
