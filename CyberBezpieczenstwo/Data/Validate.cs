using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CyberBezpieczenstwo.Data
{
    public class Validate
    {
        public bool ifUserExist(string username, string password)
        {
            var dataHandler = new DataHandler();
            var users = dataHandler.GetUsers();
            var user = users.Where(x => x.username == username).FirstOrDefault();
            if (user == null) return false;
            if (user.password == password) return true;
            return false;
        }
        public bool ifUserExist(string username)
        {
            var dataHandler = new DataHandler();
            var users = dataHandler.GetUsers();
            var user = users.Where(x => x.username == username).FirstOrDefault();
            if (user == null) return false;
            return true;
        }

        public bool checkRegex(string password)
        {
            string regexPattern = @"(?=.*[a-z])(?=.*\W)";
            Regex regexSN = new Regex(regexPattern, RegexOptions.IgnoreCase);
            var RegexOK = regexSN.IsMatch(password);
            return RegexOK;
        }
    }
}
