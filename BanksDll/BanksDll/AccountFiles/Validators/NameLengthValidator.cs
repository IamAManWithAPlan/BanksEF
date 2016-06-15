using BanksDll.AccountFiles.Interfaces;

namespace BanksDll.AccountFiles.Validators
{
    public class NameLengthValidator : IAccountValidator
    {
        public bool Validate(AccountModel model)
        {
            return model.Name.Length >= 3 && model.Surname.Length >= 3;
        }
    }
}