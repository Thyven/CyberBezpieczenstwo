
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CyberBezpieczenstwo.Data
{
    public class GeneratePassword
    {
        public string OneTimePassword(int a, int x)
        {
            decimal newPassword = Decimal.Divide(a, x);
            newPassword = Math.Round(newPassword, 7);
            return newPassword.ToString();
        }
    }
}