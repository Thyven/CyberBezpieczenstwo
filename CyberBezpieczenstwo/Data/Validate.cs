using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

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

        public bool checkRegex(string password, bool isRegexNeeded)
        {
            string regexPattern = @"(?=.*[a-z])(?=.*\W)";
            Regex regexSN = new Regex(regexPattern, RegexOptions.IgnoreCase);
            var RegexOK = regexSN.IsMatch(password);

            if (isRegexNeeded == false)
            {
                RegexOK = true;
            }

            return RegexOK;
        }

        public bool checkOTP(string username, double otp)
        {
            DataHandler dataHandler = new DataHandler();
            var user = dataHandler.GetUsers().Where(x => x.username == username).FirstOrDefault();
            if (user == null) return false;
            else
            {
                if (user.OneTimePassYN == "Y")
                {
                    if ( ((otp-0.1) <= user.OneTimePassRes || (otp + 0.1) <= user.OneTimePassRes) && ((otp - 0.1) <= user.OneTimePassRes || (otp + 0.1) <= user.OneTimePassRes))
                    {

                        Debug.WriteLine("!!! OK OTP !!!");
                        Debug.WriteLine(otp);
                        Debug.WriteLine(user.OneTimePassRes);

                        return true;
                    }
                    else
                    {
                        Debug.WriteLine("!!! wrong OTP !!!");
                        return false;
                    }
                }
                else return true;    
            }
        }

        public string HashString(string input)
        {
            string outputString;

            byte[] buffer = Encoding.UTF8.GetBytes(input);
            byte[] hashedData = SHA256.HashData(buffer);
            outputString = Encoding.UTF8.GetString(hashedData, 0, hashedData.Length);

            return outputString;
        }
    }
}
