using System.Collections.Generic;
using System.Linq;
using BanksDll.ClientValidators.Interfaces;


namespace BanksDll.ClientValidators.Validators
{
    public class PeselValidator : IAccountValidator
    {
        public bool Validate(AccountModel model)
        {
            var validators = new List<IPeselValidator>
            {
                new PeselNumbersValidator(),
                new PeselDateValidator(),
                new PeselDataBaseValidator(),               
            };
            return validators.All(validator => validator.Validate(model.Pesel));
        }
    }
}