using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Is_SecurePassword
    {
        public static PasswordStrength IsSecurePassword(string password)
        {
            int lowerCount = 0;
            int upperCount = 0;
            int digitCount = 0;

            // Rule: Length between 8 and 12
            if (password.Length < 8 || password.Length > 12)
            {
                return PasswordStrength.TOO_WEAK;
            }

            foreach (char c in password)
            {
                if (char.IsLower(c)) lowerCount++;
                else if (char.IsUpper(c)) upperCount++;
                else if (char.IsDigit(c)) digitCount++;
            }

            if (lowerCount >= 2 && upperCount >= 2 && digitCount >= 1)
            {
                return PasswordStrength.STRONG_ENOUGH;
            }

            return PasswordStrength.TOO_WEAK;
        }

        // Enum to represent password strength
        public enum PasswordStrength
        {
            TOO_WEAK,
            STRONG_ENOUGH
        }

    }
}
