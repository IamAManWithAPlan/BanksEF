using System.Collections.Generic;
using System.Linq;
using BanksDll.ClientValidators.Interfaces;

namespace BanksDll.ClientValidators.Validators
{
    public static class FullModelValidate
    {
        public static bool Validate(AccountModel model)
        {
            var validators = new List<IAccountValidator>()
        {
            new PeselValidator(),
            new NameLengthValidator(),
            new PasswordValidator()
        };
            return validators.All(x => x.Validate(model));
        }
    }
}