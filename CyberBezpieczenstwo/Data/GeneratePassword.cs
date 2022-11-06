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
        public string OneTimePassword(int a)
        {
            var rnd = new Random();
            int x = rnd.Next(100);
            if (x == 0) x = 1;
            decimal newPassword = Decimal.Divide(a, x);
            newPassword = Math.Round(newPassword, 7);
            return newPassword.ToString();
        }
    }
}
