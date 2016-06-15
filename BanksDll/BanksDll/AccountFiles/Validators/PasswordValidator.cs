using BanksDll.AccountFiles.Interfaces;

namespace BanksDll.AccountFiles.Validators
{
    public class PasswordValidator : IAccountValidator
    {
        private const int RequiredPasswordLength = 8;
        private const int MaxPasswordLength = 20;

        public bool Validate(AccountModel model)
        {
            return AreSamePasswords(model.AccountPassword, model.RePassword) & IsRequiredPasswordLength(model.AccountPassword);
        }

        private static bool AreSamePasswords(string password, string password2)
        {
            return password.Equals(password2);
        }

        private static bool IsRequiredPasswordLength(string password)
        {
            return password.Length >= RequiredPasswordLength && password.Length <= MaxPasswordLength;
        }
    }
}