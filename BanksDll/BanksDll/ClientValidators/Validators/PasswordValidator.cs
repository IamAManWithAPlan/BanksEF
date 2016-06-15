using BanksDll.ClientValidators.Interfaces;

namespace BanksDll.ClientValidators.Validators
{
    public class PasswordValidator : IAccountValidator
    {
        private const int RequiredPasswordLength = 8;
        private const int MaxPasswordLength = 20;

        public bool Validate(AccountModel model)
        {
            return AreSamePasswords(model.Password, model.RePassword) & IsRequiredPasswordLength(model.Password);
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