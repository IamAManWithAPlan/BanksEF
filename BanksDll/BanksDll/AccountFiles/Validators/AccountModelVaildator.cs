using System.Collections.Generic;
using System.Linq;
using BanksDll.AccountFiles.Interfaces;

namespace BanksDll.AccountFiles.Validators
{
    public static class FullModelValidate
    {
        public static bool Validate(AccountModel model)
        {
            var validators = new List<IAccountValidator>
            {
                new NameLengthValidator(),
                new PasswordValidator(),
                new PeselNumbersValidator(),
                new PeselDateValidator(),
                new PeselDataBaseValidator()
            };
            return validators.All(x => x.Validate(model));
        }
    }
}