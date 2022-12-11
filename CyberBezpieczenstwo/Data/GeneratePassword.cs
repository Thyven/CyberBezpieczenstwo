
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
        public double OneTimePassword(int a, int x)
        {
            Decimal newPassword = Decimal.Multiply(a, x);
            // newPassword = Math.Round(newPassword, 7);
            return (double)newPassword;
        }
    }
}