using BanksDll.ClientValidators.Interfaces;

namespace BanksDll.ClientValidators.Validators
{
    public class NameLengthValidator : IAccountValidator
    {
        public bool Validate(AccountModel model)
        {
            return model.Name.Length >= 3 && model.Surname.Length >= 3;
        }
    }
}