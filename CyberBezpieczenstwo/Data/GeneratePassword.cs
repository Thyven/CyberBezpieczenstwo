namespace CyberBezpieczenstwo.Data
{
    public class GeneratePassword
    {
        public double OneTimePassword(int a, int x)
        {
            Decimal newPassword = Decimal.Divide(a, x);
            newPassword = Math.Round(newPassword, 4);
            return (double)newPassword;
        }
    }
}