using System;
using System.Net.Mail;
namespace AshkanSocial.Core.Services
{
    public static class ValidationService
    {
        public static bool IsValidEmail(string value)
        {
            try { var address = new MailAddress((value ?? string.Empty).Trim()); return address.Address == (value ?? string.Empty).Trim(); }
            catch { return false; }
        }
        public static string ValidateRegistration(string fullName, string username, string email, string password, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(fullName) || fullName.Trim().Length < 2) return "Please enter a valid full name.";
            if (string.IsNullOrWhiteSpace(username) || username.Trim().Length < 3) return "Username must contain at least 3 characters.";
            if (!IsValidEmail(email)) return "Please enter a valid email address.";
            if (string.IsNullOrEmpty(password) || password.Length < 6) return "Password must contain at least 6 characters.";
            if (!string.Equals(password, confirmPassword, StringComparison.Ordinal)) return "Passwords do not match.";
            return null;
        }
    }
}
